using System;
using System.Collections.Generic;
using System.Text;

namespace Obj2Sql {    
    public class SqlBuilderImplSelecWhere<T>: 
        SqlBuilderImplCreateSelect<SqlBuilderImplSelecWhere<T>> where T: 
        SqlBuilderImplSelecWhere<T> {
        public T Where(){
            sql.Desc += "Where";
            return (T)this;
        }
    }
}
