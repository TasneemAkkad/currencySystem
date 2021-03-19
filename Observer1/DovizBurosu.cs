using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer1
{
    //Observer Concrete
    class DovizBurosu : IDovizBurosu
    {
        private string name;
        private double decrease;
        

        public DovizBurosu(string name, double decrease)
        {
            this.name = name;
            this.decrease = decrease;
        }

        //güncelleme metodu 
        //fiyatın artması ve azaltması gösteriyor
        public void Update (Doviz doviz)
        {
            if (decrease < doviz.Price )
            {
                Console.WriteLine("Notify " + name + " of " + doviz.GetType().Name + "'s  Price increase to  " + doviz.Price);
            }
            else if(doviz.Price < decrease)
            {
                Console.WriteLine(" Notify " + name + " of " + doviz.GetType().Name + "'s  Price decrease to  " + doviz.Price);
            }
        }


    }
}
