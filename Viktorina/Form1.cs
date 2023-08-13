using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viktorina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void quiz4_Click(object sender, EventArgs e)
        {

        }

        private void Answer1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Answer = Answer1.Text;
            if(Answer == "12")
            {
                MessageBox.Show("Верно!");
            }
            else
            {
                MessageBox.Show("Неверно!");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Answer = Answer2.Text;
            if (Answer == "Париж")
            {
                MessageBox.Show("Верно!");
            }
            else
            {
                MessageBox.Show("Неверно!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Answer = Answer3.Text;
            if (Answer == "Metallica"|| Answer == "metallica")
            {
                MessageBox.Show("Верно!");
            }
            else
            {
                MessageBox.Show("Неверно!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Answer = Answer4.Text;
            if (Answer == "Tesla" || Answer == "tesla")
            {
                MessageBox.Show("Верно!");
            }
            else
            {
                MessageBox.Show("Неверно!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Answer = Answer5.Text;
            if (Answer == "Чай"|| Answer == "чай")
            {
                MessageBox.Show("Верно!");
            }
            else
            {
                MessageBox.Show("Неверно!");
            }
        }

        private void Answer2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Answer3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Answer4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Answer5_TextChanged(object sender, EventArgs e)
        {

        }

        private void AllAnswer_Click(object sender, EventArgs e)
        {
            string Ans1 = Answer1.Text;
            string Ans2 = Answer2.Text;
            string Ans3 = Answer3.Text;
            string Ans4 = Answer4.Text;
            string Ans5 = Answer5.Text;
            int All = 0;
            if (Ans1 == "12")
            {
                All++;
            }
            if(Ans2 == "Париж")
            {
                All++;
            }
            if(Ans3 == "Metallica" || Ans3 == "metallica")
            {
                All++;
            }
            if(Ans4 == "Tesla" || Ans4 == "tesla")
            {
                All++;
            }
            if (Ans5 == "Чай"|| Ans5 == "чай")
            {
                All++;
            }

            //MessageBox.Show($"Правильных ответов {All}");

            AnswerLay.Text = $"Правильных ответов {All}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
