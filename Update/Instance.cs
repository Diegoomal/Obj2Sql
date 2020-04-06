using System;
using System.Collections.Generic;
using System.Text;

namespace Obj2Sql.Update {

    // aparece o metodo CREATE, FIELDS e WHERE
    public class Instance: ImplWhere<Instance> {
        public static Instance Sql => new Instance();
    }

}
