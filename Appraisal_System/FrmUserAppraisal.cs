using Appraisal_System.Models;
using System.Data;

namespace Appraisal_System {
    public partial class FrmUserAppraisal : Form {
        private DelBindDgv _delBindDgv;
        public FrmUserAppraisal() {
            InitializeComponent();
        }

        private void FrmUserAppraisal_Load(object sender, EventArgs e) {
            SetCol();
            SetValue();
            _delBindDgv = SetValue;
        }

        private void SetValue() {
            //获取需要扩展的表
            DataTable dtUser = UserAppraisalBase.GetDtJoinAppraisal();
            //获取系数表集合
            List<AppraisalCoefficients> appraisalCoefficients = AppraisalCoefficients.ListAll();
            //通过系数表填充DT
            foreach (var item in appraisalCoefficients) {
                //添加列名
                dtUser.Columns.Add(new DataColumn {
                    ColumnName = "AppraisalType" + item.Id
                });
                //添加系数值
                dtUser.Columns.Add(new DataColumn {
                    ColumnName = "AppraisalCoefficient" + item.Id
                });
                //添加计算方式
                dtUser.Columns.Add(new DataColumn {
                    ColumnName = "CalculationMethod" + item.Id
                });
            }
            //添加考核年度
            dtUser.Columns.Add(new DataColumn {
                ColumnName = "AssessmentYear"
            });
            //添加实发年终奖
            dtUser.Columns.Add(new DataColumn {
                ColumnName = "YearBonus"
            });

            //给dtUser填充数据
            List<UserAppraisalCoefficient> userAppraisalCoefficients = UserAppraisalCoefficient.ListAll();
            for (int i = 0; i < dtUser.Rows.Count; i++) {
                var uacFilter = userAppraisalCoefficients.FindAll(m => m.UserId == (int)dtUser.Rows[i]["Id"] && m.AssessmentYear == Convert.ToInt32(cbxYear.Text));
                //系数计算的数组，用于存放每个考核类型的总系数
                double[] yearBonusArray = new double[uacFilter.Count];
                for (int j = 0; j < uacFilter.Count; j++) {
                    //获取AppraisalType对应的dtUser的ColumnName的值
                    //获取考核次数
                    string appraisalTypeCountKey = "AppraisalType" + uacFilter[j].CoefficientId;
                    double appraisalTypeCountValue = uacFilter[j].Count;
                    //获取考核系数
                    string appraisalCoefficientKey = "AppraisalCoefficient" + uacFilter[j].CoefficientId;
                    double appraisalCoefficientValue = uacFilter[j].AppraisalCoefficient;
                    //获取计算方式
                    string calculationMethodKey = "CalculationMethod" + uacFilter[j].CoefficientId;
                    int calculationMethodValue = uacFilter[j].CalculationMethod;
                    //给dtUser绑定值
                    dtUser.Rows[i][appraisalTypeCountKey] = appraisalTypeCountValue;
                    dtUser.Rows[i][appraisalCoefficientKey] = appraisalCoefficientValue;
                    dtUser.Rows[i][calculationMethodKey] = calculationMethodValue;
                    //计算考核系数
                    //"考核系数"*"次数"*"计算方式"
                    yearBonusArray[j] = appraisalCoefficientValue * appraisalTypeCountValue * calculationMethodValue;
                }
                dtUser.Rows[i]["AssessmentYear"] = cbxYear.Text.Trim();
                //结算实发年终奖
                double yearBonusAll = 0;
                foreach (var item in yearBonusArray) {
                    yearBonusAll += item;
                }
                //计算实发年终奖
                double yearBonus = (1 + yearBonusAll) * Convert.ToDouble(dtUser.Rows[i]["AppraisalBase"]);
                //由于很有可能这个人迟到太多，钱被扣成负数，如果是负数，则为0
                dtUser.Rows[i]["YearBonus"] = yearBonus < 0 ? 0 : yearBonus;
            }
            dgvUserAppraisal.AutoGenerateColumns = false;
            dgvUserAppraisal.DataSource = dtUser;
        }

        private void SetCol() {
            List<AppraisalCoefficients> appraisalCoefficients = AppraisalCoefficients.ListAll();
            List<DataGridViewTextBoxColumn> dataGridViewTextBoxColumns = new();
            foreach (var appraisalCoefficient in appraisalCoefficients) {
                dataGridViewTextBoxColumns.Add(new DataGridViewTextBoxColumn {
                    HeaderText = appraisalCoefficient.AppraisalType,
                    Name = "AppraisalType" + appraisalCoefficient.Id.ToString(),
                    DataPropertyName = "AppraisalType" + appraisalCoefficient.Id.ToString(),
                    ReadOnly = true,
                });
                dataGridViewTextBoxColumns.Add(new DataGridViewTextBoxColumn {
                    HeaderText = "系数",
                    Name = "AppraisalCoefficient" + appraisalCoefficient.Id.ToString(),
                    DataPropertyName = "AppraisalCoefficient" + appraisalCoefficient.Id.ToString(),
                    ReadOnly = true,
                    Visible = false,
                });
                dataGridViewTextBoxColumns.Add(new DataGridViewTextBoxColumn {
                    HeaderText = "计算方式",
                    Name = "CalculationMethod" + appraisalCoefficient.Id.ToString(),
                    DataPropertyName = "CalculationMethod" + appraisalCoefficient.Id.ToString(),
                    ReadOnly = true,
                    Visible = false
                });
            }
            dgvUserAppraisal.Columns.AddRange(dataGridViewTextBoxColumns.ToArray());
            dgvUserAppraisal.Columns.Add(new DataGridViewTextBoxColumn {
                HeaderText = "考核年度",
                Name = "AssessmentYear",
                DataPropertyName = "AssessmentYear",
                ReadOnly = true,
            });
            dgvUserAppraisal.Columns.Add(new DataGridViewTextBoxColumn {
                HeaderText = "实发年终奖",
                Name = "YearBonus",
                DataPropertyName = "YearBonus",
                ReadOnly = true,
            });
        }

        private void dgvUserAppraisal_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                if (e.RowIndex > -1) {
                    dgvUserAppraisal.Rows[e.RowIndex].Selected = true;
                    tsmEdit.Visible = true;
                }
            }
        }

        private void tsmEdit_Click(object sender, EventArgs e) {
            int id = (int)dgvUserAppraisal.SelectedRows[0].Cells["Id"].Value;
            FrmSetUserAppraisal frmSetUserAppraisal = new(_delBindDgv,id);
            frmSetUserAppraisal.ShowDialog();
        }
    }
}
