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
                    dr["price"].ToString(),"Portion", "Out"
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
                string prc = srow.Cells["prc"].Value.ToString();
                //string price = srow.Cells["prc"].Value.ToString();
                Form2 newest = new Form2(pCode, product, measure, ins, prc);
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            loaddatas();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void cmbmeasurement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbmeasurement.Text == "Others")
            {
                txtmeasure.Visible = true;
                txtmeasure.Enabled = true;
            }
            else
            {
                txtmeasure.Visible = false;
                txtmeasure.Enabled = false;
            }
            
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtcode.Text)&& String.IsNullOrEmpty(txtmeasure.Text)&& String.IsNullOrEmpty(txtprice.Text)&& String.IsNullOrEmpty(txtprod.Text)&&
                String.IsNullOrEmpty(txtqty.Text))
            {
                MessageBox.Show("All Field Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {           
                string sql = "insert into tbl_newmaster (p_code,product,U_measure,price,qty,stock_in) VALUES(@code,@prod,@measure,@price,@qty,@stock)";
                string insql = "INSERT into tbl_newin (p_code,product,U_measure,price,stock_in) VALUES(@code,@prod,@measure,@price,@stock)";
                using (MySqlConnection con = Connection.GetConnection())
                {
                    using (MySqlCommand incmd = new MySqlCommand(insql, con))
                    { 
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.CommandType = CommandType.Text;
                            incmd.CommandType = CommandType.Text;
                        if (txtmeasure.Visible == true)
                        {
                                    incmd.Parameters.Add("@measure", MySqlDbType.VarChar).Value = txtmeasure.Text;
                                cmd.Parameters.Add("@measure", MySqlDbType.VarChar).Value = txtmeasure.Text;
                        }
                        else
                        {
                                    incmd.Parameters.Add("@measure", MySqlDbType.VarChar).Value = cmbmeasurement.Text;
                                cmd.Parameters.Add("@measure", MySqlDbType.VarChar).Value = cmbmeasurement.Text;
                            }
                        cmd.Parameters.Add("@code", MySqlDbType.VarChar).Value = txtcode.Text;
                        cmd.Parameters.Add("@prod", MySqlDbType.VarChar).Value = txtprod.Text;
                        cmd.Parameters.Add("@qty", MySqlDbType.Int32).Value = txtqty.Text;
                        cmd.Parameters.Add("@price", MySqlDbType.Int32).Value = txtprice.Text;
                        cmd.Parameters.Add("@stock", MySqlDbType.Int32).Value = txtqty.Text;
                            incmd.Parameters.Add("@code", MySqlDbType.VarChar).Value = txtcode.Text;
                            incmd.Parameters.Add("@prod", MySqlDbType.VarChar).Value = txtprod.Text;
                            incmd.Parameters.Add("@price", MySqlDbType.Int32).Value = txtprice.Text;
                            incmd.Parameters.Add("@stock", MySqlDbType.Int32).Value = txtqty.Text;
                        try
                        {
                            incmd.ExecuteNonQuery();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("New Product Addded", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loaddatas();
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Unsuccessful\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
                        }

                    }
                    }
                }
            }
           
        }
    }
}
