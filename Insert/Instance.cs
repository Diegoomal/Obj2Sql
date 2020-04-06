using System;
using System.Collections.Generic;
using System.Text;

namespace Obj2Sql.Insert {

    public class Instance: ImplReturning<Instance> {
        public static Instance Sql => new Instance();
    }

}
