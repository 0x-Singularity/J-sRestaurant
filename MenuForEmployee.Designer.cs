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
            this.DiningFloor = new System.Windows.Forms.Button();
            this.ShowCurrentEmployee = new System.Windows.Forms.Label();
            this.ToMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(651, 96);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(120, 120);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // DiningFloor
            // 
            this.DiningFloor.Location = new System.Drawing.Point(815, 96);
            this.DiningFloor.Name = "DiningFloor";
            this.DiningFloor.Size = new System.Drawing.Size(120, 120);
            this.DiningFloor.TabIndex = 1;
            this.DiningFloor.Text = "Dining Room";
            this.DiningFloor.UseVisualStyleBackColor = true;
            this.DiningFloor.Click += new System.EventHandler(this.Orders_Click);
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
            // ToMainMenu
            // 
            this.ToMainMenu.Location = new System.Drawing.Point(651, 253);
            this.ToMainMenu.Name = "ToMainMenu";
            this.ToMainMenu.Size = new System.Drawing.Size(120, 120);
            this.ToMainMenu.TabIndex = 3;
            this.ToMainMenu.Text = "button1";
            this.ToMainMenu.UseVisualStyleBackColor = true;
            // 
            // MenuForEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.ToMainMenu);
            this.Controls.Add(this.ShowCurrentEmployee);
            this.Controls.Add(this.DiningFloor);
            this.Controls.Add(this.Login);
            this.Name = "MenuForEmployee";
            this.Size = new System.Drawing.Size(1080, 520);
            this.ResumeLayout(false);

        }

        #endregion

        private Button Login;
        private Button DiningFloor;
        private Label ShowCurrentEmployee;
        private Button ToMainMenu;
    }
}
