using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Linq;

namespace GeneratePassword
{
    public partial class Form1 : Form
    {
        public string GeneratedPasswordWord { get; private set; }

        #region SymbolForPassword
        private const string LowercaseChars = "abcdefghijklmnopqrstuvwxyz";
        private const string UppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string DigitChars = "0123456789";
        private const string SymbolChars = "!@#$%^&*()";
        #endregion

        private HistoryForm historyForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lWarning.Visible = false;
            if (!cbLowercaseChars.Checked && !cbUppercaseChars.Checked && !cbDigitChars.Checked && !cbSymbolChars.Checked)
            {
                ShowSymbolSelectionPromt();
            }
            else
            {
                int passwordLength = (int)numericUpDown1.Value;

                string generatedPassword = GeneratePassword(passwordLength); // Генерируем пароль
                textSetPassword.Text = generatedPassword; // Отображаем сгенерированный пароль


                if (historyForm != null) // Проверяем, если есть экземпляр HistoryForm
                {
                    historyForm.AddPasswordToGrid(generatedPassword); // Добавляем пароль в историю
                }
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (!(textSetPassword.Text == string.Empty))
            {
                Clipboard.SetText(textSetPassword.Text);
            }
        }

        /// <summary>
        /// Метод использующийся для создания уникального пароля.
        /// </summary>
        /// <param name="passwordLength"></param>
        /// <returns></returns>
        private string GeneratePassword(int passwordLength)
        {
            var password = new StringBuilder();
            string characterSet = "";

            if (passwordLength <= 0)
            {
                MessageBox.Show("Please enter a valid password length.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }

            if (cbLowercaseChars.Checked)
            {
                characterSet += LowercaseChars;
            }
                
            if (cbUppercaseChars.Checked)
            {
                characterSet += UppercaseChars;
            }
                
            if (cbDigitChars.Checked)
            {
                characterSet += DigitChars;
            }

            if (cbSymbolChars.Checked)
            {
                characterSet += SymbolChars;
            }

            if (characterSet.Length == 0)
            {
                MessageBox.Show("Please select at least one character set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return password.ToString();
            }

            //To increase the cryptographic strength of random number generation, we use RNGCryptoServiceProvider
            using (RNGCryptoServiceProvider rngCryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                byte[] randomBytes = new byte[passwordLength];
                rngCryptoServiceProvider.GetBytes(randomBytes);

                for (int i = 0; i < passwordLength; i++)
                {
                    int randomIndex = randomBytes[i] % characterSet.Length;
                    password.Append(characterSet[randomIndex]);
                }
            }

            return GeneratedPasswordWord = password.ToString();
        }

        private void ShowSymbolSelectionPromt()
        {
            if (!lWarning.Visible)
            {
                textSetPassword.Text = string.Empty;
                lWarning.Text = "Please select at least\none character set.";
                lWarning.Visible = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Проверяем, если уже есть открытый экземпляр HistoryForm
            HistoryForm historyForm = Application.OpenForms.OfType<HistoryForm>().FirstOrDefault();

            if (historyForm == null)
            {
                // Создаем экземпляр HistoryForm только если нет открытых экземпляров
                historyForm = new HistoryForm(this);
            }

            // Устанавливаем положение новой формы на том же месте, где находится предыдущая форма
            historyForm.StartPosition = FormStartPosition.Manual;
            historyForm.Location = this.Location;

            // Скрываем текущую форму
            this.Hide();

            // Отображаем форму HistoryForm в виде модального окна
            historyForm.ShowDialog();
        }

    }
}