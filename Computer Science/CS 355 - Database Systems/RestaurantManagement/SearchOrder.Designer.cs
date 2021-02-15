namespace RestaurantManagement
{
    partial class SearchOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchOrder));
            this.label_CustomerNIC = new System.Windows.Forms.Label();
            this.label_OrderID = new System.Windows.Forms.Label();
            this.label_StaffID = new System.Windows.Forms.Label();
            this.label_OrderDate = new System.Windows.Forms.Label();
            this.textbox_CustomerNIC = new System.Windows.Forms.TextBox();
            this.textbox_StaffID = new System.Windows.Forms.TextBox();
            this.textbox_OrderID = new System.Windows.Forms.TextBox();
            this.datetimepicker_OrderDate = new System.Windows.Forms.DateTimePicker();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_View = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_BackToMenu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_CustomerNIC
            // 
            this.label_CustomerNIC.AutoSize = true;
            this.label_CustomerNIC.BackColor = System.Drawing.Color.Transparent;
            this.label_CustomerNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.label_CustomerNIC.Location = new System.Drawing.Point(18, 66);
            this.label_CustomerNIC.Name = "label_CustomerNIC";
            this.label_CustomerNIC.Size = new System.Drawing.Size(107, 18);
            this.label_CustomerNIC.TabIndex = 1;
            this.label_CustomerNIC.Text = "Customer NIC:";
            this.label_CustomerNIC.Click += new System.EventHandler(this.label_CustomerNIC_Click);
            // 
            // label_OrderID
            // 
            this.label_OrderID.AutoSize = true;
            this.label_OrderID.BackColor = System.Drawing.Color.Transparent;
            this.label_OrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.label_OrderID.Location = new System.Drawing.Point(450, 62);
            this.label_OrderID.Name = "label_OrderID";
            this.label_OrderID.Size = new System.Drawing.Size(64, 18);
            this.label_OrderID.TabIndex = 2;
            this.label_OrderID.Text = "OrderID:";
            // 
            // label_StaffID
            // 
            this.label_StaffID.AutoSize = true;
            this.label_StaffID.BackColor = System.Drawing.Color.Transparent;
            this.label_StaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.label_StaffID.Location = new System.Drawing.Point(48, 90);
            this.label_StaffID.Name = "label_StaffID";
            this.label_StaffID.Size = new System.Drawing.Size(60, 18);
            this.label_StaffID.TabIndex = 3;
            this.label_StaffID.Text = "Staff ID:";
            this.label_StaffID.Click += new System.EventHandler(this.label_StaffID_Click);
            // 
            // label_OrderDate
            // 
            this.label_OrderDate.AutoSize = true;
            this.label_OrderDate.BackColor = System.Drawing.Color.Transparent;
            this.label_OrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.label_OrderDate.Location = new System.Drawing.Point(436, 90);
            this.label_OrderDate.Name = "label_OrderDate";
            this.label_OrderDate.Size = new System.Drawing.Size(85, 18);
            this.label_OrderDate.TabIndex = 4;
            this.label_OrderDate.Text = "Order Date:";
            // 
            // textbox_CustomerNIC
            // 
            this.textbox_CustomerNIC.Location = new System.Drawing.Point(135, 66);
            this.textbox_CustomerNIC.Name = "textbox_CustomerNIC";
            this.textbox_CustomerNIC.Size = new System.Drawing.Size(199, 20);
            this.textbox_CustomerNIC.TabIndex = 5;
            this.textbox_CustomerNIC.TextChanged += new System.EventHandler(this.textbox_CustomerNIC_TextChanged);
            // 
            // textbox_StaffID
            // 
            this.textbox_StaffID.Location = new System.Drawing.Point(135, 88);
            this.textbox_StaffID.Name = "textbox_StaffID";
            this.textbox_StaffID.Size = new System.Drawing.Size(199, 20);
            this.textbox_StaffID.TabIndex = 6;
            // 
            // textbox_OrderID
            // 
            this.textbox_OrderID.Location = new System.Drawing.Point(525, 65);
            this.textbox_OrderID.Name = "textbox_OrderID";
            this.textbox_OrderID.Size = new System.Drawing.Size(200, 20);
            this.textbox_OrderID.TabIndex = 7;
            // 
            // datetimepicker_OrderDate
            // 
            this.datetimepicker_OrderDate.Location = new System.Drawing.Point(525, 91);
            this.datetimepicker_OrderDate.Name = "datetimepicker_OrderDate";
            this.datetimepicker_OrderDate.Size = new System.Drawing.Size(200, 20);
            this.datetimepicker_OrderDate.TabIndex = 8;
            this.datetimepicker_OrderDate.ValueChanged += new System.EventHandler(this.datetimepicker_OrderDate_ValueChanged);
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.Color.Transparent;
            this.button_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Search.BackgroundImage")));
            this.button_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search.Location = new System.Drawing.Point(661, 113);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(62, 42);
            this.button_Search.TabIndex = 9;
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click_1);
            // 
            // button_View
            // 
            this.button_View.BackColor = System.Drawing.Color.Transparent;
            this.button_View.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_View.BackgroundImage")));
            this.button_View.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_View.Location = new System.Drawing.Point(656, 400);
            this.button_View.Name = "button_View";
            this.button_View.Size = new System.Drawing.Size(69, 61);
            this.button_View.TabIndex = 11;
            this.button_View.UseVisualStyleBackColor = false;
            this.button_View.Click += new System.EventHandler(this.button_View_Click);
            // 
            // button_BackToMenu
            // 
            this.button_BackToMenu.BackColor = System.Drawing.Color.Transparent;
            this.button_BackToMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_BackToMenu.BackgroundImage")));
            this.button_BackToMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_BackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BackToMenu.Location = new System.Drawing.Point(577, 400);
            this.button_BackToMenu.Name = "button_BackToMenu";
            this.button_BackToMenu.Size = new System.Drawing.Size(68, 61);
            this.button_BackToMenu.TabIndex = 12;
            this.button_BackToMenu.UseVisualStyleBackColor = false;
            this.button_BackToMenu.Click += new System.EventHandler(this.button_BackToMenu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(693, 229);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(276, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 33);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // SearchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(774, 473);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_BackToMenu);
            this.Controls.Add(this.button_View);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.datetimepicker_OrderDate);
            this.Controls.Add(this.textbox_OrderID);
            this.Controls.Add(this.textbox_StaffID);
            this.Controls.Add(this.textbox_CustomerNIC);
            this.Controls.Add(this.label_OrderDate);
            this.Controls.Add(this.label_StaffID);
            this.Controls.Add(this.label_OrderID);
            this.Controls.Add(this.label_CustomerNIC);
            this.DoubleBuffered = true;
            this.Name = "SearchOrder";
            this.Text = "SarchOrder";
            this.Load += new System.EventHandler(this.SarchOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_CustomerNIC;
        private System.Windows.Forms.Label label_OrderID;
        private System.Windows.Forms.Label label_StaffID;
        private System.Windows.Forms.Label label_OrderDate;
        private System.Windows.Forms.TextBox textbox_CustomerNIC;
        private System.Windows.Forms.TextBox textbox_StaffID;
        private System.Windows.Forms.TextBox textbox_OrderID;
        private System.Windows.Forms.DateTimePicker datetimepicker_OrderDate;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_View;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_BackToMenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}