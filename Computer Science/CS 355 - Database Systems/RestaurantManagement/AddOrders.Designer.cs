namespace RestaurantManagement
{
    partial class AddOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrders));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_AddOrder = new System.Windows.Forms.Button();
            this.label_Date = new System.Windows.Forms.Label();
            this.groupbox_StaffDetails = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupbox_CustomerDetails = new System.Windows.Forms.GroupBox();
            this.textbox_LastName = new System.Windows.Forms.TextBox();
            this.textbox_FirstName = new System.Windows.Forms.TextBox();
            this.textbox_CustomerNIC = new System.Windows.Forms.TextBox();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_CustomerNIC = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.combobox_FoodItems = new System.Windows.Forms.ComboBox();
            this.label_FoodItems = new System.Windows.Forms.Label();
            this.button_BackToMenu = new System.Windows.Forms.Button();
            this.OrderedItems = new System.Windows.Forms.ListBox();
            this.button_AddItem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.QtyTextBox = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupbox_StaffDetails.SuspendLayout();
            this.groupbox_CustomerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(424, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button_AddOrder
            // 
            this.button_AddOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_AddOrder.BackgroundImage")));
            this.button_AddOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_AddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddOrder.Location = new System.Drawing.Point(602, 381);
            this.button_AddOrder.Name = "button_AddOrder";
            this.button_AddOrder.Size = new System.Drawing.Size(68, 64);
            this.button_AddOrder.TabIndex = 9;
            this.button_AddOrder.UseVisualStyleBackColor = true;
            this.button_AddOrder.Click += new System.EventHandler(this.button_AddOrder_Click);
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.BackColor = System.Drawing.Color.Transparent;
            this.label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.Location = new System.Drawing.Point(363, 76);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(48, 18);
            this.label_Date.TabIndex = 13;
            this.label_Date.Text = "Date:";
            this.label_Date.Click += new System.EventHandler(this.label_Date_Click);
            // 
            // groupbox_StaffDetails
            // 
            this.groupbox_StaffDetails.BackColor = System.Drawing.Color.Transparent;
            this.groupbox_StaffDetails.Controls.Add(this.comboBox1);
            this.groupbox_StaffDetails.Controls.Add(this.label2);
            this.groupbox_StaffDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_StaffDetails.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupbox_StaffDetails.Location = new System.Drawing.Point(45, 61);
            this.groupbox_StaffDetails.Name = "groupbox_StaffDetails";
            this.groupbox_StaffDetails.Size = new System.Drawing.Size(231, 69);
            this.groupbox_StaffDetails.TabIndex = 12;
            this.groupbox_StaffDetails.TabStop = false;
            this.groupbox_StaffDetails.Text = "Staff Details";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(78, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 28);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Staff ID:";
            // 
            // groupbox_CustomerDetails
            // 
            this.groupbox_CustomerDetails.BackColor = System.Drawing.Color.Transparent;
            this.groupbox_CustomerDetails.Controls.Add(this.textbox_LastName);
            this.groupbox_CustomerDetails.Controls.Add(this.textbox_FirstName);
            this.groupbox_CustomerDetails.Controls.Add(this.textbox_CustomerNIC);
            this.groupbox_CustomerDetails.Controls.Add(this.label_LastName);
            this.groupbox_CustomerDetails.Controls.Add(this.label_CustomerNIC);
            this.groupbox_CustomerDetails.Controls.Add(this.label_FirstName);
            this.groupbox_CustomerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_CustomerDetails.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupbox_CustomerDetails.Location = new System.Drawing.Point(356, 175);
            this.groupbox_CustomerDetails.Name = "groupbox_CustomerDetails";
            this.groupbox_CustomerDetails.Size = new System.Drawing.Size(261, 138);
            this.groupbox_CustomerDetails.TabIndex = 11;
            this.groupbox_CustomerDetails.TabStop = false;
            this.groupbox_CustomerDetails.Text = "CustomerDetails";
            this.groupbox_CustomerDetails.Enter += new System.EventHandler(this.groupbox_CustomerDetails_Enter);
            // 
            // textbox_LastName
            // 
            this.textbox_LastName.Location = new System.Drawing.Point(118, 87);
            this.textbox_LastName.Name = "textbox_LastName";
            this.textbox_LastName.Size = new System.Drawing.Size(131, 26);
            this.textbox_LastName.TabIndex = 7;
            // 
            // textbox_FirstName
            // 
            this.textbox_FirstName.Location = new System.Drawing.Point(118, 60);
            this.textbox_FirstName.Name = "textbox_FirstName";
            this.textbox_FirstName.Size = new System.Drawing.Size(131, 26);
            this.textbox_FirstName.TabIndex = 6;
            this.textbox_FirstName.TextChanged += new System.EventHandler(this.Textbox_FirstName_TextChanged);
            // 
            // textbox_CustomerNIC
            // 
            this.textbox_CustomerNIC.Location = new System.Drawing.Point(118, 33);
            this.textbox_CustomerNIC.Name = "textbox_CustomerNIC";
            this.textbox_CustomerNIC.Size = new System.Drawing.Size(131, 26);
            this.textbox_CustomerNIC.TabIndex = 5;
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label_LastName.Location = new System.Drawing.Point(26, 93);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(90, 17);
            this.label_LastName.TabIndex = 4;
            this.label_LastName.Text = "Last Name:";
            // 
            // label_CustomerNIC
            // 
            this.label_CustomerNIC.AutoSize = true;
            this.label_CustomerNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label_CustomerNIC.Location = new System.Drawing.Point(6, 39);
            this.label_CustomerNIC.Name = "label_CustomerNIC";
            this.label_CustomerNIC.Size = new System.Drawing.Size(111, 17);
            this.label_CustomerNIC.TabIndex = 1;
            this.label_CustomerNIC.Text = "Customer NIC:";
            this.label_CustomerNIC.Click += new System.EventHandler(this.label_CustomerNIC_Click);
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label_FirstName.Location = new System.Drawing.Point(26, 66);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(91, 17);
            this.label_FirstName.TabIndex = 3;
            this.label_FirstName.Text = "First Name:";
            // 
            // combobox_FoodItems
            // 
            this.combobox_FoodItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_FoodItems.FormattingEnabled = true;
            this.combobox_FoodItems.Location = new System.Drawing.Point(131, 149);
            this.combobox_FoodItems.Name = "combobox_FoodItems";
            this.combobox_FoodItems.Size = new System.Drawing.Size(147, 26);
            this.combobox_FoodItems.TabIndex = 15;
            this.combobox_FoodItems.SelectedIndexChanged += new System.EventHandler(this.combobox_FoodItems_SelectedIndexChanged);
            // 
            // label_FoodItems
            // 
            this.label_FoodItems.AutoSize = true;
            this.label_FoodItems.BackColor = System.Drawing.Color.Transparent;
            this.label_FoodItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FoodItems.Location = new System.Drawing.Point(27, 153);
            this.label_FoodItems.Name = "label_FoodItems";
            this.label_FoodItems.Size = new System.Drawing.Size(98, 18);
            this.label_FoodItems.TabIndex = 16;
            this.label_FoodItems.Text = "Food Items:";
            // 
            // button_BackToMenu
            // 
            this.button_BackToMenu.BackColor = System.Drawing.Color.Transparent;
            this.button_BackToMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_BackToMenu.BackgroundImage")));
            this.button_BackToMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_BackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BackToMenu.Location = new System.Drawing.Point(520, 381);
            this.button_BackToMenu.Name = "button_BackToMenu";
            this.button_BackToMenu.Size = new System.Drawing.Size(76, 64);
            this.button_BackToMenu.TabIndex = 17;
            this.button_BackToMenu.UseVisualStyleBackColor = false;
            this.button_BackToMenu.Click += new System.EventHandler(this.button_BackToMenu_Click);
            // 
            // OrderedItems
            // 
            this.OrderedItems.BackColor = System.Drawing.Color.OldLace;
            this.OrderedItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderedItems.FormattingEnabled = true;
            this.OrderedItems.ItemHeight = 18;
            this.OrderedItems.Location = new System.Drawing.Point(54, 261);
            this.OrderedItems.Name = "OrderedItems";
            this.OrderedItems.Size = new System.Drawing.Size(182, 184);
            this.OrderedItems.TabIndex = 18;
            this.OrderedItems.SelectedIndexChanged += new System.EventHandler(this.OrderedItems_SelectedIndexChanged);
            // 
            // button_AddItem
            // 
            this.button_AddItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_AddItem.BackgroundImage")));
            this.button_AddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_AddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddItem.Location = new System.Drawing.Point(210, 186);
            this.button_AddItem.Name = "button_AddItem";
            this.button_AddItem.Size = new System.Drawing.Size(42, 40);
            this.button_AddItem.TabIndex = 19;
            this.button_AddItem.UseVisualStyleBackColor = true;
            this.button_AddItem.Click += new System.EventHandler(this.Button_AddItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Quantity:";
            // 
            // QtyTextBox
            // 
            this.QtyTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QtyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyTextBox.Location = new System.Drawing.Point(146, 186);
            this.QtyTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.QtyTextBox.Name = "QtyTextBox";
            this.QtyTextBox.Size = new System.Drawing.Size(52, 22);
            this.QtyTextBox.TabIndex = 21;
            this.QtyTextBox.Text = "1";
            // 
            // Quantity
            // 
            this.Quantity.BackColor = System.Drawing.Color.OldLace;
            this.Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.FormattingEnabled = true;
            this.Quantity.ItemHeight = 18;
            this.Quantity.Location = new System.Drawing.Point(236, 261);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(68, 184);
            this.Quantity.TabIndex = 22;
            this.Quantity.SelectedIndexChanged += new System.EventHandler(this.Quantity_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(236, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 33);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // AddOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(685, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.QtyTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_AddItem);
            this.Controls.Add(this.OrderedItems);
            this.Controls.Add(this.button_BackToMenu);
            this.Controls.Add(this.label_FoodItems);
            this.Controls.Add(this.combobox_FoodItems);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button_AddOrder);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.groupbox_StaffDetails);
            this.Controls.Add(this.groupbox_CustomerDetails);
            this.DoubleBuffered = true;
            this.Name = "AddOrders";
            this.Text = "AddOrders";
            this.Load += new System.EventHandler(this.AddOrders_Load);
            this.groupbox_StaffDetails.ResumeLayout(false);
            this.groupbox_StaffDetails.PerformLayout();
            this.groupbox_CustomerDetails.ResumeLayout(false);
            this.groupbox_CustomerDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_AddOrder;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.GroupBox groupbox_StaffDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupbox_CustomerDetails;
        private System.Windows.Forms.TextBox textbox_LastName;
        private System.Windows.Forms.TextBox textbox_FirstName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_CustomerNIC;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.ComboBox combobox_FoodItems;
        private System.Windows.Forms.Label label_FoodItems;
        private System.Windows.Forms.Button button_BackToMenu;
        private System.Windows.Forms.ListBox OrderedItems;
        private System.Windows.Forms.Button button_AddItem;
        private System.Windows.Forms.TextBox textbox_CustomerNIC;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QtyTextBox;
        private System.Windows.Forms.ListBox Quantity;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}