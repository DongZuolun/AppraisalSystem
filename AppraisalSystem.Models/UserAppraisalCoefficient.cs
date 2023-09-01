using Appraisal_System.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appraisal_System.Models {
        public class UserAppraisalCoefficient {
                public int Id { get; set; }
                public int UserId { get; set; }
                public int CoefficientId { get; set; }
                public string? Count { get; set; }
                public int AssessmentYear { get; set; }
                public string AppraisalType { get; set; }
                public double AppraisalCoefficient { get; set; }
                public int CalculationMethod { get; set; }
                public bool IsDel { get; set; }

                public static List<UserAppraisalCoefficient> ListAll() {
                        List<UserAppraisalCoefficient> userAppraisalCoefficients = new();
                        DataTable dataTable = SqlHelper.ExecuteTable("SELECT ua.*,ac.AppraisalType,ac.AppraisalCoefficient,ac.CalculationMethod FROM UserAppraisals ua LEFT JOIN AppraisalCoefficients ac ON ua.CoefficientId=ac.Id;");
                        foreach (DataRow dr in dataTable.Rows) {
                                userAppraisalCoefficients.Add(dr.DataRowToModel<UserAppraisalCoefficient>());
                        };
                        return userAppraisalCoefficients;
                }
                public static List<UserAppraisalCoefficient> ListByUserIdAndYear(params int[] args) {
                        List<UserAppraisalCoefficient> userAppraisalCoefficients = new();
                        DataTable dt = SqlHelper.ExecuteTable("SELECT ua.*,ac.AppraisalType,ac.AppraisalCoefficient,ac.CalculationMethod FROM UserAppraisals ua LEFT JOIN AppraisalCoefficients ac ON ua.CoefficientId=ac.Id WHERE ua.UserId=@UserId AND ua.AssessmentYear=@AssessmentYear;",
                                new SqlParameter("@UserId", args[0]),
                                new SqlParameter("@AssessmentYear", args[1])
                                );
                        foreach (DataRow dr in dt.Rows) {
                                userAppraisalCoefficients.Add(dr.DataRowToModel<UserAppraisalCoefficient>());
                        }
                        return userAppraisalCoefficients;
                }
                public static int Update(UserAppraisalCoefficient userApp) {
                        return SqlHelper.ExecuteNonQuery("UPDATE UserAppraisals SET UserId=@UserId,CoefficientId=@CoefficientId,Count=@Count,IsDel=@IsDel WHERE Id=@Id",
                            new SqlParameter("@Id", userApp.Id),
                            new SqlParameter("@UserId", userApp.UserId),
                            new SqlParameter("@CoefficientId", userApp.CoefficientId),
                            new SqlParameter("@Count", userApp.Count),
                            new SqlParameter("@AssessmentYear", userApp.AssessmentYear),
                            new SqlParameter("@IsDel", userApp.IsDel));
                }
        }
}
