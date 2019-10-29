using System;
using System.Collections.Generic;
using System.Text;

namespace Obj2Sql {
    public class SqlBuilderImplCreateInsert<T>: 
        SqlBuilder where T: 
        SqlBuilderImplCreateInsert<T> {    
        public T Create(){
            sql.Desc = "ImplCreateInsert";
            return (T)this;
        }
    }
}
