using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Palindrome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string copy = "";
        string reverse = "";
        int i = 1;

        private void BtnPalindrome_Click(object sender, EventArgs e)
        {
            string input = "and";
            int length = input.Length;
            copy = new string(input);
            MessageBox.Show(Palindrome(input, length, i).ToString());
        }
        
        
        private bool Palindrome(string text, int n ,int i)
        {

            if (text.Length >= 1)
            {
                reverse += text[n -i].ToString();
                return Palindrome(text.Substring(0, n -1), n -1, i++); 
            }
            else if(copy == reverse.ToString())
            {
                return true;
            }
            else
            { 
                return false; 
            }
        }
    }
}