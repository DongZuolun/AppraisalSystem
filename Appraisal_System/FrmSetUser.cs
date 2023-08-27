using Appraisal_System.Models;

namespace Appraisal_System {
    public partial class FrmSetUser : Form {
        private DelBindDgv _delBindDgv;
        public FrmSetUser(DelBindDgv bindDgv) {
            InitializeComponent();
            _delBindDgv = bindDgv;
        }
        private Users _user;
        public FrmSetUser(DelBindDgv bindDgv, int userId) : this(bindDgv) {
            _user = Users.ListAll().Find(m => m.Id == userId);
        }

        private void FrmSetUser_Load(object sender, EventArgs e) {
            List<AppraisalBases> appraisalBases = AppraisalBases.ListAll();
            cbxBase.DataSource = appraisalBases;
            cbxBase.DisplayMember = "BaseType";
            cbxBase.ValueMember = "Id";
            if (_user != null) {
                txtUserName.Text = _user.UserName;
                cbxBase.SelectedValue = _user.BaseTypeId;
                cbxSex.Text = _user.Sex;
                chkIsStop.Checked = _user.IsDel;
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            string userName = txtUserName.Text.Trim();
            int baseTypeId = (int)cbxBase.SelectedValue;
            string sex = cbxSex.Text.Trim();
            bool isDel = chkIsStop.Checked;
            if (_user == null) {
                Users user = new Users {
                    UserName = userName,
                    BaseTypeId = baseTypeId,
                    Password = "111",
                    Sex = sex,
                    IsDel = isDel
                };
                Users.Insert(user);
                MessageBox.Show("用户添加成功！");
            }
            else {
                _user.UserName = userName;
                _user.BaseTypeId = baseTypeId;
                _user.Sex = sex;
                _user.IsDel = isDel;
                Users.Update(_user);
                MessageBox.Show("用户修改成功！");
                this.Close();
            }
            _delBindDgv();
        }
    }
}
