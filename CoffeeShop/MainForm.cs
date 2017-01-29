using System;
using System.IO;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class MainForm : Form
    {
        #region variable and methods

        private int espressoCountValue = 0;
        private int americanoCountValue = 0;
        private int cappuccinoCountValue = 0;
        private int latteCountValue = 0;
        
        private const string MORE_INFORMATION = "Нажать на изображение для доп. информации.";
        private const string MESSAGE_NOT_CHOSEN = "Вы не сделали заказ";

        public void ClearAll()
        {
            espressoDelCup.Enabled = false;
            espressoAddCup.Enabled = false;
            espressoCount.Enabled = false;

            americanoDelCup.Enabled = false;
            americanoAddCup.Enabled = false;
            americanoCount.Enabled = false;

            cappuccinoDelCup.Enabled = false;
            cappuccinoAddCup.Enabled = false;
            cappuccinoCount.Enabled = false;

            latteDelCup.Enabled = false;
            latteAddCup.Enabled = false;
            latteCount.Enabled = false;

            espressoCount.Text = "";
            americanoCount.Text = "";
            cappuccinoCount.Text = "";
            latteCount.Text = "";

            choiceEspresso.Checked = false;
            choiceAmericano.Checked = false;
            choiceCappuccino.Checked = false;
            choiceLatte.Checked = false;

            about.Text = MORE_INFORMATION;
        }
              
        //Calling Forms method from another Form
        public static MainForm SelfRef
        {
            get;
            set;
        }

        #endregion

        public MainForm()
        {
            InitializeComponent();
            SelfRef = this;
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            ClearAll();
        }

        #region choice coffee

        private void choiceEspresso_CheckedChanged(object sender, EventArgs e)
        {

            if (choiceEspresso.Checked)
            {
                espressoDelCup.Enabled = true;
                espressoAddCup.Enabled = true;
                espressoCount.Enabled = true;

                espressoCountValue = 1;
                espressoCount.Text = espressoCountValue.ToString();
            }
            else
            {
                espressoDelCup.Enabled = false;
                espressoAddCup.Enabled = false;
                espressoCount.Enabled = false;

                espressoCountValue = 0;
                espressoCount.Text = "";
            }
        }

        private void choiceAmericano_CheckedChanged(object sender, EventArgs e)
        {
            if (choiceAmericano.Checked)
            {
                americanoDelCup.Enabled = true;
                americanoAddCup.Enabled = true;
                americanoCount.Enabled = true;

                americanoCountValue = 1;
                americanoCount.Text = americanoCountValue.ToString();
            }
            else
            {
                americanoDelCup.Enabled = false;
                americanoAddCup.Enabled = false;
                americanoCount.Enabled = false;

                americanoCountValue = 0;
                americanoCount.Text = "";
            }
        }

        private void choiceCappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if (choiceCappuccino.Checked)
            {
                cappuccinoDelCup.Enabled = true;
                cappuccinoAddCup.Enabled = true;
                cappuccinoCount.Enabled = true;

                cappuccinoCountValue = 1;
                cappuccinoCount.Text = cappuccinoCountValue.ToString();
            }
            else
            {
                cappuccinoDelCup.Enabled = false;
                cappuccinoAddCup.Enabled = false;
                cappuccinoCount.Enabled = false;

                cappuccinoCountValue = 0;
                cappuccinoCount.Text = "";
            }
        }

        private void choiceLatte_CheckedChanged(object sender, EventArgs e)
        {
            if (choiceLatte.Checked)
            {
                latteDelCup.Enabled = true;
                latteAddCup.Enabled = true;
                latteCount.Enabled = true;

                latteCountValue = 1;
                latteCount.Text = latteCountValue.ToString();
            }
            else
            {
                latteDelCup.Enabled = false;
                latteAddCup.Enabled = false;
                latteCount.Enabled = false;

                latteCountValue = 0;
                latteCount.Text = "";
            }
        }

        #endregion

        #region add and delete cup

        private void espressoAddCup_Click(object sender, EventArgs e)
        {
            espressoCountValue = espressoCountValue + 1;
            espressoCount.Text = espressoCountValue.ToString();
        }

        private void espressoDelCup_Click(object sender, EventArgs e)
        {
            if ((espressoCountValue = espressoCountValue - 1) <= 0)
            {
                espressoCountValue = 1;
                espressoCount.Text = espressoCountValue.ToString();
            }
            else
            {
                espressoCount.Text = espressoCountValue.ToString();
            }
        }

        private void americanoAddCup_Click(object sender, EventArgs e)
        {
            americanoCountValue = americanoCountValue + 1;
            americanoCount.Text = americanoCountValue.ToString();
        }

        private void americanoDelCup_Click(object sender, EventArgs e)
        {
            if ((americanoCountValue = americanoCountValue - 1) <= 0)
            {
                americanoCountValue = 1;
                americanoCount.Text = americanoCountValue.ToString();
            }
            else
            {
                americanoCount.Text = americanoCountValue.ToString();
            }
        }

        private void cappuccinoAddCup_Click(object sender, EventArgs e)
        {
            cappuccinoCountValue = cappuccinoCountValue + 1;
            cappuccinoCount.Text = cappuccinoCountValue.ToString();
        }

        private void cappuccinoDelCup_Click(object sender, EventArgs e)
        {
            if ((cappuccinoCountValue = cappuccinoCountValue - 1) <= 0)
            {
                cappuccinoCountValue = 1;
                cappuccinoCount.Text = cappuccinoCountValue.ToString();
            }
            else
            {
                cappuccinoCount.Text = cappuccinoCountValue.ToString();
            }
        }

        private void latteAddCup_Click(object sender, EventArgs e)
        {
            latteCountValue = latteCountValue + 1;
            latteCount.Text = latteCountValue.ToString();
        }

        private void latteDelCup_Click(object sender, EventArgs e)
        {
            if ((latteCountValue = latteCountValue - 1) <= 0)
            {
                latteCountValue = 1;
                latteCount.Text = latteCountValue.ToString();
            }
            else
            {
                latteCount.Text = latteCountValue.ToString();
            }
        }

        #endregion

        #region create order

        private void newOrder_Click(object sender, EventArgs e)
        {
            if (choiceEspresso.Checked || choiceAmericano.Checked || choiceCappuccino.Checked || choiceLatte.Checked)
            {
                using (NewOrder newOrder = new NewOrder(espressoCountValue, americanoCountValue, cappuccinoCountValue, latteCountValue) )
                {
                    newOrder.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show(MESSAGE_NOT_CHOSEN);
            }
        }

        #endregion

        #region more information

        private void espresso_Click(object sender, EventArgs e)
        {
            using (var sr = new StreamReader(@"espresso.txt", System.Text.Encoding.Default))
            {
                var str = sr.ReadToEnd();
                about.Text = str.ToString();
            }
        }

        private void americano_Click(object sender, EventArgs e)
        {
            using (var sr = new StreamReader(@"americano.txt", System.Text.Encoding.Default))
            {
                var str = sr.ReadToEnd();
                about.Text = str.ToString();
            }
        }

        private void cappuccino_Click(object sender, EventArgs e)
        {
            using (var sr = new StreamReader(@"cappuccino.txt", System.Text.Encoding.Default))
            {
                var str = sr.ReadToEnd();
                about.Text = str.ToString();
            }
        }

        private void latte_Click(object sender, EventArgs e)
        {
            using (var sr = new StreamReader(@"latte.txt", System.Text.Encoding.Default))
            {
                var str = sr.ReadToEnd();
                about.Text = str.ToString();
            }
        }

        private void about_TextChanged(object sender, EventArgs e)
        {
            about.ReadOnly = true;
        }

        #endregion
    }
}