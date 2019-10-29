using System;

namespace Obj2Sql {
    class Program {
        static void Main(string[] args) {
            
            Sql sqlSelect = SqlBuilderInstanceSelect.SqlSelect.Create().Build();
            System.Console.WriteLine(sqlSelect);

            Sql sqlSelectWhere = SqlBuilderInstanceSelect.SqlSelect.Create().Where().Build();
            System.Console.WriteLine(sqlSelectWhere);

            Sql sqlInsert = SqlBuilderInstanceInsert.SqlInsert.Create().Build();
            System.Console.WriteLine(sqlInsert);

            Sql sqlInsertReturning = SqlBuilderInstanceInsert.SqlInsert.Create().Returning().Build();
            System.Console.WriteLine(sqlInsertReturning);

        }
    }
}
