using Appraisal_System.Utility;
using System.Data;
using System.Data.SqlClient;

namespace Appraisal_System.Models {
    public class Users {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Sex { get; set; }
        public int BaseTypeId { get; set; }
        public bool IsDel { get; set; }

        public static List<Users> ListAll() {
            var users = new List<Users>();
            DataTable dt = SqlHelper.ExecuteTable(
                "SELECT u.Id,u.UserName,u.Password,u.Sex,u.BaseTypeId,u.IsDel FROM Users u");
            foreach (DataRow dr in dt.Rows) {
                users.Add(dr.DataRowToModel<Users>());
            }
            return users;
        }
        public static int Insert(Users user) {
            return SqlHelper.ExecuteNonQuery($"INSERT INTO Users(UserName,Password,Sex,BaseTypeId,IsDel) VALUES (@UserName,@Password,@Sex,@BaseTypeId,@IsDel)",
                new SqlParameter("@UserName", user.UserName),
                new SqlParameter("@Password", user.Password),
                new SqlParameter("@Sex", user.Sex),
                new SqlParameter("@BaseTypeId", user.BaseTypeId),
                new SqlParameter("@IsDel", user.IsDel));
        }
        public static int Update(Users user) {
            return SqlHelper.ExecuteNonQuery("UPDATE Users SET UserName=@UserName,Password=@Password," +
                "Sex=@Sex,BaseTypeId=@BaseTypeId,IsDel=@IsDel WHERE Id=@Id",
                new SqlParameter("@Id", user.Id),
                new SqlParameter("@UserName", user.UserName),
                new SqlParameter("@Password", user.Password),
                new SqlParameter("@Sex", user.Sex),
                new SqlParameter("@BaseTypeId", user.BaseTypeId),
                new SqlParameter("@IsDel", user.IsDel));
        }
                public static int Delete(int userId,string userName) {
                        return SqlHelper.ExecuteNonQuery("DELETE FROM Users  WHERE Id=@Id AND UserName=@UserName",
                            new SqlParameter("@Id", userId),
                            new SqlParameter("@UserName", userName));
                }
        }
}
