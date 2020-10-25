namespace test005
{
    partial class CheckIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.patient_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.phonenum = new System.Windows.Forms.TextBox();
            this.ssn = new System.Windows.Forms.TextBox();
            this.insurance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.checkin_button = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patient_name
            // 
            this.patient_name.Location = new System.Drawing.Point(313, 72);
            this.patient_name.Name = "patient_name";
            this.patient_name.Size = new System.Drawing.Size(268, 38);
            this.patient_name.TabIndex = 0;
            this.patient_name.TextChanged += new System.EventHandler(this.patient_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(313, 143);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(268, 38);
            this.dob.TabIndex = 2;
            this.dob.TextChanged += new System.EventHandler(this.dob_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "DOB(mm-dd-yyyy)";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(313, 208);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(268, 38);
            this.address.TabIndex = 4;
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 638);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 32);
            this.label5.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "Health Insurance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 32);
            this.label7.TabIndex = 9;
            this.label7.Text = "SSN";
            // 
            // phonenum
            // 
            this.phonenum.Location = new System.Drawing.Point(313, 276);
            this.phonenum.Name = "phonenum";
            this.phonenum.Size = new System.Drawing.Size(268, 38);
            this.phonenum.TabIndex = 10;
            this.phonenum.TextChanged += new System.EventHandler(this.phonenum_TextChanged);
            // 
            // ssn
            // 
            this.ssn.Location = new System.Drawing.Point(313, 335);
            this.ssn.Name = "ssn";
            this.ssn.Size = new System.Drawing.Size(268, 38);
            this.ssn.TabIndex = 11;
            this.ssn.TextChanged += new System.EventHandler(this.ssn_TextChanged);
            // 
            // insurance
            // 
            this.insurance.Location = new System.Drawing.Point(313, 397);
            this.insurance.Name = "insurance";
            this.insurance.Size = new System.Drawing.Size(268, 38);
            this.insurance.TabIndex = 12;
            this.insurance.TextChanged += new System.EventHandler(this.insurance_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 460);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 32);
            this.label8.TabIndex = 13;
            this.label8.Text = "Email";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(313, 460);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(268, 38);
            this.email.TabIndex = 14;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // checkin_button
            // 
            this.checkin_button.Location = new System.Drawing.Point(149, 603);
            this.checkin_button.Name = "checkin_button";
            this.checkin_button.Size = new System.Drawing.Size(166, 67);
            this.checkin_button.TabIndex = 16;
            this.checkin_button.Text = "Check-In";
            this.checkin_button.UseVisualStyleBackColor = true;
            this.checkin_button.Click += new System.EventHandler(this.checkin_button_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(457, 603);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(166, 67);
            this.cancelbutton.TabIndex = 17;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 770);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.checkin_button);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.insurance);
            this.Controls.Add(this.ssn);
            this.Controls.Add(this.phonenum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patient_name);
            this.Name = "CheckIn";
            this.Text = "CheckIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox patient_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phonenum;
        private System.Windows.Forms.TextBox ssn;
        private System.Windows.Forms.TextBox insurance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button checkin_button;
        private System.Windows.Forms.Button cancelbutton;
    }
}