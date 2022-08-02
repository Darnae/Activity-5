using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Read_From_A_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            StreamReader sr = new StreamReader("../../TextFile1.txt");
            string data = sr.ReadToEnd();
            string[] words = data.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string str in words)
                {
                    if (str.Length > ctr)
                    {
                        word = str;
                        ctr = str.Length;
                    }
                }
                FileText.Text = data.ToLower();
                LongestWord.Text = word;


               



                string first = "first";
                string last = "last";
                string second = "second";
                FirstWord.Text = first;
                LastWord.Text = last;
                Vowels.Text = second;



            }
        }
    }
}
