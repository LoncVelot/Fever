using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shifr
{
    public partial class FormAuth : Form
    {
        bool vis = true;
        public  FormAuth()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (userAuthSucceess())
                this.DialogResult = DialogResult.OK;
            else
                return;
        }

        private bool userAuthSucceess()
        {
            if (incorrectFiledsOnForm())
            {
                MessageBox.Show("Не корректные поля на форме");
                return false;
            }

            if (hasUser(textBox1.Text, textBox2.Text))
            return true;
            else
            {
                MessageBox.Show("Не верный логин или пароль");
                return false;
            }
        }

        private bool incorrectFiledsOnForm()
        {
            if (isUnCorrectField(textBox1.Text) || isUnCorrectField(textBox2.Text))
                return true;


            return false;
        }

        private bool isUnCorrectField(string field)
        {
            if (String.IsNullOrWhiteSpace(field))
                return true;
            return false;
        }

        private bool hasUser(string login, string password)
        {
            User user = new User(login, password);

            return user.IsCorrect();
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            DialogResult authDialogResult = new Reg().ShowDialog();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (vis)
            {
                textBox2.UseSystemPasswordChar = false;
                vis = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                vis = true;
            }
        }

        private void FormAuth_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
