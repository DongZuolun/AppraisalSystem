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
            ((System.ComponentModel.ISupportInitialize)dgvBase).BeginInit();
            SuspendLayout();
            // 
            // dgvBase
            // 
            dgvBase.AllowUserToAddRows = false;
            dgvBase.AllowUserToDeleteRows = false;
            dgvBase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBase.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvBase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBase.Columns.AddRange(new DataGridViewColumn[] { Id, BaseType, AppraisalBase, IsDel });
            dgvBase.Dock = DockStyle.Fill;
            dgvBase.Location = new Point(0, 0);
            dgvBase.Name = "dgvBase";
            dgvBase.RowTemplate.Height = 25;
            dgvBase.Size = new Size(800, 450);
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
            // FrmBaseManager
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvBase);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBaseManager";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmBaseManager";
            WindowState = FormWindowState.Maximized;
            Load += FrmBaseManager_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBase).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBase;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn BaseType;
        private DataGridViewTextBoxColumn AppraisalBase;
        private DataGridViewCheckBoxColumn IsDel;
    }
}