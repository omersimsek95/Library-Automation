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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        MySqlConnection mySqlConnection = new MySqlConnection();

        private void FormUser_Load(object sender, EventArgs e)
        {
            list();
        }

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO user (RollNo, Name, EmailId, MobNo, Password) VALUES (@P1, @P2, @P5, @P6, @P7)", mySqlConnection.connection());

                command.Parameters.AddWithValue("@P1", textStdNo.Text);
                command.Parameters.AddWithValue("@P2", textNameSurname.Text);
                command.Parameters.AddWithValue("@P5", textMail.Text);
                command.Parameters.AddWithValue("@P6", textPhone.Text);
                command.Parameters.AddWithValue("@P7", textStdNo.Text);
                command.ExecuteNonQuery();
                mySqlConnection.connection().Close();
                MessageBox.Show("Kullanıcı başarıyla oluşturuldu! (Parola bilgisi kullanıcı adına eşittir.)", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                list();
                clear();
            }
            catch
            {
                MessageBox.Show("Bir şeyler yanlış gitti. Lütfen tekrar deneyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void list()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT RollNo AS OgrenciNo, Name AS IsimSoyisim, EmailId AS Mail, MobNo AS Telefon FROM user", mySqlConnection.connection());
            mySqlConnection.connection().Close();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void clear()
        {
            textStdNo.Text = "";
            textNameSurname.Text = "";
            textMail.Text = "";
            textPhone.Text = "";
        }

        private void simpleButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Kullanıcıyı silmek istediğinize emin misiniz? Bu işlem geri alınamaz!", "Uyarı", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MySqlCommand command = new MySqlCommand("DELETE FROM user WHERE RollNo = @P1", mySqlConnection.connection());
                    command.Parameters.AddWithValue("@P1", textStdNo.Text);
                    command.ExecuteNonQuery();
                    mySqlConnection.connection().Close();
                    MessageBox.Show("Kullanıcı başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                textStdNo.Text = dr["OgrenciNo"].ToString();
                textNameSurname.Text = dr["IsimSoyisim"].ToString();
                textMail.Text = dr["Mail"].ToString();
                textPhone.Text = dr["Telefon"].ToString();
            }
        }

        private void simpleButtonClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void simpleButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Kullanıcıyı güncellemek istediğinize emin misiniz? (ÖĞR. NO üzerinde değişiklik yapmayınız.)", "Uyarı", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MySqlCommand command = new MySqlCommand("UPDATE user SET Name = @P1, EmailId = @P4, MobNo = @P5 WHERE RollNo = @P7", mySqlConnection.connection());
                    command.Parameters.AddWithValue("@P1", textNameSurname.Text);
                    command.Parameters.AddWithValue("@P4", textMail.Text);
                    command.Parameters.AddWithValue("@P5", textPhone.Text);
                    command.Parameters.AddWithValue("@P7", textStdNo.Text);
                    command.ExecuteNonQuery();
                    mySqlConnection.connection().Close();
                    MessageBox.Show("Kullanıcı başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    list();
                    clear();
                }
            }
            catch
            {
                MessageBox.Show("Bir şeyler yanlış gitti. Lütfen tekrar deneyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormHistory formHistory = new FormHistory();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                string title = string.Format("{0} - {1} (Geçmiş)", dr["OgrenciNo"].ToString(), dr["IsimSoyisim"].ToString());
                formHistory.stdNo = dr["OgrenciNo"].ToString();
                formHistory.Text = title;
            }
            formHistory.Show();
        }

        private void simpleButtonResetPass_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Seçili kullanıcının parolasını sıfırlamak istediğinize emin misiniz? (Parola bilgisi kullanıcı adına eşitlenecektir.)", "Uyarı", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MySqlCommand command = new MySqlCommand("UPDATE user SET Password = @P1 WHERE RollNo = @P2", mySqlConnection.connection());
                    command.Parameters.AddWithValue("@P1", textStdNo.Text);
                    command.Parameters.AddWithValue("@P2", textStdNo.Text);
                    command.ExecuteNonQuery();
                    mySqlConnection.connection().Close();
                    MessageBox.Show("Parola başarıyla sıfırlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    list();
                    clear();
                }
            }
            catch
            {
                MessageBox.Show("Bir şeyler yanlış gitti. Lütfen tekrar deneyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButtonRefresh_Click(object sender, EventArgs e)
        {
            list();
        }
    }
}
