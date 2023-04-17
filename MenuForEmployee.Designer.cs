namespace Sprint_2_GUI_Group1_1
{
    partial class MenuForEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login = new System.Windows.Forms.Button();
            this.Orders = new System.Windows.Forms.Button();
            this.ShowCurrentEmployee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(772, 123);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(94, 29);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Orders
            // 
            this.Orders.Location = new System.Drawing.Point(769, 201);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(94, 29);
            this.Orders.TabIndex = 1;
            this.Orders.Text = "Orders";
            this.Orders.UseVisualStyleBackColor = true;
            this.Orders.Click += new System.EventHandler(this.Orders_Click);
            // 
            // ShowCurrentEmployee
            // 
            this.ShowCurrentEmployee.Location = new System.Drawing.Point(440, 40);
            this.ShowCurrentEmployee.Name = "ShowCurrentEmployee";
            this.ShowCurrentEmployee.Size = new System.Drawing.Size(200, 25);
            this.ShowCurrentEmployee.TabIndex = 2;
            this.ShowCurrentEmployee.Text = "Current Employee:";
            this.ShowCurrentEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuForEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ShowCurrentEmployee);
            this.Controls.Add(this.Orders);
            this.Controls.Add(this.Login);
            this.Name = "MenuForEmployee";
            this.Size = new System.Drawing.Size(1080, 520);
            this.ResumeLayout(false);

        }

        #endregion

        private Button Login;
        private Button Orders;
        private Label ShowCurrentEmployee;
    }
}
