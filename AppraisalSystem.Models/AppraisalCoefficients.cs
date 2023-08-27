using Appraisal_System.Utility;
using System.Data;
using System.Data.SqlClient;

namespace Appraisal_System.Models {
    public class AppraisalCoefficients {
        public int Id { get; set; }
        public string AppraisalType { get; set; }
        public double AppraisalCoefficient { get; set; }
        public int CalculationMethod { get; set; }
        public bool IsDel { get; set; }
        public static List<AppraisalCoefficients> ListAll() {
            List<AppraisalCoefficients> appraisalCoefficients = new();
            DataTable dt = SqlHelper.ExecuteTable("SELECT * FROM AppraisalCoefficients");
            foreach (DataRow dr in dt.Rows) {
                appraisalCoefficients.Add(dr.DataRowToModel<AppraisalCoefficients>());
            }
            return appraisalCoefficients;
        }
        public static int Update(AppraisalCoefficients coefficient) {
            return SqlHelper.ExecuteNonQuery("UPDATE AppraisalCoefficients SET AppraisalType=@AppraisalType,AppraisalCoefficient=@AppraisalCoefficient,CalculationMethod=@CalculationMethod,IsDel=@IsDel WHERE Id=@Id",
                new SqlParameter("@Id", coefficient.Id),
                new SqlParameter("@AppraisalType", coefficient.AppraisalType),
                new SqlParameter("@AppraisalCoefficient", coefficient.AppraisalCoefficient),
                new SqlParameter("@CalculationMethod", coefficient.CalculationMethod),
                new SqlParameter("@IsDel", coefficient.IsDel));
        }
    }
}
