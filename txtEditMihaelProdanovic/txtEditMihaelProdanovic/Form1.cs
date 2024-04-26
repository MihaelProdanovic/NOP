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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace txtEditMihaelProdanovic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = !richTextBox1.Visible;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style ^ FontStyle.Bold);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style ^ FontStyle.Italic);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style ^ FontStyle.Underline);
        }
    }
}
