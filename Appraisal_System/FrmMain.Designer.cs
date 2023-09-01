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
                        spcMain = new SplitContainer();
                        trvMenu = new TreeView();
                        btnAuthorByDzl = new Button();
                        ((System.ComponentModel.ISupportInitialize)spcMain).BeginInit();
                        spcMain.Panel1.SuspendLayout();
                        spcMain.SuspendLayout();
                        SuspendLayout();
                        // 
                        // spcMain
                        // 
                        spcMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                        spcMain.BorderStyle = BorderStyle.FixedSingle;
                        spcMain.Location = new Point(0, 0);
                        spcMain.Margin = new Padding(2, 3, 2, 3);
                        spcMain.Name = "spcMain";
                        // 
                        // spcMain.Panel1
                        // 
                        spcMain.Panel1.Controls.Add(trvMenu);
                        // 
                        // spcMain.Panel2
                        // 
                        spcMain.Panel2.BackgroundImage = Properties.Resources.疾风剑豪;
                        spcMain.Panel2.BackgroundImageLayout = ImageLayout.Zoom;
                        spcMain.Size = new Size(884, 436);
                        spcMain.SplitterDistance = 144;
                        spcMain.SplitterWidth = 3;
                        spcMain.TabIndex = 0;
                        // 
                        // trvMenu
                        // 
                        trvMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
                        trvMenu.Size = new Size(142, 434);
                        trvMenu.TabIndex = 0;
                        trvMenu.AfterSelect += trvMenu_AfterSelect;
                        // 
                        // btnAuthorByDzl
                        // 
                        btnAuthorByDzl.Dock = DockStyle.Bottom;
                        btnAuthorByDzl.Location = new Point(0, 436);
                        btnAuthorByDzl.Name = "btnAuthorByDzl";
                        btnAuthorByDzl.Size = new Size(884, 25);
                        btnAuthorByDzl.TabIndex = 2;
                        btnAuthorByDzl.Text = "Copyright © 2023 DongZuolun. All rights reserved.";
                        btnAuthorByDzl.TextAlign = ContentAlignment.MiddleLeft;
                        btnAuthorByDzl.UseVisualStyleBackColor = true;
                        btnAuthorByDzl.Click += btnAuthorByDzl_Click;
                        // 
                        // FrmMain
                        // 
                        AutoScaleDimensions = new SizeF(96F, 96F);
                        AutoScaleMode = AutoScaleMode.Dpi;
                        AutoSize = true;
                        ClientSize = new Size(884, 461);
                        Controls.Add(btnAuthorByDzl);
                        Controls.Add(spcMain);
                        Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
                        IsMdiContainer = true;
                        Margin = new Padding(4);
                        Name = "FrmMain";
                        Text = "Appraisal_System";
                        Load += FrmMain_Load;
                        spcMain.Panel1.ResumeLayout(false);
                        ((System.ComponentModel.ISupportInitialize)spcMain).EndInit();
                        spcMain.ResumeLayout(false);
                        ResumeLayout(false);
                }

                #endregion

                private System.Windows.Forms.SplitContainer spcMain;
                private System.Windows.Forms.TreeView trvMenu;
                private Button btnAuthorByDzl;
        }
}

