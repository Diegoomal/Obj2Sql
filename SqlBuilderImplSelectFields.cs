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

        public T Fields(string[] campos) {
            if(campos == null) {
                sql.SqlString = "erro";
            } else if(campos.Length == 0) {
                sql.SqlString = "erro";
            } else {
                sql.SqlString = string.Empty;
                string[] camposTabela = this.sql.Tabela.GetOnlyProperties();
                string[] diffCampos = campos.Intersect(camposTabela).ToArray();
                sql.SqlString = $"select { string.Join(", ", diffCampos) } from { this.sql.Tabela.Nome.ToLower() };";
            }
            return (T)this;
        }

    }
}
