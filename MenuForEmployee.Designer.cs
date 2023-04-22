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
            this.ToCurrentOrders = new System.Windows.Forms.Button();
            this.GraphOfTheDay = new System.Windows.Forms.PictureBox();
            this.ToManagerLogin = new System.Windows.Forms.Button();
            this.BackgroundEmployeeMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GraphOfTheDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundEmployeeMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(689, 171);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(190, 190);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // DiningFloor
            // 
            this.DiningFloor.Location = new System.Drawing.Point(885, 171);
            this.DiningFloor.Name = "DiningFloor";
            this.DiningFloor.Size = new System.Drawing.Size(190, 190);
            this.DiningFloor.TabIndex = 1;
            this.DiningFloor.Text = "Dining Room";
            this.DiningFloor.UseVisualStyleBackColor = true;
            this.DiningFloor.Click += new System.EventHandler(this.DiningFloor_Click);
            // 
            // ShowCurrentEmployee
            // 
            this.ShowCurrentEmployee.BackColor = System.Drawing.SystemColors.Control;
            this.ShowCurrentEmployee.Location = new System.Drawing.Point(490, 75);
            this.ShowCurrentEmployee.Name = "ShowCurrentEmployee";
            this.ShowCurrentEmployee.Size = new System.Drawing.Size(300, 25);
            this.ShowCurrentEmployee.TabIndex = 2;
            this.ShowCurrentEmployee.Text = "Current Employee: Not Logged In";
            this.ShowCurrentEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToCurrentOrders
            // 
            this.ToCurrentOrders.Location = new System.Drawing.Point(689, 367);
            this.ToCurrentOrders.Name = "ToCurrentOrders";
            this.ToCurrentOrders.Size = new System.Drawing.Size(190, 190);
            this.ToCurrentOrders.TabIndex = 3;
            this.ToCurrentOrders.Text = "Current Orders";
            this.ToCurrentOrders.UseVisualStyleBackColor = true;
            this.ToCurrentOrders.Click += new System.EventHandler(this.ToCurrentOrders_Click);
            // 
            // GraphOfTheDay
            // 
            this.GraphOfTheDay.Image = global::Sprint_2_GUI_Group1_1.Properties.Resources.Picture_of_Graph_of_Orders;
            this.GraphOfTheDay.Location = new System.Drawing.Point(129, 171);
            this.GraphOfTheDay.Name = "GraphOfTheDay";
            this.GraphOfTheDay.Size = new System.Drawing.Size(540, 385);
            this.GraphOfTheDay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GraphOfTheDay.TabIndex = 4;
            this.GraphOfTheDay.TabStop = false;
            // 
            // ToManagerLogin
            // 
            this.ToManagerLogin.Location = new System.Drawing.Point(885, 367);
            this.ToManagerLogin.Name = "ToManagerLogin";
            this.ToManagerLogin.Size = new System.Drawing.Size(190, 190);
            this.ToManagerLogin.TabIndex = 5;
            this.ToManagerLogin.Text = "Manager Login";
            this.ToManagerLogin.UseVisualStyleBackColor = true;
            // 
            // BackgroundEmployeeMenu
            // 
            this.BackgroundEmployeeMenu.Image = global::Sprint_2_GUI_Group1_1.Properties.Resources.BlackWavesResized;
            this.BackgroundEmployeeMenu.Location = new System.Drawing.Point(0, 0);
            this.BackgroundEmployeeMenu.Name = "BackgroundEmployeeMenu";
            this.BackgroundEmployeeMenu.Size = new System.Drawing.Size(1280, 722);
            this.BackgroundEmployeeMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackgroundEmployeeMenu.TabIndex = 6;
            this.BackgroundEmployeeMenu.TabStop = false;
            // 
            // MenuForEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.ToManagerLogin);
            this.Controls.Add(this.GraphOfTheDay);
            this.Controls.Add(this.ToCurrentOrders);
            this.Controls.Add(this.ShowCurrentEmployee);
            this.Controls.Add(this.DiningFloor);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.BackgroundEmployeeMenu);
            this.Name = "MenuForEmployee";
            this.Size = new System.Drawing.Size(1280, 720);
            ((System.ComponentModel.ISupportInitialize)(this.GraphOfTheDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundEmployeeMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Login;
        private Button DiningFloor;
        private Label ShowCurrentEmployee;
        private Button ToCurrentOrders;
        private PictureBox GraphOfTheDay;
        private Button ToManagerLogin;
        private PictureBox BackgroundEmployeeMenu;
    }
}
