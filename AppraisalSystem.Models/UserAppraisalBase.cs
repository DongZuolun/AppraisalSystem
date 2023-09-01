using Appraisal_System.Utility;
using System.Data;
using System.Data.SqlClient;

namespace Appraisal_System.Models {
        public class UserAppraisalBase {
                public int Id { get; set; }
                public string? UserName { get; set; }
                public string? Sex { get; set; }
                public int BaseTypeId { get; set; }
                public string? BaseType { get; set; }
                public int AppraisalBase { get; set; }
                public bool IsDel { get; set; }
                public static DataTable GetDtJoinAppraisal() {
                        DataTable dt = SqlHelper.ExecuteTable("SELECT u.Id,u.UserName,u.Sex,u.BaseTypeId,u.IsDel,a.AppraisalBase,a.BaseType FROM Users u LEFT JOIN AppraisalBases a ON u.BaseTypeId=a.Id;");
                        return dt;
                }
                public static List<UserAppraisalBase> GetListJoinAppraisal() {
                        List<UserAppraisalBase> userAppraisalBases = new();
                        DataTable dt = GetDtJoinAppraisal();
                        foreach (DataRow dr in dt.Rows) {
                                userAppraisalBases.Add(dr.DataRowToModel<UserAppraisalBase>());
                        }
                        return userAppraisalBases;
                }
        }
}
