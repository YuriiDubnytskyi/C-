using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] words;
        char[] chars;
        private void button1_Click(object sender, EventArgs e)
        
        {
            listBox1.Items.Clear();
            words = textBox1.Text.Split(' ',',','.','!');
            foreach (string item in words)
            {
                listBox1.Items.Add(item);
            }
            listBox1.Items.Add("Кількість слів = "+words.Length);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            char a = 'о';
            foreach (string word in words)
            {
                if (word[word.Length - 1] == a)
                {
                    listBox2.Items.Add(word);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chars = textBox1.Text.ToCharArray();
            char[] golosn = { 'ї', 'у' };
            char[] pruholos = { 'ч','т','д'};
            int golos = 0;
            int pruholo = 0;
            if (radioButton1.Checked == true)
            {
                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i] == golosn[0] || chars[i] == golosn[1]) {
                        golos++;
                    }
                }
                MessageBox.Show("Кількість голосних букв = "+golos);
            }
            if (radioButton2.Checked == true)
            {
                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i] == pruholos[0] || chars[i] == pruholos[1] || chars[i] == pruholos[2])
                    {
                        pruholo++;
                    }
                }
                MessageBox.Show("Кількість приголосних букв = " + pruholo);
            }
        }
    }
}
