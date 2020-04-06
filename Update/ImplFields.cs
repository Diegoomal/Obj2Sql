using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj2Sql.Update {    
    public class ImplFields<T>: 
        Create<ImplFields<T>> where T: 
        ImplFields<T> {

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

                Item[] itens = this.sql.Tabela.Itens.Where(    o => campos.Contains(o.Propriedade.ToLower())   ).ToArray();

                List<string> _campos = new List<string>();
                List<string> _valores = new List<string>();

                for (int i = 0; i < itens.Length; i++) {
    
                    Item item = itens[i];

                    _campos.Add(item.Propriedade.ToLower());
    
                    if (item.Tipagem.Equals(typeof(int).ToString())) {              // int
                        _valores.Add(item.Valor.ToString());
                    }
                    else if (item.Tipagem.Equals(typeof(double).ToString())) {      // double
                        _valores.Add(item.Valor.ToString());
                    }
                    else if (item.Tipagem.Equals(typeof(string).ToString())) {      // string
                        _valores.Add($"'{ item.Valor.ToString() }'");
                    }
                    else if (item.Tipagem.Equals(typeof(DateTime).ToString())) {    // datetime
                        _valores.Add($"'{ item.Valor.ToString() }'");
                    }

                }// for - i

                sql.SqlString = string.Format("insert into {0} ({1}) values ({2});",
                    this.sql.Tabela.Nome, string.Join(", ", _campos), string.Join(", ", _valores));

            }
            return (T)this;
        }

    }
}
