using Appraisal_System.Models;

namespace Appraisal_System {
        public partial class FrmCoefficientManager : Form {
                public FrmCoefficientManager() {
                        InitializeComponent();
                }
                private void FrmCoefficientManager_Load(object sender, EventArgs e) {
                        dgvAppraisalCoefficient.AutoGenerateColumns = false;
                        dgvAppraisalCoefficient.DataSource = AppraisalCoefficients.ListAll();
                }
                private void dgvAppraisalCoefficient_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
                        if (e.RowIndex > -1) {
                                AppraisalCoefficients appraisalCoefficients = (AppraisalCoefficients)dgvAppraisalCoefficient.Rows[e.RowIndex].DataBoundItem;
                                AppraisalCoefficients.Update(appraisalCoefficients);
                        }
                }
        }
}
