using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj2Sql
{
    public class Item : ICloneable {
        public string Propriedade { get; set; }
        public string Valor { get; set; }
        public string Tipagem { get; set; }

        public object Clone() {
            return this.MemberwiseClone();
        }

        public override string ToString() {
            return $"Type: { this.Tipagem } - Property: { this.Propriedade } - Value: { this.Valor }";
        }
    }

    public class Tabela : ICloneable {

        public string Nome { get; set; }
        
        public Item[] Itens { get; set; }

        public string[] GetOnlyProperties() 
        {
            List<string> lst = new List<string>();

            foreach (var item in this.Itens) {
                lst.Add(item.Propriedade.ToLower());
            }

            return lst.ToArray();
        }

        public string[] GetOnlyValues() {

            List<string> lst = new List<string>();

            foreach (var item in this.Itens) {
                    
                if (item.Tipagem.Equals(typeof(int).ToString())) {              //int
                    lst.Add(item.Valor.ToString());
                }
                else if (item.Tipagem.Equals(typeof(double).ToString())) {      //double
                    lst.Add(item.Valor.ToString());
                }
                else if (item.Tipagem.Equals(typeof(string).ToString())) {      //string
                    lst.Add("'" + item.Valor.ToString() + "'");
                }
                else if (item.Tipagem.Equals(typeof(DateTime).ToString())) {    //datetime
                    lst.Add("'" + item.Valor.ToString() + "'");
                }
                
            }

            return lst.ToArray();

        }

        public object Clone() {
            return this.MemberwiseClone();
        }

        
        public override string ToString()
        {
            return $"Nome: {this.Nome}";
        }
    
    }

    public class Sql {

        public string SqlString { get; set; }
        public Tabela Tabela { get; set; }

        public void SetTable(object o) {
            
            if(this.Tabela == null)
                this.Tabela = new Tabela();

            this.Tabela.Nome = o.GetType().Name;
            this.Tabela.Itens = this.GetAllItens(o);

        }

        private Item[] GetAllItens(object o) {
            List<Item> list = new List<Item>();
            System.Reflection.PropertyInfo[] props = o.GetType().GetProperties();

            for (int i = 0; i < props.Length; i++) {
                Item item = new Item() {
                    Propriedade = props[i].Name,
                    Valor = props[i].GetValue(o).ToString(),
                    Tipagem = props[i].GetValue(o).GetType().ToString()
                };
                list.Add(item);
            }

            return list.ToArray();
        }

        public override string ToString() {
            return this.SqlString;
        }

    }// class
}// namespace