using System;
using System.Collections.Generic;
using System.Text;

namespace Obj2Sql {

    public class SqlBuilderInstanceDelete: SqlBuilderImplDeleteWhere<SqlBuilderInstanceDelete> {
        public static SqlBuilderInstanceDelete Sql => new SqlBuilderInstanceDelete();
    }

}
