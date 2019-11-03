using System;
using System.Collections.Generic;
using System.Text;

namespace Obj2Sql {

    // aparece o metodo CREATE, FIELDS e WHERE
    public class SqlBuilderInstanceUpdate: SqlBuilderImplUpdateWhere<SqlBuilderInstanceUpdate> {
        public static SqlBuilderInstanceUpdate Sql => new SqlBuilderInstanceUpdate();
    }

}
