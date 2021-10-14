using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Product;

namespace Builder.MakePizza
{
    public class Margarita : PizzaBaker
    {
        public override void AddCeehese()
        {

            this.pizza.Add("сыр");
        }

        public override void AddTomatoes()
        {
            this.pizza.Add("томаты");
        }
        public override void AddOlives()
        {
            this.pizza.Add("оливки");
        }
        public override void AddMeat()
        {
            //this.pizza.Add("мясо");
        }

        public override string Print()
        {
            return pizza.ListAdditive();
        }
    }
}
