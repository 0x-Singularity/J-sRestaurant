namespace Sprint_2_GUI_Group1_1
{
    partial class CustomizationMenu
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
            this.CustomizationButton1 = new System.Windows.Forms.Button();
            this.CustomizationButton2 = new System.Windows.Forms.Button();
            this.CustomizationButton3 = new System.Windows.Forms.Button();
            this.CustomizationButton4 = new System.Windows.Forms.Button();
            this.CustomizationButton5 = new System.Windows.Forms.Button();
            this.MenuLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomizationButton1
            // 
            this.CustomizationButton1.Location = new System.Drawing.Point(3, 3);
            this.CustomizationButton1.Name = "CustomizationButton1";
            this.CustomizationButton1.Size = new System.Drawing.Size(175, 175);
            this.CustomizationButton1.TabIndex = 0;
            this.CustomizationButton1.Text = "EmptyItem1";
            this.CustomizationButton1.UseMnemonic = false;
            this.CustomizationButton1.UseVisualStyleBackColor = true;
            this.CustomizationButton1.Click += new System.EventHandler(this.CustomizationButton1_Click);
            // 
            // CustomizationButton2
            // 
            this.CustomizationButton2.Location = new System.Drawing.Point(184, 3);
            this.CustomizationButton2.Name = "CustomizationButton2";
            this.CustomizationButton2.Size = new System.Drawing.Size(175, 175);
            this.CustomizationButton2.TabIndex = 1;
            this.CustomizationButton2.Text = "EmptyItem2";
            this.CustomizationButton2.UseMnemonic = false;
            this.CustomizationButton2.UseVisualStyleBackColor = true;
            this.CustomizationButton2.Click += new System.EventHandler(this.CustomizationButton2_Click);
            // 
            // CustomizationButton3
            // 
            this.CustomizationButton3.Location = new System.Drawing.Point(365, 3);
            this.CustomizationButton3.Name = "CustomizationButton3";
            this.CustomizationButton3.Size = new System.Drawing.Size(175, 175);
            this.CustomizationButton3.TabIndex = 2;
            this.CustomizationButton3.Text = "EmptyItem3";
            this.CustomizationButton3.UseMnemonic = false;
            this.CustomizationButton3.UseVisualStyleBackColor = true;
            this.CustomizationButton3.Click += new System.EventHandler(this.CustomizationButton3_Click);
            // 
            // CustomizationButton4
            // 
            this.CustomizationButton4.Location = new System.Drawing.Point(3, 184);
            this.CustomizationButton4.Name = "CustomizationButton4";
            this.CustomizationButton4.Size = new System.Drawing.Size(175, 175);
            this.CustomizationButton4.TabIndex = 3;
            this.CustomizationButton4.Text = "EmptyItem4";
            this.CustomizationButton4.UseMnemonic = false;
            this.CustomizationButton4.UseVisualStyleBackColor = true;
            this.CustomizationButton4.Click += new System.EventHandler(this.CustomizationButton4_Click);
            // 
            // CustomizationButton5
            // 
            this.CustomizationButton5.Location = new System.Drawing.Point(184, 184);
            this.CustomizationButton5.Name = "CustomizationButton5";
            this.CustomizationButton5.Size = new System.Drawing.Size(175, 175);
            this.CustomizationButton5.TabIndex = 4;
            this.CustomizationButton5.Text = "EmptyItem5";
            this.CustomizationButton5.UseMnemonic = false;
            this.CustomizationButton5.UseVisualStyleBackColor = true;
            this.CustomizationButton5.Click += new System.EventHandler(this.CustomizationButton5_Click);
            // 
            // MenuLabel
            // 
            this.MenuLabel.Location = new System.Drawing.Point(200, 470);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(150, 20);
            this.MenuLabel.TabIndex = 5;
            this.MenuLabel.Text = "EmptyCategory";
            this.MenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MenuLabel.UseMnemonic = false;
            // 
            // CustomizationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.MenuLabel);
            this.Controls.Add(this.CustomizationButton5);
            this.Controls.Add(this.CustomizationButton4);
            this.Controls.Add(this.CustomizationButton3);
            this.Controls.Add(this.CustomizationButton2);
            this.Controls.Add(this.CustomizationButton1);
            this.Name = "CustomizationMenu";
            this.Size = new System.Drawing.Size(550, 550);
            this.ResumeLayout(false);

        }

        #endregion

        private Button CustomizationButton1;
        private Button CustomizationButton2;
        private Button CustomizationButton3;
        private Button CustomizationButton4;
        private Button CustomizationButton5;
        private Label MenuLabel;
    }
}
