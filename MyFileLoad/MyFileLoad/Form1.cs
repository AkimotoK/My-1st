using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MyFileLoad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
　　　　　//テキストファイルを作成する
           string path = textBox1.Text;
           string text = textBox2.Text;
           StreamWriter textFile;
           textFile = new StreamWriter(path, false, System.Text.Encoding.Default);
           textFile.WriteLine(text);
           textFile.Close();
           label1.Text = "書き出しました";
      }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            if (File.Exists(path) == false)
            {
                label1.Text = "ファイルがありません";
                return;
            }
            StreamReader textFile;
            textFile = new StreamReader(path, System.Text.Encoding.Default);
            label1.Text = textFile.ReadToEnd();
            textFile.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
