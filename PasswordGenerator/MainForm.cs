using Newtonsoft.Json;

namespace PasswordGenerator
{
    public partial class MainForm : Form
    {
        ConfigJSON configJson;

        public MainForm()
        {
            InitializeComponent();

            string filePath = "Data/config.json";

            if (!File.Exists(filePath))
            {
                MessageBox.Show(this, $"The file does not exists: {filePath}", "An error has occured!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            configJson = LoadJson(filePath);
        }

        private ConfigJSON LoadJson(string filePath)
        {
            var json = string.Empty;

            using (var sr = new StreamReader(filePath))
                json = sr.ReadToEnd();

            return JsonConvert.DeserializeObject<ConfigJSON>(json);
        }

        private string GetLetter()
        {
            if (!chkLowercase.Checked && !chkUppercase.Checked)
                return string.Empty;

            Random random = new Random();
            string letter = configJson.Letters[random.Next(configJson.Letters.Length)];

            if (chkLowercase.Checked && !chkUppercase.Checked)
                return letter.ToLower();
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

            return configJson.Numbers[random.Next(configJson.Numbers.Length)];
        }

        private string GetSymbol()
        {
            if (!chkSymbols.Checked)
                return string.Empty;

            Random random = new Random();

            return configJson.Symbols[random.Next(configJson.Symbols.Length)];
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
            int attempts = configJson.Attempts;

            for (int i = 0; i < trkLength.Value; i++)
            {
                if (attempts == 0)
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
                    attempts--;
                    i--;
                }
                else
                    password += nextItem;
            }

            txtPassword.Text = password;
        }
    }
}