using System;
using System.Collections.Generic;
using System.Text;

namespace Obj2Sql
{
    public class Sql {
        public string Desc { get; set; }

        public override string ToString() {
            return this.Desc;
        }
    }
}
