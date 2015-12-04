namespace QUANLY_HSSV
{
    partial class frmHuongDan
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nhóm Thực Hiện");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Giới Thiệu Sản Phẩm");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("GIỚI THIỆU CHUNG", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Form Chính");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Form Thông Tin Giảng Dạy");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("HƯỚNG DẪN SỬ DỤNG", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Location = new System.Drawing.Point(12, 16);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "root_GT_GTN";
            treeNode1.Text = "Nhóm Thực Hiện";
            treeNode2.Name = "root_GT_GTSP";
            treeNode2.Text = "Giới Thiệu Sản Phẩm";
            treeNode3.Name = "root_GT";
            treeNode3.Text = "GIỚI THIỆU CHUNG";
            treeNode4.Name = "root_HD_DA";
            treeNode4.Text = "Form Chính";
            treeNode5.Name = "root_HD_TTGD";
            treeNode5.Text = "Form Thông Tin Giảng Dạy";
            treeNode6.Name = "root_HD";
            treeNode6.Text = "HƯỚNG DẪN SỬ DỤNG";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(228, 379);
            this.treeView1.TabIndex = 5;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(276, 16);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(23, 23);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(662, 379);
            this.webBrowser1.TabIndex = 6;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // frmHuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 407);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.treeView1);
            this.Name = "frmHuongDan";
            this.Text = "frmHuongDan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}