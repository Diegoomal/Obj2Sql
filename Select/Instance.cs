using System;
using System.Collections.Generic;
using System.Text;

namespace Obj2Sql.Select {

    public class Instance: ImplWhere<Instance> {
        public static Instance Sql => new Instance();
    }

}
