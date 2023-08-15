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
    public partial class UcPos : UserControl
    {
        public UcPos()
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
                    dr["qty"].ToString(),
                    dr["price"].ToString(),"ADD", "Out"
                );
            }

            dr.Close(); // Close the reader
            conn.Close(); // Close the connection
        }
      

   


        private void dgv_sample_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 5)
            {
                DataGridViewRow srow = dgv_sample.Rows[e.RowIndex];
                string pCode = srow.Cells["code"].Value.ToString();
                string product = srow.Cells["prod"].Value.ToString();
                string measure = srow.Cells["mea"].Value.ToString();
                string ins = srow.Cells["QTY"].Value.ToString();
                //string price = srow.Cells["prc"].Value.ToString();
                Form2 newest = new Form2(pCode, product, measure, ins);
                newest.ShowDialog();
            }
            else if(e.ColumnIndex == 6)
            {
                DataGridViewRow srow = dgv_sample.Rows[e.RowIndex];
                string pCode = srow.Cells["code"].Value.ToString();
                string product = srow.Cells["prod"].Value.ToString();
                string measure = srow.Cells["mea"].Value.ToString();
                string ins = srow.Cells["QTY"].Value.ToString();
                string prc = srow.Cells["prc"].Value.ToString();
                Form3 newest = new Form3(pCode, product, measure, ins, prc);
                newest.ShowDialog();
            }
        }

        private void UcPos_Load(object sender, EventArgs e)
        {
            loaddatas();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
