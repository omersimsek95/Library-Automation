using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAutomation
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public string id;
        public bool adminCheck;


        private void FormMain_Load(object sender, EventArgs e)
        {
            if (adminCheck == true) barButtonManage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            else barButtonManage.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            if (formHomePage == null)
            {
                formHomePage = new FormHomePage();
                formHomePage.MdiParent = this;
                formHomePage.Show();
            }
        }

        FormUser formUser;

        private void barButtonUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (formUser == null || formUser.IsDisposed)
            {
                formUser = new FormUser();
                formUser.MdiParent = this;
                formUser.Show();
            }
        }

        FormBook formBook;

        private void barButtonBook_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (formBook == null || formBook.IsDisposed)
            {
                formBook = new FormBook();
                formBook.MdiParent = this;
                formBook.Show();
            }
        }

        FormBorrow formBorrow;

        private void barButtonBorrow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (formBorrow == null || formBorrow.IsDisposed)
            {
                formBorrow = new FormBorrow();
                formBorrow.MdiParent = this;
                formBorrow.Show();
            }
        }

        FormSetting formSetting;

        private void barButtonSetting_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (formSetting == null || formSetting.IsDisposed)
            {
                formSetting = new FormSetting();
                formSetting.id = id;
                formSetting.Show();
            }
        }

        FormManage formManage;

        private void barButtonManage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (formManage == null || formManage.IsDisposed)
            {
                formManage = new FormManage();
                formManage.Show();
            }
        }

        FormHomePage formHomePage;

        private void barButtonHomePage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (formHomePage == null || formHomePage.IsDisposed)
            {
                formHomePage = new FormHomePage();
                formHomePage.MdiParent = this;
                formHomePage.Show();
            }
        }
    }
}
