using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace LibraryAutomation
{
    class MySqlConnection
    {
        public MySql.Data.MySqlClient.MySqlConnection connection()
        {
            MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection("Server = www.yorumdeposu.com; Database = yorumdeposu_com_library; Uid = yorum_librarian; Pwd = blablabla3; CharSet = utf8;");
            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("İnternet bağlantınızı kontrol ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connection;
        }
    }
}
