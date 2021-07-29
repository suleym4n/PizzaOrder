using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzacım
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        Pizza[] Pizzas = new Pizza[0];
        Size[] Sizes = new Size[0];
        PizzaThickness[] Thicknesses = new PizzaThickness[0];
        Material[] Materials = new Material[0];
        Order[] Orders = new Order[0];
        Material[] CheckMaterials = new Material[0];
        public Order ord;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            #region AddPizza
            Pizza p1 = new Pizza("KLASİK", 14);
            Array.Resize(ref Pizzas, Pizzas.Length + 1);
            Pizzas[Pizzas.Length - 1] = p1;
            Pizza p2 = new Pizza("KARIŞIK", 17);
            Array.Resize(ref Pizzas, Pizzas.Length + 1);
            Pizzas[Pizzas.Length - 1] = p2;
            Pizza p3 = new Pizza("EXTRAVAGANZA", 21);
            Array.Resize(ref Pizzas, Pizzas.Length + 1);
            Pizzas[Pizzas.Length - 1] = p3;
            Pizza p4 = new Pizza("ITALIANO", 20);
            Array.Resize(ref Pizzas, Pizzas.Length + 1);
            Pizzas[Pizzas.Length - 1] = p4;
            Pizza p5 = new Pizza("TURKISH", 23);
            Array.Resize(ref Pizzas, Pizzas.Length + 1);
            Pizzas[Pizzas.Length - 1] = p5;
            Pizza p6 = new Pizza("TUNA", 18);
            Array.Resize(ref Pizzas, Pizzas.Length + 1);
            Pizzas[Pizzas.Length - 1] = p6;
            Pizza p7 = new Pizza("SEAFEED", 19);
            Array.Resize(ref Pizzas, Pizzas.Length + 1);
            Pizzas[Pizzas.Length - 1] = p7;
            Pizza p8 = new Pizza("KASTAMONU", 20);
            Array.Resize(ref Pizzas, Pizzas.Length + 1);
            Pizzas[Pizzas.Length - 1] = p8;
            Pizza p9 = new Pizza("CALYPSO", 24);
            Array.Resize(ref Pizzas, Pizzas.Length + 1);
            Pizzas[Pizzas.Length - 1] = p9;
            Pizza p10 = new Pizza("AKDENİZ", 21);
            Array.Resize(ref Pizzas, Pizzas.Length + 1);
            Pizzas[Pizzas.Length - 1] = p10;
            Pizza p11 = new Pizza("KARADENİZ", 20);
            Array.Resize(ref Pizzas, Pizzas.Length + 1);
            Pizzas[Pizzas.Length - 1] = p11;


            foreach (var item in Pizzas)
            {
                lstPizza.Items.Add(item);
            }
            #endregion
            #region AddSize


            Size s1 = new Size();
            s1._size = "Küçük";
            Array.Resize(ref Sizes, Sizes.Length + 1);
            Sizes[Sizes.Length - 1] = s1;


            Size s2 = new Size();
            s2._size = "Orta";
            Array.Resize(ref Sizes, Sizes.Length + 1);
            Sizes[Sizes.Length - 1] = s2;

            Size s3 = new Size();
            s3._size = "Büyük";
            Array.Resize(ref Sizes, Sizes.Length + 1);
            Sizes[Sizes.Length - 1] = s3;


            Size s4 = new Size();
            s4._size = "Maxi";
            Array.Resize(ref Sizes, Sizes.Length + 1);
            Sizes[Sizes.Length - 1] = s4;

            foreach (var item in Sizes)
            {
                cmbEbat.Items.Add(item);
            }
            #endregion
            #region AddThick

            PizzaThickness t1 = new PizzaThickness();
            t1.Thickness = "Kalın Kenar";
            t1.priceDif = 2;
            Array.Resize(ref Thicknesses, Thicknesses.Length + 1);
            Thicknesses[Thicknesses.Length - 1] = t1;


            PizzaThickness t2 = new PizzaThickness();
            t2.Thickness = "İnce Kenar";
            t2.priceDif = 0;
            Array.Resize(ref Thicknesses, Thicknesses.Length + 1);
            Thicknesses[Thicknesses.Length - 1] = t2;


            foreach (var item in Thicknesses)
            {
                foreach (var cont in this.Controls)
                {
                    if (cont is RadioButton)
                    {
                        RadioButton rdbThick = (RadioButton)cont;
                        if (rdbThick.Text == null || rdbThick.Text == "")
                        {
                            rdbThick.Text = item.Thickness;
                            rdbThick.Tag = item;
                            break;
                        }
                    }
                }
            }
            #endregion
            #region AddMaterials
            Material m1 = new Material();
            m1.MaterialName = "Dana Jambon";
            Array.Resize(ref Materials, Materials.Length + 1);
            Materials[Materials.Length - 1] = m1;

            Material m2 = new Material();
            m2.MaterialName = "Salam";
            Array.Resize(ref Materials, Materials.Length + 1);
            Materials[Materials.Length - 1] = m2;

            Material m3 = new Material();
            m3.MaterialName = "Sosis";
            Array.Resize(ref Materials, Materials.Length + 1);
            Materials[Materials.Length - 1] = m3;

            Material m4 = new Material();
            m4.MaterialName = "Sucuk";
            Array.Resize(ref Materials, Materials.Length + 1);
            Materials[Materials.Length - 1] = m4; ;

            Material m5 = new Material();
            m5.MaterialName = "Mısır";
            Array.Resize(ref Materials, Materials.Length + 1);
            Materials[Materials.Length - 1] = m5;

            Material m6 = new Material();
            m6.MaterialName = "Mantar";
            Array.Resize(ref Materials, Materials.Length + 1);
            Materials[Materials.Length - 1] = m6;

            Material m7 = new Material();
            m7.MaterialName = "Ançuez";
            Array.Resize(ref Materials, Materials.Length + 1);
            Materials[Materials.Length - 1] = m7;

            Material m8 = new Material();
            m8.MaterialName = "Ton Balığı";
            Array.Resize(ref Materials, Materials.Length + 1);
            Materials[Materials.Length - 1] = m8;

            Material m9 = new Material();
            m9.MaterialName = "Zeytin";
            Array.Resize(ref Materials, Materials.Length + 1);
            Materials[Materials.Length - 1] = m9;

            Material m10 = new Material();
            m10.MaterialName = "Peynir";
            Array.Resize(ref Materials, Materials.Length + 1);
            Materials[Materials.Length - 1] = m10;

            foreach (var item in Materials)
            {

                foreach (var cont2 in this.groupBox1.Controls)
                {

                    if (cont2 is CheckBox)
                    {

                        CheckBox mt = (CheckBox)cont2;
                        if (mt.Text == null || mt.Text == "")
                        {
                            mt.Text = item.MaterialName;
                            mt.Tag = item;
                            break;
                        }
                    }

                }
            }


            #endregion

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtAdet.Text) <= 0)
                {
                    MessageBox.Show("Geçerli bir değer giriniz...");
                    txtAdet.Text = "";
                }
                else
                {
                    if (CreateOrder()!=null)
                    {  
                        txtAmount.Text = CreateOrder().OrderPrice.ToString("C");
                    }

                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Geçerli bir değer giriniz...");
                txtAmount.Text = "";
                txtAdet.Text = "";

            }

        }
        public Order CreateOrder()
        {
            try
            {

                Pizza checkPizza = (Pizza)lstPizza.SelectedItem;
                Size checkSize = (Size)cmbEbat.SelectedItem;
                PizzaThickness checkThickness = null;
                #region Thickness
                RadioButton rdbbtn = new RadioButton();
                foreach (Control item in this.Controls)
                {
                    if (item is RadioButton)
                    {
                        rdbbtn = (RadioButton)item;
                        if (rdbbtn.Checked == true)
                        {
                            if (rdbbtn.Text == "Kalın Kenar")
                            {
                                checkThickness = Thicknesses[0];
                                break;
                            }
                            else
                            {
                                checkThickness = Thicknesses[1];

                                break;
                            }
                        }


                    }
                }
                #endregion
                #region Materials
                foreach (var item in Materials)
                {

                    foreach (var cont2 in this.groupBox1.Controls)
                    {

                        if (cont2 is CheckBox)
                        {

                            CheckBox mt = (CheckBox)cont2;
                            if (mt.Checked == true && mt.Text == item.MaterialName)
                            {
                                Array.Resize(ref CheckMaterials, CheckMaterials.Length + 1);
                                CheckMaterials[CheckMaterials.Length - 1] = item;

                            }
                        }
                    }
                }
                #endregion
                int piece = Convert.ToInt32(txtAdet.Text);
                decimal price = (checkSize.SizeX * checkPizza.DefaultPrice + Convert.ToDecimal(checkThickness.priceDif));
                decimal orderPrice = price * piece;
                ord = new Order(checkSize, checkThickness, checkPizza, CheckMaterials, piece, price, orderPrice);
                Array.Resize(ref Orders, Orders.Length + 1);
                Orders[Orders.Length - 1] = ord;
                Array.Resize(ref CheckMaterials, 0);
                return ord;



            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Seçim yapınız...");
                return null;
            }
            catch (FormatException)
            {

                MessageBox.Show("Geçerli bir değer giriniz...");
                TextClear();
                throw;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ord != null)
                {
                    
                    lstBasket.Items.Add(ord);

                    foreach (var item in lstBasket.Items)
                    {
                        ord.TotalPrice += ord.OrderPrice;

                    }


                    label6.Text = ord.TotalPrice.ToString("C");
                }
                else
                {
                    MessageBox.Show("Seçim Yapınız...");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Siparişinizi Hesaplayınız...");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (lstBasket.Items.Count < 1)
            {
                MessageBox.Show("Sepetinizde ürün bulunmamaktadır...");
            }
            else
            {
                MessageBox.Show("Toplam " + lstBasket.Items.Count + " Adet siparişiniz\n" + ord.TotalPrice + " TL Tutarındadır.");
                ord.Approved();
                TextClear();
                lstBasket.Items.Clear();
            }




        }
        public void TextClear()
        {
            txtAdet.Text = "";
            txtAmount.Text = "";
        }
    }
}
