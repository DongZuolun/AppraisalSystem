namespace Appraisal_System {
    partial class FrmSetUser {
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
            chkIsStop = new CheckBox();
            cbxBase = new ComboBox();
            label3 = new Label();
            cbxSex = new ComboBox();
            txtUserName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnSave = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkIsStop);
            groupBox1.Controls.Add(cbxBase);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbxSex);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(528, 168);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "用户信息";
            // 
            // chkIsStop
            // 
            chkIsStop.AutoSize = true;
            chkIsStop.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            chkIsStop.Location = new Point(368, 77);
            chkIsStop.Margin = new Padding(4);
            chkIsStop.Name = "chkIsStop";
            chkIsStop.Size = new Size(84, 24);
            chkIsStop.TabIndex = 10;
            chkIsStop.Text = "是否停用";
            chkIsStop.UseVisualStyleBackColor = true;
            // 
            // cbxBase
            // 
            cbxBase.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbxBase.FormattingEnabled = true;
            cbxBase.Location = new Point(99, 76);
            cbxBase.Margin = new Padding(4);
            cbxBase.Name = "cbxBase";
            cbxBase.Size = new Size(219, 27);
            cbxBase.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 79);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 8;
            label3.Text = "身份";
            // 
            // cbxSex
            // 
            cbxSex.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbxSex.FormattingEnabled = true;
            cbxSex.Items.AddRange(new object[] { "男", "女" });
            cbxSex.Location = new Point(405, 31);
            cbxSex.Margin = new Padding(4);
            cbxSex.Name = "cbxSex";
            cbxSex.Size = new Size(74, 27);
            cbxSex.TabIndex = 7;
            cbxSex.Text = "男";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(99, 31);
            txtUserName.Margin = new Padding(4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(219, 25);
            txtUserName.TabIndex = 6;
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
            label2.Text = "性别";
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
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSave);
            groupBox2.Location = new Point(12, 186);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(528, 85);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(405, 34);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "保存";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FrmSetUser
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 283);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmSetUser";
            Text = "FrmSetUser";
            Load += FrmSetUser_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnSave;
        private ComboBox cbxBase;
        private Label label3;
        private ComboBox cbxSex;
        private TextBox txtUserName;
        private Label label2;
        private Label label1;
        private CheckBox chkIsStop;
    }
}