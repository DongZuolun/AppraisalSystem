using Appraisal_System.Models;

namespace Appraisal_System {
        public partial class FrmBaseManager : Form {
                public FrmBaseManager() {
                        InitializeComponent();
                }

                private void FrmBaseManager_Load(object sender, EventArgs e) {
                        dgvBase.DataSource = AppraisalBases.ListAll();
                }

                private void dgvBase_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
                        if (e.RowIndex > -1) {
                                AppraisalBases bases = (AppraisalBases)dgvBase.Rows[e.RowIndex].DataBoundItem;
                                AppraisalBases.Update(bases);
                        }
                }
        }
}
