using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj2Sql.Insert {
    public class Create<T>: 
        SqlBuilder where T: 
        Create<T> {

        public T CreateByObject(object o) {

            sql.SetTable(o);

            string[] campos = sql.Tabela.GetOnlyProperties();
            string[] valores = sql.Tabela.GetOnlyValues();
            
            sql.SqlString = string.Format("insert into {0} ({1}) values ({2});", 
                sql.Tabela.Nome.ToLower(),
                string.Join(", ", campos), 
                string.Join(", ", valores));

            return (T)this;

        }

    }
}
