using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory {
    class ModernFactory : AbstractStyleFactory {
        public override IStyle CreateStyle() {
            Random random = new Random();
            int interior = random.Next(0, 2);
            if (interior == 0) {
                return new ModernDesk();
            }
            else {
                return new ModernChair();
            }
        }
        public override List<IStyle> CreateSetByStyle() {
            List<IStyle> set = new List<IStyle>();
            set.Add(new ModernDesk());
            set.Add(new ModernChair());
            return set;
        }
    }
}
