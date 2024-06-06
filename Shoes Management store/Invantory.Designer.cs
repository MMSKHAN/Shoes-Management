namespace Shoes_Management_store
{
    partial class Invantory
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Brand_Name = new TextBox();
            Shoes_Size = new TextBox();
            Col = new TextBox();
            Price = new TextBox();
            Quantity = new TextBox();
            dataGridView1 = new DataGridView();
            Create = new Button();
            Update = new Button();
            Delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(335, 24);
            label1.Name = "label1";
            label1.Size = new Size(119, 32);
            label1.TabIndex = 0;
            label1.Text = "Inventory";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label2.Location = new Point(191, 100);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 1;
            label2.Text = "Brand Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label3.Location = new Point(200, 129);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 2;
            label3.Text = "Shoes Size";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label4.Location = new Point(200, 159);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 3;
            label4.Text = "Color";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label5.Location = new Point(200, 188);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 4;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label6.Location = new Point(200, 219);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 5;
            label6.Text = "Price ";
            // 
            // Brand_Name
            // 
            Brand_Name.Location = new Point(371, 102);
            Brand_Name.Name = "Brand_Name";
            Brand_Name.Size = new Size(183, 23);
            Brand_Name.TabIndex = 6;
            // 
            // Shoes_Size
            // 
            Shoes_Size.Location = new Point(371, 131);
            Shoes_Size.Name = "Shoes_Size";
            Shoes_Size.Size = new Size(183, 23);
            Shoes_Size.TabIndex = 7;
            // 
            // Col
            // 
            Col.Location = new Point(371, 161);
            Col.Name = "Col";
            Col.Size = new Size(183, 23);
            Col.TabIndex = 8;
            // 
            // Price
            // 
            Price.Location = new Point(371, 219);
            Price.Name = "Price";
            Price.Size = new Size(183, 23);
            Price.TabIndex = 9;
            // 
            // Quantity
            // 
            Quantity.Location = new Point(371, 190);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(183, 23);
            Quantity.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(114, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(597, 150);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Create
            // 
            Create.Location = new Point(191, 257);
            Create.Name = "Create";
            Create.Size = new Size(103, 23);
            Create.TabIndex = 12;
            Create.Text = "Create Shoes";
            Create.UseVisualStyleBackColor = true;
            Create.Click += Create_Click;
            // 
            // Update
            // 
            Update.Location = new Point(362, 257);
            Update.Name = "Update";
            Update.Size = new Size(75, 23);
            Update.TabIndex = 13;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click_1;
            // 
            // Delete
            // 
            Delete.Location = new Point(530, 257);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 23);
            Delete.TabIndex = 14;
            Delete.Text = "Delete Shoes";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click_1;
            // 
            // Invantory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 450);
            Controls.Add(Delete);
            Controls.Add(Update);
            Controls.Add(Create);
            Controls.Add(dataGridView1);
            Controls.Add(Quantity);
            Controls.Add(Price);
            Controls.Add(Col);
            Controls.Add(Shoes_Size);
            Controls.Add(Brand_Name);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Invantory";
            Text = "Invantory";
            Load += Invantory_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox Brand_Name;
        private TextBox Shoes_Size;
        private TextBox Col;
        private TextBox Price;
        private TextBox Quantity;
        private DataGridView dataGridView1;
        private Button Create;
        private Button Update;
        private Button Delete;
    }
}