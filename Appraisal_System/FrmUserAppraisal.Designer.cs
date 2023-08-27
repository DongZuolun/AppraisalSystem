﻿namespace Appraisal_System {
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
            groupBox1 = new GroupBox();
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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserAppraisal).BeginInit();
            cmsSetUserAppraisal.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(cbxYear);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 64);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "选项";
            // 
            // cbxYear
            // 
            cbxYear.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbxYear.FormattingEnabled = true;
            cbxYear.Location = new Point(596, 23);
            cbxYear.Margin = new Padding(4);
            cbxYear.Name = "cbxYear";
            cbxYear.Size = new Size(173, 27);
            cbxYear.TabIndex = 5;
            cbxYear.Text = "2018";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(546, 26);
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
            dgvUserAppraisal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dgvUserAppraisal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUserAppraisal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvUserAppraisal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserAppraisal.Columns.AddRange(new DataGridViewColumn[] { Id, UserName, Sex, BaseType, AppraisalBase });
            dgvUserAppraisal.ContextMenuStrip = cmsSetUserAppraisal;
            dgvUserAppraisal.Location = new Point(11, 91);
            dgvUserAppraisal.MultiSelect = false;
            dgvUserAppraisal.Name = "dgvUserAppraisal";
            dgvUserAppraisal.ReadOnly = true;
            dgvUserAppraisal.RowTemplate.Height = 25;
            dgvUserAppraisal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUserAppraisal.Size = new Size(777, 347);
            dgvUserAppraisal.TabIndex = 1;
            dgvUserAppraisal.CellMouseDown += dgvUserAppraisal_CellMouseDown;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "编号";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // UserName
            // 
            UserName.DataPropertyName = "UserName";
            UserName.HeaderText = "用户名";
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            // 
            // Sex
            // 
            Sex.DataPropertyName = "Sex";
            Sex.HeaderText = "性别";
            Sex.Name = "Sex";
            Sex.ReadOnly = true;
            // 
            // BaseType
            // 
            BaseType.DataPropertyName = "BaseType";
            BaseType.HeaderText = "身份";
            BaseType.Name = "BaseType";
            BaseType.ReadOnly = true;
            // 
            // AppraisalBase
            // 
            AppraisalBase.DataPropertyName = "AppraisalBase";
            AppraisalBase.HeaderText = "年终奖基数";
            AppraisalBase.Name = "AppraisalBase";
            AppraisalBase.ReadOnly = true;
            // 
            // cmsSetUserAppraisal
            // 
            cmsSetUserAppraisal.Items.AddRange(new ToolStripItem[] { tsmEdit });
            cmsSetUserAppraisal.Name = "cmsSetUserAppraisal";
            cmsSetUserAppraisal.Size = new Size(181, 48);
            // 
            // tsmEdit
            // 
            tsmEdit.Name = "tsmEdit";
            tsmEdit.Size = new Size(180, 22);
            tsmEdit.Text = "编辑";
            tsmEdit.Click += tsmEdit_Click;
            // 
            // FrmUserAppraisal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvUserAppraisal);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUserAppraisal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmUserAppraisal";
            WindowState = FormWindowState.Maximized;
            Load += FrmUserAppraisal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserAppraisal).EndInit();
            cmsSetUserAppraisal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
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
    }
}