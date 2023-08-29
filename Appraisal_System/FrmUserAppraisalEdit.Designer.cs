namespace Appraisal_System {
    partial class FrmUserAppraisalEdit {
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
            flpSetUserAppraisal = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnCancel = new Button();
            btnSave = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // flpSetUserAppraisal
            // 
            flpSetUserAppraisal.Dock = DockStyle.Fill;
            flpSetUserAppraisal.Location = new Point(3, 19);
            flpSetUserAppraisal.Name = "flpSetUserAppraisal";
            flpSetUserAppraisal.Size = new Size(625, 161);
            flpSetUserAppraisal.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flpSetUserAppraisal);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(631, 183);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "填写信息";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCancel);
            groupBox2.Controls.Add(btnSave);
            groupBox2.Location = new Point(12, 201);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(631, 63);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(521, 22);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(415, 22);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "保存";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FrmUserAppraisalEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 276);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmUserAppraisalEdit";
            Text = "FrmSetUserAppraisal";
            Load += FrmSetUserAppraisal_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpSetUserAppraisal;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnCancel;
        private Button btnSave;
    }
}