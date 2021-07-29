using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzacım
{
    public class Order : IOrder
    {

        public Order()
        {

        }

        public Order(Size size, PizzaThickness thickness, Pizza pizza, Material[] Materials, int piece, decimal price, decimal orderPrice)
        {
            Size = size;
            Thickness = thickness;
            Pizza = pizza;
            CheckMaterials = Materials;
            Piece = piece;
            Price = price;
            OrderPrice = orderPrice;
        }

        

        public Size Size { get; set; }
        public PizzaThickness Thickness { get; set; }
        public Pizza Pizza { get; set; }
        public Material[] CheckMaterials { get; set; }
        public string materials { get; set; }
        private int _piece;
        public int Piece
        {
            get { return _piece; }
            set
            {
                if (value > 0)
                {
                    _piece = value;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Lütfen geçerli bir değer giriniz");
                    
                }
            }
        }
        public decimal Price { get; set; }
        public decimal OrderPrice { get; set; }
        public decimal TotalPrice { get; set; }

        public override string ToString()
        {
            for (int i = 0; i < CheckMaterials.Length; i++)
            {
                materials += "," + CheckMaterials.ElementAt(i).MaterialName;
            }
            
                return Size + "," + Pizza + "," + Thickness.Thickness + materials + ":" + Piece + " x " + Price + " = " + OrderPrice;
      
        }
        public virtual void Approved()
        {
            System.Windows.Forms.MessageBox.Show("Sipariş onaylandı..");
        }
        public decimal Discount(int orderPrice)
        {
            return orderPrice*0.95m;

        }
        public decimal Discount(int orderPrice, int discountOrderPrice)
        {
            return orderPrice * 0.75m;
        }




    }
}
