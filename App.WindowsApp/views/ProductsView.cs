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
using App.Core.Services;

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

            // guard against designer not having created the control (nullable warnings)
            if (dgvproducts != null)
                dgvproducts.DataSource = _dgvbindingSource;
        }

        private void ProductsView_Load(object sender, EventArgs e)
        {
            // guard controls that the designer may have marked nullable
            if (cmbcategory == null || cmbstatus == null || txtboxsearch == null)
                return;

            // Populate category ComboBox: add a sentinel "--All--" then enum values as items
            cmbcategory.Items.Clear();
            cmbcategory.Items.Add("--All--");
            foreach (var val in Enum.GetValues(typeof(ProductCategoryEnum)).Cast<ProductCategoryEnum>())
                cmbcategory.Items.Add(val);
            cmbcategory.SelectedIndex = 0;

            // Populate status ComboBox similarly
            cmbstatus.Items.Clear();
            cmbstatus.Items.Add("--All--");
            foreach (var val in Enum.GetValues(typeof(ProductStatusEnum)).Cast<ProductStatusEnum>())
                cmbstatus.Items.Add(val);
            cmbstatus.SelectedIndex = 0;

            if (_service == null)
                return;

            _dgvbindingSource.DataSource = _service.GetAll();


        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            ProductsForm prodForm = new ProductsForm(ProductFormModeEnum.Add, null, _service);
            prodForm.ShowDialog();
            refreshGrid();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvbindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductsForm prodForm = new ProductsForm(ProductFormModeEnum.View, selectedProduct, _service);
                prodForm.ShowDialog();
            }

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvbindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductsForm prodForm = new ProductsForm(ProductFormModeEnum.Edit, selectedProduct, _service);
                prodForm.ShowDialog();
                refreshGrid();
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {

        }

        private void refreshGrid()
        {
            if (_service == null || _dgvbindingSource == null)
                return;

            string searchText = txtboxsearch?.Text ?? string.Empty;

            ProductCategoryEnum? selectedCategory = null;
            if (cmbcategory?.SelectedItem != null)
            {
                var sel = cmbcategory.SelectedItem.ToString();
                if (!string.IsNullOrEmpty(sel) && !sel.Equals("--All--", StringComparison.OrdinalIgnoreCase))
                {
                    if (Enum.TryParse<ProductCategoryEnum>(sel, out var parsedCat))
                        selectedCategory = parsedCat;
                }
            }

            ProductStatusEnum? selectedStatus = null;
            if (cmbstatus?.SelectedItem != null)
            {
                var sel = cmbstatus.SelectedItem.ToString();
                if (!string.IsNullOrEmpty(sel) && !sel.Equals("--All--", StringComparison.OrdinalIgnoreCase))
                {
                    if (Enum.TryParse<ProductStatusEnum>(sel, out var parsedStatus))
                        selectedStatus = parsedStatus;
                }
            }

            // Use search result (previous code overwrote it with GetAll())
            _dgvbindingSource.DataSource = _service.Search(searchText, selectedCategory, selectedStatus);
        }

        private void txtboxsearch_TextChanged(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void cmbcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshGrid();
        }
        private void cmbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshGrid();
        }
    }


}
