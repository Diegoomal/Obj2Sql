using System;
using System.Collections.Generic;
using System.Text;

namespace Obj2Sql {

    // aparece o metodo CREATE, FIELDS e RETURNING
    public class SqlBuilderInstanceInsert: SqlBuilderImplInsertReturning<SqlBuilderInstanceInsert> {
        public static SqlBuilderInstanceInsert SqlInsert => new SqlBuilderInstanceInsert();
    }

}
