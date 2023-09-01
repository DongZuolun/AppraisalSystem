using Appraisal_System.Models;
using Appraisal_System.Utility;
using System.Data;

namespace Appraisal_System {
        public partial class FrmUserAppraisal : Form {
                private Action _bindDgv;
                public FrmUserAppraisal() {
                        InitializeComponent();
                }

                private void FrmUserAppraisal_Load(object sender, EventArgs e) {
                        SetCol();
                        SetValue();
                        _bindDgv = SetValue;
                }

                private void SetValue() {
                        //获取需要扩展的表
                        DataTable dtUser = UserAppraisalBase.GetDtJoinAppraisal();
                        //获取系数表集合
                        List<AppraisalCoefficients> appraisalCoefficients = AppraisalCoefficients.ListAll();
                        //通过系数表填充DT
                        foreach (var ac in appraisalCoefficients) {
                                //添加列名
                                dtUser.Columns.Add(new DataColumn {
                                        ColumnName = ac.AppraisalType
                                });
                                //添加系数值
                                dtUser.Columns.Add(new DataColumn {
                                        ColumnName = ac.AppraisalType + ac.AppraisalCoefficient
                                });
                                //添加计算方式
                                dtUser.Columns.Add(new DataColumn {
                                        ColumnName = ac.AppraisalType + ac.CalculationMethod
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
                                var uacFilter = userAppraisalCoefficients.FindAll(x => x.UserId == (int)dtUser.Rows[i]["Id"] && x.AssessmentYear == Convert.ToInt32(cbxYear.Text));
                                //系数计算的数组，用于存放每个考核类型的总系数
                                double[] yearBonusArray = new double[uacFilter.Count];
                                for (int j = 0; j < uacFilter.Count; j++) {
                                        //获取AppraisalType对应的dtUser的ColumnName的值
                                        //获取考核次数
                                        string appraisalTypeCountKey = uacFilter[j].AppraisalType;
                                        string appraisalTypeCountValue = uacFilter[j].Count;
                                        //获取考核系数
                                        string appraisalCoefficientKey = uacFilter[j].AppraisalType + uacFilter[j].AppraisalCoefficient;
                                        double appraisalCoefficientValue = uacFilter[j].AppraisalCoefficient;
                                        //获取计算方式
                                        string calculationMethodKey = uacFilter[j].AppraisalType + uacFilter[j].CalculationMethod;
                                        int calculationMethodValue = uacFilter[j].CalculationMethod;
                                        //给dtUser绑定值
                                        dtUser.Rows[i][appraisalTypeCountKey] = appraisalTypeCountValue;
                                        dtUser.Rows[i][appraisalCoefficientKey] = appraisalCoefficientValue;
                                        dtUser.Rows[i][calculationMethodKey] = calculationMethodValue;
                                        //计算考核系数
                                        //"考核系数"*"次数"*"计算方式"
                                        yearBonusArray[j] = appraisalCoefficientValue * Convert.ToInt32(appraisalTypeCountValue == "" ? "0" : appraisalTypeCountValue) * calculationMethodValue;
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
                        args[0] = (int)cbxUserId.SelectedValue;
                        args[1] = Convert.ToInt32(cbxYear?.Text);
                        if (args[0] == 0) {
                                dgvUserAppraisal.DataSource = dtUser;
                        }
                        else {
                                DataTable table = (DataTable)dgvUserAppraisal.DataSource;
                                table.Rows.Clear();
                                foreach (DataRow row in dtUser.Rows) {
                                        if (args[0] == (int)row["Id"]) {
                                                table.Rows.Add(row.ItemArray);
                                        }
                                }
                                dgvUserAppraisal.DataSource = table;
                        }
                }

                private int[] args = new int[2];

                private void SetCol() {
                        List<Users> users = Users.ListAll();
                        List<Users> usersPlus = new List<Users>();
                        foreach (Users user in users) {
                                Users u = user;
                                u.UserName = $"[{user.Id}]" + user.UserName;
                                usersPlus.Add(u);
                        }
                        usersPlus.Insert(0, new Users {
                                Id = 0,
                                UserName = "—查询所有用户—",
                                Password = "111",
                                Sex = "未知",
                                BaseTypeId = 0,
                                IsDel = false,
                        });
                        cbxUserId.DataSource = usersPlus;
                        cbxUserId.DisplayMember = "UserName";
                        cbxUserId.ValueMember = "Id";
                        List<AppraisalCoefficients> appraisalCoefficients = AppraisalCoefficients.ListAll();
                        List<DataGridViewTextBoxColumn> dataGridViewTextBoxColumns = new();
                        foreach (var ac in appraisalCoefficients) {
                                dataGridViewTextBoxColumns.Add(new DataGridViewTextBoxColumn {
                                        HeaderText = ac.AppraisalType,
                                        Name = ac.AppraisalType,
                                        DataPropertyName = ac.AppraisalType,
                                        ReadOnly = true,
                                });
                                dataGridViewTextBoxColumns.Add(new DataGridViewTextBoxColumn {
                                        HeaderText = ac.AppraisalType + "系数",
                                        Name = ac.AppraisalType + ac.AppraisalCoefficient,
                                        DataPropertyName = ac.AppraisalType + ac.AppraisalCoefficient,
                                        ReadOnly = true,
                                        Visible = false,
                                });
                                dataGridViewTextBoxColumns.Add(new DataGridViewTextBoxColumn {
                                        HeaderText = ac.AppraisalType + "计算方式",
                                        Name = ac.AppraisalType + ac.CalculationMethod,
                                        DataPropertyName = ac.AppraisalType + ac.CalculationMethod,
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
                        int year = Convert.ToInt32(cbxYear.Text);
                        FrmUserAppraisalEdit frmSetUserAppraisal = new(id, year, _bindDgv);
                        frmSetUserAppraisal.ShowDialog();
                }

                private void btnQuery_Click(object sender, EventArgs e) {
                        _bindDgv();
                }
        }
}
