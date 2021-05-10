using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAJSTAR
{
    public class EggOrder
    {
        public int quantity;
        public int quality;
        public int GetQuantity()
        {
            if(quantity>1 && quantity < 100)
            {
                quantity.ToString();
            }
            return quantity;
        }
        public int GetQuality()
        {
            Random rnd = new Random();
            quality = rnd.Next(101);
            if (quality > 25)
            {
                quality.ToString();
            }
            else
            {
                rnd.ToString();
            }
            return quality;
            
        }
        public int Creack()
        {
            if (quality < 25)
            {
                quality.ToString();
            }
            return quality;
        }
        public void DiscrardShell()
        {

        }

        public void Cook()
        {

        }

        
    }
    

}
