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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order o = new Order();
            o.Show();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Feedback fb = new Feedback();
            fb.Show();
        }
    }
}
