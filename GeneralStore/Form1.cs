using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralStore
{
    public partial class Form1 : Form
    {
        ProductDal _productDal=new ProductDal();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            using (GeneralStoreContext context = new GeneralStoreContext())
            {
                dgvProduct.DataSource = _productDal.GetAllProduct();
            }
        }
        private void SearchProductsByName(string key)
        {
            var result = _productDal.GetProductByName(key);
            dgvProduct.DataSource = result;
        }

        private void SearchProductsById(int keyId)
        {
            var result = _productDal.GetProductById(keyId);
            dgvProduct.DataSource = result;
        }

        private void ShowProductsByRangePrice(decimal minPrice, decimal maxPrice)
        {
            var result = _productDal.GetProductByPriceRange(minPrice,maxPrice);
            dgvProduct.DataSource = result;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _productDal.AddProduct(new Product
                {
                    ProductName = tbxProductNameAdd.Text,
                    ProductPrice = Convert.ToDecimal(tbxProductPriceAdd.Text),
                    ProductStockAmount = Convert.ToInt32(tbxProductStockAmountAdd.Text)
                });
                LoadProducts();
                MessageBox.Show("Product Added");
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxProductNameUpdate.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
            tbxProductPriceUpdate.Text = dgvProduct.CurrentRow.Cells[2].Value.ToString();
            tbxProductStockAmountUpdate.Text = dgvProduct.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _productDal.UpdateProduct(new Product
                {
                    Id = Convert.ToInt32(dgvProduct.CurrentRow.Cells[0].Value.ToString()),
                    ProductName = tbxProductNameUpdate.Text,
                    ProductPrice = Convert.ToDecimal(tbxProductPriceUpdate.Text),
                    ProductStockAmount = Convert.ToInt32(tbxProductStockAmountUpdate.Text)
                });
                LoadProducts();
                MessageBox.Show("Product Updated");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            _productDal.DeleteProduct(new Product
            {
                Id = Convert.ToInt32(dgvProduct.CurrentRow.Cells[0].Value),
            });
            LoadProducts();
            MessageBox.Show("Product Deleted");

        }
        

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {

            SearchProductsByName(tbxSearchName.Text);
        }

        private void btxSearchId_Click(object sender, EventArgs e)
        {
            try
            {
                var keyId = Convert.ToInt32(tbxSearchId.Text);
                SearchProductsById(keyId);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btxRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnRange_Click(object sender, EventArgs e)
        {
            try
            {
                decimal minPrice = Convert.ToDecimal(tbxMinPrice.Text);
                decimal maxPrice = Convert.ToDecimal(tbxMaxPrice.Text);
                ShowProductsByRangePrice(minPrice, maxPrice);
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
