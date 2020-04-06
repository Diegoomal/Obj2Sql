using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj2Sql.Select {
    public class Create<T>: 
        SqlBuilder where T: 
        Create<T> {

        public T CreateByObject(object o) {
            this.sql.SetTable(o);
            string sProps = string.Join(", ", this.sql.Tabela.GetOnlyProperties());
            this.sql.SqlString = $"select { sProps } from { this.sql.Tabela.Nome.ToLower() };";
            return (T)this;
        }

    }
}
