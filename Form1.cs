using ProductManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManagement
{
    public partial class Form1 : Form
    {
        private BindingList<Product> products;
        private BindingList<Product> filterProducts;
        public Form1()
        {
            products = new BindingList<Product>();
            filterProducts = new BindingList<Product>();
            for (int i = 0; i < 10; i++)
            {
                products.Add(new Product() { Id = i, Name = "Product " + i, Price = 1000 * i, Origin = "Nation " + i, Stock = 100 * i, ExpiredDate = DateTime.Now.AddDays(i) });
            }
            InitializeComponent();
            //Data grid 1 
            this.dgProduct.DataSource = products;
            this.dgProduct.Columns["Id"].HeaderText = "Mã SP";
            this.dgProduct.Columns["Name"].HeaderText = "Tên sản phẩm";
            this.dgProduct.Columns["Price"].HeaderText = "Đơn giá";
            this.dgProduct.Columns["Origin"].HeaderText = "Xuất xứ";
            this.dgProduct.Columns["Stock"].HeaderText = "Số lượng";
            this.dgProduct.Columns["ExpiredDate"].HeaderText = "Ngày hết hạn";

            this.dgProduct.Columns["Id"].DisplayIndex = 0;           // Product ID as the first column
            this.dgProduct.Columns["Name"].DisplayIndex = 1;         // Product Name as the second column
            this.dgProduct.Columns["Stock"].DisplayIndex = 2;        // Available Stock as the fourth column
            this.dgProduct.Columns["Price"].DisplayIndex = 3;        // Unit Price as the third column
            this.dgProduct.Columns["Origin"].DisplayIndex = 4;       // Country of Origin as the fifth column
            this.dgProduct.Columns["ExpiredDate"].DisplayIndex = 5;
            //Data grid 2
            this.dgFilteredProduct.DataSource = filterProducts;
            this.dgFilteredProduct.Columns["Id"].HeaderText = "Mã SP";
            this.dgFilteredProduct.Columns["Name"].HeaderText = "Tên sản phẩm";
            this.dgFilteredProduct.Columns["Price"].HeaderText = "Đơn giá";
            this.dgFilteredProduct.Columns["Origin"].HeaderText = "Xuất xứ";
            this.dgFilteredProduct.Columns["Stock"].HeaderText = "Số lượng";
            this.dgFilteredProduct.Columns["ExpiredDate"].HeaderText = "Ngày hết hạn";

            this.dgFilteredProduct.Columns["Id"].DisplayIndex = 0;           // Product ID as the first column
            this.dgFilteredProduct.Columns["Name"].DisplayIndex = 1;         // Product Name as the second column
            this.dgFilteredProduct.Columns["Stock"].DisplayIndex = 2;        // Available Stock as the fourth column
            this.dgFilteredProduct.Columns["Price"].DisplayIndex = 3;        // Unit Price as the third column
            this.dgFilteredProduct.Columns["Origin"].DisplayIndex = 4;       // Country of Origin as the fifth column
            this.dgFilteredProduct.Columns["ExpiredDate"].DisplayIndex = 5;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtDeleteOrigin.Text))
            {
                MessageBox.Show("Origin is required");
                return;
            }
            int deletes = products.Count(p => p.Origin == txtDeleteOrigin.Text);
            if(deletes == 0)
            {
                MessageBox.Show("No product found");
                return;
            }
            products = new BindingList<Product>(products.Where(p => p.Origin != txtDeleteOrigin.Text).ToList());
            dgProduct.DataSource = null;
            dgProduct.DataSource = products;
            MessageBox.Show($"Deleted all products from {txtDeleteOrigin.Text}, Deletes: {deletes}");
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductId.Text))
            {
                MessageBox.Show("Product ID is required");
                return;
            }
            if (string.IsNullOrEmpty(txtProductName.Text))
            {
                MessageBox.Show("Product name is required");
                return;
            }
            if (string.IsNullOrEmpty(txtProductPrice.Text))
            {
                MessageBox.Show("Product price is required");
                return;
            }
            if (string.IsNullOrEmpty(txtProductOrigin.Text))
            {
                MessageBox.Show("Product origin is required");
                return;
            }
            if (string.IsNullOrEmpty(txtProductStock.Text))
            {
                MessageBox.Show("Product stock is required");
                return;
            }
            if (datePickerProductExpire.Value == null)
            {
                MessageBox.Show("Product expired date is required");
                return;
            }
            // validation
            if (int.TryParse(txtProductId.Text, out int id))
            {
                Product product = new Product()
                {
                    Id = id,
                    Name = txtProductName.Text,
                    Price = double.Parse(txtProductPrice.Text),
                    Origin = txtProductOrigin.Text,
                    Stock = int.Parse(txtProductStock.Text),
                    ExpiredDate = datePickerProductExpire.Value
                };
                products.Add(product);
            }
        }

        private void btnFilterHighestPrice_Click(object sender, EventArgs e)
        {
            filterProducts = new BindingList<Product>(products.OrderByDescending(p => p.Price).Take(1).ToList());
            dgFilteredProduct.DataSource = null;
            dgFilteredProduct.DataSource = filterProducts;
        }

        private void btnFilterProductFromJap_Click(object sender, EventArgs e)
        {
            filterProducts = new BindingList<Product>(products.Where(p => p.Origin == "Japan").Take(1).ToList());
            dgFilteredProduct.DataSource = null;
            dgFilteredProduct.DataSource = filterProducts;
        }

        private void btnFilterExpiredProducts_Click(object sender, EventArgs e)
        {

            filterProducts = new BindingList<Product>(products.Where(p => p.ExpiredDate <= DateTime.Now).ToList());
            dgFilteredProduct.DataSource = null;
            dgFilteredProduct.DataSource = filterProducts;
        }


        private void btnDeleteProductByOrigin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDeleteOrigin.Text))
            {
                MessageBox.Show("Origin is required");
                return;
            }
            int deletes = products.Count(p => p.Origin == txtDeleteOrigin.Text);
            if (deletes == 0)
            {
                MessageBox.Show("No product found");
                return;
            }
            products = new BindingList<Product>(products.Where(p => p.Origin != txtDeleteOrigin.Text).ToList());
            dgProduct.DataSource = null;
            dgProduct.DataSource = products;
            MessageBox.Show($"Deleted all products from {txtDeleteOrigin.Text}, Deletes: {deletes}");
        }

        private void btnFilterProductByRange_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtPriceFrom.Text) || string.IsNullOrEmpty(txtPriceTo.Text))
            {
                MessageBox.Show("Price range is required");
                return;
            }
            double priceFrom = double.Parse(txtPriceFrom.Text);
            double priceTo = double.Parse(txtPriceTo.Text);
            filterProducts = new BindingList<Product>(products.Where(p => p.Price >= priceFrom && p.Price <= priceTo).ToList());
            dgFilteredProduct.DataSource = null;
            dgFilteredProduct.DataSource = filterProducts;
        }

        private void btnCheckIfExistExpiredProduct_Click(object sender, EventArgs e)
        {
            Boolean isExist = products.Any(p => p.ExpiredDate <= DateTime.Now);
            if (isExist)
            {
                MessageBox.Show("There is at least one product that has expired");
            }
            else
            {
                MessageBox.Show("There is no product that has expired");
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductId.Text))
            {
                MessageBox.Show("Product ID is required");
                return;
            }
            int deletes = products.Count(p => p.Id == int.Parse(txtProductId.Text));
            if (deletes == 0)
            {
                MessageBox.Show("No product found");
                return;
            }
            products = new BindingList<Product>(products.Where(p => p.Id != int.Parse(txtProductId.Text)).ToList());
            dgProduct.DataSource = null;
            dgProduct.DataSource = products;
            MessageBox.Show($"Deleted product with ID {txtProductId.Text}, Deletes: {deletes}");
        }

        private void btnDeleteAllProduct_Click(object sender, EventArgs e)
        {
            products.Clear();
        }

        private void btnDeleteAllExpiredProduct_Click(object sender, EventArgs e)
        {
            products = new BindingList<Product>(products.Where(p => p.ExpiredDate > DateTime.Now).ToList());
            dgProduct.DataSource = null;
            dgProduct.DataSource = products;
        }
    }
}
