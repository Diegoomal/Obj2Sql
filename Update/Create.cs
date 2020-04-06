using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj2Sql.Update {
    public class Create<T>: 
        SqlBuilder where T: 
        Create<T> {

        public T CreateByObject(object o) {
            this.sql.SetTable(o);
            
            this.sql.SqlString = "update criado";

            Item[] itens = this.sql.Tabela.Itens;

            List<string> camposValores = new List<string>();

            for (int i = 0; i < itens.Length; i++) {
                
                Item item = itens[i];

                string s = string.Empty;

                if (item.Tipagem.Equals(typeof(int).ToString())) {              // int
                    s = $"{ item.Propriedade.ToLower() } = { item.Valor }";
                }
                else if (item.Tipagem.Equals(typeof(double).ToString())) {      // double
                    s = $"{ item.Propriedade.ToLower() } = { item.Valor }";
                }
                else if (item.Tipagem.Equals(typeof(string).ToString())) {      // string
                    s = $"{ item.Propriedade.ToLower() } = '{ item.Valor }'";
                }
                else if (item.Tipagem.Equals(typeof(DateTime).ToString())) {    // datetime
                    s = $"{ item.Propriedade.ToLower() } = '{ item.Valor }'";
                }

                camposValores.Add(s);

            }

            this.sql.SqlString = $"update { this.sql.Tabela.Nome } set { string.Join(", ", camposValores.ToArray()) };";

            return (T)this;
        }

    }
}
