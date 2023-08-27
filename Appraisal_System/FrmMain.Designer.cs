namespace Appraisal_System {
    partial class FrmMain {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            TreeNode treeNode1 = new TreeNode("人员管理");
            TreeNode treeNode2 = new TreeNode("基数管理");
            TreeNode treeNode3 = new TreeNode("系数管理");
            TreeNode treeNode4 = new TreeNode("人员绩效");
            splitContainer1 = new SplitContainer();
            trvMenu = new TreeView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(2, 3, 2, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(trvMenu);
            splitContainer1.Size = new Size(963, 540);
            splitContainer1.SplitterDistance = 213;
            splitContainer1.SplitterWidth = 3;
            splitContainer1.TabIndex = 0;
            // 
            // trvMenu
            // 
            trvMenu.Dock = DockStyle.Fill;
            trvMenu.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            trvMenu.FullRowSelect = true;
            trvMenu.ItemHeight = 40;
            trvMenu.Location = new Point(0, 0);
            trvMenu.Margin = new Padding(2, 3, 2, 3);
            trvMenu.Name = "trvMenu";
            treeNode1.Name = "tnUserManager";
            treeNode1.Tag = "FrmUserManager";
            treeNode1.Text = "人员管理";
            treeNode2.Name = "tnBaseManager";
            treeNode2.Tag = "FrmBaseManager";
            treeNode2.Text = "基数管理";
            treeNode3.Name = "tnCoefficientManager";
            treeNode3.Tag = "FrmCoefficientManager";
            treeNode3.Text = "系数管理";
            treeNode4.Name = "tnUserAppraisal";
            treeNode4.Tag = "FrmUserAppraisal";
            treeNode4.Text = "人员绩效";
            trvMenu.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4 });
            trvMenu.ShowLines = false;
            trvMenu.Size = new Size(213, 540);
            trvMenu.TabIndex = 0;
            trvMenu.AfterSelect += trvMenu_AfterSelect;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 540);
            Controls.Add(splitContainer1);
            Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IsMdiContainer = true;
            Margin = new Padding(4);
            Name = "FrmMain";
            Text = "Appraisal_System";
            Load += FrmMain_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView trvMenu;
    }
}

