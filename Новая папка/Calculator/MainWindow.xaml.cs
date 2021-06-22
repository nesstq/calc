using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static char[] operators = { '+', '-', '*', '/', '%' };
        double rez = 0, x = 0, y = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (textBlock_2.Text == "|")
            {

            }
        }




        private void ButtonPowerOff_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_0_Click(object sender, RoutedEventArgs e)
        {
            if (y == 0)
            {
                textBlock_2.Text = null;
                y = 1;
            }

            textBlock_2.Text += "0";

            y = Convert.ToDouble(textBlock_2.Text);
        }

        private void Btn_1_Click(object sender, RoutedEventArgs e)
        {
            if (y == 0)
            {
                textBlock_2.Text = null;
                y = 1;
            }

            textBlock_2.Text += "1";

            y = Convert.ToDouble(textBlock_2.Text);
        }

        private void Btn_2_Click(object sender, RoutedEventArgs e)
        {
            if (y == 0)
            {
                textBlock_2.Text = null;
                y = 1;
            }

            textBlock_2.Text += "2";

            y = Convert.ToDouble(textBlock_2.Text);
        }

        private void Btn_3_Click(object sender, RoutedEventArgs e)
        {
            if (y == 0)
            {
                textBlock_2.Text = null;
                y = 1;
            }

            textBlock_2.Text += "3";

            y = Convert.ToDouble(textBlock_2.Text);
        }

        private void Btn_4_Click(object sender, RoutedEventArgs e)
        {
            if (y == 0)
            {
                textBlock_2.Text = null;
                y = 1;
            }

            textBlock_2.Text += "4";

            y = Convert.ToDouble(textBlock_2.Text);
        }

        private void Btn_5_Click(object sender, RoutedEventArgs e)
        {
            if (y == 0)
            {
                textBlock_2.Text = null;
                y = 1;
            }

            textBlock_2.Text += "5";

            y = Convert.ToDouble(textBlock_2.Text);
        }

        private void Btn_6_Click(object sender, RoutedEventArgs e)
        {
            if (y == 0)
            {
                textBlock_2.Text = null;
                y = 1;
            }

            textBlock_2.Text += "6";

            y = Convert.ToDouble(textBlock_2.Text);
        }

        private void Btn_7_Click(object sender, RoutedEventArgs e)
        {
            if (y == 0)
            {
                textBlock_2.Text = null;
                y = 1;
            }

            textBlock_2.Text += "7";

            y = Convert.ToDouble(textBlock_2.Text);
        }

        private void Btn_8_Click(object sender, RoutedEventArgs e)
        {
            if (y == 0)
            {
                textBlock_2.Text = null;
                y = 1;
            }

            textBlock_2.Text += "8";

            y = Convert.ToDouble(textBlock_2.Text);
        }

        private void Btn_9_Click(object sender, RoutedEventArgs e)
        {
            if (y == 0)
            {
                textBlock_2.Text = null;
                y = 1;
            }

            textBlock_2.Text += "9";

            y = Convert.ToDouble(textBlock_2.Text);
        }

        private void Btn_Plus_Click(object sender, RoutedEventArgs e)
        {
            string buf = textBlock_1.Text;

            if (buf != "")
            {
                if (buf[buf.Length - 1] == '+' || buf[buf.Length - 1] == '-' || buf[buf.Length - 1] == '/' || buf[buf.Length - 1] == '*' || buf[buf.Length - 1] == '%')
                {
                    buf = buf.Remove(buf.Length - 1);

                    textBlock_1.Text = buf + "+";
                }
            }

            if (y == 0 & buf != "")
            {
                textBlock_1.Text += "+";
            }

            else
            {
                textBlock_1.Text += Convert.ToString(y) + "+";
            }

            rez = y + x;
            textBlock_2.Text = Convert.ToString(rez);
            x = Convert.ToDouble(textBlock_2.Text);
            y = 0;
        }

        private void Btn_Ravno_Click(object sender, RoutedEventArgs e)
        {
            string buf = textBlock_1.Text;

            if (buf[buf.Length - 1] == '+')
            {
                y = Convert.ToDouble(textBlock_2.Text);
                rez = x + y;
                textBlock_2.Text = Convert.ToString(rez);
            }
            if (buf[buf.Length - 1] == '-')
            {
                y = Convert.ToDouble(textBlock_2.Text);
                rez = x - y;
                textBlock_2.Text = Convert.ToString(rez);
            }
            if (buf[buf.Length - 1] == '*')
            {
                y = Convert.ToDouble(textBlock_2.Text);
                rez = x * y;
                textBlock_2.Text = Convert.ToString(rez);

            }
            if (buf[buf.Length - 1] == '/')
            {
                y = Convert.ToDouble(textBlock_2.Text);
                rez = x / y;
                textBlock_2.Text = Convert.ToString(rez);
            }
            rez = 0;
            x = 0; y = 0;
            textBlock_1.Text = null;
        }

        private void Btn_Zv_Click(object sender, RoutedEventArgs e)
        {
            string buf = textBlock_1.Text;

            if (buf != "")
            {
                if (buf[buf.Length - 1] == '+' || buf[buf.Length - 1] == '-' || buf[buf.Length - 1] == '/' || buf[buf.Length - 1] == '%')
                {
                    buf = buf.Remove(buf.Length - 1);

                    textBlock_1.Text = buf + "*";
                }
            }
            if (y == 0)
            {
                textBlock_1.Text += "*";
            }
            else
            {
                textBlock_1.Text += Convert.ToString(y) + "*";
            }

            if (x == 0)
            {
                rez = y;
            }
            else
            {
                rez = x * y;
            }

            textBlock_2.Text = Convert.ToString(rez);
            x = Convert.ToDouble(textBlock_2.Text);
            y = 0;

        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            string buf = textBlock_1.Text;

            if (buf != "")
            {
                if (buf[buf.Length - 1] == '+' || buf[buf.Length - 1] == '-' || buf[buf.Length - 1] == '/' || buf[buf.Length - 1] == '*' || buf[buf.Length - 1] == '%')
                {
                    buf = buf.Remove(buf.Length - 1);

                    textBlock_1.Text = buf + "-";
                }

            }

            if (y == 0 & buf != "")
            {
                textBlock_1.Text += "-";
            }

            else
            {
                textBlock_1.Text += Convert.ToString(y) + "-";
            }

            if (x == 0)
            {
                rez = y - x;
            }
            else
            {
                rez = x - y;
            }
            textBlock_2.Text = Convert.ToString(rez);
            x = Convert.ToDouble(textBlock_2.Text);
            y = 0;
        }

        private void Btn_Del_Click(object sender, RoutedEventArgs e)
        {
            string buf = textBlock_1.Text;

            if (buf != "")
            {
                if (buf[buf.Length - 1] == '+' || buf[buf.Length - 1] == '-' || buf[buf.Length - 1] == '/' || buf[buf.Length - 1] == '%')
                {
                    buf = buf.Remove(buf.Length - 1);

                    textBlock_1.Text = buf + "/";
                }
            }
            if (y == 0)
            {
                textBlock_1.Text += "/";
            }
            else
            {
                textBlock_1.Text += Convert.ToString(y) + "/";
            }

            if (x == 0)
            {
                rez = y;
            }
            else
            {
                rez = x / y;
            }

            textBlock_2.Text = Convert.ToString(rez);
            x = Convert.ToDouble(textBlock_2.Text);
            y = 0;
        }

        private void btnProc_Click(object sender, RoutedEventArgs e)
        {

            string buf = textBlock_1.Text;

            if (buf != "")
            {
                if (buf[buf.Length - 1] == '+' || buf[buf.Length - 1] == '-' || buf[buf.Length - 1] == '/' || buf[buf.Length - 1] == '%')
                {
                    buf = buf.Remove(buf.Length - 1);

                    textBlock_1.Text = buf + "%";
                }
            }
            if (y == 0)
            {
                textBlock_1.Text += "%";
            }
            else
            {
                textBlock_1.Text += Convert.ToString(y) + "%";
            }

            if (x == 0)
            {
                rez = y;
            }
            else
            {
                rez = x / (y + x) * 100;
            }

            textBlock_2.Text = Convert.ToString(rez);
            x = Convert.ToDouble(textBlock_2.Text);
            y = 0;
        }

        private void btnKor_Click(object sender, RoutedEventArgs e)
        {
            string text1 = textBlock_2.Text;
            double a = Convert.ToDouble(text1);
            a = Math.Sqrt(a);
            textBlock_2.Text = a.ToString();
        }

        private void btndel_Click(object sender, RoutedEventArgs e)
        {
              string buf = textBlock_1.Text;
             buf = buf.Remove(buf.Length - 1);
             textBlock_1.Text = buf;
            textBlock_2.Text = "0";
        }

        private void btnProc_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            textBlock_2.Text = "";
        }

        private void textBlock_2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789/*-+.%^()√ ,".IndexOf(e.Text) < 0;

        }
    }
}
