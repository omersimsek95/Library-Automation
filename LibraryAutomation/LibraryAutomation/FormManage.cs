using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using MySql.Data.MySqlClient;

namespace LibraryAutomation
{
    public partial class FormManage : Form
    {
        public FormManage()
        {
            InitializeComponent();
        }

        MySqlConnection mySqlConnection = new MySqlConnection();

        private void FormManage_Load(object sender, EventArgs e)
        {
            list();
        }

        void list()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT id AS ID FROM admin", mySqlConnection.connection());
            mySqlConnection.connection().Close();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void simpleButtonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO admin (id, pass) VALUES (@P1, @P2)", mySqlConnection.connection());
                command.Parameters.AddWithValue("@P1", textId.Text);
                command.Parameters.AddWithValue("@P2", textPass.Text);
                command.ExecuteNonQuery();
                mySqlConnection.connection().Close();
                MessageBox.Show("Kullanıcı başarıyla oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                list();
                clear();
            }
            catch
            {
                MessageBox.Show("Bir şeyler yanlış gitti. Lütfen tekrar deneyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void clear()
        {
            textId.Text = "";
            textPass.Text = "";
        }

        private void simpleButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Kullanıcıyı silmek istediğinize emin misiniz? Bu işlem geri alınamaz!", "Uyarı", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MySqlCommand command = new MySqlCommand("DELETE FROM admin WHERE id = @P1", mySqlConnection.connection());
                    command.Parameters.AddWithValue("@P1", textId.Text);
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

        private void gridView1_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            string id = view.GetListSourceRowCellValue(e.ListSourceRow, "ID").ToString();
            if (id == "admin")
            {
                e.Visible = false;
                e.Handled = true;
            }
        }

        private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                textId.Text = dr["ID"].ToString();
            }
        }

        private void simpleButtonClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void simpleButtonReset_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Seçili kullanıcının parolasını sıfırlamak istediğinize emin misiniz? (Parola bilgisi kullanıcı adına eşitlenecektir.)", "Uyarı", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MySqlCommand command = new MySqlCommand("UPDATE admin SET pass = @P1 WHERE id = @P2", mySqlConnection.connection());
                    command.Parameters.AddWithValue("@P1", textId.Text);
                    command.Parameters.AddWithValue("@P2", textId.Text);
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
    }
}
