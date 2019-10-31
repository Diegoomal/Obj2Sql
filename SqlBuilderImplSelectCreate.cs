using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj2Sql {
    public class SqlBuilderImplSelectCreate<T>: 
        SqlBuilder where T: 
        SqlBuilderImplSelectCreate<T> {


        public T Create(object o) {
            sql.Desc = CreateSelect(o);
            return (T)this;
        }

        private string CreateSelect(object o) {
            string[] campos = o.GetType().GetProperties().Select(x => x.Name.ToLower()).ToArray();
            return string.Format("select {0} from {1};", string.Join(", ", campos), o.GetType().Name.ToLower());
        }


    }
}
