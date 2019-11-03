using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj2Sql {
    public class SqlBuilderImplDeleteCreate<T>: 
        SqlBuilder where T: 
        SqlBuilderImplDeleteCreate<T> {

        public T CreateByObject(object o) {
            sql.SetTable(o);
            sql.SqlString = $"delete { sql.Tabela.Nome.ToLower() };";
            return (T)this;
        }

    }
}
