using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj2Sql {    
    public class SqlBuilderImplSelecWhere<T>: 
        SqlBuilderImplSelecFields<SqlBuilderImplSelecWhere<T>> where T: 
        SqlBuilderImplSelecWhere<T> {

        public T Where(string campo) {

            if(string.IsNullOrEmpty(campo)) {
                sql.SqlString = "erro";
                return (T)this;
            }

            if(this.sql.Tabela.Itens.Length == 0) {
                sql.SqlString = "erro";
                return (T)this;
            }

            campo = campo.ToLower();

            Item[] itens = this.sql.Tabela.Itens;

            for (int i = 0; i < itens.Length; i++) {                                // percorre a lista de itens
                if(campo.Equals(itens[i].Propriedade.ToLower())) {                  // existe na lista

                    Item item = itens[i];
                    
                    if (item.Tipagem.Equals(typeof(int).ToString())) {              // int
                        sql.SqlString = sql.SqlString.Replace(";", "");
                        sql.SqlString += $" where { campo } = { itens[i].Valor };";
                    }
                    else if (item.Tipagem.Equals(typeof(double).ToString())) {      // double
                        sql.SqlString = sql.SqlString.Replace(";", "");
                        sql.SqlString += $" where { campo } = { itens[i].Valor };";
                    }
                    else if (item.Tipagem.Equals(typeof(string).ToString())) {      // string
                        sql.SqlString = sql.SqlString.Replace(";", "");
                        sql.SqlString += $" where { campo } = '{ itens[i].Valor }';";
                    }
                    else if (item.Tipagem.Equals(typeof(DateTime).ToString())) {    // datetime
                        sql.SqlString = sql.SqlString.Replace(";", "");
                        sql.SqlString += $" where { campo } = '{ itens[i].Valor }';";
                    }

                    break;
                }
            }

            return (T)this;
        }

    }
}
