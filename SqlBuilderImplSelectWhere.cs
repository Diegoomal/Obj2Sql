using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj2Sql {    
    public class SqlBuilderImplSelecWhere<T>: 
        SqlBuilderImplSelecFields<SqlBuilderImplSelecWhere<T>> where T: 
        SqlBuilderImplSelecWhere<T> {


        public T Where(object o, string campo) {

            sql.Desc = sql.Desc.Replace(";", "");
            sql.Desc += (" where " + CreateWhere(o, "id") + ";");
            return (T)this;

        }

        private string CreateWhere(object o, string _campo) {

            string s = string.Empty;
            System.Reflection.PropertyInfo[] props = o.GetType().GetProperties();
            for (int i = 0; i < props.Length; i++) {
                
                // string propriedade = props[i].Name;
                // string valor = props[i].GetValue(o).ToString();
                // string tipagem = props[i].GetValue(o).GetType().ToString();

                string prop = props[i].Name.ToLower();
                string val = props[i].GetValue(o).ToString();

                if(prop.Equals(_campo.ToLower())){
                    s = prop + " = " + val;
                }
                
            }

            return s;

        }


    }
}
