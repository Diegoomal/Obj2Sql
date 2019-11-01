using System;
using System.Collections.Generic;
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

        public object Clone() {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Nome: {this.Nome}";
        }
    }

    public class Sql {
        public string Desc { get; set; }
        public Tabela Tabela { get; set; }

        public override string ToString() {
            return this.Desc;
        }
    }
}
