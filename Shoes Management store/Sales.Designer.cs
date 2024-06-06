namespace Shoes_Management_store
{
    partial class Sales
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
            panel1 = new Panel();
            button1 = new Button();
            label6 = new Label();
            shoe = new TextBox();
            quantity = new TextBox();
            date = new TextBox();
            Cus = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(303, 9);
            label1.Name = "label1";
            label1.Size = new Size(79, 37);
            label1.TabIndex = 0;
            label1.Text = "Sales";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(shoe);
            panel1.Controls.Add(quantity);
            panel1.Controls.Add(date);
            panel1.Controls.Add(Cus);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(123, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 194);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(155, 157);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Buy Shoes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(345, 12);
            label6.Name = "label6";
            label6.Size = new Size(70, 13);
            label6.TabIndex = 8;
            label6.Text = "For Customer";
            // 
            // shoe
            // 
            shoe.Location = new Point(92, 54);
            shoe.Name = "shoe";
            shoe.Size = new Size(181, 23);
            shoe.TabIndex = 7;
            // 
            // quantity
            // 
            quantity.Location = new Point(92, 115);
            quantity.Name = "quantity";
            quantity.Size = new Size(181, 23);
            quantity.TabIndex = 6;
            // 
            // date
            // 
            date.Location = new Point(92, 86);
            date.Name = "date";
            date.Size = new Size(181, 23);
            date.TabIndex = 5;
            // 
            // Cus
            // 
            Cus.Location = new Point(92, 25);
            Cus.Name = "Cus";
            Cus.Size = new Size(181, 23);
            Cus.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 94);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 3;
            label5.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 123);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 2;
            label4.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 62);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 1;
            label3.Text = "Shoes ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 26);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 0;
            label2.Text = "Customer ID";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(74, 274);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(616, 164);
            dataGridView1.TabIndex = 2;
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Sales";
            Text = "Sales";
            Load += Sales_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button button1;
        private Label label6;
        private TextBox shoe;
        private TextBox quantity;
        private TextBox Cus;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox date;
    }
}