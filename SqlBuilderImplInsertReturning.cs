using System;
using System.Collections.Generic;
using System.Text;

namespace Obj2Sql {    
    public class SqlBuilderImplInsertReturning<T>: 
        SqlBuilderImplInsertFields<SqlBuilderImplInsertReturning<T>> where T: 
        SqlBuilderImplInsertReturning<T> {
        public T Returning(){
            sql.Desc += "Returning ID";
            return (T)this;
        }
    }
}
