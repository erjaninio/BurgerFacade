using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerFacade
{
    class Cook
    {
        public void CreateBurger(BurgerFacadeBody facade)
        {
            facade.Start();
            facade.Stop();
        }
}
}
