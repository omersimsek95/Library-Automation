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
    public partial class FormBorrow : Form
    {
        public FormBorrow()
        {
            InitializeComponent();
        }

        MySqlConnection mySqlConnection = new MySqlConnection();
        public int oldStatus = 0;

        private void FormBarrow_Load(object sender, EventArgs e)
        {
            /*
             * issue - istek tarihi
             * due - isteğin onaylanıp kitabın teslim edildiği tarih
             * return - kitabın kütüphaneye teslim edildiği tarih
             */

            listLend(); //verilebilecek
            listBorrow(); //alınacak
            listRequest(); //istek
            userStdNo();
        }

        void listLend()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT b.BookId AS ISBN, b.Title AS KitapAdi, a.Author AS Yazar, b.Category AS Kategori, b.Status AS Durum, b.Publisher AS Yayinevi, b.Year AS Yil, b.Availability AS Stok FROM book b INNER JOIN author a ON a.BookId = b.BookId WHERE b.Availability > 0", mySqlConnection.connection());
            mySqlConnection.connection().Close();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void listBorrow()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT r.RecordId AS RecordID, r.RollNo AS OgrenciNo, u.Name AS IsimSoyisim, r.BookId AS ISBN, b.Title AS KitapAdi, b.Status AS EskiDurum, r.Due_Date AS AldigiTarih, CASE WHEN (15 - DATEDIFF(DATE (NOW()), r.Due_Date)) >= 0 THEN (15 - DATEDIFF(DATE (NOW()), r.Due_Date)) ELSE 'CEZA' END AS KalanGunSayisi FROM record r INNER JOIN user u ON u.RollNo = r.RollNo INNER JOIN book b ON b.BookId = r.BookId WHERE r.Date_of_Return IS NULL", mySqlConnection.connection());
            mySqlConnection.connection().Close();
            da.Fill(dt);
            gridControl2.DataSource = dt;
            gridView2.Columns["RecordID"].Visible = false;
        }

        void listRequest()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT r.RollNo AS OgrenciNo, u.Name AS IsimSoyisim, r.BookId AS ISBN, b.Title AS KitapAdi, b.Category AS Kategori, b.Status AS Durum, r.Date_of_Issue AS IstekTarihi, CASE WHEN DATEDIFF(DATE(NOW()), r.Date_of_Issue) = 0 THEN 'Bugün' WHEN DATEDIFF(DATE(NOW()), r.Date_of_Issue) = 1 THEN 'Dun' WHEN DATEDIFF(DATE(NOW()), r.Date_of_Issue) = 2 THEN '2 Gun Once' WHEN DATEDIFF(DATE(NOW()), r.Date_of_Issue) = 3 THEN '3 Gun Once' WHEN DATEDIFF(DATE(NOW()), r.Date_of_Issue) = 4 THEN '4 Gun Once' WHEN DATEDIFF(DATE(NOW()), r.Date_of_Issue) = 5 THEN '5 Gun Once' ELSE '5 Gunden Once' END AS 'Istek Suresi' FROM request r INNER JOIN user u ON r.RollNo = u.RollNo INNER JOIN book b ON b.BookId = r.BookId ORDER BY r.Date_of_Issue", mySqlConnection.connection());
            mySqlConnection.connection().Close();
            da.Fill(dt);
            gridControl3.DataSource = dt;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////request//////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView3.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                textRequestIssueDate.Text = dr["IstekTarihi"].ToString();
                textRequestStdNo.Text = dr["OgrenciNo"].ToString();
                textRequestISBN.Text = dr["ISBN"].ToString();
            }
        }

        private void simpleButtonRequestIgnore_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("İsteği reddetmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MySqlCommand command1 = new MySqlCommand("DELETE FROM request WHERE RollNo = @P1 AND BookId = @P2", mySqlConnection.connection());
                    command1.Parameters.AddWithValue("@P1", textRequestStdNo.Text);
                    command1.Parameters.AddWithValue("@P2", textRequestISBN.Text);
                    
                    command1.ExecuteNonQuery();
              
                    mySqlConnection.connection().Close();
                    MessageBox.Show("İstek başarıyla reddedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listRequest();
                }
            }
            catch
            {
                MessageBox.Show("Bir şeyler yanlış gitti. Lütfen tekrar deneyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButtonRequestAccept_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("İsteği onaylamak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MySqlCommand command = new MySqlCommand("INSERT INTO record (RollNo, BookId, Date_of_Issue, Due_Date) VALUES (@P1, @P2, @P3, @P4)", mySqlConnection.connection());
                    command.Parameters.AddWithValue("@P1", textRequestStdNo.Text);
                    command.Parameters.AddWithValue("@P2", textRequestISBN.Text);
                    command.Parameters.AddWithValue("@P3", Convert.ToDateTime(textRequestIssueDate.Text));
                    command.Parameters.AddWithValue("@P4", DateTime.Now.ToString("yyyy-MM-dd"));
                    command.ExecuteNonQuery();
                    MySqlCommand command1 = new MySqlCommand("DELETE FROM request WHERE RollNo = @P1 AND BookId = @P2", mySqlConnection.connection());
                    command1.Parameters.AddWithValue("@P1", textRequestStdNo.Text);
                    command1.Parameters.AddWithValue("@P2", textRequestISBN.Text);
                    command1.ExecuteNonQuery();
                    mySqlConnection.connection().Close();
                    MessageBox.Show("İstek başarıyla onaylandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listRequest();
                }
            }
            catch
            {
                MessageBox.Show("Bir şeyler yanlış gitti. Lütfen tekrar deneyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButtonRequestRefresh_Click(object sender, EventArgs e)
        {
            listRequest();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////request//////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////kitap al/////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr != null)
            {
                textBorrowRecordID.Text = dr["RecordID"].ToString();
                textBorrowDueDate.Text = dr["AldigiTarih"].ToString();
                textBorrowISBN.Text = dr["ISBN"].ToString();
                oldStatus = Convert.ToInt32(dr["EskiDurum"]);
                numericUpDownStatus.Maximum = Convert.ToInt32(dr["EskiDurum"]);
                numericUpDownStatus.Text = dr["ISBN"].ToString();
            }
        }

        private void simpleButtonBorrowReturn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Kitabı geri alım işlemini onaylamak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MySqlCommand command = new MySqlCommand("UPDATE record SET Date_of_Return = @P1, Dues = @P2 WHERE RecordId = @P3", mySqlConnection.connection());
                    command.Parameters.AddWithValue("@P1", DateTime.Now.ToString("yyyy-MM-dd"));

                    DateTime nowDate = DateTime.Today;
                    DateTime dueDate = Convert.ToDateTime(textBorrowDueDate.Text);
                    String stringCalcDiff = (nowDate - dueDate).TotalDays.ToString();
                    int intCalcDiff = Convert.ToInt32(stringCalcDiff);
                    int due = 0;
                    if (intCalcDiff <= 15)
                    {
                        due = 0;
                    }
                    else
                    {
                        due = (intCalcDiff - 15);
                    }
                    command.Parameters.AddWithValue("@P2", (due + (oldStatus - Convert.ToInt32(numericUpDownStatus.Text)) * 2).ToString());
                    command.Parameters.AddWithValue("@P3", textBorrowRecordID.Text);
                    command.ExecuteNonQuery();

                    MySqlCommand command1 = new MySqlCommand("UPDATE book SET Availability = Availability + 1, Status = @P2 WHERE BookId = @P1", mySqlConnection.connection());
                    command1.Parameters.AddWithValue("@P1", textBorrowISBN.Text);
                    command1.Parameters.AddWithValue("@P2", numericUpDownStatus.Text);
                    command1.ExecuteNonQuery();

                    mySqlConnection.connection().Close();
                    string message = String.Format("Kitap başarıyla geri alındı. Cezanız: {0} Gün", due + (oldStatus - Convert.ToInt32(numericUpDownStatus.Text)) * 2);
                    MessageBox.Show(message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listBorrow();
                }
            }
            catch
            {
                MessageBox.Show("Bir şeyler yanlış gitti. Lütfen tekrar deneyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButtonBorrowRefresh_Click(object sender, EventArgs e)
        {
            listBorrow();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////kitap al/////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////kitap ver////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void userStdNo()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT RollNo AS OgrenciNo, Name AS IsimSoyisim FROM user", mySqlConnection.connection());
            da.Fill(dt);
            searchLookUpStdNo.Properties.ValueMember = "OgrenciNo";
            searchLookUpStdNo.Properties.DisplayMember = "IsimSoyisim";
            searchLookUpStdNo.Properties.DataSource = dt;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                textLendISBN.Text = dr["ISBN"].ToString();
            }
        }

        private void simpleButtonLendGive_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Kitabı teslim işlemini onaylamak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MySqlCommand command = new MySqlCommand("INSERT INTO record (RollNo, BookId, Date_of_Issue, Due_Date) VALUES (@P1, @P2, @P3, @P4)", mySqlConnection.connection());
                    command.Parameters.AddWithValue("@P1", searchLookUpStdNo.EditValue);
                    command.Parameters.AddWithValue("@P2", textLendISBN.Text);
                    command.Parameters.AddWithValue("@P3", DateTime.Now.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@P4", DateTime.Now.ToString("yyyy-MM-dd"));
                    command.ExecuteNonQuery();
                    MySqlCommand command1 = new MySqlCommand("UPDATE book SET Availability = Availability - 1 WHERE BookId = @P1", mySqlConnection.connection());
                    command1.Parameters.AddWithValue("@P1", textLendISBN.Text);
                    command1.ExecuteNonQuery();
                    mySqlConnection.connection().Close();
                    MessageBox.Show("Kitap başarıyla teslim edildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listLend();
                    userStdNo();
                }
            }
            catch
            {
                MessageBox.Show("Bir şeyler yanlış gitti. Lütfen tekrar deneyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButtonLendRefresh_Click(object sender, EventArgs e)
        {
            listLend();
            userStdNo();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////kitap ver////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
