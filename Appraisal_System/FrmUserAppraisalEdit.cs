using Appraisal_System.Models;
using System.Data;

namespace Appraisal_System {
    public partial class FrmUserAppraisalEdit : Form {
        private Action _bindDgv;
        private int _userId;
        private int _year;
        public FrmUserAppraisalEdit() {
            InitializeComponent();
        }
        public FrmUserAppraisalEdit(int Id, int year, Action bindDGV) : this() {
            _userId = Id;
            _year = year;
            _bindDgv = bindDGV;
        }
        private void FrmSetUserAppraisal_Load(object sender, EventArgs e) {
            CreateControls();
            BindControls();
        }

        private void BindControls() {
            List<UserAppraisals> userAppraisals = UserAppraisals.ListByUserIdAndYear(_userId, _year);
            foreach (var ua in userAppraisals) {
                var flpCtls = flpSetUserAppraisal.Controls;
                foreach (Control flpCtl in flpCtls) {
                    if (flpCtl is Panel) {
                        var plCtls = flpCtl.Controls;
                        foreach (Control plCtl in plCtls) {
                            if (plCtl is TextBox) {
                                int acId = Convert.ToInt32(plCtl.Name.Split('_')[1]);
                                plCtl.Text = userAppraisals.Find(x => x.CoefficientId == acId)?.Count.ToString();
                            }
                        }
                    }
                }
            }
        }

        private void CreateControls() {
            List<AppraisalCoefficients> appraisalCoefficients = AppraisalCoefficients.ListAll();
            foreach (var ac in appraisalCoefficients) {
                Panel panel = new Panel();
                Label label = new Label {
                    Text = ac.AppraisalType,
                    Width = 60,
                    Location = new Point(0, 4)
                };
                TextBox textBox = new TextBox {
                    Width = 120,
                    Height = 26,
                    Location = new Point(66, 0),
                    Name = "txtAppraisal_" + ac.Id
                };
                panel.Controls.Add(label);
                panel.Controls.Add(textBox);
                flpSetUserAppraisal.Controls.Add(panel);
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            var flpCtls = flpSetUserAppraisal.Controls;
            foreach (Control flpCtl in flpCtls) {
                if (flpCtl is Panel) {
                    var plCtls = flpCtl.Controls;
                    foreach (Control plCtl in plCtls) {
                        if (plCtl is TextBox) {
                            int acId = Convert.ToInt32(plCtl.Name.Split('_')[1]);
                            UserAppraisals.Delete(_userId, _year, acId);
                            UserAppraisals userAppraisal = new UserAppraisals {
                                UserId = _userId,
                                CoefficientId = acId,
                                AssessmentYear = _year,
                                Count = Convert.ToInt32(plCtl.Text == "" ? 0 : plCtl.Text),
                                IsDel = false
                            };
                            UserAppraisals.Insert(userAppraisal);
                        }
                    }
                }
            }
            MessageBox.Show("修改成功！");
            _bindDgv();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
