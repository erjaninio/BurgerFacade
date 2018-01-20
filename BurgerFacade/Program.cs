using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            Sauce sauce = new Sauce();
            Veggies veggies = new Veggies();
            Cutlet cutlet = new Cutlet();
            Bun bun = new Bun();
            Burger burger = new Burger();
            BurgerFacadeBody bfp = new BurgerFacadeBody(sauce, veggies, cutlet, bun, burger);
            Cook cook = new Cook();
            cook.CreateBurger(bfp);
            
            Console.Read();
        }
    }
}
