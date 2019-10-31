using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj2Sql {    
    public class SqlBuilderImplSelecFields<T>: 
        SqlBuilderImplSelectCreate<SqlBuilderImplSelecFields<T>> where T: 
        SqlBuilderImplSelecFields<T> {

        public T Fields(){
            return (T)this;
        }

        public T Fields(object o, string[] campos) {

            if(campos == null) {
                sql.Desc = "erro";
            } else if(campos.Length == 0) {
                sql.Desc = "erro";
            } else {
                sql.Desc = string.Empty;
                sql.Desc = CreateSelect(o, campos);
            }

            return (T)this;

        }

        private string CreateSelect(object o, string[] _campos) {
            string[] campos = o.GetType().GetProperties().Select(x => x.Name.ToLower()).ToArray();
            string[] diffCampos = campos.Intersect(_campos).ToArray();
            return string.Format("select {0} from {1};", string.Join(", ", diffCampos), o.GetType().Name.ToLower());
        }


    }
}
