using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int loopStart;
        int loopEnd;
        int answer = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            loopStart = int.Parse(textBox1.Text); ;
            loopEnd = int.Parse(textBox2.Text);

            for (int i = loopStart ; i < loopEnd + 1; i++)
            {
                answer = answer + i;
                listBox1.Items.Add("i = " + i +" answer = " + answer.ToString());

            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
