using System.Data;

namespace Appraisal_System.Utility {
    public static class ToModel {
        /// <summary>
        /// 扩展方法
        /// </summary>
        /// <typeparam name="Tmodel"></typeparam>
        /// <param name="dr"></param>
        /// <returns></returns>
        public static Tmodel DataRowToModel<Tmodel>(this DataRow dr) {
            Type type = typeof(Tmodel);
            Tmodel model = (Tmodel)Activator.CreateInstance(type);
            foreach(var prop in type.GetProperties()) {
                prop.SetValue(model, dr[prop.Name]);
            }
            return model;
        }
    }
}