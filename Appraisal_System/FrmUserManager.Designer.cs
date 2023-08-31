namespace Appraisal_System {
        partial class FrmUserManager {
                /// <summary>
                /// Required designer variable.
                /// </summary>
                private System.ComponentModel.IContainer components = null;

                /// <summary>
                /// Clean up any resources being used.
                /// </summary>
                /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
                protected override void Dispose(bool disposing) {
                        if (disposing && (components != null)) {
                                components.Dispose();
                        }
                        base.Dispose(disposing);
                }

                #region Windows Form Designer generated code

                /// <summary>
                /// Required method for Designer support - do not modify
                /// the contents of this method with the code editor.
                /// </summary>
                private void InitializeComponent() {
                        components = new System.ComponentModel.Container();
                        gbUser = new GroupBox();
                        btnSearch = new Button();
                        cbxBase = new ComboBox();
                        chkIsStop = new CheckBox();
                        txtUserName = new TextBox();
                        label2 = new Label();
                        label1 = new Label();
                        dgvUserAppraisal = new DataGridView();
                        Id = new DataGridViewTextBoxColumn();
                        UserName = new DataGridViewTextBoxColumn();
                        Sex = new DataGridViewTextBoxColumn();
                        BaseType = new DataGridViewTextBoxColumn();
                        AppraisalBase = new DataGridViewTextBoxColumn();
                        IsDel = new DataGridViewCheckBoxColumn();
                        cmsUserManager = new ContextMenuStrip(components);
                        tsmAdd = new ToolStripMenuItem();
                        tsmEdit = new ToolStripMenuItem();
                        tsmStart = new ToolStripMenuItem();
                        tsmStop = new ToolStripMenuItem();
                        gbUser.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)dgvUserAppraisal).BeginInit();
                        cmsUserManager.SuspendLayout();
                        SuspendLayout();
                        // 
                        // gbUser
                        // 
                        gbUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                        gbUser.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                        gbUser.Controls.Add(btnSearch);
                        gbUser.Controls.Add(cbxBase);
                        gbUser.Controls.Add(chkIsStop);
                        gbUser.Controls.Add(txtUserName);
                        gbUser.Controls.Add(label2);
                        gbUser.Controls.Add(label1);
                        gbUser.Font = new Font("宋体", 10F, FontStyle.Regular, GraphicsUnit.Point);
                        gbUser.Location = new Point(13, 13);
                        gbUser.Margin = new Padding(4);
                        gbUser.Name = "gbUser";
                        gbUser.Padding = new Padding(4);
                        gbUser.Size = new Size(710, 60);
                        gbUser.TabIndex = 0;
                        gbUser.TabStop = false;
                        gbUser.Text = "筛选";
                        // 
                        // btnSearch
                        // 
                        btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        btnSearch.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
                        btnSearch.Location = new Point(582, 23);
                        btnSearch.Margin = new Padding(4);
                        btnSearch.Name = "btnSearch";
                        btnSearch.Size = new Size(120, 27);
                        btnSearch.TabIndex = 4;
                        btnSearch.Text = "搜索";
                        btnSearch.UseVisualStyleBackColor = true;
                        btnSearch.Click += btnSearch_Click;
                        // 
                        // cbxBase
                        // 
                        cbxBase.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
                        cbxBase.FormattingEnabled = true;
                        cbxBase.Location = new Point(278, 24);
                        cbxBase.Margin = new Padding(4);
                        cbxBase.Name = "cbxBase";
                        cbxBase.Size = new Size(173, 27);
                        cbxBase.TabIndex = 3;
                        // 
                        // chkIsStop
                        // 
                        chkIsStop.AutoSize = true;
                        chkIsStop.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
                        chkIsStop.Location = new Point(485, 27);
                        chkIsStop.Margin = new Padding(4);
                        chkIsStop.Name = "chkIsStop";
                        chkIsStop.Size = new Size(70, 24);
                        chkIsStop.TabIndex = 2;
                        chkIsStop.Text = "已停职";
                        chkIsStop.UseVisualStyleBackColor = true;
                        // 
                        // txtUserName
                        // 
                        txtUserName.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
                        txtUserName.Location = new Point(109, 25);
                        txtUserName.Margin = new Padding(4);
                        txtUserName.Name = "txtUserName";
                        txtUserName.Size = new Size(93, 25);
                        txtUserName.TabIndex = 1;
                        // 
                        // label2
                        // 
                        label2.AutoSize = true;
                        label2.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
                        label2.Location = new Point(228, 27);
                        label2.Margin = new Padding(4, 0, 4, 0);
                        label2.Name = "label2";
                        label2.Size = new Size(37, 20);
                        label2.TabIndex = 0;
                        label2.Text = "身份";
                        // 
                        // label1
                        // 
                        label1.AutoSize = true;
                        label1.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
                        label1.Location = new Point(42, 27);
                        label1.Margin = new Padding(4, 0, 4, 0);
                        label1.Name = "label1";
                        label1.Size = new Size(51, 20);
                        label1.TabIndex = 0;
                        label1.Text = "用户名";
                        // 
                        // dgvUserAppraisal
                        // 
                        dgvUserAppraisal.AllowUserToAddRows = false;
                        dgvUserAppraisal.AllowUserToDeleteRows = false;
                        dgvUserAppraisal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                        dgvUserAppraisal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dgvUserAppraisal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                        dgvUserAppraisal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        dgvUserAppraisal.Columns.AddRange(new DataGridViewColumn[] { Id, UserName, Sex, BaseType, AppraisalBase, IsDel });
                        dgvUserAppraisal.ContextMenuStrip = cmsUserManager;
                        dgvUserAppraisal.Location = new Point(13, 82);
                        dgvUserAppraisal.Margin = new Padding(4);
                        dgvUserAppraisal.MultiSelect = false;
                        dgvUserAppraisal.Name = "dgvUserAppraisal";
                        dgvUserAppraisal.ReadOnly = true;
                        dgvUserAppraisal.RowTemplate.Height = 23;
                        dgvUserAppraisal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvUserAppraisal.Size = new Size(710, 341);
                        dgvUserAppraisal.TabIndex = 1;
                        dgvUserAppraisal.CellMouseDown += dgvUserAppraisal_CellMouseDown;
                        dgvUserAppraisal.MouseDown += dgvUserAppraisal_MouseDown;
                        // 
                        // Id
                        // 
                        Id.DataPropertyName = "Id";
                        Id.HeaderText = "编号";
                        Id.Name = "Id";
                        Id.ReadOnly = true;
                        Id.Width = 57;
                        // 
                        // UserName
                        // 
                        UserName.DataPropertyName = "UserName";
                        UserName.HeaderText = "用户名";
                        UserName.Name = "UserName";
                        UserName.ReadOnly = true;
                        UserName.Width = 69;
                        // 
                        // Sex
                        // 
                        Sex.DataPropertyName = "Sex";
                        Sex.HeaderText = "性别";
                        Sex.Name = "Sex";
                        Sex.ReadOnly = true;
                        Sex.Width = 57;
                        // 
                        // BaseType
                        // 
                        BaseType.DataPropertyName = "BaseType";
                        BaseType.HeaderText = "基数类型";
                        BaseType.Name = "BaseType";
                        BaseType.ReadOnly = true;
                        BaseType.Width = 81;
                        // 
                        // AppraisalBase
                        // 
                        AppraisalBase.DataPropertyName = "AppraisalBase";
                        AppraisalBase.HeaderText = "基数";
                        AppraisalBase.Name = "AppraisalBase";
                        AppraisalBase.ReadOnly = true;
                        AppraisalBase.Width = 57;
                        // 
                        // IsDel
                        // 
                        IsDel.DataPropertyName = "IsDel";
                        IsDel.HeaderText = "停职";
                        IsDel.Name = "IsDel";
                        IsDel.ReadOnly = true;
                        IsDel.Resizable = DataGridViewTriState.True;
                        IsDel.SortMode = DataGridViewColumnSortMode.Automatic;
                        IsDel.Width = 57;
                        // 
                        // cmsUserManager
                        // 
                        cmsUserManager.Items.AddRange(new ToolStripItem[] { tsmAdd, tsmEdit, tsmStart, tsmStop });
                        cmsUserManager.Name = "cmsUserManager";
                        cmsUserManager.Size = new Size(101, 92);
                        // 
                        // tsmAdd
                        // 
                        tsmAdd.Name = "tsmAdd";
                        tsmAdd.Size = new Size(100, 22);
                        tsmAdd.Text = "新建";
                        tsmAdd.Click += tsmAdd_Click;
                        // 
                        // tsmEdit
                        // 
                        tsmEdit.Name = "tsmEdit";
                        tsmEdit.Size = new Size(100, 22);
                        tsmEdit.Text = "编辑";
                        tsmEdit.Click += tsmEdit_Click;
                        // 
                        // tsmStart
                        // 
                        tsmStart.Name = "tsmStart";
                        tsmStart.Size = new Size(100, 22);
                        tsmStart.Text = "启用";
                        tsmStart.Click += tsmStart_Click;
                        // 
                        // tsmStop
                        // 
                        tsmStop.Name = "tsmStop";
                        tsmStop.Size = new Size(100, 22);
                        tsmStop.Text = "停用";
                        tsmStop.Click += tsmStop_Click;
                        // 
                        // FrmUserManager
                        // 
                        AutoScaleMode = AutoScaleMode.None;
                        AutoSize = true;
                        AutoSizeMode = AutoSizeMode.GrowAndShrink;
                        BackgroundImageLayout = ImageLayout.Zoom;
                        ClientSize = new Size(736, 436);
                        Controls.Add(dgvUserAppraisal);
                        Controls.Add(gbUser);
                        Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
                        FormBorderStyle = FormBorderStyle.None;
                        Margin = new Padding(4);
                        Name = "FrmUserManager";
                        StartPosition = FormStartPosition.CenterParent;
                        Text = "FrmUserManager";
                        WindowState = FormWindowState.Maximized;
                        Load += FrmUserManager_Load;
                        gbUser.ResumeLayout(false);
                        gbUser.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)dgvUserAppraisal).EndInit();
                        cmsUserManager.ResumeLayout(false);
                        ResumeLayout(false);
                }

                #endregion

                private System.Windows.Forms.GroupBox gbUser;
                private System.Windows.Forms.DataGridView dgvUserAppraisal;
                private System.Windows.Forms.Button btnSearch;
                private System.Windows.Forms.ComboBox cbxBase;
                private System.Windows.Forms.CheckBox chkIsStop;
                private System.Windows.Forms.TextBox txtUserName;
                private System.Windows.Forms.Label label2;
                private System.Windows.Forms.Label label1;
                private ContextMenuStrip cmsUserManager;
                private ToolStripMenuItem tsmAdd;
                private ToolStripMenuItem tsmEdit;
                private ToolStripMenuItem tsmStart;
                private ToolStripMenuItem tsmStop;
                private DataGridViewTextBoxColumn Id;
                private DataGridViewTextBoxColumn UserName;
                private DataGridViewTextBoxColumn Sex;
                private DataGridViewTextBoxColumn BaseType;
                private DataGridViewTextBoxColumn AppraisalBase;
                private DataGridViewCheckBoxColumn IsDel;
        }
}