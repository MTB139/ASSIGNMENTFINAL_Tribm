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
    public partial class Form2 : Form
    {
        private List<Invoice> invoices = new List<Invoice>();
        public double VAT = 0.1;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cbotypeofcustomer.Items.Add("Household customer");
            cbotypeofcustomer.Items.Add("Administration agency, public services");
            cbotypeofcustomer.Items.Add("Production units");
            cbotypeofcustomer.Items.Add("Business services");




            lv.View = View.Details;
            lv.Columns.Add("Customer Name", 200);
            lv.Columns.Add("Last Month Water Meter", 200);
            lv.Columns.Add("This Month Water Meter", 200);
            lv.Columns.Add("Amount Of Consumption", 200);
            lv.Columns.Add("Total Water Bill", 200);


        }

        private void cbotypeofcustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string typeofcustomer = cbotypeofcustomer.Text;
            if (typeofcustomer.Equals(" Household customer"))
            {
                txtnumberofperson.Enabled = true;
            }
            else
            {
                txtnumberofperson.Enabled = false;
                txtnumberofperson.Text = "";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string customername = txtcustomername.Text;
            string customertype = cbotypeofcustomer.Text.Trim();
            int numberofperson = 0;
            double lastmonthwater = 0;
            double thismonthwater = 0;



            if (customername == "")
            {
                MessageBox.Show("Please enter the customer's name", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (customertype == "")
            {
                MessageBox.Show("Select customer type", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (customertype == "Household customer")
            {
                if (!int.TryParse(txtnumberofperson.Text, out numberofperson) || numberofperson == 0)
                {
                    MessageBox.Show("Please enter number of member", " Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (!double.TryParse(txtlastmonthwater.Text, out lastmonthwater) || lastmonthwater <= 0)

            {
                MessageBox.Show("Last month water meter should be a positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtthismonthwater.Text, out thismonthwater) || thismonthwater < 0)
            {
                MessageBox.Show("This month water meter should be a positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lastmonthwater > thismonthwater)
            {
                MessageBox.Show("Last month water meter must not be less than this month water meter ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var waterBill = Calculator(customertype, numberofperson, lastmonthwater, thismonthwater);

            ListViewItem item = new ListViewItem(customername);
            item.SubItems.Add(lastmonthwater.ToString());
            item.SubItems.Add(thismonthwater.ToString());
            item.SubItems.Add(waterBill.Item1.ToString());
            item.SubItems.Add(waterBill.Item2.ToString());
            lv.Items.Add(item);


            Invoice invoice = new Invoice
            {
                CustomerName = customername,
                LastMonthWater = lastmonthwater,
                ThisMonthWater = thismonthwater,
                Consumption = waterBill.Item1,
                WaterMoney = waterBill.Item2,
            };
            invoices.Add(invoice);
        }
        private (double, double) Calculator(string customertype, int numberofmember, double lastmonthwatermeter, double thismonthwatermeter)
        {
            double consumption = thismonthwatermeter - lastmonthwatermeter;
            double waterMoney = 0;

            // Calculate water money based on customer type

            if (customertype == "Household customer")
            {
                double averagePerson = consumption / numberofmember;

                if (averagePerson < 10)
                {
                    waterMoney = consumption * 5973;
                }
                else if (averagePerson >= 10 && averagePerson <= 20)
                {
                    waterMoney = consumption * 7052;
                }
                else if (averagePerson >= 20 && averagePerson <= 30)
                {
                    waterMoney = consumption * 8699;
                }
                else if (averagePerson >= 30)
                {
                    waterMoney = consumption * 15929;
                }
            }
            else if (customertype == "Administration agency, public services")
            {
                waterMoney = consumption * 9955;
            }
            else if (customertype == "Production units")
            {
                waterMoney = consumption * 11615;
            }
            else if (customertype == "Business services")
            {
                waterMoney = consumption * 22068;
            }

            // Apply VAT tax

            waterMoney += (waterMoney * VAT);
            return (consumption, waterMoney);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            lv.Items.Clear();
            bool foundResult = false;

            if (search == "")
            {

                foreach (Invoice invoice in invoices)
                {
                    ListViewItem item = new ListViewItem(invoice.CustomerName);
                    item.SubItems.Add(invoice.LastMonthWater.ToString());
                    item.SubItems.Add(invoice.ThisMonthWater.ToString());
                    item.SubItems.Add(invoice.Consumption.ToString());
                    item.SubItems.Add(invoice.WaterMoney.ToString());
                    lv.Items.Add(item);
                }
                foundResult = true;
            }
            else
            {

                foreach (Invoice invoice in invoices)
                {
                    if (invoice.CustomerName.ToLower().Contains(search))
                    {
                        ListViewItem item = new ListViewItem(invoice.CustomerName);
                        item.SubItems.Add(invoice.LastMonthWater.ToString());
                        item.SubItems.Add(invoice.ThisMonthWater.ToString());
                        item.SubItems.Add(invoice.Consumption.ToString());
                        item.SubItems.Add(invoice.WaterMoney.ToString());
                        lv.Items.Add(item);
                        foundResult = true;
                    }
                }

            }
            if (!foundResult)
            {

                ListViewItem item = new ListViewItem("No results found.");
                lv.Items.Add(item);
            }
        }

        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lv.SelectedItems[0].Index;
            Invoice invoice = invoices[index];
            this.Hide();
            Form3 frm3 = new Form3(invoice.CustomerName, invoice.ThisMonthWater, invoice.LastMonthWater, invoice.WaterMoney, invoice.Consumption);
            frm3.ShowDialog();
        }

        private void groupboc_Enter(object sender, EventArgs e)
        {

        }

        private void btnshowbill_Click(object sender, EventArgs e)
        {
        }

        private void btnshowbill_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
public class Invoice
{
    public string CustomerName
    {
        get;
        set;
    }

    public double LastMonthWater
    {
        get;
        set;
    }

    public double ThisMonthWater
    {
        get;
        set;
    }

    public double Consumption
    {
        get;
        set;
    }

    public double WaterMoney
    {
        get;
        set;
    }

}


