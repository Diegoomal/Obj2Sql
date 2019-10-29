using System;
using System.Collections.Generic;
using System.Text;

namespace Obj2Sql {
    public class SqlBuilderImplCreateSelect<T>: 
        SqlBuilder where T: 
        SqlBuilderImplCreateSelect<T> {    
        public T Create(){
            sql.Desc = "ImplCreateSelect";
            return (T)this;
        }
    }
}
