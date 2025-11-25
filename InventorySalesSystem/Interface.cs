using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace InventorySalesSystem
{

    public partial class Interface : Form
    {
        DataTable inventory = new DataTable();
        string filePath = "Inventory.txt";
        

        public Interface()
        {
            InitializeComponent();
            
        }
        
        private void Interface_Load(object sender, EventArgs e)
        {
            inventory.Columns.Add("Product ID",typeof(string));
            inventory.Columns.Add("Name", typeof(string));
            inventory.Columns.Add("Category", typeof(string));
            inventory.Columns.Add("Quantity", typeof(string));
            inventory.Columns.Add("Price", typeof(string));

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
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Inventory.txt file not found. Please place it in the project folder.", "File Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            string[] lines = File.ReadAllLines(filePath);
            string[] rowSplit;
            //populates the grid
            for (int i = 0; i < lines.Length; i++)
            {
                rowSplit = lines[i].ToString().Split(',');
                string[] rows = new string[] { rowSplit[0], rowSplit[1], 
                    rowSplit[2], rowSplit[3], rowSplit[4] };
                
                inventory.Rows.Add(rows);
            }
            InventoryView.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {                        
            string id = textBox1.Text;
            string name = textBox2.Text;
            string category = textBox3.Text;
            string quantity = textBox4.Text;
            string price = textBox5.Text;
            //add to grid view
            inventory.Rows.Add(id, name, category, quantity, price);


            string[] lines = {id, name, category, quantity, price };

            //add to text file and starts a new line in text file
            string commaString = string.Join(",", lines);
            File.AppendAllText(filePath, commaString + Environment.NewLine);

            //clears text box after adding
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
            if (InventoryView.SelectedRows.Count > 0)
            {
                int rowIndexToDelete = InventoryView.SelectedRows[0].Index;
                string[] _data = File.ReadAllLines(filePath);

                string[] newData = new string[_data.Length - 1];
                if (rowIndexToDelete > 0)
                {
                    Array.Copy(_data, 0, newData, 0, rowIndexToDelete);
                }
                if (rowIndexToDelete < _data.Length - 1)
                {
                    Array.Copy(_data, rowIndexToDelete + 1, newData, rowIndexToDelete, _data.Length - rowIndexToDelete - 1);

                }
                _data = newData;
                inventory.Rows[InventoryView.CurrentCell.RowIndex].Delete();
                File.WriteAllLines(filePath, _data);
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
