namespace HAPXPathFinder
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tpDOMTree = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.spDOMTree = new System.Windows.Forms.SplitContainer();
            this.tvDOMTree = new System.Windows.Forms.TreeView();
            this.pgHtmlNode = new System.Windows.Forms.PropertyGrid();
            this.searchResultListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.tpSourceCode = new System.Windows.Forms.TabPage();
            this.txtSourceCode = new System.Windows.Forms.TextBox();
            this.tpBrowser = new System.Windows.Forms.TabPage();
            this.lblURL = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.wbMain = new System.Windows.Forms.WebBrowser();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpXPath = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.scXPathResult = new System.Windows.Forms.SplitContainer();
            this.tvXPathResult = new System.Windows.Forms.TreeView();
            this.pgXPathResult = new System.Windows.Forms.PropertyGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFindXPath = new System.Windows.Forms.Button();
            this.txtXPath = new System.Windows.Forms.TextBox();
            this.waitNavigateTimer = new System.Windows.Forms.Timer(this.components);
            this.tpDOMTree.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spDOMTree)).BeginInit();
            this.spDOMTree.Panel1.SuspendLayout();
            this.spDOMTree.Panel2.SuspendLayout();
            this.spDOMTree.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpSourceCode.SuspendLayout();
            this.tpBrowser.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpXPath.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scXPathResult)).BeginInit();
            this.scXPathResult.Panel1.SuspendLayout();
            this.scXPathResult.Panel2.SuspendLayout();
            this.scXPathResult.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpDOMTree
            // 
            this.tpDOMTree.Controls.Add(this.panel2);
            this.tpDOMTree.Controls.Add(this.panel1);
            this.tpDOMTree.Location = new System.Drawing.Point(4, 22);
            this.tpDOMTree.Name = "tpDOMTree";
            this.tpDOMTree.Padding = new System.Windows.Forms.Padding(3);
            this.tpDOMTree.Size = new System.Drawing.Size(975, 664);
            this.tpDOMTree.TabIndex = 3;
            this.tpDOMTree.Text = "DOM Tree";
            this.tpDOMTree.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(969, 630);
            this.panel2.TabIndex = 9;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.spDOMTree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.searchResultListView);
            this.splitContainer1.Size = new System.Drawing.Size(969, 630);
            this.splitContainer1.SplitterDistance = 711;
            this.splitContainer1.TabIndex = 7;
            // 
            // spDOMTree
            // 
            this.spDOMTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spDOMTree.Location = new System.Drawing.Point(0, 0);
            this.spDOMTree.Name = "spDOMTree";
            // 
            // spDOMTree.Panel1
            // 
            this.spDOMTree.Panel1.Controls.Add(this.tvDOMTree);
            // 
            // spDOMTree.Panel2
            // 
            this.spDOMTree.Panel2.Controls.Add(this.pgHtmlNode);
            this.spDOMTree.Size = new System.Drawing.Size(711, 630);
            this.spDOMTree.SplitterDistance = 346;
            this.spDOMTree.TabIndex = 1;
            // 
            // tvDOMTree
            // 
            this.tvDOMTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDOMTree.FullRowSelect = true;
            this.tvDOMTree.HideSelection = false;
            this.tvDOMTree.Location = new System.Drawing.Point(0, 0);
            this.tvDOMTree.Name = "tvDOMTree";
            this.tvDOMTree.Size = new System.Drawing.Size(346, 630);
            this.tvDOMTree.TabIndex = 0;
            this.tvDOMTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDOMTree_AfterSelect);
            // 
            // pgHtmlNode
            // 
            this.pgHtmlNode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgHtmlNode.Location = new System.Drawing.Point(0, 0);
            this.pgHtmlNode.Name = "pgHtmlNode";
            this.pgHtmlNode.Size = new System.Drawing.Size(361, 630);
            this.pgHtmlNode.TabIndex = 0;
            // 
            // searchResultListView
            // 
            this.searchResultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.searchResultListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchResultListView.Location = new System.Drawing.Point(0, 0);
            this.searchResultListView.Name = "searchResultListView";
            this.searchResultListView.Size = new System.Drawing.Size(254, 630);
            this.searchResultListView.TabIndex = 0;
            this.searchResultListView.UseCompatibleStateImageBehavior = false;
            this.searchResultListView.View = System.Windows.Forms.View.Details;
            this.searchResultListView.ItemActivate += new System.EventHandler(this.searchResultListView_ItemActivate);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Text";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFind);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 28);
            this.panel1.TabIndex = 8;
            // 
            // txtFind
            // 
            this.txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFind.Location = new System.Drawing.Point(0, 3);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(888, 20);
            this.txtFind.TabIndex = 5;
            this.txtFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyDown);
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.Location = new System.Drawing.Point(893, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 6;
            this.btnFind.Text = "&Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tpSourceCode
            // 
            this.tpSourceCode.Controls.Add(this.txtSourceCode);
            this.tpSourceCode.Location = new System.Drawing.Point(4, 22);
            this.tpSourceCode.Name = "tpSourceCode";
            this.tpSourceCode.Padding = new System.Windows.Forms.Padding(3);
            this.tpSourceCode.Size = new System.Drawing.Size(975, 664);
            this.tpSourceCode.TabIndex = 2;
            this.tpSourceCode.Text = "Source code";
            this.tpSourceCode.UseVisualStyleBackColor = true;
            // 
            // txtSourceCode
            // 
            this.txtSourceCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSourceCode.Location = new System.Drawing.Point(3, 3);
            this.txtSourceCode.Multiline = true;
            this.txtSourceCode.Name = "txtSourceCode";
            this.txtSourceCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSourceCode.Size = new System.Drawing.Size(969, 658);
            this.txtSourceCode.TabIndex = 0;
            // 
            // tpBrowser
            // 
            this.tpBrowser.Controls.Add(this.lblURL);
            this.tpBrowser.Controls.Add(this.btnGo);
            this.tpBrowser.Controls.Add(this.txtURL);
            this.tpBrowser.Controls.Add(this.wbMain);
            this.tpBrowser.Location = new System.Drawing.Point(4, 22);
            this.tpBrowser.Name = "tpBrowser";
            this.tpBrowser.Padding = new System.Windows.Forms.Padding(3);
            this.tpBrowser.Size = new System.Drawing.Size(975, 664);
            this.tpBrowser.TabIndex = 1;
            this.tpBrowser.Text = "Browser";
            this.tpBrowser.UseVisualStyleBackColor = true;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(9, 9);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(29, 13);
            this.lblURL.TabIndex = 5;
            this.lblURL.Text = "URL";
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(894, 5);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "&Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtURL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.txtURL.Location = new System.Drawing.Point(50, 6);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(838, 20);
            this.txtURL.TabIndex = 3;
            this.txtURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtURL_KeyDown);
            // 
            // wbMain
            // 
            this.wbMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbMain.Location = new System.Drawing.Point(6, 35);
            this.wbMain.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMain.Name = "wbMain";
            this.wbMain.ScriptErrorsSuppressed = true;
            this.wbMain.Size = new System.Drawing.Size(969, 629);
            this.wbMain.TabIndex = 0;
            this.wbMain.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.wbMain_Navigated);
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpBrowser);
            this.tcMain.Controls.Add(this.tpSourceCode);
            this.tcMain.Controls.Add(this.tpDOMTree);
            this.tcMain.Controls.Add(this.tpXPath);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(983, 690);
            this.tcMain.TabIndex = 0;
            // 
            // tpXPath
            // 
            this.tpXPath.Controls.Add(this.panel4);
            this.tpXPath.Controls.Add(this.panel3);
            this.tpXPath.Location = new System.Drawing.Point(4, 22);
            this.tpXPath.Name = "tpXPath";
            this.tpXPath.Padding = new System.Windows.Forms.Padding(3);
            this.tpXPath.Size = new System.Drawing.Size(975, 664);
            this.tpXPath.TabIndex = 4;
            this.tpXPath.Text = "XPath";
            this.tpXPath.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.scXPathResult);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(969, 630);
            this.panel4.TabIndex = 11;
            // 
            // scXPathResult
            // 
            this.scXPathResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scXPathResult.Location = new System.Drawing.Point(0, 0);
            this.scXPathResult.Name = "scXPathResult";
            // 
            // scXPathResult.Panel1
            // 
            this.scXPathResult.Panel1.Controls.Add(this.tvXPathResult);
            // 
            // scXPathResult.Panel2
            // 
            this.scXPathResult.Panel2.Controls.Add(this.pgXPathResult);
            this.scXPathResult.Size = new System.Drawing.Size(969, 630);
            this.scXPathResult.SplitterDistance = 476;
            this.scXPathResult.TabIndex = 9;
            // 
            // tvXPathResult
            // 
            this.tvXPathResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvXPathResult.FullRowSelect = true;
            this.tvXPathResult.HideSelection = false;
            this.tvXPathResult.Location = new System.Drawing.Point(0, 0);
            this.tvXPathResult.Name = "tvXPathResult";
            this.tvXPathResult.Size = new System.Drawing.Size(476, 630);
            this.tvXPathResult.TabIndex = 0;
            this.tvXPathResult.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvXPathResult_AfterSelect);
            // 
            // pgXPathResult
            // 
            this.pgXPathResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgXPathResult.Location = new System.Drawing.Point(0, 0);
            this.pgXPathResult.Name = "pgXPathResult";
            this.pgXPathResult.Size = new System.Drawing.Size(489, 630);
            this.pgXPathResult.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnFindXPath);
            this.panel3.Controls.Add(this.txtXPath);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(969, 28);
            this.panel3.TabIndex = 10;
            // 
            // btnFindXPath
            // 
            this.btnFindXPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindXPath.Location = new System.Drawing.Point(892, 2);
            this.btnFindXPath.Name = "btnFindXPath";
            this.btnFindXPath.Size = new System.Drawing.Size(75, 23);
            this.btnFindXPath.TabIndex = 10;
            this.btnFindXPath.Text = "&Find";
            this.btnFindXPath.UseVisualStyleBackColor = true;
            this.btnFindXPath.Click += new System.EventHandler(this.btnFindXPath_Click);
            // 
            // txtXPath
            // 
            this.txtXPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXPath.Location = new System.Drawing.Point(1, 3);
            this.txtXPath.Name = "txtXPath";
            this.txtXPath.Size = new System.Drawing.Size(886, 20);
            this.txtXPath.TabIndex = 9;
            this.txtXPath.Enter += new System.EventHandler(this.txtXPath_Enter);
            this.txtXPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtXPath_KeyDown);
            // 
            // waitNavigateTimer
            // 
            this.waitNavigateTimer.Interval = 1000;
            this.waitNavigateTimer.Tick += new System.EventHandler(this.waitNavigateTimer_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(983, 690);
            this.Controls.Add(this.tcMain);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTMLAgilityPack XPath Finder";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tpDOMTree.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.spDOMTree.Panel1.ResumeLayout(false);
            this.spDOMTree.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spDOMTree)).EndInit();
            this.spDOMTree.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpSourceCode.ResumeLayout(false);
            this.tpSourceCode.PerformLayout();
            this.tpBrowser.ResumeLayout(false);
            this.tpBrowser.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tpXPath.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.scXPathResult.Panel1.ResumeLayout(false);
            this.scXPathResult.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scXPathResult)).EndInit();
            this.scXPathResult.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpDOMTree;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.SplitContainer spDOMTree;
        private System.Windows.Forms.TreeView tvDOMTree;
        private System.Windows.Forms.PropertyGrid pgHtmlNode;
        private System.Windows.Forms.TabPage tpSourceCode;
        private System.Windows.Forms.TextBox txtSourceCode;
        private System.Windows.Forms.TabPage tpBrowser;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.WebBrowser wbMain;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpXPath;
        private System.Windows.Forms.SplitContainer scXPathResult;
        private System.Windows.Forms.TreeView tvXPathResult;
        private System.Windows.Forms.PropertyGrid pgXPathResult;
        private System.Windows.Forms.Timer waitNavigateTimer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView searchResultListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFindXPath;
        private System.Windows.Forms.TextBox txtXPath;
    }
}

