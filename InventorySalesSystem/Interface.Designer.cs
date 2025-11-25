namespace InventorySalesSystem
{
    partial class Interface
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            InventoryView = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            delete = new Button();
            clear = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)InventoryView).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(26, 513);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 0;
            button1.Text = "Sign Out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSignOut_Click;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(12, 231);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(122, 40);
            button2.TabIndex = 1;
            button2.Text = "Check Inventory";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 282);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(123, 35);
            button3.TabIndex = 2;
            button3.Text = "Add Product";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 325);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(123, 31);
            button4.TabIndex = 3;
            button4.Text = "Edit Product";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // InventoryView
            // 
            InventoryView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            InventoryView.BackgroundColor = Color.White;
            InventoryView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InventoryView.Location = new Point(174, 231);
            InventoryView.Margin = new Padding(3, 4, 3, 4);
            InventoryView.Name = "InventoryView";
            InventoryView.RowHeadersWidth = 51;
            InventoryView.Size = new Size(728, 329);
            InventoryView.TabIndex = 4;
            InventoryView.Visible = false;
            InventoryView.CellContentClick += InventoryView_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(327, 12);
            label1.Name = "label1";
            label1.Size = new Size(308, 81);
            label1.TabIndex = 5;
            label1.Text = "Inventory";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 182);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(327, 182);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(478, 182);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(629, 182);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(777, 182);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 10;
            // 
            // delete
            // 
            delete.Location = new Point(26, 403);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 11;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // clear
            // 
            clear.Location = new Point(26, 438);
            clear.Name = "clear";
            clear.Size = new Size(94, 29);
            clear.TabIndex = 13;
            clear.Text = "clear";
            clear.UseMnemonic = false;
            clear.UseVisualStyleBackColor = true;
            clear.Visible = false;
            clear.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 147);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 14;
            label2.Text = "Product ID";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(361, 147);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 15;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(502, 147);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 16;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(662, 147);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 17;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(812, 147);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 18;
            label6.Text = "Price";
            // 
            // Interface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(914, 600);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(clear);
            Controls.Add(delete);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(InventoryView);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Interface";
            Text = "Interface";
            Load += Interface_Load;
            ((System.ComponentModel.ISupportInitialize)InventoryView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView InventoryView;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button delete;
        private Button clear;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}