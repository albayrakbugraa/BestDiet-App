using BusinessLogicLayer.Services;
using Model.Entites;
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
    public partial class FormAdmin : Form
    {
        UserService userService;
        FoodService foodService;
        SportService sportService;
        public FormAdmin()
        {
            InitializeComponent();
            userService = new UserService();
            foodService = new FoodService();
            sportService = new SportService();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            FillFoods(foodService.GetFoodsAll());
            FillSports(sportService.GetSportsAll());
            FillUsers(userService.GetUsers());
        }
       
        private void btnYemekEkle_Click(object sender, EventArgs e)
        {
            FormFoodAdd formFood = new FormFoodAdd();
            formFood.ShowDialog();
            FillFoods(foodService.GetFoodsAll());
        }
        private void btnYemekAkitfPasif_Click(object sender, EventArgs e)
        {
            if (lvYemek.SelectedItems.Count != 1) return;
            int foodID = (int)lvYemek.SelectedItems[0].Tag;
            Food food = foodService.GetByFoodID(foodID);

            if(food.IsActive)
            {
                DialogResult dr = MessageBox.Show("Pasif etme işlemini onaylıyor musunuz?", "Uyarı", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                    if (foodService.DoPassiveByFoodID(foodID))
                MessageBox.Show("Yiyecek Pasif hale getirildi");
                FillFoods(foodService.GetFoodsAll());
            }
            else
            {
                DialogResult dr = MessageBox.Show("Aktif etme işlemini onaylıyor musunuz?", "Uyarı", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                    if (foodService.DoActiveByFoodID(foodID))
                MessageBox.Show("Yiyecek Aktif hale getirildi");
                FillFoods(foodService.GetFoodsAll());
            }
            
        }

        private void btnYemekGüncelle_Click(object sender, EventArgs e)
        {
            if (lvYemek.SelectedItems.Count != 1) return;

            FormFoodAdd formFoodAdd = new FormFoodAdd((int)lvYemek.SelectedItems[0].Tag);
            formFoodAdd.ShowDialog();
            FillFoods(foodService.GetFoodsAll());
        }

        

        private void btnAktiviteEkle_Click(object sender, EventArgs e)
        {
            FormActivityAdd formActivityAdd = new FormActivityAdd();
            formActivityAdd.ShowDialog();
            FillSports(sportService.GetSportsAll());
        }


        private void btnAktiviteAktifPasif_Click(object sender, EventArgs e)
        {
            if (lvAktivite.SelectedItems.Count != 1) return;

            int sportID = (int)lvAktivite.SelectedItems[0].Tag;
            Sport sport = sportService.GetBySportID(sportID);
            if(sport.IsActive)
            {
                DialogResult dr = MessageBox.Show("Pasif etme işlemini onaylıyor musunuz?", "Uyarı", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    if (sportService.DoPassiveBySportID(sportID))
                        MessageBox.Show("Aktivite Pasif hale getirildi");
                    else
                        MessageBox.Show("Pasif etme esnasında bir hata oluştu");
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Aktif etme işlemini onaylıyor musunuz?", "Uyarı", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    if (sportService.DoActiveBySportID(sportID))
                        MessageBox.Show("Aktivite Aktif hale getirildi");
                    else
                        MessageBox.Show("Akif etme esnasında bir hata oluştu");
                }
            }
            FillSports(sportService.GetSportsAll());
        }


        private void btnKullaniciAktifPasif_Click(object sender, EventArgs e)
        {
            if (lvKullanici.SelectedItems.Count != 1) return;

            string userID = lvKullanici.SelectedItems[0].Tag.ToString();
            User user = userService.GetUserByUserName(userID);
            if (user.IsActive)
            {
                DialogResult dr = MessageBox.Show("Pasif etme işlemini onaylıyor musunuz?", "Uyarı", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    if (userService.DoPassiveByUserID(userID))
                        MessageBox.Show("Aktivite Pasif hale getirildi");
                    else
                        MessageBox.Show("Pasif etme esnasında bir hata oluştu");
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Aktif etme işlemini onaylıyor musunuz?", "Uyarı", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    if (userService.DoActiveByUserID(userID))
                        MessageBox.Show("Aktivite Aktif hale getirildi");
                    else
                        MessageBox.Show("Akif etme esnasında bir hata oluştu");
                }
            }
            FillUsers(userService.GetUsers());
        }

        private void btnAktiviteGuncelle_Click(object sender, EventArgs e)
        {

        }
        private void txtYemekAra_TextChanged(object sender, EventArgs e)
        {
            FillFoods(foodService.GetFoodsByText(txtYemekAra.Text));
        }

        private void txtAktiviteAra_TextChanged(object sender, EventArgs e)
        {
            FillSports(sportService.GetFoodsByText(txtAktiviteAra.Text));
        }

        private void txtKullaniciAra_TextChanged(object sender, EventArgs e)
        {
            FillUsers(userService.GetUsersByText(txtKullaniciAra.Text));
        }


        private void FillFoods(List<Food> foodList)
        {
            lvYemek.Items.Clear();
            if (foodList != null)
            {
                foreach (Food food in foodList)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = food.FoodName;
                    lvi.SubItems.Add(food.FoodCategory.CategoryName);
                    lvi.SubItems.Add(food.Calori.ToString());
                    lvi.SubItems.Add(food.IsActive ? "Akitf" : "Pasif");
                    lvi.Tag = food.FoodID;
                    lvYemek.Items.Add(lvi);
                }
            }
        }
        private void FillSports(List<Sport> sportList)
        {
            lvAktivite.Items.Clear();
            if (sportList != null)
            {
                foreach (Sport sport in sportList)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = sport.SportName;
                    lvi.SubItems.Add(sport.BurningCalori.ToString());
                    lvi.SubItems.Add(sport.IsActive ? "Aktif" : "Pasif");
                    lvi.Tag = sport.SportID;
                    lvAktivite.Items.Add(lvi);
                }
            }
        }
        private void FillUsers(List<User> userList)
        {
            lvKullanici.Items.Clear();
            if (userList != null)
            {
                foreach (User user in userList)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = user.FirstName;
                    lvi.SubItems.Add(user.LastName);
                    lvi.SubItems.Add(user.UserID);
                    lvi.SubItems.Add(userService.GetAge(user.UserID).ToString());
                    lvi.SubItems.Add(user.Height.ToString());
                    lvi.SubItems.Add(user.Weight.ToString());
                    lvi.SubItems.Add(user.TargetWeight.ToString());
                    lvi.SubItems.Add(foodService.GetFavoriteFoodName(user.UserID));
                    lvi.SubItems.Add(sportService.GetFavoriteSportByUserID(user.UserID));
                    lvi.SubItems.Add(user.IsActive ? "Aktif" : "Pasif");
                    lvi.Tag = user.UserID;
                    lvKullanici.Items.Add(lvi);
                }
            }
        }

    }
}
