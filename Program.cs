using System;
using System.Linq;

namespace Obj2Sql {

    public class IEntidade {
        public int Id { get; set; }
    }
    
    public class Pessoa : IEntidade {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public override string ToString()
        {
            // if(Obj == null) return "NullReferenceException";

            // StringBuilder sb = new StringBuilder();
            // System.Reflection.PropertyInfo[] props = Obj.GetType().GetProperties();

            // for (int i = 0; i < props.Length - 1; i++) {
            //     sb.Append(props[i].Name).Append(": ");
            //     sb.Append(props[i].GetValue(Obj)).Append(": ");
            //     sb.Append(props[i].GetValue(Obj).GetType()).Append(": ");
            //     sb.Append("\n");
            // }

            // return sb.ToString();

            return $"{ this.Nome } { this.Sobrenome }";
        }
    }

    class Program {

        static void Main(string[] args) {

            Pessoa p = new Pessoa() { Id = 1, Nome = "Diego", Sobrenome = "Maldonado" };

            string[] campos = new string[] { "id", "nome" };

            Select(p, campos);

            Insert(p, campos);

            Update(p, campos);

            Delete(p, campos);

        }

        private static void Select(Pessoa p, string[] campos) {

            System.Console.WriteLine(   Obj2Sql.Select.Instance.Sql.CreateByObject(p).Build()   );

            System.Console.WriteLine(   Obj2Sql.Select.Instance.Sql.CreateByObject(p).Fields(campos).Build()    );

            System.Console.WriteLine(   Obj2Sql.Select.Instance.Sql.CreateByObject(p).Fields().Where("id").Build()  );

            System.Console.WriteLine(   Obj2Sql.Select.Instance.Sql.CreateByObject(p).Fields().Where("nome").Build()    );

            System.Console.WriteLine(   Obj2Sql.Select.Instance.Sql.CreateByObject(p).Fields(campos).Where("id").Build()    );

        }

        private static void Insert(Pessoa p, string[] campos) {

            System.Console.WriteLine(   Obj2Sql.Insert.Instance.Sql.CreateByObject(p).Build()   );

            System.Console.WriteLine(   Obj2Sql.Insert.Instance.Sql.CreateByObject(p).Fields(campos).Build()    );

            System.Console.WriteLine(   Obj2Sql.Insert.Instance.Sql.CreateByObject(p).Fields().Returning("id").Build()  );

            System.Console.WriteLine(   Obj2Sql.Insert.Instance.Sql.CreateByObject(p).Fields(campos).Returning("id").Build()    );

        }

        private static void Update(Pessoa p, string[] campos) {

            System.Console.WriteLine(   Obj2Sql.Update.Instance.Sql.CreateByObject(p).Build()   );

            System.Console.WriteLine(   Obj2Sql.Update.Instance.Sql.CreateByObject(p).Fields(campos).Build()    );

            System.Console.WriteLine(   Obj2Sql.Update.Instance.Sql.CreateByObject(p).Fields().Where("id").Build()  );

            System.Console.WriteLine(   Obj2Sql.Update.Instance.Sql.CreateByObject(p).Fields(campos).Where("id").Build()    );

        }

        private static void Delete(Pessoa p, string[] campos) {
            
            System.Console.WriteLine(   Obj2Sql.Delete.Instance.Sql.CreateByObject(p).Build()   );

            System.Console.WriteLine(   Obj2Sql.Delete.Instance.Sql.CreateByObject(p).Where("id").Build()  );

        }

    }// class
}// namespace
