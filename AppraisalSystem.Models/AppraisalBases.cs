using Appraisal_System.Utility;
using System.Data;
using System.Data.SqlClient;

namespace Appraisal_System.Models {
    public class AppraisalBases {
        public int Id { get; set; }
        public string? BaseType { get; set; }
        public int AppraisalBase { get; set; }
        public bool IsDel { get; set; }
        public static List<AppraisalBases> ListAll() {
            List<AppraisalBases> appraisalBases = new();
            DataTable dt = SqlHelper.ExecuteTable("SELECT * FROM AppraisalBases");
            foreach (DataRow dr in dt.Rows) {
                appraisalBases.Add(dr.DataRowToModel<AppraisalBases>());
            }
            return appraisalBases;
        }
        public static int Update(AppraisalBases appraisalBase) {
            return SqlHelper.ExecuteNonQuery("UPDATE AppraisalBases SET BaseType=@BaseType,AppraisalBase=@AppraisalBase,IsDel=@IsDel WHERE Id=@Id",
                new SqlParameter("@Id", appraisalBase.Id),
                new SqlParameter("@BaseType", appraisalBase.BaseType),
                new SqlParameter("@AppraisalBase", appraisalBase.AppraisalBase),
                new SqlParameter("@IsDel", appraisalBase.IsDel));
        }
    }
}
