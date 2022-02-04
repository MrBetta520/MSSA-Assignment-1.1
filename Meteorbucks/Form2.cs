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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        

        private void btnHotCoffee_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            Hot_Coffee_Checkout coffeeCheck = new Hot_Coffee_Checkout();
            coffeeCheck.Show();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.Show();
        }
    }
}
