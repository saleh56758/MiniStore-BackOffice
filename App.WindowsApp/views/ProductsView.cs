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
using App.Core.Models;
using App.Core.Utilities;
using App.WindowsApp.Forms;
using WindowsFormsApp1.Forms;
namespace App.WindowsApp.views
{
    public partial class ProductsView : UserControl
    {
        IproductService _service;
        BindingSource _dgvbindingSource = new BindingSource();
        public ProductsView(IproductService ser)

        {
            _service = ser;
            InitializeComponent();
            dgvproducts.DataSource = _dgvbindingSource;

        }

        private void ProductsView_Load(object sender, EventArgs e)
        {
            cmbcategory.Items.Clear();
            cmbcategory.Items.Add("--All--");
            cmbcategory.Items.AddRange(Enum.GetNames(typeof(ProductCategoryEnum)));
            cmbcategory.SelectedIndex = 0;
            cmbstatus.Items.Clear();
            cmbstatus.Items.Add("--All--");
            cmbstatus.Items.AddRange(Enum.GetNames(typeof(ProductStatusEnum)));
            cmbstatus.SelectedIndex = 0;
            if (_service == null)
                return;
            _service.GetAll();
            _dgvbindingSource.DataSource = _service.GetAll(); 


        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            ProductsForm prodForm=new ProductsForm(ProductFormModeEnum.Add,null);
            prodForm.ShowDialog();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvbindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductsForm prodForm = new ProductsForm(ProductFormModeEnum.View, selectedProduct);
                prodForm.ShowDialog();
            }

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            Product? selectedProduct=_dgvbindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductsForm prodForm = new ProductsForm(ProductFormModeEnum.Edit, selectedProduct);
                prodForm.ShowDialog();
            }
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
