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
            ((System.ComponentModel.ISupportInitialize)dgvAppraisalCoefficient).BeginInit();
            SuspendLayout();
            // 
            // dgvAppraisalCoefficient
            // 
            dgvAppraisalCoefficient.AllowUserToAddRows = false;
            dgvAppraisalCoefficient.AllowUserToDeleteRows = false;
            dgvAppraisalCoefficient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppraisalCoefficient.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvAppraisalCoefficient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppraisalCoefficient.Columns.AddRange(new DataGridViewColumn[] { Id, AppraisalType, AppraisalCoefficient, CalculationMethod, IsDel });
            dgvAppraisalCoefficient.Dock = DockStyle.Fill;
            dgvAppraisalCoefficient.Location = new Point(0, 0);
            dgvAppraisalCoefficient.Name = "dgvAppraisalCoefficient";
            dgvAppraisalCoefficient.RowTemplate.Height = 25;
            dgvAppraisalCoefficient.Size = new Size(800, 450);
            dgvAppraisalCoefficient.TabIndex = 0;
            dgvAppraisalCoefficient.CellValueChanged += dgvAppraisalCoefficient_CellValueChanged;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "编号";
            Id.Name = "Id";
            // 
            // AppraisalType
            // 
            AppraisalType.DataPropertyName = "AppraisalType";
            AppraisalType.HeaderText = "类型";
            AppraisalType.Name = "AppraisalType";
            // 
            // AppraisalCoefficient
            // 
            AppraisalCoefficient.DataPropertyName = "AppraisalCoefficient";
            AppraisalCoefficient.HeaderText = "系数";
            AppraisalCoefficient.Name = "AppraisalCoefficient";
            // 
            // CalculationMethod
            // 
            CalculationMethod.DataPropertyName = "CalculationMethod";
            CalculationMethod.HeaderText = "计算方式";
            CalculationMethod.Name = "CalculationMethod";
            // 
            // IsDel
            // 
            IsDel.DataPropertyName = "IsDel";
            IsDel.HeaderText = "删除";
            IsDel.Name = "IsDel";
            IsDel.Resizable = DataGridViewTriState.True;
            IsDel.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // FrmCoefficientManager
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvAppraisalCoefficient);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCoefficientManager";
            Tag = "";
            Text = "FrmCoefficientManager";
            WindowState = FormWindowState.Maximized;
            Load += FrmCoefficientManager_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAppraisalCoefficient).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAppraisalCoefficient;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn AppraisalType;
        private DataGridViewTextBoxColumn AppraisalCoefficient;
        private DataGridViewTextBoxColumn CalculationMethod;
        private DataGridViewCheckBoxColumn IsDel;
    }
}