using System;
using System.Collections.Generic;
using System.Text;

namespace Obj2Sql {

    public class SqlBuilderInstanceDelete: SqlBuilderImplDeleteCreate<SqlBuilderInstanceDelete> {
        public static SqlBuilderInstanceDelete Sql => new SqlBuilderInstanceDelete();
    }

}
