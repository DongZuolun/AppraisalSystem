using System.Reflection;

namespace Appraisal_System.Common {
        public class FrmFactory<T> {
                private static List<Type> types = new();
                static FrmFactory() {
                        Assembly assembly = Assembly.LoadFrom("Appraisal_System");
                        types = assembly.GetTypes().ToList();
                }
                public static Form CreatForm(string formName) {
                        Type type = types.Find(m => m.Name == formName);
                        Form form = (Form)Activator.CreateInstance(type);
                        return form;
                }
        }
}
