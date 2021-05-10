using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAJSTAR
{
    class Employee
    {
        
        public int quantity;

        public Employee(int quantity)
        {
            this.quantity = quantity;
        }

        public Employee()
        {
        }

        public int NewRequest()
        {
            EggOrder egg = new EggOrder();
            egg.GetQuality();
            egg.GetQuantity();
            egg.Creack();
            return quantity;
        }
        public void CopyRequest()
        {
            NewRequest request = new NewRequest();
            NewRequest copy = request;
            copy.ToString();
            EggOrder egg = new EggOrder();
            egg.GetQuality();
            egg.GetQuantity();
            egg.Creack();
            
        }
        public int Inspect()
        {
            NewRequest request = new NewRequest();

            if(quantity > 1 && quantity < 100)
            {
                request.ToString();
            }
            return quantity;
        }
        public int PrepareFood()
        {
            CkickenOrder order = new CkickenOrder();
            order.GetQuantity();
            order.Cook();
            if (quantity > 1)
            {
                quantity.ToString("Ваш заказ приготовлень");
            }
            else if(quantity<1)
            {
                quantity.ToString("Ошибки на заказ");
            }

            EggOrder egg = new EggOrder();
            egg.GetQuantity();
            egg.DiscrardShell();
            egg.Cook();
            if (quantity < 1)
            {
                quantity.ToString($"Ваш яйца не тухлый {egg.quality}");
            }
            return quantity;


        }
    }
}
