using App.Core.Models;
using App.Core.Utilities;
using App.WindowsApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Core.Contracts;
using App.Core.Services;
namespace WindowsFormsApp1.Forms
{
    public partial class ProductsForm : Form
    {
        ProductFormModeEnum _mode;
        Product product;
        IproductService _service;
        public ProductsForm(ProductFormModeEnum mode, Product? p, IproductService service)
        {
            InitializeComponent();
            numPrice.Maximum = Decimal.MaxValue;
            numStock.Maximum = Decimal.MaxValue;
            cmbCat.Items.Clear();

            cmbCat.DataSource = Enum.GetValues(typeof(ProductCategoryEnum));
            cmbCat.SelectedIndex = 0;
            cmbStatus.Items.Clear();

            cmbStatus.DataSource = Enum.GetValues(typeof(ProductStatusEnum));
            cmbStatus.SelectedIndex = 0;

            _mode = mode;
            _service = service;

            // Ensure non-nullable field `product` is always assigned
            if (mode == ProductFormModeEnum.Edit || mode == ProductFormModeEnum.View)
            {
                if (p == null)
                    throw new ArgumentNullException(nameof(p), "Product must be provided when opening in Edit or View mode.");
                product = p;
            }
            else
            {
                product = new Product();
            }

            if (mode == ProductFormModeEnum.View)
            {
                btnsave.Visible = false;
            }
            else if (mode == ProductFormModeEnum.Edit)
            {
                btnsave.Text = "Update";
            }

            if (mode == ProductFormModeEnum.Edit || mode == ProductFormModeEnum.View)
            {
                txtID.Text = product.ID;
                txtName.Text = product.Name;
                cmbCat.SelectedItem = product.Category;
                cmbStatus.SelectedItem = product.Status;
                numPrice.Value = product.Price;
                numStock.Value = product.Stock;
            }


        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (_mode == ProductFormModeEnum.Add)
            {
                Product newProduct = new Product();
                newProduct.Name = txtName.Text;
                newProduct.Category = cmbCat.SelectedItem is ProductCategoryEnum cat ? cat : ProductCategoryEnum.None;
                newProduct.Status = cmbStatus.SelectedItem is ProductStatusEnum st ? st : ProductStatusEnum.None;
                newProduct.Price = numPrice.Value;
                newProduct.Stock = (int)numStock.Value;

                //product =_service.Add(newProduct);
                //txtID.Text = newProduct.ID;

                Product temp = _service.Add(newProduct);
                txtID.Text = temp?.ID ?? "";
            }
            else if (_mode == ProductFormModeEnum.Edit)
            {
                product.Name = txtName.Text;
                product.Category = cmbCat.SelectedItem is ProductCategoryEnum cat ? cat : ProductCategoryEnum.None;
                product.Status = cmbStatus.SelectedItem is ProductStatusEnum st ? st : ProductStatusEnum.None;
                product.Price = numPrice.Value;
                product.Stock = (int)numStock.Value;
                bool isUpdated = _service.Update(product);
            }
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
