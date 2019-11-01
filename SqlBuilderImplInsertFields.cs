using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj2Sql {    
    public class SqlBuilderImplInsertFields<T>: 
        SqlBuilderImplInsertCreate<SqlBuilderImplInsertFields<T>> where T: 
        SqlBuilderImplInsertFields<T> {

        public T Fields(){
            sql.Desc += "fields";
            return (T)this;
        }

    }
}
