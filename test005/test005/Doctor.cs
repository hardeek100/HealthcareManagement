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
    

    public partial class Doctor : Form
    {
        protected string password;
        public string name, username;
        struct schedule
        {
            string day;
            string time_in;
            string time_out;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public Doctor()
        {
            InitializeComponent();
        }
    }
}
