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
    public partial class Form3 : Form
    {
        private string pCode;
        private string product;
        private string measure;
        private string ins;
        private string prc;

        public Form3(string pCode, string product, string measure, string ins, string prc)
        {
            InitializeComponent();
            lblcode.Text = pCode;
            lblprod.Text = product;
            lblmeasure.Text = measure;
            lblstock.Text = ins;
            lblprc.Text = prc;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            int transaction = GetNextTransactionId();
            lbltransaction_id.Text = $"{transaction}";
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

        private void btnportioned_Click(object sender, EventArgs e)
        {
            if (float.TryParse(lblprc.Text, out float price) && int.TryParse(txtqtyportioned.Text, out int quantity))
            {

                float total_price = price * quantity;
                float total_stock = float.Parse(lblstock.Text) - quantity;
                string sql = "INSERT INTO tbl_out (p_code, product, stock_out, U_measure, price, transac_Id) VALUES (@code, @product, @out, @measure, @price, @id)";
                string updatesql = "UPDATE tbl_newmaster SET qty=@qty WHERE U_measure = @measure AND product = @product";

                using (MySqlConnection con = Connection.GetConnection())
                {


                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    using (MySqlCommand updatecmd = new MySqlCommand(updatesql, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@code", lblcode.Text);
                        cmd.Parameters.AddWithValue("@product", lblprod.Text);
                        cmd.Parameters.AddWithValue("@out", quantity);
                        cmd.Parameters.AddWithValue("@measure", lblmeasure.Text);
                        cmd.Parameters.AddWithValue("@price", total_price);
                        cmd.Parameters.AddWithValue("@id", int.Parse(lbltransaction_id.Text));

                        updatecmd.Parameters.AddWithValue("@qty", total_stock);
                        updatecmd.Parameters.AddWithValue("@measure", lblmeasure.Text);
                        updatecmd.Parameters.AddWithValue("@product", lblprod.Text);

                        try
                        {
                            updatecmd.ExecuteNonQuery();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("OUT SUCCESSFUL", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
