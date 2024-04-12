using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;

namespace Presentation_Layer
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();

        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            
            LogicLayerClass logic = new LogicLayerClass();
            string productName = productTextBox.Text;
            int quantity = Convert.ToInt32(quantityTextBox.Text);
            decimal price = Convert.ToDecimal(priceTextBox.Text);
            decimal total = quantity * price;
            decimal stock = total;

            try
            {
                logic.InsertProduct(productName, quantity, price, stock);
                MessageBox.Show($"{ productName} added successfully!");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            priceTextBox.Text = string.Empty;
            quantityTextBox.Text = string.Empty;
            productTextBox.Text = string.Empty;
            stockTextBox.Text = string.Empty;
            dataGridView1.DataSource = logic.DisplayOnGrid();
        }
   
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            LogicLayerClass logic = new LogicLayerClass();
            {
                string productName = productTextBox.Text;
                int quantity = Convert.ToInt32(quantityTextBox.Text);
                decimal price = Convert.ToDecimal(priceTextBox.Text);
                decimal total = quantity * price;
                decimal stock = total;

                try
                {
                    logic.UpdateProduct(productName,quantity, price, stock);
                    MessageBox.Show($"{productName} updated successfully!");

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message );
                }
                priceTextBox.Text = string.Empty;
                quantityTextBox.Text = string.Empty;
                productTextBox.Text = string.Empty;
                stockTextBox.Text = string.Empty;


                dataGridView1.DataSource = logic.DisplayOnGrid();

            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            LogicLayerClass logic = new LogicLayerClass();
            {
                string productName = productTextBox.Text;

                try
                {
                    logic.DeleteProduct(productName);
                    MessageBox.Show($"{productName} deleted successfully!");

                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message );
                }
                    priceTextBox.Text = string.Empty;
                    quantityTextBox.Text = string.Empty;
                    productTextBox.Text = string.Empty;
                    stockTextBox.Text = string.Empty;
                dataGridView1.DataSource = logic.DisplayOnGrid();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            productTextBox.Text = string.Empty;
            quantityTextBox.Text = string.Empty;
            priceTextBox.Text = string.Empty;
            stockTextBox.Text = string.Empty;
            dataGridView1.DataSource = null;
        }
    }
}
