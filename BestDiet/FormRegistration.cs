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
    public partial class FormRegistration : Form
    {
        UserService userService;
        public FormRegistration()
        {
            InitializeComponent();
            userService = new UserService();
        }
        private void FormRegistration_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
            txtSifreTekrar.PasswordChar = '*';
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            User user = userService.GetUserByUserName(txtEmail.Text.Trim());
            if(user != null)
            {
                MessageBox.Show("Böyle bir maile sahip kullanıcı mevcut!!!");
                return;
            }
            if(txtSifre.Text != txtSifreTekrar.Text)
            {
                MessageBox.Show("Şifre tekrarı hatalı");
                return;
            }
            if(string.IsNullOrWhiteSpace(txtSifre.Text) || lblSifre.Text == "Zayıf")
            {
                MessageBox.Show("Şifre yeterince güçlü değil!!!");
                return;
            }
            if(!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Geçerli bir mail adresi giriniz");
                return ;
            }
            try 
            {
                user = new User();
                user.FirstName = txtIsim.Text.Trim();
                user.LastName = txtSoyisim.Text.Trim();
                user.UserID = txtEmail.Text.Trim();
                user.Gender = rdbErkek.Checked ? Gender.Male : Gender.Female;
                user.BirthDate = dtpDogumTarihi.Value;
                user.Height = (int)nudBoy.Value;
                user.Weight = (double)nudKilo.Value;
                user.TargetWeight = (double)nudHedefKilo.Value;
                user.Password = txtSifre.Text;
                user.UserType = UserType.User;
                user.IsActive = true;
                if (userService.InsertUser(user))
                {
                    MessageBox.Show("Kayıt başarılı ! ! !");
                    this.Close();
                }
                else throw new Exception("Kayıt esnasında bir hata oluştu :(");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            bool isPasswordOk = false;
            bool characterExist = false;
            bool numberExist = false;
            int length = txtSifre.Text.Trim().Length;
            if (length<1)
            {
                lblSifre.Text = string.Empty;
            }
            else if(length < 5)
            {
                lblSifre.Text = "Zayıf";
                lblSifre.ForeColor = Color.Red;
            }
            else
            {
                lblSifre.Text = "Orta";
                lblSifre.ForeColor = Color.Orange;

                string characters = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
                char[] charactersArray = characters.ToCharArray();
                char[] numbers = new char[] {'1','2','3','4','5','6','7','8','9','0'};
                foreach(char c in charactersArray)
                {
                    if(txtSifre.Text.Contains(c))
                        characterExist = true;
                }
                foreach(char c in numbers)
                {
                    if (txtSifre.Text.Contains(c))
                        numberExist = true;
                }
            }

            if(characterExist || numberExist )
            {
                lblSifre.Text = "Güçlü";
                lblSifre.ForeColor = Color.LightGreen;
                isPasswordOk = true;
            }
            if(isPasswordOk && length>10)
            {
                lblSifre.Text = "Çok Güçlü";
                lblSifre.ForeColor = Color.DarkGreen;
            }
        }
    }
}
