using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzacım
{
    public class Size
    {
        public string _size { get; set; }
        public decimal SizeX
        {
            get
            {
                if (this._size == "Küçük")
                {
                    return 1;
                }
                else if (this._size == "Orta")
                {
                    return 1.25M;
                }
                else if (this._size == "Büyük")
                {
                    return 1.75M;
                }
                else
                    return 2;
            }

        }
        public override string ToString()
        {
            return this._size;
        }



    }
}
