namespace Appraisal_System {
        partial class FrmBaseManager {
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
                        dgvBase = new DataGridView();
                        Id = new DataGridViewTextBoxColumn();
                        BaseType = new DataGridViewTextBoxColumn();
                        AppraisalBase = new DataGridViewTextBoxColumn();
                        IsDel = new DataGridViewCheckBoxColumn();
                        gbBase = new GroupBox();
                        btnUpdate = new Button();
                        ((System.ComponentModel.ISupportInitialize)dgvBase).BeginInit();
                        gbBase.SuspendLayout();
                        SuspendLayout();
                        // 
                        // dgvBase
                        // 
                        dgvBase.AllowUserToAddRows = false;
                        dgvBase.AllowUserToDeleteRows = false;
                        dgvBase.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                        dgvBase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvBase.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                        dgvBase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        dgvBase.Columns.AddRange(new DataGridViewColumn[] { Id, BaseType, AppraisalBase, IsDel });
                        dgvBase.Location = new Point(12, 81);
                        dgvBase.Name = "dgvBase";
                        dgvBase.RowTemplate.Height = 25;
                        dgvBase.Size = new Size(776, 357);
                        dgvBase.TabIndex = 0;
                        dgvBase.CellValueChanged += dgvBase_CellValueChanged;
                        // 
                        // Id
                        // 
                        Id.DataPropertyName = "Id";
                        Id.HeaderText = "编号";
                        Id.Name = "Id";
                        // 
                        // BaseType
                        // 
                        BaseType.DataPropertyName = "BaseType";
                        BaseType.HeaderText = "基数类型";
                        BaseType.Name = "BaseType";
                        // 
                        // AppraisalBase
                        // 
                        AppraisalBase.DataPropertyName = "AppraisalBase";
                        AppraisalBase.HeaderText = "基数";
                        AppraisalBase.Name = "AppraisalBase";
                        // 
                        // IsDel
                        // 
                        IsDel.DataPropertyName = "IsDel";
                        IsDel.HeaderText = "停用";
                        IsDel.Name = "IsDel";
                        // 
                        // gbBase
                        // 
                        gbBase.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                        gbBase.Controls.Add(btnUpdate);
                        gbBase.Location = new Point(12, 11);
                        gbBase.Name = "gbBase";
                        gbBase.Size = new Size(776, 64);
                        gbBase.TabIndex = 1;
                        gbBase.TabStop = false;
                        gbBase.Text = "选项";
                        // 
                        // btnUpdate
                        // 
                        btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        btnUpdate.Location = new Point(671, 22);
                        btnUpdate.Name = "btnUpdate";
                        btnUpdate.Size = new Size(75, 23);
                        btnUpdate.TabIndex = 7;
                        btnUpdate.Text = "更新数据";
                        btnUpdate.UseVisualStyleBackColor = true;
                        // 
                        // FrmBaseManager
                        // 
                        AutoScaleDimensions = new SizeF(96F, 96F);
                        AutoScaleMode = AutoScaleMode.Dpi;
                        AutoSize = true;
                        ClientSize = new Size(800, 450);
                        Controls.Add(gbBase);
                        Controls.Add(dgvBase);
                        FormBorderStyle = FormBorderStyle.None;
                        Name = "FrmBaseManager";
                        StartPosition = FormStartPosition.CenterParent;
                        Text = "FrmBaseManager";
                        WindowState = FormWindowState.Maximized;
                        Load += FrmBaseManager_Load;
                        ((System.ComponentModel.ISupportInitialize)dgvBase).EndInit();
                        gbBase.ResumeLayout(false);
                        ResumeLayout(false);
                }

                #endregion

                private DataGridView dgvBase;
                private DataGridViewTextBoxColumn Id;
                private DataGridViewTextBoxColumn BaseType;
                private DataGridViewTextBoxColumn AppraisalBase;
                private DataGridViewCheckBoxColumn IsDel;
                private GroupBox gbBase;
                private Button btnUpdate;
        }
}