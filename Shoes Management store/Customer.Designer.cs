namespace Shoes_Management_store
{
    partial class Customer
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
            Customer_Name = new TextBox();
            Customer_Age = new TextBox();
            Customer_Email = new TextBox();
            Customer_Contact = new TextBox();
            Create = new Button();
            Update = new Button();
            Delete = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(325, 20);
            label1.Name = "label1";
            label1.Size = new Size(140, 40);
            label1.TabIndex = 0;
            label1.Text = "Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label2.Location = new Point(167, 113);
            label2.Name = "label2";
            label2.Size = new Size(46, 25);
            label2.TabIndex = 1;
            label2.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label3.Location = new Point(167, 80);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label4.Location = new Point(167, 150);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label5.Location = new Point(167, 180);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 4;
            label5.Text = "Contact";
            // 
            // Customer_Name
            // 
            Customer_Name.Location = new Point(296, 90);
            Customer_Name.Name = "Customer_Name";
            Customer_Name.Size = new Size(263, 23);
            Customer_Name.TabIndex = 5;
            // 
            // Customer_Age
            // 
            Customer_Age.Location = new Point(296, 119);
            Customer_Age.Name = "Customer_Age";
            Customer_Age.Size = new Size(263, 23);
            Customer_Age.TabIndex = 6;
            // 
            // Customer_Email
            // 
            Customer_Email.Location = new Point(296, 148);
            Customer_Email.Name = "Customer_Email";
            Customer_Email.Size = new Size(263, 23);
            Customer_Email.TabIndex = 7;
            // 
            // Customer_Contact
            // 
            Customer_Contact.Location = new Point(296, 180);
            Customer_Contact.Name = "Customer_Contact";
            Customer_Contact.Size = new Size(263, 23);
            Customer_Contact.TabIndex = 9;
            // 
            // Create
            // 
            Create.Location = new Point(213, 238);
            Create.Name = "Create";
            Create.Size = new Size(75, 23);
            Create.TabIndex = 10;
            Create.Text = "Create";
            Create.UseVisualStyleBackColor = true;
            Create.Click += Create_Click;
            // 
            // Update
            // 
            Update.Location = new Point(361, 238);
            Update.Name = "Update";
            Update.Size = new Size(75, 23);
            Update.TabIndex = 11;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click_1;
            // 
            // Delete
            // 
            Delete.Location = new Point(512, 238);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 23);
            Delete.TabIndex = 12;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 277);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(697, 161);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(Delete);
            Controls.Add(Update);
            Controls.Add(Create);
            Controls.Add(Customer_Contact);
            Controls.Add(Customer_Email);
            Controls.Add(Customer_Age);
            Controls.Add(Customer_Name);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Customer";
            Text = "Customer";
            Load += Customer_Load_2;
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
        private TextBox Customer_Name;
        private TextBox Customer_Age;
        private TextBox Customer_Email;
        private TextBox Customer_Contact;
        private Button Create;
        private Button Update;
        private Button Delete;
        private DataGridView dataGridView1;
    }
}