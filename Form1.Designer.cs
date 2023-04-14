namespace Sprint_2_ISWE_Group_1_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubmitLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SubmitLogin);
            this.panel1.Location = new System.Drawing.Point(196, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 330);
            this.panel1.TabIndex = 0;
            // 
            // SubmitLogin
            // 
            this.SubmitLogin.Location = new System.Drawing.Point(135, 269);
            this.SubmitLogin.Name = "SubmitLogin";
            this.SubmitLogin.Size = new System.Drawing.Size(94, 29);
            this.SubmitLogin.TabIndex = 0;
            this.SubmitLogin.Text = "Login";
            this.SubmitLogin.UseVisualStyleBackColor = true;
            this.SubmitLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button SubmitLogin;
    }
}