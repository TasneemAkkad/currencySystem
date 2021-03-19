using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer1
{
    //Subject concrete2
    class Euro : Doviz
    {
        //döviz base olan fiyat aktarıyoruz
        public Euro(double price) : base(price) { }
    }
}
