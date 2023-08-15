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
    public partial class Form2 : Form
    {
        private string pCode;
        private string product;
        private string measure;
        private string ins;

        public Form2()
        {
            InitializeComponent();

        }

        public Form2(string pCode, string product, string measure, string ins)
        {
            InitializeComponent();
            label1.Text = pCode;
            label2.Text = product;
            label3.Text = measure;
            label4.Text = ins;
        }
        void check(ref string measures, ref string products, ref string count)
        {
            MySqlConnection con = Connection.GetConnection();
            string selectsql = "select U_measure,product,qty from tbl_newmaster where p_code = '" + label1.Text + "'";
            MySqlCommand selectcmd = new MySqlCommand(selectsql, con);
            MySqlDataReader dr = selectcmd.ExecuteReader();
            dr.Read();
            while (dr.Read())
            {
                measures = dr.GetString(0);
                products = dr.GetString(1);
                count = dr.GetString(2);
            }
            dr.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            int newTransactionId = GetNextTransactionId();

            label5.Text = $"{newTransactionId}";
        }
        private int GetNextTransactionId()
        {
            using (MySqlConnection connection = Connection.GetConnection())
            using (MySqlCommand command = new MySqlCommand("SELECT MAX(transac_Id) FROM tbl_out", connection))
            {
                
                var result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result) + 1;
                }
                return 1; // No existing transaction, start from 1
            }
        }
        private void LoadPortioned()
        {
            using (MySqlConnection connection = Connection.GetConnection())
            {
                string productName = label2.Text + "pcs";
                string selectSql = "SELECT p_code, product, u_measure, qty, price FROM tbl_newmaster WHERE p_code = @pCode AND product = @productName AND u_measure = 'Pcs'";

                MySqlCommand portionedCmd = new MySqlCommand(selectSql, connection);
                portionedCmd.Parameters.AddWithValue("@pCode", label1.Text);
                portionedCmd.Parameters.AddWithValue("@productName", productName);

                using (MySqlDataReader dr = portionedCmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        label7.Text = dr.GetString(0);
                        label8.Text = dr.GetString(1);
                        label9.Text = dr.GetString(2);
                        label10.Text = dr.GetString(3);
                        lblprice.Text = dr.GetString(4);
                    }
                }
            }
        }

        private void btns_Click(object sender, EventArgs e)
        {
            if (label3.Text == "Box")

            {
                float fvalue = float.Parse(txtqty.Text);
                float newvalue = fvalue * 60;
                string bald = label2.Text + "pcs";// new product name
                string sql = "Insert into tbl_newin (p_code,product,stock_in,U_measure,price) Values(@code,@prod,@stock,@measure,@price)";
                MySqlConnection con = Connection.GetConnection();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@code", MySqlDbType.VarChar).Value = label1.Text;
                cmd.Parameters.Add("@prod", MySqlDbType.VarChar).Value = bald;
                cmd.Parameters.Add("@stock", MySqlDbType.Int32).Value = newvalue;
                cmd.Parameters.Add("@measure", MySqlDbType.VarChar).Value = "Pcs";
                cmd.Parameters.Add("@price", MySqlDbType.Int32).Value = txtprice.Text;

                string measures = "";
                string products = "";
                string count = "";

                check(ref measures, ref products, ref count);

                if (string.IsNullOrEmpty(measures) && string.IsNullOrEmpty(products))
                {// if theres no produt it will create a new because you portioned it
                    string sql1 = "Insert into tbl_newmaster (p_code,product,stock_in,U_measure,price,qty) Values(@code,@prod,@stock,@measure,@price,@qty)";
                    MySqlCommand cmd1 = new MySqlCommand(sql1, con);
                    cmd1.CommandType = CommandType.Text;
                    cmd1.Parameters.Add("@code", MySqlDbType.VarChar).Value = label1.Text;
                    cmd1.Parameters.Add("@prod", MySqlDbType.VarChar).Value = bald;
                    cmd1.Parameters.Add("@qty", MySqlDbType.Int32).Value = newvalue;
                    cmd1.Parameters.Add("@stock", MySqlDbType.Int32).Value = newvalue;
                    cmd1.Parameters.Add("@measure", MySqlDbType.VarChar).Value = "Pcs";
                    cmd1.Parameters.Add("@price", MySqlDbType.Int32).Value = txtprice.Text;
                    cmd1.ExecuteNonQuery();
                }
                else
                {
                    float Qty = float.Parse(count);
                   
                    if(measures == "Box") //to update the master list where you only need to minus your stock

                    {
                        Qty = Qty - fvalue;
                        string updatesql = "update from tbl_newmaster set qty=@qty where U_measure = '" + measures + "', product = '" + products + "'";
                        MySqlCommand updatecmd = new MySqlCommand(updatesql, con);
                        updatecmd.CommandType = CommandType.Text;
                        updatecmd.Parameters.Add("@qty", MySqlDbType.Int32).Value = Qty;
                        updatecmd.ExecuteNonQuery();
                    }
                    else
                    {//to update the master list if theres already a product in the system
                        Qty = Qty + fvalue;
                        string updatesql = "update from tbl_newmaster set qty=@qty where U_measure = '" + measures + "', product = '" + products + "'";
                        MySqlCommand updatecmd = new MySqlCommand(updatesql, con);
                        updatecmd.CommandType = CommandType.Text;
                        updatecmd.Parameters.Add("@qty", MySqlDbType.Int32).Value = Qty;
                        updatecmd.ExecuteNonQuery();
                    }
                  

                }
                            

                string sql2 = "Insert into tbl_out (p_code,product,stock_out,U_measure,price,transac_Id) Values(@code,@prod,@stock,@measure,@price,@id)"; //insert an out of the product
                MySqlCommand cmd2 = new MySqlCommand(sql2, con);
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.Add("@code", MySqlDbType.VarChar).Value = label1.Text;
                cmd2.Parameters.Add("@prod", MySqlDbType.VarChar).Value = label2.Text;
                cmd2.Parameters.Add("@stock", MySqlDbType.Int32).Value = fvalue;
                cmd2.Parameters.Add("@measure", MySqlDbType.VarChar).Value = "Box";
                cmd2.Parameters.Add("@price", MySqlDbType.Int32).Value = txtprice.Text;
                cmd2.Parameters.Add("@id", MySqlDbType.Int32).Value = label5.Text;

                try
                {
                    //upcmd.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();

                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("ADD SUCCESSFUL", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPortioned();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("UNSUCCESSFUL \n" + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
        }

        private void btnportioned_Click(object sender, EventArgs e)
        {
            if (float.TryParse(lblprice.Text, out float price) && int.TryParse(txtqtyportioned.Text, out int quantity))
            {
             
                float total_price = price * quantity;
                float total_stock = float.Parse(label10.Text) - quantity;
                string sql = "INSERT INTO tbl_out (p_code, product, stock_out, U_measure, price, transac_Id) VALUES (@code, @product, @out, @measure, @price, @id)";
                string updatesql = "UPDATE tbl_newmaster SET qty=@qty WHERE U_measure = @measure AND product = @product";

                using (MySqlConnection con = Connection.GetConnection())
                {
                    

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    using (MySqlCommand updatecmd = new MySqlCommand(updatesql, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@code", label7.Text);
                        cmd.Parameters.AddWithValue("@product", label8.Text);
                        cmd.Parameters.AddWithValue("@out", quantity);
                        cmd.Parameters.AddWithValue("@measure", label9.Text);
                        cmd.Parameters.AddWithValue("@price", total_price);
                        cmd.Parameters.AddWithValue("@id", int.Parse(label5.Text));

                        updatecmd.Parameters.AddWithValue("@qty", total_stock);
                        updatecmd.Parameters.AddWithValue("@measure", label9.Text);
                        updatecmd.Parameters.AddWithValue("@product", label8.Text);

                        try
                        {
                            updatecmd.ExecuteNonQuery();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("ADD SUCCESSFUL", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("UNSUCCESSFUL \n" + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid price or quantity.");
            }
        }

    }
}
