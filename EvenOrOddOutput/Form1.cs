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
            //for(int j = 0; j < 10;j++)
            //{
                MessageBox.Show(even(40).ToString());
                MessageBox.Show(odd(20).ToString());
            //}
        }


        string evenoutput = "";
        string oddoutput = "";
        private string even(int num)
        {
            if(num == 0)
            {
                return evenoutput;
            }
            if(num %2 == 0)
            {
                evenoutput = num.ToString() + " :";
                return evenoutput + even(num -2);
            }
            else
            {
                even(num - 2);
            }
            return evenoutput;
        }

        private string odd(int num)
        {
            if(num == 0)
            {
                return oddoutput;
            }
            if (num % 2 == 1)
            {
                oddoutput += num.ToString() + ":";
                return odd(num - 1)+ oddoutput;
            }
            else
            {
                odd(num -1);
            }
            return oddoutput;
        }
    }
}