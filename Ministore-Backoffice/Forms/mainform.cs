using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.views;

namespace WindowsFormsApp1.forms
{
    public partial class mainform : Form

    {
        private Button _activeviewbutton;
        private readonly Color NavNormalBack = Color.FromArgb(244, 244, 246);
        private readonly Color NavActiveBack = Color.FromArgb(153, 153, 161);
        private readonly Color NavNormalFore = Color.Black;
        private readonly Color NavActiveFore = Color.Black;
        private readonly Color NavHoverBack = Color.FromArgb(153, 153, 161);
        private readonly Dictionary<Type, UserControl> _views = new Dictionary<Type, UserControl>();
        public mainform()
        {
            InitializeComponent();
        }
        private void SetActiveNavButton(Button btn)
        {
            if (btn == null) return;
            if (_activeviewbutton != null)
            {
                _activeviewbutton.BackColor = NavNormalBack;
                _activeviewbutton.ForeColor = NavNormalFore;
                _activeviewbutton.Font = new Font(_activeviewbutton.Font, FontStyle.Regular);
                
            }

            { _activeviewbutton = btn;
             _activeviewbutton.BackColor = NavActiveBack;
             _activeviewbutton.ForeColor = NavActiveFore;
             _activeviewbutton.Font = new Font(_activeviewbutton.Font, FontStyle.Bold);

            }

        }
        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pnlsidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlcontent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void flpleft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainform_Load(object sender, EventArgs e)
        {
                   }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btn_dashboard_Click(Object sender, EventArgs e)
        {
            SetActiveNavButton(btndashboard);
            //pnlContent.Controls.Clear();
            //pnlContent.Controls.Add(new DashboardView());
            ShowView(() => new DashboardView());
        }
        private void btn_products_Click(Object sender, EventArgs e)
        { SetActiveNavButton(btnproducts);
            //pnlContent.Controls.Clear();
            //pnlContent.Controls.Add(new ProductsView());
            ShowView(() => new ProductsView());

        }
        private void btn_Orders_Click(Object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            SetActiveNavButton(btnorders);
          
          

        }
        private void btn_Settings_Click(Object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            SetActiveNavButton(btnsettings);
         

        }
        private void btn_Log_Click(Object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            SetActiveNavButton(btnlogs);
            

        }
        private void btn_Reports_Click(Object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            SetActiveNavButton(btnreports);
            

        }
        private void bt_Sync_Click(Object sender, EventArgs e)

        {
            pnlContent.Controls.Clear();
            SetActiveNavButton(btnsync);
           

        }
        
        private void ShowView<T>(Func<T> factory) where T:UserControl
        {
            var key = typeof(T);
            if (!_views.TryGetValue(key, out var view))
            {
                view = factory();
                _views[key] = view;
                view.Dock = DockStyle.Fill;
            }
                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(view);
            
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
