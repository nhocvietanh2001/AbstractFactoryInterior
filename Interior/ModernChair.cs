using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory {
    class ModernChair : Modern {
        public override string GetName() {
            return "modern chair";
        }
    }
}
