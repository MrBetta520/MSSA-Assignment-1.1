using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meteorbucks
{
    public partial class Hot_Coffee_Checkout : Form
    {
        public Hot_Coffee_Checkout()
        {
            InitializeComponent();
        }

        private void Hot_Coffee_Checkout_Load(object sender, EventArgs e)
        {
            Coffee newCoffee = new Coffee();

            comboBoxSize.DataSource = Enum.GetValues(typeof(Size));
            comboBoxMilk.DataSource = Enum.GetValues(typeof(Milk));
            comboBoxTemp.DataSource = Enum.GetValues(typeof(Temp));
            comboBoxTopping.DataSource = Enum.GetValues(typeof(Topping));
            
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            lblPrice.Text = Convert.ToString("$ " + (0.088 * 5 + 5));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order o = new Order();
            o.Show();
        }
    }
}
