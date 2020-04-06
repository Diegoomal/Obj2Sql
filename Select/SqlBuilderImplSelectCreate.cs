using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj2Sql {
    public class SqlBuilderImplSelectCreate<T>: 
        SqlBuilder where T: 
        SqlBuilderImplSelectCreate<T> {

        public T CreateByObject(object o) {
            this.sql.SetTable(o);
            string sProps = string.Join(", ", this.sql.Tabela.GetOnlyProperties());
            this.sql.SqlString = $"select { sProps } from { this.sql.Tabela.Nome.ToLower() };";
            return (T)this;
        }

    }
}
