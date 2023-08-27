using System.Reflection;

namespace Appraisal_System.Common {
    public class FrmFactory<T> {
        private static List<Form> forms = new();
        private static List<Type> types = new();
        static FrmFactory() {
            Assembly assembly = Assembly.LoadFrom("Appraisal_System");
            types = assembly.GetTypes().ToList();
        }
        public static Form CreatForm(string formName) {
            HideFormAll();
            Form form = forms.Find(m => m.Name == formName);
            if (form == null) {
                Type type = types.Find(m => m.Name == formName);
                form = (Form)Activator.CreateInstance(type);
                forms.Add(form);
            }
            return form;
        }
        public static void HideFormAll() {
            foreach (var form in forms) {
                form.Hide();
            }
        }
    }
}
