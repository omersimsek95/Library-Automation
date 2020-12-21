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

namespace LibraryAutomation
{
    public partial class FormHistory : Form
    {
        public FormHistory()
        {
            InitializeComponent();
        }

        public string stdNo;
        MySqlConnection mySqlConnection = new MySqlConnection();

        private void FormHistory_Load(object sender, EventArgs e)
        {
            listhistory();
        }

        void listhistory()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT b.BookId AS ISBN, b.Title AS KitapAdi, r.Date_of_Issue AS IstekTarihi, r.Due_Date AS VerilmeTarihi, r.Date_of_Return AS IadeTarihi, r.Dues AS CEZA FROM record r INNER JOIN book b ON r.BookId = b.BookId WHERE r.RollNo = @P1 AND r.Date_of_Return IS NOT NULL", mySqlConnection.connection());
            da.SelectCommand.Parameters.AddWithValue("@P1", stdNo);
            mySqlConnection.connection().Close();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
    }
}
