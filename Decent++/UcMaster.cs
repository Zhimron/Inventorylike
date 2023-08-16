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
    public partial class UcMaster : UserControl
    {
        public UcMaster()
        {
            InitializeComponent();
        }
        public void loaddatas()
        {
            string sql = "SELECT * from tbl_newmaster";
            MySqlConnection conn = Connection.GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            dgv_sample.Rows.Clear();

            while (dr.Read()) // Read and process each row
            {
                dgv_sample.Rows.Add(
                    dr["p_code"].ToString(),
                    dr["product"].ToString(),
                    dr["U_measure"].ToString(),
                    dr["price"].ToString()
                );
            }

            dr.Close(); // Close the reader
            conn.Close(); // Close the connection
        }
        private void UcMaster_Load(object sender, EventArgs e)
        {
            loaddatas();
        }
    }
}
