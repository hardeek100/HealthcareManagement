using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test005
{
    [Serializable]
    class Patient
    {
        protected string name, dob, address, phoneNo, email, ssn, insurance;

        public Patient(string name, string dob, string address, string phoneNo, string email, string ssn, string insurance)
        {
            this.name = name;
            this.dob = dob;
            this.address = address;
            this.phoneNo = phoneNo;
            this.email = email;
            this.ssn = ssn;
            this.insurance = insurance;
        }

        public string getName() { return this.name; }
        public string getdob() { return this.dob; }
        public string getphoneNo() { return this.phoneNo; }
        public string getemail() { return this.email; }
        public string getssn() { return this.ssn; }
        public string getinsurance() { return this.insurance; }


    }
}
