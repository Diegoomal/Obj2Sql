using System;
using System.Collections.Generic;
using System.Text;

namespace Obj2Sql {
    public class SqlBuilder {

        protected Sql sql;
        
        public SqlBuilder() {
            sql = new Sql();
        }

        public Sql Build() => sql;

    }
}
