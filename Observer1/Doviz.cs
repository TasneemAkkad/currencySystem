using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer1
{
    //Subject
    //takip edilecek olan nesne
    abstract class Doviz
    {
        private double price;
        private List<IDovizBurosu> dovizBurosuslar = new List<IDovizBurosu>();
        public Doviz (double price)
        {
            this.price = price;
        }

        //yeni office eklemek için
        public void Attach(IDovizBurosu dovizBurosu)
        {
            dovizBurosuslar.Add(dovizBurosu);
        }
        //bir office silmek için
        public void Detach(IDovizBurosu dovizBurosu)
        {
            dovizBurosuslar.Remove(dovizBurosu);
        }

        //yeni olan değişiliklerin haber vermek için
        // Herhangi bir değişiklik olduğunda observers Update metotunu tetikleterek istenilen aksiyonu gerçekleştirebiliriz.
        public void Notify()
        {
            foreach (IDovizBurosu burosu in dovizBurosuslar)
            {
                burosu.Update(this);
            }

            Console.WriteLine("");
        }

        //fiyatı döndürüyor
        public double Price
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    price = value;
                    Notify(); //Automatically notify our observers of price changes
                }
            }
        }
    }
}
