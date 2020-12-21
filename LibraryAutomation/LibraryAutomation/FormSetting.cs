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
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
        }

        MySqlConnection mySqlConnection = new MySqlConnection();
        public string id;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textOldPass.Text == "")
                {
                    MessageBox.Show("Lütfen eski şifrenizi giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (textNewPass.Text == "")
                    {
                        MessageBox.Show("Yeni şifrenizi boş bırakamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MySqlCommand command = new MySqlCommand("SELECT * FROM admin WHERE id = @P2 AND pass = @P1", mySqlConnection.connection());
                        command.Parameters.AddWithValue("@P1", textOldPass.Text);
                        command.Parameters.AddWithValue("@P2", id);
                        mySqlConnection.connection().Close();
                        MySqlDataReader dr = command.ExecuteReader();
                        if (dr.Read())
                        {
                            DialogResult dialogResult = MessageBox.Show("Şifrenizi değiştirmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                MySqlCommand command1 = new MySqlCommand("UPDATE admin SET pass = @P1 WHERE id = @P2", mySqlConnection.connection());
                                command1.Parameters.AddWithValue("@P1", textNewPass.Text);
                                command1.Parameters.AddWithValue("@P2", id);
                                command1.ExecuteNonQuery();
                                mySqlConnection.connection().Close();
                                MessageBox.Show("Şifreniz başarıyla değiştirildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Eski şifrenizi yanlış girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Bir şeyler yanlış gitti. Lütfen tekrar deneyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
