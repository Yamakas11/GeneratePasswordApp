using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneratePassword
{
    public partial class HistoryForm : Form
    {
        DataGridView dataGridView = new DataGridView();

        Form1 form1 = new Form1();

        private Form previousForm;

        List<GetSetHistoryPassword> passwordList = new List<GetSetHistoryPassword>();

        public HistoryForm(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.form1 = form1;

            ColumnTextPassword.ToolTipText = "Password";
        }

        public void SomeMethod()
        {
            string generatedPassword = form1.GeneratedPasswordWord;
            AddPasswordToGrid(generatedPassword);
        }

        private void HistoryForm_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            previousForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public void AddPasswordToGrid(string password)
        {
            GetSetHistoryPassword newPassword = new GetSetHistoryPassword()
            {
                GeneratedPassword = password,
                GeneratedDate = DateTime.Now
            };

            passwordList.Add(newPassword);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = passwordList;

        }

    }
}
