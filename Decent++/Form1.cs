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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void users<T>() where T : UserControl, new()
        {
            UserControl newest = new T();
            Controller(newest);
        }
        private void Controller(UserControl user)
        {
            user.Dock = DockStyle.Fill;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(user);
            user.BringToFront();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnData_Click(object sender, EventArgs e)
        {
            users<UcAddData> ();
        }

        private void BtnImports_Click(object sender, EventArgs e)
        {
            users<Import>();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            users<UcPos>();
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            users<Ucin>();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            users<Ucout>();
        }
    }
}
