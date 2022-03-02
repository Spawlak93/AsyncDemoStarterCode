using AsyncDemoNetFive.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncDemoNetFive
{
    class AsyncUI
    {
        public async Task Run()
        {
            //BurgerMaster Class
            BurgerMaster burgerMaster = new BurgerMaster();

            //Syncronous code run
            Patty patty = burgerMaster.CookPatty();
            Console.WriteLine("Patty Done");
            Fries fries = burgerMaster.FryFries();
            Console.WriteLine("Fries Done");
            Bun bun = burgerMaster.ToastBun();
            Console.WriteLine("Bun Toasted");
            Produce produce = burgerMaster.ChopProduce();
            Console.WriteLine("Produce Chopped");
            Console.ResetColor();

            burgerMaster.AssembleBurger();
            Console.WriteLine("Burger Done");

            Console.ReadLine();
        }
    }
}
