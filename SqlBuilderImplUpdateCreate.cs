using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj2Sql {
    public class SqlBuilderImplUpdateCreate<T>: 
        SqlBuilder where T: 
        SqlBuilderImplUpdateCreate<T> {

        public T CreateByObject(object o) {
            this.sql.SetTable(o);
            // string sProps = string.Join(", ", this.sql.Tabela.GetOnlyProperties());
            // this.sql.SqlString = $"select { sProps } from { this.sql.Tabela.Nome.ToLower() };";
            this.sql.SqlString = "update criado";
            return (T)this;
        }

    }
}
