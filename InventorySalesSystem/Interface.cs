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
        //public use of the data table and filePath within the interface form.
        DataTable inventory = new DataTable();
        string filePath = "Inventory.txt";
        
       
        public Interface()
        {
            InitializeComponent();
            
        }
        
        private void Interface_Load(object sender, EventArgs e)
        {
            //preloads the column headers of the grid.
            inventory.Columns.Add("Product ID",typeof(string));
            inventory.Columns.Add("Name", typeof(string));
            inventory.Columns.Add("Category", typeof(string));
            inventory.Columns.Add("Quantity", typeof(int));
            inventory.Columns.Add("Price", typeof(decimal));
            
            InventoryView.DataSource = inventory;
            //Formats the last column "Price" to currency 
            InventoryView.Columns["Price"].DefaultCellStyle.Format = "c";
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            //ask users if they want to sign out
            var result = MessageBox.Show("Are you sure you want to sign out?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //closes interface and goes back to login screen
            if (result == DialogResult.Yes)
            {
                this.Close();

            }


        }

        private void checkInv_Click(object sender, EventArgs e)
        {            
            //Checks for existing file and will not create a new file. There is only one inventory file.
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Inventory.txt file not found. Please place it in the project folder.", "File Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            //Clears and refreshes the grid, acts as an updater when check inventory is pressed multiple times.
            inventory.Rows.Clear();

            string[] lines = File.ReadAllLines(filePath);
            string[] rowSplit;

            //Populates the grid
            for (int i = 0; i < lines.Length; i++)
            {
                rowSplit = lines[i].ToString().Split(',');
                string[] rows = new string[] { rowSplit[0], rowSplit[1],
                    rowSplit[2], rowSplit[3], rowSplit[4]};
                
                inventory.Rows.Add(rows);
            }
            
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {                        
            string id = textBox1.Text;
            string name = textBox2.Text;
            string category = textBox3.Text;
            string quantity = textBox4.Text;
            string price = textBox5.Text;
            //adds inputs to grid view
            inventory.Rows.Add(id, name, category, quantity, price);


            string[] lines = {id, name, category, quantity, price };

            //add to text file and starts a new line in text file
            string commaString = string.Join(",", lines);
            File.AppendAllText(filePath, commaString + Environment.NewLine);

            //clears text box after adding
            btnClear_Click(sender, e);
            checkInv_Click(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Save all rows from the DataTable to the file
            string[] lines = new string[inventory.Rows.Count];
            for (int i = 0; i < inventory.Rows.Count; i++)
            {
                lines[i] = string.Join(",", inventory.Rows[i].ItemArray);
            }
            //Write over text file with updated changes
            File.WriteAllLines(filePath, lines);
            
            //let users know that changes have been saved
            MessageBox.Show("Changes saved.");
            checkInv_Click(sender, e); // Refresh the grid to reflect changes

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //deletes the highlighted row and rewrites the text file.
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears the text boxes 
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
