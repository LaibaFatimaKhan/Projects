namespace RestaurantManagement
{
    partial class StaffUnPriv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffUnPriv));
            this.button_SearchOrder = new System.Windows.Forms.Button();
            this.button_AddOrder = new System.Windows.Forms.Button();
            this.button_BackToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_SearchOrder
            // 
            this.button_SearchOrder.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_SearchOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_SearchOrder.BackgroundImage")));
            this.button_SearchOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_SearchOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SearchOrder.Location = new System.Drawing.Point(137, 342);
            this.button_SearchOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_SearchOrder.Name = "button_SearchOrder";
            this.button_SearchOrder.Size = new System.Drawing.Size(149, 61);
            this.button_SearchOrder.TabIndex = 10;
            this.button_SearchOrder.UseVisualStyleBackColor = false;
            this.button_SearchOrder.Click += new System.EventHandler(this.button_SearchOrder_Click);
            // 
            // button_AddOrder
            // 
            this.button_AddOrder.BackColor = System.Drawing.Color.Transparent;
            this.button_AddOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_AddOrder.BackgroundImage")));
            this.button_AddOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_AddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddOrder.Location = new System.Drawing.Point(137, 257);
            this.button_AddOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_AddOrder.Name = "button_AddOrder";
            this.button_AddOrder.Size = new System.Drawing.Size(149, 62);
            this.button_AddOrder.TabIndex = 9;
            this.button_AddOrder.UseCompatibleTextRendering = true;
            this.button_AddOrder.UseMnemonic = false;
            this.button_AddOrder.UseVisualStyleBackColor = true;
            this.button_AddOrder.Click += new System.EventHandler(this.button_AddOrder_Click);
            // 
            // button_BackToMenu
            // 
            this.button_BackToMenu.BackColor = System.Drawing.Color.Transparent;
            this.button_BackToMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_BackToMenu.BackgroundImage")));
            this.button_BackToMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_BackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BackToMenu.Location = new System.Drawing.Point(12, 342);
            this.button_BackToMenu.Name = "button_BackToMenu";
            this.button_BackToMenu.Size = new System.Drawing.Size(68, 61);
            this.button_BackToMenu.TabIndex = 13;
            this.button_BackToMenu.UseVisualStyleBackColor = false;
            this.button_BackToMenu.Click += new System.EventHandler(this.button_BackToMenu_Click);
            // 
            // StaffUnPriv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(359, 465);
            this.Controls.Add(this.button_BackToMenu);
            this.Controls.Add(this.button_SearchOrder);
            this.Controls.Add(this.button_AddOrder);
            this.Name = "StaffUnPriv";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.StaffUnPriv_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_SearchOrder;
        private System.Windows.Forms.Button button_AddOrder;
        private System.Windows.Forms.Button button_BackToMenu;
    }
}