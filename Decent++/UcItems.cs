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
    public partial class UcItems : UserControl
    {
        private string _code;
        private string _prod;
        private string _price;

        public string Code
        {
            get { return _code; }
            set { _code = value; lblcode.Text = value;}
        }
        public string Product
        {
            get { return _prod; }
            set { _prod = value; lblprod.Text = value; }
        }       
        public string price
        {
            get { return _price; }
            set { _price = value; lblprice.Text = value; }
        }



        public UcItems()
        {
            InitializeComponent();
        }
    }
}
