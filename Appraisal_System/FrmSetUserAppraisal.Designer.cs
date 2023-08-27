namespace Appraisal_System {
    partial class FrmSetUserAppraisal {
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
            groupBox1 = new GroupBox();
            dgvUserAppraisal = new DataGridView();
            AppraisalType = new DataGridViewTextBoxColumn();
            Count = new DataGridViewTextBoxColumn();
            txtUserName = new TextBox();
            cbxYear = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserAppraisal).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvUserAppraisal);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(cbxYear);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(498, 318);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "考核信息";
            // 
            // dgvUserAppraisal
            // 
            dgvUserAppraisal.AllowUserToAddRows = false;
            dgvUserAppraisal.AllowUserToDeleteRows = false;
            dgvUserAppraisal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserAppraisal.Columns.AddRange(new DataGridViewColumn[] { AppraisalType, Count });
            dgvUserAppraisal.Location = new Point(32, 65);
            dgvUserAppraisal.Name = "dgvUserAppraisal";
            dgvUserAppraisal.RowTemplate.Height = 25;
            dgvUserAppraisal.Size = new Size(447, 247);
            dgvUserAppraisal.TabIndex = 4;
            dgvUserAppraisal.CellValueChanged += dgvUserAppraisal_CellValueChanged;
            // 
            // AppraisalType
            // 
            AppraisalType.DataPropertyName = "AppraisalType";
            AppraisalType.HeaderText = "绩效考核";
            AppraisalType.Name = "AppraisalType";
            // 
            // Count
            // 
            Count.DataPropertyName = "Count";
            Count.HeaderText = "次数";
            Count.Name = "Count";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(99, 31);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(219, 25);
            txtUserName.TabIndex = 15;
            // 
            // cbxYear
            // 
            cbxYear.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbxYear.FormattingEnabled = true;
            cbxYear.Location = new Point(405, 31);
            cbxYear.Margin = new Padding(4);
            cbxYear.Name = "cbxYear";
            cbxYear.Size = new Size(74, 27);
            cbxYear.TabIndex = 7;
            cbxYear.Text = "2018";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(355, 34);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 4;
            label2.Text = "年份";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 5;
            label1.Text = "用户名";
            // 
            // FrmSetUserAppraisal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 341);
            Controls.Add(groupBox1);
            Name = "FrmSetUserAppraisal";
            Text = "FrmSetUserAppraisal";
            Load += FrmSetUserAppraisal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserAppraisal).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private ComboBox cbxYear;
        private Label label2;
        private Label label1;
        private TextBox txtUserName;
        private DataGridView dgvUserAppraisal;
        private DataGridViewTextBoxColumn AppraisalType;
        private DataGridViewTextBoxColumn Count;
    }
}