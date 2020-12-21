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
    public partial class FormHomePage : Form
    {
        public FormHomePage()
        {
            InitializeComponent();
        }

        MySqlConnection mySqlConnection = new MySqlConnection();

        private void FormHomePage_Load(object sender, EventArgs e)
        {
            showChart();
        }

        void showChart()
        {
            chartMaxDue.Series["Series 1"].Points.Clear();
            MySqlCommand command = new MySqlCommand("SELECT u.name, SUM(r.Dues) FROM record r INNER JOIN user u ON u.RollNo = r.RollNo WHERE r.Date_of_Return IS NOT NULL GROUP BY u.RollNo ORDER BY SUM(r.Dues) DESC LIMIT 10", mySqlConnection.connection());
            MySqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                chartMaxDue.Series["Series 1"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
            }

            chartMaxHistory.Series["Series 1"].Points.Clear();
            MySqlCommand command1 = new MySqlCommand("SELECT u.name, COUNT(r.RollNo) FROM record r INNER JOIN user u ON u.RollNo = r.RollNo WHERE r.Date_of_Return IS NOT NULL GROUP BY r.RollNo ORDER BY COUNT(r.RollNo) DESC LIMIT 10", mySqlConnection.connection());
            MySqlDataReader dr1 = command1.ExecuteReader();
            while (dr1.Read())
            {
                chartMaxHistory.Series["Series 1"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr1[0], dr1[1]));
            }

            chartCountCategory.Series["Series 1"].Points.Clear();
            MySqlCommand command2 = new MySqlCommand("SELECT Category, COUNT(Category) FROM book GROUP BY Category ORDER BY COUNT(Category) DESC LIMIT 10", mySqlConnection.connection());
            MySqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                chartCountCategory.Series["Series 1"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }

            chartMaxBorrow.Series["Series 1"].Points.Clear();
            MySqlCommand command3 = new MySqlCommand("SELECT b.Title, COUNT(r.BookId) FROM record r INNER JOIN book b ON b.BookId = r.BookId WHERE r.Date_of_Return IS NOT NULL GROUP BY b.Title ORDER BY COUNT(r.BookId) DESC LIMIT 10", mySqlConnection.connection());
            MySqlDataReader dr3 = command3.ExecuteReader();
            while (dr3.Read())
            {
                chartMaxBorrow.Series["Series 1"].Points.AddPoint(Convert.ToString(dr3[0]), int.Parse(dr3[1].ToString()));
            }

            mySqlConnection.connection().Close();
        }

        private void simpleButtonRefresh_Click(object sender, EventArgs e)
        {
            showChart();
        }
    }
}
