using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test005
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void staffbutton_Click(object sender, EventArgs e)
        {
            Staff stf = new Staff();
            stf.Show();
        }

        private void docbutton_Click(object sender, EventArgs e)
        {
            Doctor doc = new Doctor();
            doc.Show();
        }

        private void nursebutton_Click(object sender, EventArgs e)
        {
            Nurse nurse = new Nurse();
            nurse.Show();
        }

        private void ceobutton_Click(object sender, EventArgs e)
        {
            CEO ceo = new CEO();
            ceo.Show();
        }
    }
}
