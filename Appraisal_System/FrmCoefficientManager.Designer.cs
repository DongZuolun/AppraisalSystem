namespace Appraisal_System {
        partial class FrmCoefficientManager {
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
                        dgvAppraisalCoefficient = new DataGridView();
                        Id = new DataGridViewTextBoxColumn();
                        AppraisalType = new DataGridViewTextBoxColumn();
                        AppraisalCoefficient = new DataGridViewTextBoxColumn();
                        CalculationMethod = new DataGridViewTextBoxColumn();
                        IsDel = new DataGridViewCheckBoxColumn();
                        gbAppraisal = new GroupBox();
                        btnUpdate = new Button();
                        ((System.ComponentModel.ISupportInitialize)dgvAppraisalCoefficient).BeginInit();
                        gbAppraisal.SuspendLayout();
                        SuspendLayout();
                        // 
                        // dgvAppraisalCoefficient
                        // 
                        dgvAppraisalCoefficient.AllowUserToAddRows = false;
                        dgvAppraisalCoefficient.AllowUserToDeleteRows = false;
                        dgvAppraisalCoefficient.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                        dgvAppraisalCoefficient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dgvAppraisalCoefficient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        dgvAppraisalCoefficient.Columns.AddRange(new DataGridViewColumn[] { Id, AppraisalType, AppraisalCoefficient, CalculationMethod, IsDel });
                        dgvAppraisalCoefficient.Location = new Point(12, 82);
                        dgvAppraisalCoefficient.Name = "dgvAppraisalCoefficient";
                        dgvAppraisalCoefficient.RowTemplate.Height = 25;
                        dgvAppraisalCoefficient.Size = new Size(710, 341);
                        dgvAppraisalCoefficient.TabIndex = 0;
                        dgvAppraisalCoefficient.CellValueChanged += dgvAppraisalCoefficient_CellValueChanged;
                        // 
                        // Id
                        // 
                        Id.DataPropertyName = "Id";
                        Id.HeaderText = "编号";
                        Id.Name = "Id";
                        Id.Width = 57;
                        // 
                        // AppraisalType
                        // 
                        AppraisalType.DataPropertyName = "AppraisalType";
                        AppraisalType.HeaderText = "类型";
                        AppraisalType.Name = "AppraisalType";
                        AppraisalType.Width = 57;
                        // 
                        // AppraisalCoefficient
                        // 
                        AppraisalCoefficient.DataPropertyName = "AppraisalCoefficient";
                        AppraisalCoefficient.HeaderText = "系数";
                        AppraisalCoefficient.Name = "AppraisalCoefficient";
                        AppraisalCoefficient.Width = 57;
                        // 
                        // CalculationMethod
                        // 
                        CalculationMethod.DataPropertyName = "CalculationMethod";
                        CalculationMethod.HeaderText = "计算方式";
                        CalculationMethod.Name = "CalculationMethod";
                        CalculationMethod.Width = 81;
                        // 
                        // IsDel
                        // 
                        IsDel.DataPropertyName = "IsDel";
                        IsDel.HeaderText = "删除";
                        IsDel.Name = "IsDel";
                        IsDel.Resizable = DataGridViewTriState.True;
                        IsDel.SortMode = DataGridViewColumnSortMode.Automatic;
                        IsDel.Width = 57;
                        // 
                        // gbAppraisal
                        // 
                        gbAppraisal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                        gbAppraisal.Controls.Add(btnUpdate);
                        gbAppraisal.Location = new Point(12, 12);
                        gbAppraisal.Name = "gbAppraisal";
                        gbAppraisal.Size = new Size(710, 60);
                        gbAppraisal.TabIndex = 2;
                        gbAppraisal.TabStop = false;
                        gbAppraisal.Text = "选项";
                        // 
                        // btnUpdate
                        // 
                        btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        btnUpdate.Location = new Point(608, 22);
                        btnUpdate.Name = "btnUpdate";
                        btnUpdate.Size = new Size(75, 23);
                        btnUpdate.TabIndex = 7;
                        btnUpdate.Text = "更新数据";
                        btnUpdate.UseVisualStyleBackColor = true;
                        // 
                        // FrmCoefficientManager
                        // 
                        AutoScaleMode = AutoScaleMode.Inherit;
                        AutoScroll = true;
                        AutoSize = true;
                        AutoSizeMode = AutoSizeMode.GrowAndShrink;
                        ClientSize = new Size(736, 436);
                        Controls.Add(gbAppraisal);
                        Controls.Add(dgvAppraisalCoefficient);
                        FormBorderStyle = FormBorderStyle.None;
                        Name = "FrmCoefficientManager";
                        Tag = "";
                        Text = "FrmCoefficientManager";
                        WindowState = FormWindowState.Maximized;
                        Load += FrmCoefficientManager_Load;
                        ((System.ComponentModel.ISupportInitialize)dgvAppraisalCoefficient).EndInit();
                        gbAppraisal.ResumeLayout(false);
                        ResumeLayout(false);
                }

                #endregion

                private DataGridView dgvAppraisalCoefficient;
                private DataGridViewTextBoxColumn Id;
                private DataGridViewTextBoxColumn AppraisalType;
                private DataGridViewTextBoxColumn AppraisalCoefficient;
                private DataGridViewTextBoxColumn CalculationMethod;
                private DataGridViewCheckBoxColumn IsDel;
                private GroupBox gbAppraisal;
                private Button btnUpdate;
        }
}