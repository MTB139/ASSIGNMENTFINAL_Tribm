using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignmentfinal
{
    public partial class Form3 : Form
    {
        string Customername;
        double Thismonthwater;
        double Lastmonthwater;
        int Numberofperson;
        double Watermoney;
        double Comsumption;



        public Form3
            (string Customername, double Thismonthwater, double Lastmothwater, double watermoney, double comsumption)
        {
            InitializeComponent();
            this.Customername = Customername;
            this.Thismonthwater = Thismonthwater;
            this.Lastmonthwater = Lastmothwater;
            Watermoney = watermoney;
            Comsumption = comsumption;

        }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtcustomername.Text = Customername;
            txtlast.Text = Lastmonthwater.ToString();
            txtthis.Text = Thismonthwater.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment success!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
