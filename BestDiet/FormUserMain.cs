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
    public partial class FormUserMain : Form
    {
        User user;
        MealService mealService;
        ExerciseService exerciseService;
        WaterService waterService;
        MealCategoryService mealcategoryService;
        MealDetailService mealdetailService;
        ExerciseDetailService exerciseDetailService;
        public FormUserMain(User _user)
        {
            InitializeComponent();
            user = _user;
            mealcategoryService = new MealCategoryService();
            waterService = new WaterService();
            mealdetailService = new MealDetailService();
            exerciseDetailService = new ExerciseDetailService();
        }

        private void FormUserMain_Load(object sender, EventArgs e)
        {
            Helper.ClearControls(Controls);
            lblKullaniciAdi.Text = user.FirstName + " " + user.LastName;
            lblHedefKilo.Text = user.TargetWeight.ToString();
            lblKilo.Text = user.Weight.ToString();
            lblBoy.Text = user.Height.ToString();
            lblYas.Text = (DateTime.Now.Year - user.BirthDate.Year).ToString();

            int vki = Convert.ToInt32(user.Weight * 10000 / Math.Pow(user.Height, 2));
            lblKitleIndeksi.Text = vki.ToString();

            int idealKilo;
            if (user.Gender == Gender.Male) idealKilo = (int)(50 + (2.3) * ((user.Height - 152.4) / 2.54));
            else idealKilo = (int)(45.5 + (2.3) * ((user.Height - 152.4) / 2.54));
            lblIdealKilo.Text = idealKilo.ToString();           

            AlinanToplamKaloriyiGetir();
            YakilanToplamKaloriyiGetir();
            KalanKaloriyiGetir();
            SuGetir();

        }

        private void KalanKaloriyiGetir()
        {
            int alınasıGerekenKalori;
            if (user.Gender == Gender.Male) alınasıGerekenKalori = Convert.ToInt32(user.Weight * 24);
            else alınasıGerekenKalori = Convert.ToInt32(0.9 * user.Weight * 24);
            lblKalanKalori.Text = (alınasıGerekenKalori - alinanToplamKalori).ToString();
        }

        private void YakilanToplamKaloriyiGetir()
        {
            
            List<ExerciseDetail> exerciseDetails = exerciseDetailService.GetSportsByExercise(user.UserID, dtpTarih.Value.Date);
            lblYakilanKalori.Text = exerciseDetailService.GetSumCalori(exerciseDetails).ToString();
        }

        int alinanToplamKalori;
        private void AlinanToplamKaloriyiGetir()
        {
            List<MealDetail> mealDetails = mealdetailService.GetMealDetailsByUserId(user.UserID,dtpTarih.Value.Date);
            alinanToplamKalori = mealdetailService.GetSumCalori(mealDetails);
            lblAlinanKalori.Text = alinanToplamKalori.ToString();
        }

        private void lblKahvaltiEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MealAdd("Sabah");
            AlinanToplamKaloriyiGetir();
            KalanKaloriyiGetir();
        }

        private void lblOgleEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MealAdd("Öğle");
            AlinanToplamKaloriyiGetir();
            KalanKaloriyiGetir();
        }

        private void lblAperatifEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MealAdd("Aperatif");
            AlinanToplamKaloriyiGetir();
            KalanKaloriyiGetir();
        }

        private void lblAksamEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MealAdd("Akşam");
            AlinanToplamKaloriyiGetir();
            KalanKaloriyiGetir();
        }

        private void lblEgzersizEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Hide();
            exerciseService = new ExerciseService();
            Exercise exercise = exerciseService.GetExercise(user.UserID, dtpTarih.Value.Date);
            FormActivity formActivity = new FormActivity(exercise, user, dtpTarih.Value.Date);
            formActivity.ShowDialog();
            this.Show();
            YakilanToplamKaloriyiGetir();
        }

        private void lblSuEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(nudSuLitresi.Value > 0)
            {
                Water water = waterService.GetWaterByDateAndUserName(dtpTarih.Value.Date, user.UserID);
                if(water !=null)
                {
                    water.Quantity += (double)nudSuLitresi.Value;
                    if (waterService.UpdateWater(water))
                        MessageBox.Show("Su eklendi");
                    lblSu.Text = water.Quantity.ToString();
                }
                else
                {
                    water = new Water();
                    water.Quantity = (double)nudSuLitresi.Value;
                    water.WaterDate = dtpTarih.Value.Date;
                    water.User = user;
                    if (waterService.AddWater(water))
                        MessageBox.Show("İlk suyunuzu içtiniz afiyet olsun :)");

                    lblSu.Text = water.Quantity.ToString();
                }
            }
        }
        private void MealAdd(string mealName)
        {
            this.Hide();
            mealService = new MealService();
            Meal meal = mealService.GetMealByUserIDandMealCategoryName(user.UserID, mealName, dtpTarih.Value.Date);
            MealCategory mealCategory = mealcategoryService.GetMealCategoryByName(mealName);
            FormMeal formMeal = new FormMeal(meal, user, dtpTarih.Value.Date, mealCategory);
            formMeal.ShowDialog();
            this.Show();
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            AlinanToplamKaloriyiGetir();
            YakilanToplamKaloriyiGetir();
            KalanKaloriyiGetir();
            SuGetir();


        }
        private void SuGetir()
        {
            Water water = waterService.GetWaterByDateAndUserName(dtpTarih.Value.Date, user.UserID);
            if (water != null)
            {
                lblSu.Text = water.Quantity.ToString();
            }
            else
                lblSu.Text = "0";
        }

        private void btnRaporGoruntule_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReport formReport = new FormReport(user);
            formReport.ShowDialog();
            this.Show();
        }
    }
}
