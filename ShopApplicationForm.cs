using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApplication
{
    public partial class ShopApplicationForm : Form
    {
        public ShopApplicationForm()
        {
            InitializeComponent();
        }
        Shop shop1 = new Shop();
        private void saveButton_Click(object sender, EventArgs e)
        {

            shop1.shopName = shopNameTextBox.Text;
            shop1.shopAddress = shopAddressTextBox.Text;

            shopNameTextBox.Clear();
            shopAddressTextBox.Clear();
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            
            shop1.InsertProduct(productTextBox.Text,Convert.ToInt32(quantityTextBox.Text));

        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(shop1.shopName + "\n" + shop1.shopAddress + "\n" + shop1.ShowProduct() );
        }
    }
}
