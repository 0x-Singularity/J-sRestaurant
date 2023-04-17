namespace Sprint_2_GUI_Group1_1
{
    partial class OrderDisplay
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
            this.BackToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackToMenu
            // 
            this.BackToMenu.Location = new System.Drawing.Point(882, 95);
            this.BackToMenu.Name = "BackToMenu";
            this.BackToMenu.Size = new System.Drawing.Size(100, 50);
            this.BackToMenu.TabIndex = 0;
            this.BackToMenu.Text = "Main Menu";
            this.BackToMenu.UseVisualStyleBackColor = true;
            this.BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // OrderDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BackToMenu);
            this.Name = "OrderDisplay";
            this.Size = new System.Drawing.Size(1080, 520);
            this.ResumeLayout(false);

        }

        #endregion

        private Button BackToMenu;
    }
}
