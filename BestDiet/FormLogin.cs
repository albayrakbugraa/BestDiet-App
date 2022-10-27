using BusinessLogicLayer.Services;
using Model.Entites;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestDiet
{
    public partial class FormLogin : Form
    {
        public static UserService userService;
        public FormLogin()
        {
            InitializeComponent();
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
        }

        private void lnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormRegistration formRegistration = new FormRegistration();
            formRegistration.ShowDialog();
            this.Show();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
                MessageBox.Show("Kullanıcı veya şifre boş olamaz.");
            else
            {
                userService = new UserService();
                User user = userService.CheckLogin(txtKullaniciAdi.Text.Trim(),txtSifre.Text.Trim());
                if(user == null)
                {
                    MessageBox.Show("Lütfen bilgileri doğru giriniz.\nÜyeliğiniz yoksa kaydolunuz.");
                }
                else
                {
                    if(user.IsActive == false)
                    {
                        MessageBox.Show("Admin onayı gerekiyor!!!\nLütfen yetkiliyle iletişime geçiniz.");
                        return;
                    }
                    switch(user.UserType)
                    {
                        case UserType.User:
                            this.Hide();
                            FormUserMain formUserMain = new FormUserMain(user);
                            formUserMain.ShowDialog();
                            this.Show();
                            break;
                        case UserType.Admin:
                            this.Hide();
                            FormAdmin formAdmin = new FormAdmin();
                            formAdmin.ShowDialog();
                            this.Show();
                            break;
                    }
                    Helper.ClearControls(Controls);
                }

            }
        }

    }
}
