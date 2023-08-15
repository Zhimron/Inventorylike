using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decent__
{
    public partial class Ucproduct : UserControl
    {
        public Ucproduct()
        {
            InitializeComponent();
        }
        private string _prod;
        private string _title;
        public string Product { get { return _prod; } set { _prod = value; lblprod.Text = value; } }
        public string Title { get { return _title; } set { _title = value; lblprice.Text = value; } }

        private void Ucproduct_Load(object sender, EventArgs e)
        {
            
        }
    }
}
