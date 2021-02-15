namespace RestaurantManagement
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.button_AddStaff = new System.Windows.Forms.Button();
            this.button_SearchStaff = new System.Windows.Forms.Button();
            this.button_BackToMenu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_AddStaff
            // 
            this.button_AddStaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_AddStaff.BackgroundImage")));
            this.button_AddStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_AddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddStaff.Location = new System.Drawing.Point(78, 228);
            this.button_AddStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_AddStaff.Name = "button_AddStaff";
            this.button_AddStaff.Size = new System.Drawing.Size(154, 55);
            this.button_AddStaff.TabIndex = 7;
            this.button_AddStaff.UseVisualStyleBackColor = true;
            this.button_AddStaff.Click += new System.EventHandler(this.button_AddStaff_Click);
            // 
            // button_SearchStaff
            // 
            this.button_SearchStaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_SearchStaff.BackgroundImage")));
            this.button_SearchStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_SearchStaff.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_SearchStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SearchStaff.Location = new System.Drawing.Point(78, 299);
            this.button_SearchStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_SearchStaff.Name = "button_SearchStaff";
            this.button_SearchStaff.Size = new System.Drawing.Size(154, 58);
            this.button_SearchStaff.TabIndex = 8;
            this.button_SearchStaff.UseVisualStyleBackColor = true;
            this.button_SearchStaff.Click += new System.EventHandler(this.button_SearchStaff_Click);
            // 
            // button_BackToMenu
            // 
            this.button_BackToMenu.BackColor = System.Drawing.Color.Transparent;
            this.button_BackToMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_BackToMenu.BackgroundImage")));
            this.button_BackToMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_BackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BackToMenu.Location = new System.Drawing.Point(12, 546);
            this.button_BackToMenu.Name = "button_BackToMenu";
            this.button_BackToMenu.Size = new System.Drawing.Size(81, 71);
            this.button_BackToMenu.TabIndex = 14;
            this.button_BackToMenu.UseVisualStyleBackColor = false;
            this.button_BackToMenu.Click += new System.EventHandler(this.button_BackToMenu_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(78, 376);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 58);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 61);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(366, 522);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_BackToMenu);
            this.Controls.Add(this.button_SearchStaff);
            this.Controls.Add(this.button_AddStaff);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_AddStaff;
        private System.Windows.Forms.Button button_SearchStaff;
        private System.Windows.Forms.Button button_BackToMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}