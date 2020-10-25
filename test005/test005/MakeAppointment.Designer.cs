namespace test005
{
    partial class MakeAppointment
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
            this.docusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.schedulebutton = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // docusername
            // 
            this.docusername.Location = new System.Drawing.Point(294, 96);
            this.docusername.Name = "docusername";
            this.docusername.Size = new System.Drawing.Size(353, 38);
            this.docusername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doctor\'s Username";
            // 
            // schedulebutton
            // 
            this.schedulebutton.Location = new System.Drawing.Point(0, 0);
            this.schedulebutton.Name = "schedulebutton";
            this.schedulebutton.Size = new System.Drawing.Size(75, 23);
            this.schedulebutton.TabIndex = 4;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(55, 212);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // MakeAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 920);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.schedulebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.docusername);
            this.Name = "MakeAppointment";
            this.Text = "MakeAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox docusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button schedulebutton;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}