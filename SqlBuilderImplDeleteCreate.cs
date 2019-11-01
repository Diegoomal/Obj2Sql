using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj2Sql {
    public class SqlBuilderImplDeleteCreate<T>: 
        SqlBuilder where T: 
        SqlBuilderImplDeleteCreate<T> {


        public T Create(object o) {
            sql.Desc = CreateDelete(o);
            return (T)this;
        }

        private string CreateDelete(object o) {

            List<string> campos = new List<string>();
            List<string> valores = new List<string>();
            System.Reflection.PropertyInfo[] props = o.GetType().GetProperties();

            for (int i = 0; i < props.Length - 1; i++) {
                string sCampo = props[i].Name.ToLower();
                string sValor = props[i].GetValue(o).ToString();
                campos.Add(sCampo);
                valores.Add(sValor);
            }

            return string.Format("delete {0} ({2});", 
                o.GetType().Name.ToLower(),
                string.Join(", ", campos), 
                string.Join(", ", valores));
        }


    }
}
