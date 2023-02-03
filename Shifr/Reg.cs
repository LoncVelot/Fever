using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shifr
{
    public partial class Reg : Form
    {
        bool vis = true;
        public Reg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim();
            textBox2.Text = textBox2.Text.Trim();
            try
            {
                var user = new User(textBox1.Text, textBox2.Text);
                if (user.CorrectUser())
                {
                        new Database("DataSource = dataBase.db; Version = 3;").createUser(user);
                        this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Имя пользователя уже занято", "Ошибка регистрации",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка регистрации",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return;
            }
        }
        private void FormRegistration_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reg_Load(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
