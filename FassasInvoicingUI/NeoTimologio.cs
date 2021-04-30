using FassasInvoicingLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FassasInvoicingUI
{
    public partial class NeoTimologio : Form
    {
        private List<Eteria> availableEteries = GlobalConfig.Connection.GetEteries();
        double k = 0.00;

        
        public NeoTimologio()
        {
            InitializeComponent();
            //CreateSampleData();
            WireUpLists();
        }

       private void WireUpLists()
        {
            comboBox1.DataSource = availableEteries;
            comboBox1.DisplayMember = "DisplayEponimia";
            comboBox2.DataSource = availableEteries;
            comboBox2.DisplayMember = "DisplayAfm";

            comboBox4.DataSource = availableEteries;
            comboBox4.DisplayMember = "DisplayDrastiriotita";

            comboBox6.DataSource = availableEteries;
            comboBox6.DisplayMember = "DisplayDiefthinsi";

            comboBox5.DataSource = availableEteries;
            comboBox5.DisplayMember = "DisplayDoy";



        }
        private void LoadListData()
        {
            availableEteries = GlobalConfig.Connection.GetEteries();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
          
        }

 


        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "0";
                double d = double.Parse(textBox7.Text);
                textBox7.Text = "";
                k = k - d;
            }

            else
            {
                double d = double.Parse(textBox7.Text);
                textBox7.Text = "0";
                k = k - d;
            }

        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "0";
            }
            else
            {
                double d = double.Parse(textBox7.Text);
                textBox7.Text = d.ToString("#,##0.00");
                k = k + d;
                string s = k.ToString("#,##0.00");
                textBox36.Text = s;
                textBox37.Text = (k * 24 / 100).ToString("#,##0.00");

            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                textBox8.Text = "0";
                double d = double.Parse(textBox8.Text);
                textBox8.Text = "";
                k = k - d;
            }

            else
            {
                double d = double.Parse(textBox8.Text);
                textBox8.Text = "0";
                k = k - d;
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                textBox8.Text = "0";
            }
            else
            {
                double d = double.Parse(textBox8.Text);
                textBox8.Text = d.ToString("#,##0.00");
                k = k + d;
                textBox36.Text = k.ToString("#,##0.00");
                textBox37.Text=(k*24/100).ToString("#,##0.00");
            }
        }
        //Timi monadas 1
        private void textBox6_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
           
        }
        //Timi monadas 2
        private void textBox9_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NeoTimologio_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
