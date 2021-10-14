using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Product;

namespace Builder.MakePizza
{
    public abstract class PizzaBaker
    {
        public Pizza pizza { get; set; } = new Pizza();
        public abstract void AddCeehese();

        public abstract void AddTomatoes();

        public abstract void AddOlives();

        public abstract void AddMeat();

        public abstract string Print();
    }
}
