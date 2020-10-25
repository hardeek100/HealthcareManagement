using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace test005
{
    public partial class Staff : Form
    {
        List<Patient> patients;
        //Patient[] checkedInPatient1 = new Patient[10];  // Array of checked in patients. 
        public Staff(){InitializeComponent();}




        /* Button handlers
         * */

        private void makeappbutton_Click(object sender, EventArgs e)
        {
            // Make appointment
            MakeAppointment ma = new MakeAppointment();
            ma.Show();
        }

        // Check in patient.
        private void checkinbutton_Click(object sender, EventArgs e)
        {
            CheckIn checkin = new CheckIn();
            checkin.Show();
        }

        // View checked in patients.

        private void viewbutton_Click(object sender, EventArgs e)
        {
            importPatient();
            if(patients == null)
            {
                Console.WriteLine("No patients to display");    
            }
            else
            {
                foreach (var patient in patients)
                {
                    Console.WriteLine(patient.getName());
                }
            }
        }

        // Delete files 

        private void deletebutton_Click(object sender, EventArgs e)
        {
            string filename = "checkedInPatients.dat";
            if (File.Exists(filename))
            {
                File.Delete(filename);
                Console.WriteLine("Files deleted");
            }
            else
            {
                Console.WriteLine("Cannot find file " + filename);
            }
        }

        //-----------------------------------End of buttons-----------------------------------------------------

        // Import files
        private void importPatient()
        {
            string filePath = "patients.bin";
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
              
                List<Patient> patients =  (List<Patient>)binaryFormatter.Deserialize(stream);
            }

        }
       


    }
}
