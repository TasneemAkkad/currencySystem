using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer1
{
    class Program
    {
        static void Main(string[] args)
        {
            //eski fiyatı
            Dollar dollar = new Dollar(6.8);
            dollar.Attach(new DovizBurosu("Döviz Burosu İzmir", 6.8));
            dollar.Attach(new DovizBurosu("Döviz Burosu İstanbul",6.8));
            dollar.Attach(new DovizBurosu("Döviz Burosu Ankara",6.8));
            //fiyatların güncellenmiş hali
            dollar.Price = 6.2;
            dollar.Price = 6.5;
            dollar.Price = 6.9;
            dollar.Price = 7.1;
            //eski fiyat
            Euro euro = new Euro(7.4);
            euro.Attach(new DovizBurosu("Döviz Burosu İzmir", 7.4));
            euro.Attach(new DovizBurosu("Döviz Burosu İstanbul", 7.4));
            euro.Attach(new DovizBurosu("Döviz Burosu Ankara", 7.4));

            euro.Price = 7.2;
            euro.Price = 7.3;
            euro.Price = 7.9;
            euro.Price = 7.7;

            Console.ReadLine();
        }
    }
}
