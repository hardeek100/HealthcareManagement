namespace test005
{
    partial class welcome
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
            this.staffbutton = new System.Windows.Forms.Button();
            this.nursebutton = new System.Windows.Forms.Button();
            this.docbutton = new System.Windows.Forms.Button();
            this.ceobutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // staffbutton
            // 
            this.staffbutton.Location = new System.Drawing.Point(129, 140);
            this.staffbutton.Name = "staffbutton";
            this.staffbutton.Size = new System.Drawing.Size(205, 133);
            this.staffbutton.TabIndex = 0;
            this.staffbutton.Text = "Staff";
            this.staffbutton.UseVisualStyleBackColor = true;
            this.staffbutton.Click += new System.EventHandler(this.staffbutton_Click);
            // 
            // nursebutton
            // 
            this.nursebutton.Location = new System.Drawing.Point(578, 149);
            this.nursebutton.Name = "nursebutton";
            this.nursebutton.Size = new System.Drawing.Size(210, 124);
            this.nursebutton.TabIndex = 1;
            this.nursebutton.Text = "Nurse";
            this.nursebutton.UseVisualStyleBackColor = true;
            this.nursebutton.Click += new System.EventHandler(this.nursebutton_Click);
            // 
            // docbutton
            // 
            this.docbutton.Location = new System.Drawing.Point(129, 430);
            this.docbutton.Name = "docbutton";
            this.docbutton.Size = new System.Drawing.Size(205, 133);
            this.docbutton.TabIndex = 2;
            this.docbutton.Text = "Doctor";
            this.docbutton.UseVisualStyleBackColor = true;
            this.docbutton.Click += new System.EventHandler(this.docbutton_Click);
            // 
            // ceobutton
            // 
            this.ceobutton.Location = new System.Drawing.Point(583, 430);
            this.ceobutton.Name = "ceobutton";
            this.ceobutton.Size = new System.Drawing.Size(205, 133);
            this.ceobutton.TabIndex = 3;
            this.ceobutton.Text = "CEO";
            this.ceobutton.UseVisualStyleBackColor = true;
            this.ceobutton.Click += new System.EventHandler(this.ceobutton_Click);
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 784);
            this.Controls.Add(this.ceobutton);
            this.Controls.Add(this.docbutton);
            this.Controls.Add(this.nursebutton);
            this.Controls.Add(this.staffbutton);
            this.Name = "welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button staffbutton;
        private System.Windows.Forms.Button nursebutton;
        private System.Windows.Forms.Button docbutton;
        private System.Windows.Forms.Button ceobutton;
    }
}

