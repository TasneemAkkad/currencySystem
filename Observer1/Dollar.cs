using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer1
{
    //Subject concrete1
    class Dollar : Doviz
    {
        //döviz base olan fiyat aktarıyoruz
        public Dollar(double price) : base(price) { }
    }
}
