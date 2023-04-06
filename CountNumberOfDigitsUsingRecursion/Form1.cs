namespace CountNumberOfDigitsUsingRecursion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNumberOfDigits_Click(object sender, EventArgs e)
        {
            MessageBox.Show(numberOfDigitsInNumber(12345).ToString());
        }

        int numOfDigits = 0;
        private int numberOfDigitsInNumber(int number)
        {
            if(number == 0)
            {
                return numOfDigits;
            }
            else
            {
                number = number / 10;
                return numberOfDigitsInNumber(number) + numOfDigits + 1;
            }
        }
    }
}