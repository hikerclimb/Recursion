namespace SumOfFirst10Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int sumNum =0;
        private void BtnSumOf10Numbers_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sum(10).ToString());
        }

        private int sum(int num)
        {
            if(num == 0)
            {
                return sumNum;
            }
            else
            {
                return sum(num -1) + num;
            }
        }
    }
}