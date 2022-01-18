using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //DialogResult msg = MessageBox.Show("هل تريد الخروج؟", "تحذير!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (msg == DialogResult.Yes)
            //{
                this.Close();
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               
           
            if (textBox1.Text == "")
            {
                label1.Text = "أكتب معدلك؟!";
                
                
            }
            else if (Convert.ToDouble(textBox1.Text) > 4.00)
            {
                label1.Text = "المعدل أقل من 4";
            }
            else if (Convert.ToDouble(textBox1.Text) < 2.00)
            {
                label1.Text = "المعدل أكبر من 2";
            }
            else
            {
                Double result = (Convert.ToDouble(textBox1.Text)) * 25;
                label1.Text = result.ToString() + "%";
                MessageBox.Show(label1.Text, "النتيجة", MessageBoxButtons.OK);
            }
            }
            catch (Exception s)
            {
                //MessageBox.Show("Failed" + s.ToString());
                MessageBox.Show("أدخل رقماً");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult msg = MessageBox.Show("هل تريد الخروج؟?", "تحذير!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           // linkLabel1.Links.Add(https://www.facebook.com/kamal.kafi33);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
