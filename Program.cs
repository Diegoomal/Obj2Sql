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

            // Select(p, campos);

            Insert(p, campos);

            // Delete(p, campos);

        }

        private static void Select(Pessoa p, string[] campos) {

            System.Console.WriteLine("---");
            System.Console.WriteLine("Select.Create(objeto).Build()");
            Sql sql1 = SqlBuilderInstanceSelect.Sql.CreateByObject(p).Build();
            System.Console.WriteLine(sql1);

            System.Console.WriteLine("---");
            System.Console.WriteLine("Select.Create(objeto).Fields().Build()");
            Sql sql2 = SqlBuilderInstanceSelect.Sql.CreateByObject(p).Fields().Build();
            System.Console.WriteLine(sql2);

            System.Console.WriteLine("---");
            System.Console.WriteLine("Select.Create(objeto).Fields(string[]).Build()");
            Sql sql3 = SqlBuilderInstanceSelect.Sql.CreateByObject(p).Fields(campos).Build();
            System.Console.WriteLine(sql3);

            System.Console.WriteLine("---");
            System.Console.WriteLine("Select.Create(objeto).Fields().Where(string).Build()");
            Sql sql4 = SqlBuilderInstanceSelect.Sql.CreateByObject(p).Fields().Where("id").Build();
            System.Console.WriteLine(sql4);


            System.Console.WriteLine("---");
            System.Console.WriteLine("Select.Create(objeto).Fields(objeto, string[]).Where(string).Build()");
            Sql sql5 = SqlBuilderInstanceSelect.Sql.CreateByObject(p).Fields(campos).Where("id").Build();
            System.Console.WriteLine(sql5);

            System.Console.WriteLine("---");
            System.Console.WriteLine("Select.Create(objeto).Fields(objeto, string[]).Where(string).Build()");
            Sql sql6 = SqlBuilderInstanceSelect.Sql.CreateByObject(p).Fields(campos).Where("nome").Build();
            System.Console.WriteLine(sql6);

        }

        private static void Insert(Pessoa p, string[] campos) {

            System.Console.WriteLine("---");
            System.Console.WriteLine("Insert.CreateByObject(objeto).Build()");
            Sql sql1 = SqlBuilderInstanceInsert.Sql.CreateByObject(p).Build();
            System.Console.WriteLine(sql1);

            System.Console.WriteLine("---");
            System.Console.WriteLine("Insert.CreateByObject(objeto).Fields().Build()");
            Sql sql2 = SqlBuilderInstanceInsert.Sql.CreateByObject(p).Fields().Build();
            System.Console.WriteLine(sql2);

            System.Console.WriteLine("---");
            System.Console.WriteLine("Insert.CreateByObject(objeto).Fields().Returning().Build()");
            Sql sql3 = SqlBuilderInstanceInsert.Sql.CreateByObject(p).Fields().Returning().Build();
            System.Console.WriteLine(sql3);

        }

        private static void Delete(Pessoa p, string[] campos) {

            // Sql sql1 = SqlBuilderInstanceDelete.SqlDelete.Create(p).Build();
            // System.Console.WriteLine(sql1);

        }

        private static void Update(Pessoa p, string[] campos) {

        }

    }// class
}// namespace
