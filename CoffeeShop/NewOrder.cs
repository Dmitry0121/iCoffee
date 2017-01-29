using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace CoffeeShop
{
    public partial class NewOrder : Form
    {
        #region variable and methods

        private int espressoCountValue = 0;
        private int americanoCountValue = 0;
        private int cappuccinoCountValue = 0;
        private int latteCountValue = 0;

        private const decimal PRICE_ESPRESSO = 9.99M;
        private const decimal PRICE_AMERICANO = 11.5M;
        private const decimal PRICE_CAPPUCCINO = 9.95M;
        private const decimal PRICE_LATTE = 15.5M;

        private const string MESSAGE_OK = "Ваш заказ оформлен.";

        private string date = DateTime.Now.ToString("dd MMMM yyyy (HH:mm:ss)");

        private List<string> orderList = new List<string>();

        private void ClearAll()
        {            
            if (MainForm.SelfRef != null)
            {
                //ClearAll from MainForm
                MainForm.SelfRef.ClearAll();
            }

            list.Text = "";
            this.Close();
        }

        #endregion

        public NewOrder(int _espressoCount, int _americanoCount, int _cappuccinoCount, int _latteCount)
        {
            InitializeComponent();

            this.espressoCountValue = _espressoCount;
            this.americanoCountValue = _americanoCount;
            this.cappuccinoCountValue = _cappuccinoCount;
            this.latteCountValue = _latteCount;
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {
                if (espressoCountValue != 0)
                {
                    orderList.Add("Экспрессо:....x" + espressoCountValue + "(" + PRICE_ESPRESSO + ") | " + espressoCountValue * PRICE_ESPRESSO + " грн.\n");
                }
                if (americanoCountValue != 0)
                {
                    orderList.Add("Американно:...x" + americanoCountValue + "(" + PRICE_AMERICANO + ") | " + americanoCountValue * PRICE_AMERICANO + " грн.\n");
                }
                if (cappuccinoCountValue != 0)
                {
                    orderList.Add("Капучино:.....x" + cappuccinoCountValue + "(" + PRICE_CAPPUCCINO + ") | " + cappuccinoCountValue * PRICE_CAPPUCCINO + " грн.\n");
                }
                if (latteCountValue != 0)
                {
                    orderList.Add("Латте:........x" + latteCountValue + "(" + PRICE_LATTE + ") | " + latteCountValue * PRICE_LATTE + " грн.\n");
                }

                orderList.Add("ВСЕГО:.................| " + ((espressoCountValue * PRICE_ESPRESSO) +
                                                            (americanoCountValue * PRICE_AMERICANO) +
                                                            (cappuccinoCountValue * PRICE_CAPPUCCINO) +
                                                            (latteCountValue * PRICE_LATTE)) + " грн.\n");

                foreach (string line in orderList)
                {
                    list.Text = list.Text + line + "\r\n";
                }     
        }

        private void list_TextChanged(object sender, EventArgs e)
        {
            list.ReadOnly = true;
        }

        #region add new order, cancel, continue shopping
              
        private void ok_Click(object sender, EventArgs e)
        {
            using (StreamWriter order = new StreamWriter(@"C:\order.txt", true))
            {
                order.WriteLine("\r\nДата: " + date);
                foreach (string line in orderList)
                {
                    order.WriteLine(line);
                }
            }

            ClearAll();
            MessageBox.Show(MESSAGE_OK);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void continueShopping_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}