using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory {
    abstract class AbstractStyleFactory : IStyleFactory{
        abstract public IStyle CreateStyle();
        abstract public List<IStyle> CreateSetByStyle();
    }
}
