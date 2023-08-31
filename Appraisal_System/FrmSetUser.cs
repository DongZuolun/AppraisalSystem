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
                                MessageBox.Show($"{_user?.UserName}\r添加成功！");
                        }
                        else {
                                String oldUserName = _user.UserName;
                                _user.UserName = userName;
                                _user.BaseTypeId = baseTypeId;
                                _user.Sex = sex;
                                _user.IsDel = isDel;
                                Users.Update(_user);
                                MessageBox.Show($"{oldUserName}\r修改成功！");
                                this.Close();
                        }
                        _delBindDgv();
                }

                private void btnDelete_Click(object sender, EventArgs e) {
                        MessageBox.Show($"{_user.UserName}\r删除成功！");
                        Users.Delete(_user.Id, _user.UserName);
                        _delBindDgv();
                }

                private void btnCancel_Click(object sender, EventArgs e) {
                        DialogResult dialogResult = MessageBox.Show("确认退出？", "用户编辑", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (DialogResult.OK == dialogResult) {
                                this.Close();
                        }
                }
        }
}
