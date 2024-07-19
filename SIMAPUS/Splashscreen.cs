using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMAPUS
{
    public partial class Splashscreen : Form
    {
        byte count = 0;
        public Splashscreen()
        {
            InitializeComponent();
        }

        private void Splashscreen_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count > 3)
            {
                timer1.Enabled = false;
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}
