using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySalesSystem
{

    public partial class Interface : Form
    {
        DataTable inventory = new DataTable();
        public Interface()
        {
            InitializeComponent();
        }

        private void Interface_Load(object sender, EventArgs e)
        {
            inventory.Columns.Add("Product ID");
            inventory.Columns.Add("Name");
            inventory.Columns.Add("Category");
            inventory.Columns.Add("Quantity");
            inventory.Columns.Add("Price");
            InventoryView.DataSource = inventory;
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
