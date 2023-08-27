using Appraisal_System.Utility;
using System.Configuration;

namespace Appraisal_System {
    internal static class Program {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main() {
            SqlHelper.ConStr = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
