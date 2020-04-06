using System;
using System.Collections.Generic;
using System.Text;

namespace Obj2Sql {

    // aparece somente apenas o metodo CREATE
    // public class SqlBuilderInstance: SqlBuilderImplCreateSelect<SqlBuilderInstance> {    
    //     public static SqlBuilderInstance NewSql => new SqlBuilderInstance();
    // }

    // aparece o metodo CREATE, FIELDS e WHERE
    public class SqlBuilderInstanceSelect: SqlBuilderImplSelecWhere<SqlBuilderInstanceSelect> {
        public static SqlBuilderInstanceSelect Sql => new SqlBuilderInstanceSelect();
    }

}
