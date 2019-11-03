using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj2Sql {    
    public class SqlBuilderImplInsertFields<T>: 
        SqlBuilderImplInsertCreate<SqlBuilderImplInsertFields<T>> where T: 
        SqlBuilderImplInsertFields<T> {

        public T Fields(){
            return (T)this;
        }

        public T Fields(string[] fields){
            
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
