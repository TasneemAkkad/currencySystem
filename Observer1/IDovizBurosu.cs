using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer1
{
    //Observer
    interface IDovizBurosu
    {
        //güncellemesi metodu
        // Herhangi bir değişimde observer tarafından yapılması istenilen aksiyonlar.
        void Update(Doviz doviz);
    }
}
