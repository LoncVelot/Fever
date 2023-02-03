using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shifr
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            DialogResult authDialogResult = new FormAuth().ShowDialog();

            if (authDialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("Вы не авторизовались");
                Close();
            }
        }

        private void KeyBox(object sender, EventArgs e)
        {

        }

        private void textBox(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Введите ключ и текст");
                return;
            }
            string result =  new Code().Encode(textBox2.Text, textBox1.Text);
            StreamWriter writer = new StreamWriter("Шифр.txt");
            writer.WriteLine(result);
            writer.Close();
            MessageBox.Show("Результат сохранён в файл");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Введите ключ и текст");
                return;
            }
            string readString = "";
            try
            {
                StreamReader reader = new StreamReader("Шифр.txt");
                readString = reader.ReadLine();
                reader.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка при чтении файла Шифр.txt");
                return;
            }
            string result = new Code().Decode(readString, textBox1.Text);
            StreamWriter writer = new StreamWriter("Сообщение.txt");
            writer.WriteLine(result);
            writer.Close();
            MessageBox.Show("Результат сохранён в файл");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Как пользоваться программой: 1)Введите ключ и текст; 2)Нажмите кнопку ЗАШИФРОВАТЬ И РАСШИФРОВАТЬ; 3)Перейдите в корневую папку и откройте два файла ШИФР И СООБЩЕНИЕ.");

        }
    }
}
