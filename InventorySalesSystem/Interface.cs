using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace InventorySalesSystem
{

    public partial class Interface : Form
    { // 0 = Product ID, 1 = Name, 2 = Category, 3 = Quantity, 4= Price
        private string[,] _products;
        private int _productCount = 0;
        
        DataTable inventory = new DataTable();
        public Interface()
        {
            InitializeComponent();
        }

        private void Interface_Load(object sender, EventArgs e)
        {
            // Set up the inventory table Columns (for display)
            inventory.Columns.Add("Product ID");
            inventory.Columns.Add("Name");
            inventory.Columns.Add("Category");
            inventory.Columns.Add("Quantity");
            inventory.Columns.Add("Price");
           
            // Load from products.txt into 2d array
            LoadProductsFromFile();

            // Show Products in DataGridView
            DisplayProductsInGrid();

           
        }

        private void LoadProductsFromFile()
        {
            string filePath = "products.txt";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("products.txt not found. Please make sure the file exists.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] lines = File.ReadAllLines(filePath);
            _products = new string[lines.Length, 5]; // 5 columns per product
            _productCount = lines.Length;

            for (int i =0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');

                if (parts.Length >= 5)
                {
                    _products[i, 0] = parts[0].Trim(); //Product ID
                    _products[i, 1] = parts[1].Trim(); // Name
                    _products[i, 2] = parts[2].Trim(); // Category
                    _products[i, 3] = parts[3].Trim(); // Quantity
                    _products[i, 4] = parts[4].Trim(); // Price

                }
            }
        }

        private void DisplayProductsInGrid()
        {
            //clear existing rows
            inventory.Rows.Clear();

            if (_products == null || _productCount == 0)
                return;

            for (int i = 0; i < _productCount; i++)
            {
                inventory.Rows.Add(
                    _products[i,0], // Product ID
                    _products[i,1], // Name
                    _products[i,2], // Category
                    _products[i,3], // Quantity
                    _products[i,4]  // Price
                    );

                // Bind DataTable to the grid
                InventoryView.DataSource = inventory;




            }

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to sign out?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            InventoryView.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string name = textBox2.Text;
            string category = textBox3.Text;
            string quantity = textBox4.Text;
            string price = textBox5.Text;

            inventory.Rows.Add(id, name, category, quantity, price);

            button5_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InventoryView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {

                inventory.Rows[InventoryView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception err)
            {
                Console.WriteLine("Error: " + err);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
