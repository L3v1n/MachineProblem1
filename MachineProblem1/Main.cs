//Collaborated work by: BCC//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineProblem1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }        
        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void btnPropa_MouseCaptureChanged(object sender, EventArgs e)
        {
            PropaCalcu f2 = new PropaCalcu();
            f2.Show();
            this.Hide();
        }
        private void btnApprox_MouseClick(object sender, MouseEventArgs e)
        {
            ApproxCalcu f3 = new ApproxCalcu();
            f3.Show();
            this.Hide();
        }
        private void btnBack_MouseClick(object sender, MouseEventArgs e)
        {
            if (MessageBox.Show("Do you want to quit?", "Quit application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }            
        }

    }
}
