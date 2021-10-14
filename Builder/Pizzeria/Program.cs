using System;
using Builder.MakePizza;
using Builder.Product;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            PizzaBaker typeOfPizza = new Margarita();
      
            Console.WriteLine("Меню пиццерии");
            Console.WriteLine("1)Маргарита ");
            Console.WriteLine("2)Карбонара");
            Console.WriteLine("3)Итальянская "); 
            Console.WriteLine("4)Пеперони ");
            Console.Write("Выберите пиццу из предложенных: ");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    typeOfPizza = new Margarita();
                    break;

                case 2:
                    typeOfPizza = new Carbonara();
                    break;

                case 3:
                    typeOfPizza = new Italian();
                    break;
                case 4:
                    typeOfPizza = new Pepperoni();
                    break;
                default:
                        Console.WriteLine("Вы не выбрали пиццу из меню");
                break;
            }
            Console.WriteLine("хотите добавить сыр? (+ или -)");
            a = Console.ReadLine();
            if (a == "+")
            {
                typeOfPizza.AddCeehese();
            }

            Console.WriteLine("хотите добавить томаты? (+ или -)");
            a = Console.ReadLine();
            if (a == "+")
            {
                typeOfPizza.AddTomatoes();
            }

            Console.WriteLine("хотите добавить оливки? (+ или -) ");
            a = Console.ReadLine();
            if (a == "+")
            {
                typeOfPizza.AddOlives();
            }

            Console.WriteLine("хотите добавить мясо? (+ или -) ");
            a = Console.ReadLine();
            if (a == "+")
            {
                typeOfPizza.AddMeat();
            }
            Console.WriteLine("Маргарита" + typeOfPizza.Print());
        }
    }
}
