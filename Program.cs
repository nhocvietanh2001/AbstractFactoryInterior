using System;

namespace AbstractFactory {
    class Program {
        static void Main(string[] args) {
            IStyleFactory factory;

            Random random = new Random();
            int type = random.Next(0, 2);

            if (type == 0) {
                factory = new ModernFactory();
            }
            else {
                factory = new TraditionalFactory();
            }

            List<IStyle> set = factory.CreateSetByStyle();
            foreach (IStyle style in set) {
                Console.WriteLine(style.GetName());
            }
            Console.WriteLine(factory.CreateStyle().GetName());
        }
    }
}