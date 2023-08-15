using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Decent__
{
    public partial class Ucout : UserControl
    {
        public Ucout()
        {
            InitializeComponent();
        }
        public void loaddatas()
        {
            string sql = "SELECT * from tbl_out";
            MySqlConnection conn = Connection.GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            dgv_sample.Rows.Clear();

            while (dr.Read()) // Read and process each row
            {
                dgv_sample.Rows.Add(
                    dr["transac_Id"].ToString(),
                    dr["p_code"].ToString(),
                    dr["product"].ToString(),
                    dr["U_measure"].ToString(),
                    dr["stock_out"].ToString(),
                    dr["price"].ToString()
                );
            }

            dr.Close(); // Close the reader
            conn.Close(); // Close the connection
        }


        private void Ucout_Load(object sender, EventArgs e)
        {
            loaddatas();
        }
    }
}
