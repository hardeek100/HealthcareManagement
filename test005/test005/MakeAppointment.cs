﻿using System;
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
    public partial class MakeAppointment : Form
    {
        public MakeAppointment()
        {
            InitializeComponent();
            monthCalendar1.BoldedDates = new System.DateTime[] { new System.DateTime(2020, 10, 21, 0, 0, 0, 0),
                                                                 new System.DateTime(2020, 10, 22, 0,0,0,0)};
        }

        private void scheduledisplay_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
