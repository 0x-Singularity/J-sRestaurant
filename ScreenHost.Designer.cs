namespace Sprint_2_Group_1_1
{
    partial class ScreenHost
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
            this.DisplayPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.BackColor = System.Drawing.SystemColors.Control;
            this.DisplayPanel.Location = new System.Drawing.Point(100, 100);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.Size = new System.Drawing.Size(1080, 520);
            this.DisplayPanel.TabIndex = 0;
            // 
            // ScreenHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.DisplayPanel);
            this.Name = "ScreenHost";
            this.Text = "J\'s Restaurant";
            this.Load += new System.EventHandler(this.ScreenHost_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel DisplayPanel;
    }
}