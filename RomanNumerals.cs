using System.Drawing.Imaging;

namespace Roman_Numerals
{
    public partial class RomanNumerals : Form
    {
        public RomanNumerals()
        {
            InitializeComponent();
        }
        private void btnConvertClick(object sender, EventArgs e)
        {
            Converter task = new Converter();
            char[] Number = txtDecimal.Text.ToCharArray();
            foreach (char c in Number)
             {
                if (txtDecimal.Text == string.Empty || !(char.IsNumber(c)) || txtDecimal.Text.Contains(' ') || txtDecimal.Text.Contains('.') || txtDecimal.Text.Contains(','))
                {
                    MessageBox.Show("Please enter a Number", "Erorr", MessageBoxButtons.OK);
                    txtDecimal.Text = string.Empty;
                    break;
                }
                else
                {
                    task.Decimals = Convert.ToInt32(txtDecimal.Text);
                }
                int x = int.Parse(txtDecimal.Text);
                if (x >= 4000)
                {
                    MessageBox.Show("Please enter a number lower than 3999", "Too High", MessageBoxButtons.OK);
                    txtDecimal.Text = string.Empty;
                    break;
                }
                task.Romans = txtRoman.Text.ToString();
                values();     
             }
        }
        public void values()
        {
            string result= "";
            Dictionary<int, string> Roman = new Dictionary<int, string>();
            Roman.Add(1, "I"); Roman.Add(4, "IV");
            Roman.Add(5, "V"); Roman.Add(9, "IX");
            Roman.Add(10, "X"); Roman.Add(40, "XL");
            Roman.Add(50, "L"); Roman.Add(90, "XC");
            Roman.Add(100, "C"); Roman.Add(400, "CD");
            Roman.Add(500, "D"); Roman.Add(900, "CM");
            Roman.Add(1000, "M");

            int convertNumber = Convert.ToInt32(txtDecimal.Text);
            while (convertNumber > 0)
            {
                for (int i = Roman.Count - 1; i >= 0; i--)
                {
                    if (convertNumber >= Roman.ElementAt(i).Key)
                    {
                        result += Roman.ElementAt(i).Value;
                        convertNumber -= Roman.ElementAt(i).Key;
                        break;
                    }
                }
            }
            txtRoman.Text = result;

        } 
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDecimal.Text = string.Empty;
            txtRoman.Text = string.Empty;
        }
    }
}