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
namespace WindowsFormsApp1.Forms
{
    public partial class ProductsForm : Form
    {
        ProductFormModeEnum _mode;
        public ProductsForm(ProductFormModeEnum mode, Product? p)
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
                txtID.Text = p.ID;
                txtName.Text = p.Name;
                cmbCat.SelectedItem = p.Category;
                cmbStatus.SelectedItem = p.Status;
                numPrice.Value = p.Price;
                numStock.Value = p.Stock;
            }


        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (_mode == ProductFormModeEnum.Add)
            {
            }
        }
    }
}
