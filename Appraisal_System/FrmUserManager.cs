using Appraisal_System.Models;

namespace Appraisal_System {
        public delegate void DelBindDgv();//方法类型
        public partial class FrmUserManager : Form {
                private DelBindDgv _dgv;
                public FrmUserManager() {
                        InitializeComponent();
                }

                private void FrmUserManager_Load(object sender, EventArgs e) {
                        BindCbx();
                        BindDgv();
                        _dgv = BindDgv;
                }

                private void BindDgv() {
                        string userName = txtUserName.Text.Trim();
                        int baseTypeId = (int)cbxBase.SelectedValue;
                        bool isStop = chkIsStop.Checked;
                        dgvUserAppraisal.AutoGenerateColumns = false;
                        if (baseTypeId == 0) {
                                dgvUserAppraisal.DataSource = UserAppraisalBase.GetListJoinAppraisal().FindAll(
                                    m => m.UserName.Contains(userName) && m.IsDel == isStop);
                        }
                        else {
                                dgvUserAppraisal.DataSource = UserAppraisalBase.GetListJoinAppraisal().FindAll(
                                m => m.UserName.Contains(userName) && m.BaseTypeId == baseTypeId && m.IsDel == isStop);
                        }
                }

                private void BindCbx() {
                        List<AppraisalBases> appraisalBases = AppraisalBases.ListAll();
                        appraisalBases.Insert(0, new AppraisalBases {
                                Id = 0,
                                BaseType = "-查询所有-",
                                AppraisalBase = 0,
                                IsDel = false
                        });
                        cbxBase.DataSource = appraisalBases;
                        cbxBase.DisplayMember = "BaseType";
                        cbxBase.ValueMember = "Id";
                }

                private void btnSearch_Click(object sender, EventArgs e) {
                        BindDgv();
                }

                private void dgvUserAppraisal_MouseDown(object sender, MouseEventArgs e) {
                        if (e.Button == MouseButtons.Right) {
                                tsmAdd.Visible = true;
                                tsmEdit.Visible = false;
                                tsmStart.Visible = false;
                                tsmStop.Visible = false;
                        }
                }

                private void dgvUserAppraisal_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
                        if (e.Button == MouseButtons.Right) {
                                if (e.RowIndex > -1) {
                                        dgvUserAppraisal.Rows[e.RowIndex].Selected = true;
                                        tsmAdd.Visible = true;
                                        tsmEdit.Visible = true;
                                        bool isDel = (bool)dgvUserAppraisal.SelectedRows[0].Cells["IsDel"].Value;
                                        if (isDel) {
                                                tsmStart.Visible = true;
                                        }
                                        else {
                                                tsmStop.Visible = true;
                                        }
                                }
                        }
                }

                private void tsmAdd_Click(object sender, EventArgs e) {
                        FrmSetUser frmSetUser = new FrmSetUser(_dgv);
                        frmSetUser.ShowDialog();
                }

                private void tsmEdit_Click(object sender, EventArgs e) {
                        int id = (int)dgvUserAppraisal.SelectedRows[0].Cells["Id"].Value;
                        FrmSetUser frmSetUser = new FrmSetUser(_dgv, id);
                        frmSetUser.ShowDialog();
                }

                private void tsmStart_Click(object sender, EventArgs e) {
                        int id = (int)dgvUserAppraisal.SelectedRows[0].Cells["Id"].Value;
                        string userName = (string)dgvUserAppraisal.SelectedRows[0].Cells["UserName"].Value;
                        Users user = Users.ListAll().Find(x => x.Id == id && x.UserName == userName);
                        if (user != null) {
                                user.IsDel = false;
                                Users.Update(user);
                                if (Users.Update(user) > 0) {
                                        MessageBox.Show($"{user.UserName}\r入职办理成功！");
                                }
                        }
                        _dgv();
                }

                private void tsmStop_Click(object sender, EventArgs e) {
                        int id = (int)dgvUserAppraisal.SelectedRows[0].Cells["Id"].Value;
                        string userName = (string)dgvUserAppraisal.SelectedRows[0].Cells["UserName"].Value;
                        Users user = Users.ListAll().Find(x => x.Id == id && x.UserName == userName);
                        if (user != null) {
                                user.IsDel = true;
                                if (Users.Update(user) > 0) {
                                        MessageBox.Show($"{user.UserName}\r离职办理成功！");
                                }
                        }
                        _dgv();
                }
        }
}
