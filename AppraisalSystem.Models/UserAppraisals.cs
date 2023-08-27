using Appraisal_System.Utility;
using System.Data;
using System.Data.SqlClient;

namespace Appraisal_System.Models {
    public class UserAppraisals {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CoefficientId { get; set; }
        public double Count { get; set; }
        public int AssessmentYear { get; set; }
        public bool IsDel { get; set; }

        public static List<UserAppraisals> ListAll() {
            List<UserAppraisals> userAppraisals = new List<UserAppraisals>();
            DataTable dt = SqlHelper.ExecuteTable("SELECT * FROM UserAppraisals;");
            foreach (DataRow dr in dt.Rows) {
                userAppraisals.Add(dr.DataRowToModel<UserAppraisals>());
            }
            return userAppraisals;
        }
        public static int Insert(UserAppraisals userAppraisals) {
            return SqlHelper.ExecuteNonQuery("INSERT INTO UserAppraisals (Id,UserId,CoefficientId,Count,AssessmentYear,IsDel) VALUES (@Id,@UserId,@CoefficientId,@Count,@AssessmentYear,@IsDel);",
                new SqlParameter("@Id", userAppraisals.Id),
                new SqlParameter("@UserId", userAppraisals.UserId),
                new SqlParameter("@CoefficientId", userAppraisals.CoefficientId),
                new SqlParameter("@Count", userAppraisals.Count),
                new SqlParameter("@AssessmentYear", userAppraisals.AssessmentYear),
                new SqlParameter("@IsDel", userAppraisals.IsDel));
        }
        public static int Update(UserAppraisals userAppraisals) {
            return SqlHelper.ExecuteNonQuery("UPDATE UserAppraisals SET UserId=@UserId,CoefficientId=@CoefficientId,Count=@Count,AssessmentYear=@AssessmentYear,IsDel=@IsDel WHERE Id=@Id;",
                new SqlParameter("@Id", userAppraisals.Id),
                new SqlParameter("@UserId", userAppraisals.UserId),
                new SqlParameter("@CoefficientId", userAppraisals.CoefficientId),
                new SqlParameter("@Count", userAppraisals.Count),
                new SqlParameter("@AssessmentYear", userAppraisals.AssessmentYear),
                new SqlParameter("@IsDel", userAppraisals.IsDel));
        }
    }
}
