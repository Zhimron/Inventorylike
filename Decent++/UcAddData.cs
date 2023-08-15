using MySql.Data.MySqlClient;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decent__
{
    public partial class UcAddData : UserControl
    {
        public UcAddData()
        {
            InitializeComponent();
        }
        public void loaddata(string query)
        {
            string sql = query ;
            MySqlConnection con = Connection.GetConnection(); //get the connection
            MySqlCommand cmd = new MySqlCommand(sql, con); // use a command then store the query and connection
            MySqlDataReader dr = cmd.ExecuteReader(); //use a reader to store the data 

            dgv_datas.Rows.Clear();//clear the datagrid first
            dr.Read();
            if (dr.HasRows)
            {
                while (dr.Read())//output every row in the table
                {
                    dgv_datas.Rows.Add(dr["Product_code"].ToString(),
                        dr["Product_name"].ToString(),
                        dr["Description"].ToString(),
                        dr["Stock_count"].ToString(),
                        dr["Category"].ToString());
                }
            }

           

            dr.Close();//close the reader
            con.Close();//close the connection
          
        }
        public void loadcmb()
        {
            string sql = "SELECT * FROM tbl_category";
            MySqlConnection con = Connection.GetConnection(); //get the connection
            MySqlCommand cmd = new MySqlCommand(sql, con); // use a command then store the query and connection
            MySqlDataReader dr = cmd.ExecuteReader();
            ComboBox.Items.Clear();
            while (dr.Read())
            {
                ComboBox.Items.Add(dr["category"].ToString());
            }
            dr.Close();
                con.Close();
        }
        private void UcAddData_Load(object sender, EventArgs e)
        {
            loaddata("SELECT * from db_data");
            loadcmb();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if(txtcode.Text == string.Empty || txtname.Text == string.Empty || txtdescrip.Text == string.Empty || txtstock.Text == string.Empty || txtcategory.Text == string.Empty)
            {   
                MessageBox.Show("All field required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
            string sql = "INSERT INTO db_data (Product_code,Product_name,Description,Stock_count,Category) VALUES(@code,@name,@desc,@stock,@category)";
            MySqlConnection con = Connection.GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@code", MySqlDbType.VarChar).Value = txtcode.Text;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = txtname.Text;
            cmd.Parameters.Add("@desc", MySqlDbType.VarChar).Value = txtdescrip.Text;
            cmd.Parameters.Add("@stock", MySqlDbType.Int32).Value = txtstock.Text;
            cmd.Parameters.Add("@category", MySqlDbType.VarChar).Value = txtcategory.Text;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("ADDED SUCCESSFUL", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddata("SELECT * from db_data");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ADDED UNSUCCESSFUL \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con.Close();
            }
        }

        private void btntext_Click(object sender, EventArgs e)
        {
            dgv_datas.SelectAll();

            StringBuilder sb = new StringBuilder();
            foreach (DataGridViewRow row in dgv_datas.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    sb.Append(cell.Value);
                    sb.Append("\t");
                }
                sb.Length--;
                sb.AppendLine();
            }
            string textContent = sb.ToString();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt";
            saveFileDialog.Title = "Save Output Text File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                File.WriteAllText(filePath, textContent);

                MessageBox.Show("Data converted and saved to " + filePath);
            }
        }
        private void ExportToExcel(DataGridView dataGridView, string filePath)
        {
            using (var package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1"); // Create a worksheet


                for (int columnIndex = 0; columnIndex < dataGridView.Columns.Count; columnIndex++)
                {
                    worksheet.Cells[1, columnIndex + 1].Value = dataGridView.Columns[columnIndex].HeaderText;
                }

                // Loop through each data row in the DataGridView
                for (int rowIndex = 0; rowIndex < dataGridView.Rows.Count; rowIndex++)
                {
                    DataGridViewRow dataGridViewRow = dataGridView.Rows[rowIndex];

                    // Loop through each cell in the row
                    for (int columnIndex = 0; columnIndex < dataGridViewRow.Cells.Count; columnIndex++)
                    {
                        DataGridViewCell dataGridViewCell = dataGridViewRow.Cells[columnIndex];
                        // Check if the cell contains a date value
                        if (dataGridViewCell.Value is DateTime dateValue)
                        {
                            // Format the date as a string in "mm/dd/yyyy" format
                            dataGridViewCell.Value = dateValue.ToString("MM/dd/yyyy");
                        }
                        worksheet.Cells[rowIndex + 2, columnIndex + 1].Value = dataGridViewCell.Value;
                    }
                }

                FileInfo excelFile = new FileInfo(filePath);
                package.SaveAs(excelFile); // Save the Excel package to the file
            }
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save Excel File";
                saveFileDialog.FileName = "output.xlsx"; // Default file name

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    ExportToExcel(dgv_datas, filePath); // Pass the DataGridView and file path to the method

                    MessageBox.Show($"Data converted and saved to {filePath}");
                }
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddata("SELECT * from db_data Where Category like '"+ ComboBox.Text +"'");
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            loaddata("SELECT * from db_data Where Category like '" + guna2TextBox1.Text + "'");
        }

        private void dgv_datas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
