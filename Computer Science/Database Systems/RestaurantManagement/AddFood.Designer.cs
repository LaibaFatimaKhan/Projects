namespace RestaurantManagement
{
    partial class AddFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFood));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_FoodName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textbox_StaffID = new System.Windows.Forms.TextBox();
            this.textbox_CustomerNIC = new System.Windows.Forms.TextBox();
            this.button_BackToMenu = new System.Windows.Forms.Button();
            this.button_View = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(252, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 33);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // label_FoodName
            // 
            this.label_FoodName.AutoSize = true;
            this.label_FoodName.BackColor = System.Drawing.Color.Transparent;
            this.label_FoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.label_FoodName.Location = new System.Drawing.Point(32, 93);
            this.label_FoodName.Name = "label_FoodName";
            this.label_FoodName.Size = new System.Drawing.Size(87, 18);
            this.label_FoodName.TabIndex = 41;
            this.label_FoodName.Text = "FoodName:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.label1.Location = new System.Drawing.Point(32, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 42;
            this.label1.Text = "Price:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(375, 233);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textbox_StaffID
            // 
            this.textbox_StaffID.Location = new System.Drawing.Point(140, 126);
            this.textbox_StaffID.Name = "textbox_StaffID";
            this.textbox_StaffID.Size = new System.Drawing.Size(270, 20);
            this.textbox_StaffID.TabIndex = 45;
            this.textbox_StaffID.TextChanged += new System.EventHandler(this.textbox_StaffID_TextChanged);
            // 
            // textbox_CustomerNIC
            // 
            this.textbox_CustomerNIC.Location = new System.Drawing.Point(140, 91);
            this.textbox_CustomerNIC.Name = "textbox_CustomerNIC";
            this.textbox_CustomerNIC.Size = new System.Drawing.Size(270, 20);
            this.textbox_CustomerNIC.TabIndex = 44;
            this.textbox_CustomerNIC.TextChanged += new System.EventHandler(this.textbox_CustomerNIC_TextChanged);
            // 
            // button_BackToMenu
            // 
            this.button_BackToMenu.BackColor = System.Drawing.Color.Transparent;
            this.button_BackToMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_BackToMenu.BackgroundImage")));
            this.button_BackToMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_BackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BackToMenu.Location = new System.Drawing.Point(580, 83);
            this.button_BackToMenu.Name = "button_BackToMenu";
            this.button_BackToMenu.Size = new System.Drawing.Size(68, 61);
            this.button_BackToMenu.TabIndex = 47;
            this.button_BackToMenu.UseVisualStyleBackColor = false;
            this.button_BackToMenu.Click += new System.EventHandler(this.button_BackToMenu_Click);
            // 
            // button_View
            // 
            this.button_View.BackColor = System.Drawing.Color.Transparent;
            this.button_View.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_View.BackgroundImage")));
            this.button_View.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_View.Location = new System.Drawing.Point(659, 83);
            this.button_View.Name = "button_View";
            this.button_View.Size = new System.Drawing.Size(69, 61);
            this.button_View.TabIndex = 46;
            this.button_View.UseVisualStyleBackColor = false;
            this.button_View.Click += new System.EventHandler(this.button_View_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(35, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 61);
            this.button1.TabIndex = 49;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(659, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 61);
            this.button2.TabIndex = 48;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_BackToMenu);
            this.Controls.Add(this.button_View);
            this.Controls.Add(this.textbox_StaffID);
            this.Controls.Add(this.textbox_CustomerNIC);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_FoodName);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "AddFood";
            this.Text = "AddFood";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_FoodName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textbox_StaffID;
        private System.Windows.Forms.TextBox textbox_CustomerNIC;
        private System.Windows.Forms.Button button_BackToMenu;
        private System.Windows.Forms.Button button_View;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}