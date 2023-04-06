using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EvenOrOddOutput
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEvenOrOdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(even(40).ToString());
            MessageBox.Show(odd(20).ToString());
        }


        string evenoutput = "";
        string oddoutput = "";
        private string even(int num)
        {
            string result = "";
            if (num == 0)
            {
                return "";
            }
            if (num % 2 == 0)
            {
                result = num.ToString() + " ";

            }

            return even(num - 1) + result;
        }

        private string odd(int num)
        {
            string result = "";
            if (num == 0)
            {
                return "";
            }
            if (num % 2 == 1)
            {
                result = num.ToString() + " ";

            }
            return odd(num - 1) + result;
        }
    }
}