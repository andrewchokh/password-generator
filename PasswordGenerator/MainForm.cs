namespace PasswordGenerator
{
    public partial class MainForm : Form
    {
        readonly char[] letters =
        {
            'a', 'b', 'c', 'd', 'e',
            'f', 'g', 'h', 'i', 'j',
            'k', 'l', 'm', 'n', 'o',
            'p', 'q', 'r', 's', 't',
            'u', 'v', 'w', 'x', 'y',
            'z',
        };

        readonly char[] numbers =
        {
            '1', '2', '3', '4', '5',
            '6', '7', '8', '9', '0',
        };

        readonly char[] symbols =
        {
            '@', '#', '$', '!', '?',
            '/', '\\', '"', '\'', '[',
            ']', '{', '}', ';', ':',
            '&', '^', '*', '+', '-',
            '=', '_', '.', '<', '>',
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private string GeneratePassword()
        {
            string password = string.Empty;

            for (int i = 0; i < trkLength.Value; i++)
            {
                string nextItem = string.Empty;
                Random random = new Random();

                switch (random.Next(3))
                {
                    case 0:
                        nextItem = letters[random.Next(letters.Length)].ToString();
                        break;
                    case 1:
                        nextItem = chkNumbers.Checked ?
                            numbers[random.Next(numbers.Length)].ToString() :
                            letters[random.Next(letters.Length)].ToString();
                        break;
                    case 2:
                        nextItem = chkSymbols.Checked ?
                            symbols[random.Next(symbols.Length)].ToString() :
                            letters[random.Next(letters.Length)].ToString();
                        break;
                }

                switch (random.Next(2))
                {
                    case 0:
                        nextItem = chkLowercase.Checked ?
                            nextItem.ToString().ToLower() : nextItem;
                        break;
                    case 1:
                        nextItem = chkUppercase.Checked ?
                            nextItem.ToString().ToUpper() : nextItem;
                        break;
                }

                password += nextItem;
            }

            return password;
        }

        private void trkLength_Scroll(object sender, EventArgs e)
        {
            numLength.Value = trkLength.Value;
        }

        private void numLength_ValueChanged(object sender, EventArgs e)
        {
            trkLength.Value = (int)numLength.Value;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtPassword.Text = GeneratePassword();
        }
    }
}