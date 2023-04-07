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

        private string GetLetter()
        {
            if (!chkLowercase.Checked && !chkUppercase.Checked)
                return string.Empty;

            Random random = new Random();
            string letter = letters[random.Next(letters.Length)].ToString();

            if (chkLowercase.Checked && !chkUppercase.Checked)
            {
                return letter.ToLower();
            }
            else if (!chkLowercase.Checked && chkUppercase.Checked)
                return letter.ToUpper();

            switch (random.Next(2))
            {
                case 0:
                    return letter.ToLower();
                case 1:
                    return letter.ToUpper();
            }

            throw new ArgumentNullException();
        }

        private string GetNumber()
        {
            if (!chkNumbers.Checked)
                return string.Empty;

            Random random = new Random();

            return numbers[random.Next(numbers.Length)].ToString();
        }

        private string GetSymbol()
        {
            if (!chkSymbols.Checked)
                return string.Empty;

            Random random = new Random();

            return symbols[random.Next(symbols.Length)].ToString();
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
            if (!chkNumbers.Checked &&
                !chkSymbols.Checked &&
                !chkLowercase.Checked &&
                !chkUppercase.Checked)
            {
                MessageBox.Show(this, "The password is empty!", "An error has occured!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string password = string.Empty;
            int attemts = 100;

            for (int i = 0; i < trkLength.Value; i++)
            {
                if (attemts == 0)
                {
                    MessageBox.Show(this, "Timed out! Try again.", "An error has occured!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string nextItem = string.Empty;
                Random random = new Random();

                switch (random.Next(3))
                {
                    case 0:
                        nextItem = GetLetter();
                        break;
                    case 1:
                        nextItem = GetNumber();
                        break;
                    case 2:
                        nextItem = GetSymbol();
                        break;
                }

                if (string.IsNullOrEmpty(nextItem) ||
                    (chkExcluseIdentical.Checked &&
                    password.Contains(nextItem)))
                {
                    attemts--;
                    i--;
                }
                else
                    password += nextItem;
            }

            txtPassword.Text = password;
        }
    }
}