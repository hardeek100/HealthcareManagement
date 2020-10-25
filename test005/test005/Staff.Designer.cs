namespace test005
{
    partial class Staff
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
            this.makeappbutton = new System.Windows.Forms.Button();
            this.changeappointmentbutton = new System.Windows.Forms.Button();
            this.checkinbutton = new System.Windows.Forms.Button();
            this.paybutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.viewbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // makeappbutton
            // 
            this.makeappbutton.Location = new System.Drawing.Point(235, 142);
            this.makeappbutton.Name = "makeappbutton";
            this.makeappbutton.Size = new System.Drawing.Size(310, 92);
            this.makeappbutton.TabIndex = 0;
            this.makeappbutton.Text = "Make Appointment";
            this.makeappbutton.UseVisualStyleBackColor = true;
            this.makeappbutton.Click += new System.EventHandler(this.makeappbutton_Click);
            // 
            // changeappointmentbutton
            // 
            this.changeappointmentbutton.Location = new System.Drawing.Point(235, 240);
            this.changeappointmentbutton.Name = "changeappointmentbutton";
            this.changeappointmentbutton.Size = new System.Drawing.Size(310, 80);
            this.changeappointmentbutton.TabIndex = 1;
            this.changeappointmentbutton.Text = "Change Appointmemt";
            this.changeappointmentbutton.UseVisualStyleBackColor = true;
            // 
            // checkinbutton
            // 
            this.checkinbutton.Location = new System.Drawing.Point(235, 315);
            this.checkinbutton.Name = "checkinbutton";
            this.checkinbutton.Size = new System.Drawing.Size(310, 80);
            this.checkinbutton.TabIndex = 2;
            this.checkinbutton.Text = "Checkin Patient";
            this.checkinbutton.UseVisualStyleBackColor = true;
            this.checkinbutton.Click += new System.EventHandler(this.checkinbutton_Click);
            // 
            // paybutton
            // 
            this.paybutton.Location = new System.Drawing.Point(235, 401);
            this.paybutton.Name = "paybutton";
            this.paybutton.Size = new System.Drawing.Size(310, 80);
            this.paybutton.TabIndex = 3;
            this.paybutton.Text = "Pay Medical Fee";
            this.paybutton.UseVisualStyleBackColor = true;
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(235, 487);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(310, 80);
            this.cancelbutton.TabIndex = 4;
            this.cancelbutton.Text = "Cancel Appointment";
            this.cancelbutton.UseVisualStyleBackColor = true;
            // 
            // viewbutton
            // 
            this.viewbutton.Location = new System.Drawing.Point(235, 573);
            this.viewbutton.Name = "viewbutton";
            this.viewbutton.Size = new System.Drawing.Size(310, 80);
            this.viewbutton.TabIndex = 5;
            this.viewbutton.Text = "View Checked In";
            this.viewbutton.UseVisualStyleBackColor = true;
            this.viewbutton.Click += new System.EventHandler(this.viewbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(26, 573);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(173, 65);
            this.deletebutton.TabIndex = 6;
            this.deletebutton.Text = "Delete files";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 740);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.viewbutton);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.paybutton);
            this.Controls.Add(this.checkinbutton);
            this.Controls.Add(this.changeappointmentbutton);
            this.Controls.Add(this.makeappbutton);
            this.Name = "Staff";
            this.Text = "Staff";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button makeappbutton;
        private System.Windows.Forms.Button changeappointmentbutton;
        private System.Windows.Forms.Button checkinbutton;
        private System.Windows.Forms.Button paybutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button viewbutton;
        private System.Windows.Forms.Button deletebutton;
    }
}