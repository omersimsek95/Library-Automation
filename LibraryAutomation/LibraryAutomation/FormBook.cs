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
    public partial class FormBook : Form
    {
        public FormBook()
        {
            InitializeComponent();
        }

        MySqlConnection mySqlConnection = new MySqlConnection();

        private void FormBook_Load(object sender, EventArgs e)
        {
            list();
            category();
        }

        void list()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT b.BookId AS ISBN, b.Title AS KitapAdi, a.Author AS Yazar, b.Publisher AS Yayinevi, b.Category AS Kategori, b.Status AS Durum, b.Year AS Yil, b.Availability AS Stok FROM book b INNER JOIN author a ON a.BookId = b.BookId", mySqlConnection.connection());
            mySqlConnection.connection().Close();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            if (textAuthor.Text == "")
            {
                MessageBox.Show("Yazar alanı boş bırakılamaz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    MySqlCommand command = new MySqlCommand("INSERT INTO book (BookId, Title, Publisher, Year, Availability, Category, Status) VALUES (@P1, @P2, @P3, @P4, @P5, @P6, @P7)", mySqlConnection.connection());
                    command.Parameters.AddWithValue("@P1", textISBN.Text);
                    command.Parameters.AddWithValue("@P2", textTitle.Text);
                    command.Parameters.AddWithValue("@P3", textPublisher.Text);
                    command.Parameters.AddWithValue("@P4", textYear.Text);
                    command.Parameters.AddWithValue("@P5", numericUpDownAvailability.Text);
                    command.Parameters.AddWithValue("@P6", comboBoxCategory.Text);
                    command.Parameters.AddWithValue("@P7", numericUpDownStatus.Text);
                    command.ExecuteNonQuery();
                    MySqlCommand command1 = new MySqlCommand("INSERT INTO author (Author, BookId) VALUES (@P1, @P2)", mySqlConnection.connection());
                    command1.Parameters.AddWithValue("@P1", textAuthor.Text);
                    command1.Parameters.AddWithValue("@P2", textISBN.Text);
                    command1.ExecuteNonQuery();
                    mySqlConnection.connection().Close();
                    MessageBox.Show("Kitap başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    list();
                    clear();
                }
                catch
                {
                    MessageBox.Show("Bir şeyler yanlış gitti. Lütfen tekrar deneyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void simpleButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Kitabı silmek istediğinize emin misiniz? Bu işlem geri alınamaz!", "Uyarı", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MySqlCommand command1 = new MySqlCommand("DELETE FROM author WHERE BookId = @P1", mySqlConnection.connection());
                    command1.Parameters.AddWithValue("@P1", textISBN.Text);
                    command1.ExecuteNonQuery();
                    MySqlCommand command = new MySqlCommand("DELETE FROM book WHERE BookId = @P1", mySqlConnection.connection());
                    command.Parameters.AddWithValue("@P1", textISBN.Text);
                    command.ExecuteNonQuery();
                    mySqlConnection.connection().Close();
                    MessageBox.Show("Kitap başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    list();
                    clear();
                }
            }
            catch
            {
                MessageBox.Show("Bir şeyler yanlış gitti. Lütfen tekrar deneyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Kitabı güncellemek istediğinize emin misiniz? (ISBN üzerinde değişiklik yapmayınız.)", "Uyarı", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MySqlCommand command = new MySqlCommand("UPDATE book SET Title = @P1, Publisher = @P2, Year = @P3, Availability = @P4, Category = @P6, Status = @P7 WHERE BookId = @P5", mySqlConnection.connection());
                    command.Parameters.AddWithValue("@P1", textTitle.Text);
                    command.Parameters.AddWithValue("@P2", textPublisher.Text);
                    command.Parameters.AddWithValue("@P3", textYear.Text);
                    command.Parameters.AddWithValue("@P4", numericUpDownAvailability.Text);
                    command.Parameters.AddWithValue("@P5", textISBN.Text);
                    command.Parameters.AddWithValue("@P6", comboBoxCategory.Text);
                    command.Parameters.AddWithValue("@P7", numericUpDownStatus.Text);
                    command.ExecuteNonQuery();
                    MySqlCommand command1 = new MySqlCommand("UPDATE author SET Author = @P1 WHERE BookId = @P2", mySqlConnection.connection());
                    command1.Parameters.AddWithValue("@P1", textAuthor.Text);
                    command1.Parameters.AddWithValue("@P2", textISBN.Text);
                    command1.ExecuteNonQuery();
                    mySqlConnection.connection().Close();
                    MessageBox.Show("Kitap başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    list();
                    clear();
                }
            }
            catch
            {
                MessageBox.Show("Bir şeyler yanlış gitti. Lütfen tekrar deneyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                textISBN.Text = dr["ISBN"].ToString();
                textTitle.Text = dr["KitapAdi"].ToString();
                textPublisher.Text = dr["Yayinevi"].ToString();
                textYear.Text = dr["Yil"].ToString();
                numericUpDownAvailability.Text = dr["Stok"].ToString();
                textAuthor.Text = dr["Yazar"].ToString();
                comboBoxCategory.Text = dr["Kategori"].ToString();
                numericUpDownStatus.Text = dr["Durum"].ToString();
            }
        }

        private void simpleButtonClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            textISBN.Text = "";
            textTitle.Text = "";
            textPublisher.Text = "";
            textYear.Text = "";
            numericUpDownAvailability.Text = "";
            textAuthor.Text = "";
            comboBoxCategory.Text = "";
            numericUpDownStatus.Text = "";
        }

        void category()
        {
            MySqlCommand command = new MySqlCommand("SELECT CatName FROM Category ORDER BY CatName", mySqlConnection.connection());
            MySqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                comboBoxCategory.Properties.Items.Add(dr[0]);
            }
            mySqlConnection.connection().Close();
        }

        private void simpleButtonRefresh_Click(object sender, EventArgs e)
        {
            list();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
