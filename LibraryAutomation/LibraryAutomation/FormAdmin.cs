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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        MySqlConnection mySqlConnection = new MySqlConnection();

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM admin WHERE id = @p1 AND pass = @p2", mySqlConnection.connection());
                command.Parameters.AddWithValue("@p1", textId.Text);
                command.Parameters.AddWithValue("@p2", textPass.Text);
                mySqlConnection.connection().Close();
                MySqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    FormMain formMain = new FormMain();
                    formMain.id = textId.Text;
                    if (textId.Text == "admin") formMain.adminCheck = true;
                    else formMain.adminCheck = false;
                    formMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("ID yada şifre yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Bir şeyler yanlış gitti. Lütfen tekrar deneyiniz! (Bu uyarı üç kere verilecektir.)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
