using Appraisal_System.Models;
using System.Data;

namespace Appraisal_System {
    public partial class FrmSetUserAppraisal : Form {
        private DelBindDgv _delBindDgv;
        private UserAppraisalBase _userAppraisal;
        public FrmSetUserAppraisal() {
            InitializeComponent();
        }
        public FrmSetUserAppraisal(DelBindDgv delBindDgv, int Id) : this() {
            _delBindDgv = delBindDgv;
            _userAppraisal = UserAppraisalBase.GetListJoinAppraisal().Find(x => x.Id == Id);
        }
        private void FrmSetUserAppraisal_Load(object sender, EventArgs e) {
            dgvUserAppraisal.AutoGenerateColumns = false;
            dgvUserAppraisal.DataSource = AppraisalCoefficients.ListAll();
            txtUserName.Text = _userAppraisal.UserName;
        }

        private void dgvUserAppraisal_CellValueChanged(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
