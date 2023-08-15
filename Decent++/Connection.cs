using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
namespace Decent__
{
    class Connection
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "server=localhost;user id=root;password=;database=test";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR CONNECTION! \n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }
            return con;
        }
    }
}
