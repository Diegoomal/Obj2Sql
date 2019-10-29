using System;
using System.Collections.Generic;
using System.Text;

namespace Obj2Sql {    
    public class SqlBuilderImplInsertReturning<T>: 
        SqlBuilderImplCreateInsert<SqlBuilderImplInsertReturning<T>> where T: 
        SqlBuilderImplInsertReturning<T> {
        public T Returning(){
            sql.Desc += "Returning";
            return (T)this;
        }
    }
}
