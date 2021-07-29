using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzacım
{
    class CanceledOrder:Order,IOrder
    {
        

        public override void Approved()
        {
            System.Windows.Forms.MessageBox.Show("Sipariş İptal Edildi....");
        }
        public override string ToString()
        {
            throw new NotImplementedException();
        }
        
        


    }
}
