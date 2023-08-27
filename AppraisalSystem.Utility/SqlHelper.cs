using System.Data;
using System.Data.SqlClient;

namespace Appraisal_System.Utility {
    /// <summary>
    /// 数据库操作工具类
    /// </summary>
    public class SqlHelper {
        /// <summary>
        /// 连接字符串
        /// </summary>
        public static string? ConStr { get; set; }
        public static DataTable ExecuteTable(string cmdText) {
            using SqlConnection conn = new(ConStr);
            conn.Open();
            SqlCommand cmd = new(cmdText, conn);    
            SqlDataAdapter sda = new(cmd);          
            DataSet ds = new();                     
            sda.Fill(ds);
            return ds.Tables[0];                    
        }
        /// <summary>
        /// 增、删、改 操作
        /// </summary>
        /// <param name="cmdText">命令</param>
        /// <returns>受影响的行数</returns>
        /// <exception cref="Exception"></exception>
        public static int ExecuteNonQuery(string cmdText,params SqlParameter[] sqlParameters) {
            using SqlConnection conn = new(ConStr);
            conn.Open();
            SqlCommand cmd = new(cmdText, conn);
            cmd.Parameters.AddRange(sqlParameters);
            int rows = cmd.ExecuteNonQuery();
            if (rows <= 0) {
                throw new Exception("数据库操作异常");
            }
            return rows;
        }
    }
}
