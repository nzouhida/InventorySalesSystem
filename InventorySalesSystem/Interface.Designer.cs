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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            button1 = new Button();
            checkInv = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            InventoryView = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            btnDelete = new Button();
            btnClear = new Button();
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
            // checkInv
            // 
            checkInv.ForeColor = SystemColors.ControlText;
            checkInv.Location = new Point(12, 231);
            checkInv.Margin = new Padding(3, 4, 3, 4);
            checkInv.Name = "checkInv";
            checkInv.Size = new Size(122, 40);
            checkInv.TabIndex = 1;
            checkInv.Text = "Check Inventory";
            checkInv.UseVisualStyleBackColor = true;
            checkInv.Click += checkInv_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 282);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 35);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Product";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(12, 325);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(123, 31);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit Product";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // InventoryView
            // 
            InventoryView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            InventoryView.BackgroundColor = Color.White;
            InventoryView.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            InventoryView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            InventoryView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InventoryView.Location = new Point(174, 231);
            InventoryView.Margin = new Padding(3, 4, 3, 4);
            InventoryView.Name = "InventoryView";
            InventoryView.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            InventoryView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            InventoryView.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            InventoryView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            InventoryView.Size = new Size(728, 329);
            InventoryView.TabIndex = 4;
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
            // btnDelete
            // 
            btnDelete.Location = new Point(26, 403);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(26, 438);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseMnemonic = false;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Visible = false;
            btnClear.Click += btnClear_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(185, 147);
            label2.Name = "label2";
            label2.Size = new Size(105, 28);
            label2.TabIndex = 14;
            label2.Text = "Product ID";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(359, 147);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 15;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(496, 147);
            label4.Name = "label4";
            label4.Size = new Size(92, 28);
            label4.TabIndex = 16;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(648, 147);
            label5.Name = "label5";
            label5.Size = new Size(88, 28);
            label5.TabIndex = 17;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(812, 147);
            label6.Name = "label6";
            label6.Size = new Size(54, 28);
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
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(InventoryView);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(checkInv);
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
        private Button checkInv;
        private Button btnAdd;
        private Button btnEdit;
        private DataGridView InventoryView;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button btnDelete;
        private Button btnClear;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}