namespace Sprint_2_GUI_Group1_1
{
    partial class OrderOverview
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
            this.ToMainMenu = new System.Windows.Forms.Button();
            this.OrderNumberDisplay = new System.Windows.Forms.Label();
            this.SubMenuPanel = new System.Windows.Forms.Panel();
            this.BackgroundOrderOverview = new System.Windows.Forms.PictureBox();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.ToDiningRoom = new System.Windows.Forms.Button();
            this.TableDisplay = new System.Windows.Forms.Button();
            this.OrderItemNames = new System.Windows.Forms.Label();
            this.OrderItemPrices = new System.Windows.Forms.Label();
            this.SendToKitchen = new System.Windows.Forms.Button();
            this.TipDisplay = new System.Windows.Forms.Label();
            this.TotalDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundOrderOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // ToMainMenu
            // 
            this.ToMainMenu.Location = new System.Drawing.Point(905, 620);
            this.ToMainMenu.Name = "ToMainMenu";
            this.ToMainMenu.Size = new System.Drawing.Size(100, 69);
            this.ToMainMenu.TabIndex = 0;
            this.ToMainMenu.Text = "Main Menu";
            this.ToMainMenu.UseVisualStyleBackColor = true;
            this.ToMainMenu.Click += new System.EventHandler(this.ToMainMenu_Click);
            // 
            // OrderNumberDisplay
            // 
            this.OrderNumberDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.OrderNumberDisplay.Location = new System.Drawing.Point(3, 3);
            this.OrderNumberDisplay.Name = "OrderNumberDisplay";
            this.OrderNumberDisplay.Size = new System.Drawing.Size(370, 20);
            this.OrderNumberDisplay.TabIndex = 3;
            // 
            // SubMenuPanel
            // 
            this.SubMenuPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SubMenuPanel.Location = new System.Drawing.Point(680, 50);
            this.SubMenuPanel.Name = "SubMenuPanel";
            this.SubMenuPanel.Size = new System.Drawing.Size(550, 550);
            this.SubMenuPanel.TabIndex = 4;
            // 
            // BackgroundOrderOverview
            // 
            this.BackgroundOrderOverview.Image = global::Sprint_2_GUI_Group1_1.Properties.Resources.BlackWavesResized;
            this.BackgroundOrderOverview.Location = new System.Drawing.Point(0, 0);
            this.BackgroundOrderOverview.Name = "BackgroundOrderOverview";
            this.BackgroundOrderOverview.Size = new System.Drawing.Size(1280, 722);
            this.BackgroundOrderOverview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackgroundOrderOverview.TabIndex = 5;
            this.BackgroundOrderOverview.TabStop = false;
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(373, 3);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(210, 20);
            this.EmployeeNameLabel.TabIndex = 6;
            // 
            // ToDiningRoom
            // 
            this.ToDiningRoom.Location = new System.Drawing.Point(181, 620);
            this.ToDiningRoom.Name = "ToDiningRoom";
            this.ToDiningRoom.Size = new System.Drawing.Size(100, 69);
            this.ToDiningRoom.TabIndex = 7;
            this.ToDiningRoom.Text = "Dining Room";
            this.ToDiningRoom.UseVisualStyleBackColor = true;
            this.ToDiningRoom.Click += new System.EventHandler(this.ToDiningRoom_Click);
            // 
            // TableDisplay
            // 
            this.TableDisplay.Location = new System.Drawing.Point(75, 620);
            this.TableDisplay.Name = "TableDisplay";
            this.TableDisplay.Size = new System.Drawing.Size(100, 69);
            this.TableDisplay.TabIndex = 8;
            this.TableDisplay.Text = "TableYX";
            this.TableDisplay.UseVisualStyleBackColor = true;
            // 
            // OrderItemNames
            // 
            this.OrderItemNames.BackColor = System.Drawing.SystemColors.ControlDark;
            this.OrderItemNames.Location = new System.Drawing.Point(50, 50);
            this.OrderItemNames.Name = "OrderItemNames";
            this.OrderItemNames.Size = new System.Drawing.Size(220, 300);
            this.OrderItemNames.TabIndex = 9;
            this.OrderItemNames.UseMnemonic = false;
            // 
            // OrderItemPrices
            // 
            this.OrderItemPrices.BackColor = System.Drawing.SystemColors.ControlDark;
            this.OrderItemPrices.Location = new System.Drawing.Point(270, 50);
            this.OrderItemPrices.Name = "OrderItemPrices";
            this.OrderItemPrices.Size = new System.Drawing.Size(220, 300);
            this.OrderItemPrices.TabIndex = 10;
            this.OrderItemPrices.UseMnemonic = false;
            // 
            // SendToKitchen
            // 
            this.SendToKitchen.Location = new System.Drawing.Point(287, 620);
            this.SendToKitchen.Name = "SendToKitchen";
            this.SendToKitchen.Size = new System.Drawing.Size(100, 69);
            this.SendToKitchen.TabIndex = 11;
            this.SendToKitchen.Text = "Send and Pay";
            this.SendToKitchen.UseVisualStyleBackColor = true;
            this.SendToKitchen.Click += new System.EventHandler(this.SendToKitchen_Click);
            // 
            // TipDisplay
            // 
            this.TipDisplay.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TipDisplay.Location = new System.Drawing.Point(50, 375);
            this.TipDisplay.Name = "TipDisplay";
            this.TipDisplay.Size = new System.Drawing.Size(220, 220);
            this.TipDisplay.TabIndex = 12;
            this.TipDisplay.UseMnemonic = false;
            // 
            // TotalDisplay
            // 
            this.TotalDisplay.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TotalDisplay.Location = new System.Drawing.Point(270, 375);
            this.TotalDisplay.Name = "TotalDisplay";
            this.TotalDisplay.Size = new System.Drawing.Size(220, 220);
            this.TotalDisplay.TabIndex = 13;
            this.TotalDisplay.UseMnemonic = false;
            // 
            // OrderOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TotalDisplay);
            this.Controls.Add(this.TipDisplay);
            this.Controls.Add(this.SendToKitchen);
            this.Controls.Add(this.OrderItemPrices);
            this.Controls.Add(this.OrderItemNames);
            this.Controls.Add(this.TableDisplay);
            this.Controls.Add(this.ToDiningRoom);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.SubMenuPanel);
            this.Controls.Add(this.OrderNumberDisplay);
            this.Controls.Add(this.ToMainMenu);
            this.Controls.Add(this.BackgroundOrderOverview);
            this.Name = "OrderOverview";
            this.Size = new System.Drawing.Size(1280, 720);
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundOrderOverview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button ToMainMenu;
        private Label OrderNumberDisplay;
        private Panel SubMenuPanel;
        private PictureBox BackgroundOrderOverview;
        private Label EmployeeNameLabel;
        private Button ToDiningRoom;
        private Button TableDisplay;
        private Label OrderItemNames;
        private Label OrderItemPrices;
        private Button SendToKitchen;
        private Label TipDisplay;
        private Label TotalDisplay;
    }
}
