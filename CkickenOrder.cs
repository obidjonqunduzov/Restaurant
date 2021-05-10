using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAJSTAR
{
    class CkickenOrder
    {
        public int quantity;

        public int GetQuantity()
        {
            if (quantity < 100)
            {
                quantity.ToString();
            }
            else if (quantity > 1)
            {
                quantity.ToString();
            }
            return quantity;
        }
        public void GutUp()
        {
            if (quantity > 0 && quantity < 100)
            {
                quantity.ToString();
            }
        }
        public void Cook()
        {

        }

    }

}
