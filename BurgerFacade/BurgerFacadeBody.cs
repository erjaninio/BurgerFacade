using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerFacade
{
    class BurgerFacadeBody
    {
        Sauce sauce;
        Veggies veggies;
        Cutlet cutlet;
        Bun bun;
        Burger burger;
      
        public BurgerFacadeBody(Sauce sa, Veggies ve, Cutlet cu, Bun bun, Burger bur)
        {
            this.sauce = sa;
            this.veggies = ve;
            this.cutlet = cu;
            this.bun = bun;
            this.burger = bur;
        }
        public void Start()
        {
            veggies.ChopCucumber();
            veggies.ChopOnion();
            veggies.ChopTomato();
            sauce.AddSauce();
            cutlet.Barbecue();
            bun.Slit();
            bun.Fry();
        }
        public void Stop()
        {
            burger.SqueezeBun();
        }
    }
}
