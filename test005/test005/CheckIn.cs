using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

using System.Windows.Forms;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace test005
{                   
    [Serializable]
    public partial class CheckIn : Form
    {
        List<Patient> checkedInPatient = new List<Patient>();
        public string patientName, DOB, Address, Phonenum, SSN, Insurance, Email;

        public CheckIn()
        {
            InitializeComponent();
        }

        public void getCheckedin()
        {
           
        }

        private void ssn_TextChanged(object sender, EventArgs e)
        {
            this.SSN = ssn.Text;
        }

        private void checkin_button_Click(object sender, EventArgs e)
        {
         
            Patient patient = new Patient(this.patientName, this.DOB, this.Address, this.Phonenum, this.Email, this.SSN, this.Insurance);
            checkedInPatient.Add(patient);
            Console.WriteLine(this.patientName + " checked in \n");
            ClearTextBoxes();
            
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            exportPatient();
          
            this.Close();
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            this.Email = email.Text;
        }

        private void insurance_TextChanged(object sender, EventArgs e)
        {
            this.Insurance = insurance.Text;
        }

        private void phonenum_TextChanged(object sender, EventArgs e)
        {
            this.Phonenum = phonenum.Text;
        }

       

        private void address_TextChanged(object sender, EventArgs e)
        {
            this.Address = address.Text;
        }

        private void dob_TextChanged(object sender, EventArgs e)
        {
            this.DOB = dob.Text;
        }

        private void patient_name_TextChanged(object sender, EventArgs e)
        {
            this.patientName = patient_name.Text;
        }

        public void exportPatient()
        {
            string filePath = "patients.bin";
            bool append = false;

            if (File.Exists(filePath))
            {
                append = true;
            }
           
           using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
        {
            var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            binaryFormatter.Serialize(stream, checkedInPatient);
        }
            Console.WriteLine(checkedInPatient.Count + " patients exported.");
        }




    }
}
