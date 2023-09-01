namespace Appraisal_System {
        partial class FrmUserAppraisal {
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
                        gbUserAppraisal = new GroupBox();
                        btnQuery = new Button();
                        cbxUserId = new ComboBox();
                        label1 = new Label();
                        cbxYear = new ComboBox();
                        label2 = new Label();
                        dgvUserAppraisal = new DataGridView();
                        Id = new DataGridViewTextBoxColumn();
                        UserName = new DataGridViewTextBoxColumn();
                        Sex = new DataGridViewTextBoxColumn();
                        BaseType = new DataGridViewTextBoxColumn();
                        AppraisalBase = new DataGridViewTextBoxColumn();
                        cmsSetUserAppraisal = new ContextMenuStrip(components);
                        tsmEdit = new ToolStripMenuItem();
                        gbUserAppraisal.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)dgvUserAppraisal).BeginInit();
                        cmsSetUserAppraisal.SuspendLayout();
                        SuspendLayout();
                        // 
                        // gbUserAppraisal
                        // 
                        gbUserAppraisal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                        gbUserAppraisal.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                        gbUserAppraisal.Controls.Add(btnQuery);
                        gbUserAppraisal.Controls.Add(cbxUserId);
                        gbUserAppraisal.Controls.Add(label1);
                        gbUserAppraisal.Controls.Add(cbxYear);
                        gbUserAppraisal.Controls.Add(label2);
                        gbUserAppraisal.Location = new Point(12, 12);
                        gbUserAppraisal.Name = "gbUserAppraisal";
                        gbUserAppraisal.Size = new Size(710, 60);
                        gbUserAppraisal.TabIndex = 0;
                        gbUserAppraisal.TabStop = false;
                        gbUserAppraisal.Text = "选项";
                        // 
                        // btnQuery
                        // 
                        btnQuery.Location = new Point(583, 27);
                        btnQuery.Name = "btnQuery";
                        btnQuery.Size = new Size(75, 23);
                        btnQuery.TabIndex = 8;
                        btnQuery.Text = "查询";
                        btnQuery.UseVisualStyleBackColor = true;
                        btnQuery.Click += btnQuery_Click;
                        // 
                        // cbxUserId
                        // 
                        cbxUserId.FormattingEnabled = true;
                        cbxUserId.Location = new Point(69, 27);
                        cbxUserId.Name = "cbxUserId";
                        cbxUserId.Size = new Size(179, 25);
                        cbxUserId.TabIndex = 7;
                        // 
                        // label1
                        // 
                        label1.AutoSize = true;
                        label1.Location = new Point(31, 30);
                        label1.Name = "label1";
                        label1.Size = new Size(32, 17);
                        label1.TabIndex = 6;
                        label1.Text = "用户";
                        // 
                        // cbxYear
                        // 
                        cbxYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        cbxYear.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
                        cbxYear.FormattingEnabled = true;
                        cbxYear.Items.AddRange(new object[] { "2022", "2023", "2024", "2025", "2026" });
                        cbxYear.Location = new Point(311, 25);
                        cbxYear.Margin = new Padding(4);
                        cbxYear.Name = "cbxYear";
                        cbxYear.Size = new Size(173, 27);
                        cbxYear.TabIndex = 5;
                        cbxYear.Text = "2023";
                        // 
                        // label2
                        // 
                        label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        label2.AutoSize = true;
                        label2.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
                        label2.Location = new Point(266, 28);
                        label2.Margin = new Padding(4, 0, 4, 0);
                        label2.Name = "label2";
                        label2.Size = new Size(37, 20);
                        label2.TabIndex = 4;
                        label2.Text = "年份";
                        // 
                        // dgvUserAppraisal
                        // 
                        dgvUserAppraisal.AllowUserToAddRows = false;
                        dgvUserAppraisal.AllowUserToDeleteRows = false;
                        dgvUserAppraisal.AllowUserToOrderColumns = true;
                        dgvUserAppraisal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                        dgvUserAppraisal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dgvUserAppraisal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                        dgvUserAppraisal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        dgvUserAppraisal.Columns.AddRange(new DataGridViewColumn[] { Id, UserName, Sex, BaseType, AppraisalBase });
                        dgvUserAppraisal.ContextMenuStrip = cmsSetUserAppraisal;
                        dgvUserAppraisal.Location = new Point(12, 78);
                        dgvUserAppraisal.MultiSelect = false;
                        dgvUserAppraisal.Name = "dgvUserAppraisal";
                        dgvUserAppraisal.ReadOnly = true;
                        dgvUserAppraisal.RowTemplate.Height = 25;
                        dgvUserAppraisal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvUserAppraisal.Size = new Size(710, 341);
                        dgvUserAppraisal.TabIndex = 1;
                        dgvUserAppraisal.CellMouseDown += dgvUserAppraisal_CellMouseDown;
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
                        BaseType.HeaderText = "身份";
                        BaseType.Name = "BaseType";
                        BaseType.ReadOnly = true;
                        BaseType.Width = 57;
                        // 
                        // AppraisalBase
                        // 
                        AppraisalBase.DataPropertyName = "AppraisalBase";
                        AppraisalBase.HeaderText = "年终奖基数";
                        AppraisalBase.Name = "AppraisalBase";
                        AppraisalBase.ReadOnly = true;
                        AppraisalBase.Width = 93;
                        // 
                        // cmsSetUserAppraisal
                        // 
                        cmsSetUserAppraisal.Items.AddRange(new ToolStripItem[] { tsmEdit });
                        cmsSetUserAppraisal.Name = "cmsSetUserAppraisal";
                        cmsSetUserAppraisal.Size = new Size(101, 26);
                        // 
                        // tsmEdit
                        // 
                        tsmEdit.Name = "tsmEdit";
                        tsmEdit.Size = new Size(100, 22);
                        tsmEdit.Text = "编辑";
                        tsmEdit.Click += tsmEdit_Click;
                        // 
                        // FrmUserAppraisal
                        // 
                        AutoScaleMode = AutoScaleMode.Inherit;
                        AutoScroll = true;
                        AutoSize = true;
                        ClientSize = new Size(736, 436);
                        Controls.Add(dgvUserAppraisal);
                        Controls.Add(gbUserAppraisal);
                        FormBorderStyle = FormBorderStyle.None;
                        Name = "FrmUserAppraisal";
                        StartPosition = FormStartPosition.CenterParent;
                        Text = "FrmUserAppraisal";
                        WindowState = FormWindowState.Maximized;
                        Load += FrmUserAppraisal_Load;
                        gbUserAppraisal.ResumeLayout(false);
                        gbUserAppraisal.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)dgvUserAppraisal).EndInit();
                        cmsSetUserAppraisal.ResumeLayout(false);
                        ResumeLayout(false);
                }

                #endregion

                private GroupBox gbUserAppraisal;
                private ComboBox cbxYear;
                private Label label2;
                private DataGridView dgvUserAppraisal;
                private DataGridViewTextBoxColumn Id;
                private DataGridViewTextBoxColumn UserName;
                private DataGridViewTextBoxColumn Sex;
                private DataGridViewTextBoxColumn BaseType;
                private DataGridViewTextBoxColumn AppraisalBase;
                private ContextMenuStrip cmsSetUserAppraisal;
                private ToolStripMenuItem tsmEdit;
                private ComboBox cbxUserId;
                private Label label1;
                private Button btnQuery;
        }
}