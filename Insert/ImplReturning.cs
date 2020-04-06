using System;
using System.Collections.Generic;
using System.Text;

namespace Obj2Sql.Insert {    
    public class ImplReturning<T>: 
        ImplFields<ImplReturning<T>> where T: 
        ImplReturning<T> {

        public T Returning() {            
            sql.SqlString = sql.SqlString.Replace(";", "");
            sql.SqlString += " returning id;";
            return (T)this;            
        }

        public T Returning(string campo) {            
            if(string.IsNullOrEmpty(campo)) {
                sql.SqlString = "erro - IsNullOrEmpty - insert - returning";
            }
            sql.SqlString = sql.SqlString.Replace(";", "");
            sql.SqlString += " returning " + campo.ToLower();
            return (T)this;
        }
        
    }
}
