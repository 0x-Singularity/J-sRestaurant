namespace Sprint_2_GUI_Group1_1
{
    partial class EmployeeInfoReader
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
            this.WhereFile = new System.Windows.Forms.Label();
            this.Filename = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WhereFile
            // 
            this.WhereFile.AutoEllipsis = true;
            this.WhereFile.Location = new System.Drawing.Point(390, 265);
            this.WhereFile.Name = "WhereFile";
            this.WhereFile.Size = new System.Drawing.Size(500, 50);
            this.WhereFile.TabIndex = 6;
            this.WhereFile.Text = "What is the file path to Employee Information (.txt)?";
            this.WhereFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WhereFile.UseMnemonic = false;
            // 
            // Filename
            // 
            this.Filename.Location = new System.Drawing.Point(540, 325);
            this.Filename.Name = "Filename";
            this.Filename.Size = new System.Drawing.Size(200, 27);
            this.Filename.TabIndex = 5;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(590, 375);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(100, 100);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sprint_2_GUI_Group1_1.Properties.Resources.BlackWavesResized;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1280, 722);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // EmployeeInfoReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WhereFile);
            this.Controls.Add(this.Filename);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EmployeeInfoReader";
            this.Size = new System.Drawing.Size(1280, 720);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label WhereFile;
        private TextBox Filename;
        private Button Submit;
        private PictureBox pictureBox1;
    }
}
