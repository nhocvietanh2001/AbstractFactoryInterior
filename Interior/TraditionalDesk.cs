using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory {
    class TraditionalDesk : Traditional {
        public override string GetName() {
            return "Traditional Desk";
        }
    }
}
