namespace Sprint_2_GUI_Group1_1
{
    partial class CurrentOrderDisplay
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
            this.FIFO5 = new System.Windows.Forms.Label();
            this.FIFO4 = new System.Windows.Forms.Label();
            this.FIFO2 = new System.Windows.Forms.Label();
            this.FIFO3 = new System.Windows.Forms.Label();
            this.FIFO1 = new System.Windows.Forms.Label();
            this.ToMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FIFO5
            // 
            this.FIFO5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FIFO5.Location = new System.Drawing.Point(160, 256);
            this.FIFO5.Name = "FIFO5";
            this.FIFO5.Size = new System.Drawing.Size(300, 25);
            this.FIFO5.TabIndex = 9;
            this.FIFO5.Text = "Order #: null";
            // 
            // FIFO4
            // 
            this.FIFO4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FIFO4.Location = new System.Drawing.Point(160, 222);
            this.FIFO4.Name = "FIFO4";
            this.FIFO4.Size = new System.Drawing.Size(300, 25);
            this.FIFO4.TabIndex = 8;
            this.FIFO4.Text = "Order #: null";
            // 
            // FIFO2
            // 
            this.FIFO2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FIFO2.Location = new System.Drawing.Point(160, 154);
            this.FIFO2.Name = "FIFO2";
            this.FIFO2.Size = new System.Drawing.Size(300, 25);
            this.FIFO2.TabIndex = 7;
            this.FIFO2.Text = "Order #: null";
            // 
            // FIFO3
            // 
            this.FIFO3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FIFO3.Location = new System.Drawing.Point(160, 188);
            this.FIFO3.Name = "FIFO3";
            this.FIFO3.Size = new System.Drawing.Size(300, 25);
            this.FIFO3.TabIndex = 6;
            this.FIFO3.Text = "Order #: null";
            // 
            // FIFO1
            // 
            this.FIFO1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FIFO1.Location = new System.Drawing.Point(160, 119);
            this.FIFO1.Name = "FIFO1";
            this.FIFO1.Size = new System.Drawing.Size(300, 25);
            this.FIFO1.TabIndex = 5;
            this.FIFO1.Text = "Order #: null";
            // 
            // ToMainMenu
            // 
            this.ToMainMenu.Location = new System.Drawing.Point(585, 569);
            this.ToMainMenu.Name = "ToMainMenu";
            this.ToMainMenu.Size = new System.Drawing.Size(100, 60);
            this.ToMainMenu.TabIndex = 10;
            this.ToMainMenu.Text = "Main Menu";
            this.ToMainMenu.UseVisualStyleBackColor = true;
            this.ToMainMenu.Click += new System.EventHandler(this.ToMainMenu_Click);
            // 
            // CurrentOrderDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ToMainMenu);
            this.Controls.Add(this.FIFO5);
            this.Controls.Add(this.FIFO4);
            this.Controls.Add(this.FIFO2);
            this.Controls.Add(this.FIFO3);
            this.Controls.Add(this.FIFO1);
            this.Name = "CurrentOrderDisplay";
            this.Size = new System.Drawing.Size(1280, 720);
            this.ResumeLayout(false);

        }

        #endregion

        private Label FIFO5;
        private Label FIFO4;
        private Label FIFO2;
        private Label FIFO3;
        private Label FIFO1;
        private Button ToMainMenu;
    }
}
