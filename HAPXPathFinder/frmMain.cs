using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace HAPXPathFinder
{
    public partial class FrmMain : Form
    {
        HtmlNode _rootNode;
        private string _currentUrl;

        public FrmMain()
        {
            InitializeComponent();
            wbMain.ScriptErrorsSuppressed = true;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            NavigateToUrl();
        }

        private void NavigateToUrl()
        {
            if (_currentUrl == txtURL.Text)
            {
                wbMain.Refresh();
            }
            else
            {
                wbMain.Navigate(txtURL.Text);
                _currentUrl = txtURL.Text;
            }
        }

        static string GetXPathID(string xpath)
        {
            var r = "]";
            for (var i = xpath.Length - 2; i > 0; i--)
            {
                r = xpath[i] + r;
                if (xpath[i] == '[')
                    return r;
            }

            return "";
        }

        public string GetNodeDisplayText(HtmlNode hn)
        {
            if (hn is HtmlTextNode)
            {
                return hn.Name + GetXPathID(hn.XPath) + ": " + hn.InnerText;
            }

            var r = "";
            for (var i = 0; i < hn.OuterHtml.Length && hn.OuterHtml[i] != '>'; i++)
                r += hn.OuterHtml[i];
            r += ">";
            return r;
        }

        public TreeNode CreateTreeNodeFromHtmlNode(HtmlNode hn)
        {
            var tn = new TreeNode(GetNodeDisplayText(hn)) {Tag = hn};
            return tn;
        }

        private void FillToTreeNode(TreeNode tnode)
        {
            foreach (var item in ((HtmlNode) tnode.Tag).ChildNodes)
            {
                var tn = CreateTreeNodeFromHtmlNode(item);
                tnode.Nodes.Add(tn);
                FillToTreeNode(tn);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FindNode();
        }

        private void FindNode()
        {
            if (_rootNode == null)
                return;
            _treenodeResults.Clear();
            FindInTreeView(tvDOMTree.Nodes[0], txtFind.Text.ToLower());
            searchResultListView.Items.Clear();
            foreach (var item in _treenodeResults)
            {
                var lvi = new ListViewItem(item.Text) {Tag = item};
                searchResultListView.Items.Add(lvi);
            }
        }

        readonly List<TreeNode> _treenodeResults = new List<TreeNode>();

        private void FindInTreeView(TreeNode tn, string text)
        {
            if (tn.Tag is HtmlTextNode node && node.Text.ToLower().Contains(text.Trim()))
                _treenodeResults.Add(tn);

            foreach (TreeNode item in tn.Nodes)
                FindInTreeView(item, text);
        }

        private void tvDOMTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            pgHtmlNode.SelectedObject = e.Node.Tag;
        }

        private void btnFindXPath_Click(object sender, EventArgs e)
        {
            FindXPath();
        }

        private void FindXPath()
        {
            if (_rootNode == null)
                return;
            try
            {
                txtXPath.BackColor = Color.White;
                var hnc = _rootNode.SelectNodes(txtXPath.Text);
                tvXPathResult.Nodes.Clear();
                foreach (var item in hnc)
                {
                    var tn = CreateTreeNodeFromHtmlNode(item);
                    FillToTreeNode(tn);
                    tvXPathResult.Nodes.Add(tn);
                }

                tvXPathResult.ExpandAll();
            }
            catch
            {
                txtXPath.BackColor = Color.Pink;
            }
        }

        private void txtXPath_Enter(object sender, EventArgs e)
        {
            txtXPath.BackColor = Color.White;
        }

        private void tvXPathResult_AfterSelect(object sender, TreeViewEventArgs e)
        {
            pgXPathResult.SelectedObject = e.Node.Tag;
        }

        private void txtURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                NavigateToUrl();
        }

        private void txtFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                FindNode();
        }

        //Wait for web redirect
        private void waitNavigateTimer_Tick(object sender, EventArgs e)
        {
            if (wbMain.Url == null) return;

            Cursor = Cursors.WaitCursor;
            txtURL.Text = wbMain.Url.AbsoluteUri;
            HtmlAgilityPack.HtmlDocument hd;
            try
            {
                var hw = new HtmlWeb();
                hd = hw.Load(txtURL.Text);
            }
            catch (ArgumentException)
            {
                var wc = new GZipWebClient();
                hd = new HtmlAgilityPack.HtmlDocument();
                hd.Load(wc.OpenRead(txtURL.Text), true);
            }

            var hn = hd.DocumentNode;
            _rootNode = hn;
            txtSourceCode.Text = hn.OuterHtml;

            // Build DOM Tree

            var root = CreateTreeNodeFromHtmlNode(_rootNode);
            FillToTreeNode(root);
            tvDOMTree.Nodes.Clear();
            tvDOMTree.Nodes.Add(root);
            waitNavigateTimer.Enabled = false;
            Cursor = Cursors.Arrow;
        }

        private string _mainUrl;

        private void wbMain_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            if (_mainUrl == wbMain.Url.AbsoluteUri) return;

            txtURL.Text = wbMain.Url.AbsoluteUri;
            _mainUrl = wbMain.Url.AbsoluteUri;
            waitNavigateTimer.Enabled = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // https://stackoverflow.com/a/7841596"
            wbMain.ScriptErrorsSuppressed = true;
        }

        private void searchResultListView_ItemActivate(object sender, EventArgs e)
        {
            if (searchResultListView.SelectedItems[0].Tag != null)
                tvDOMTree.SelectedNode = (TreeNode) searchResultListView.SelectedItems[0].Tag;
        }

        private void txtXPath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                FindXPath();
        }
    }
}