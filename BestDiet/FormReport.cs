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
    public partial class FormReport : Form
    {
        User user;
        MealService mealService;
        ExerciseService exerciseService;
        WaterService waterService;
        MealCategoryService mealcategoryService;
        MealDetailService mealdetailService;
        ExerciseDetailService exerciseDetailService;
        FoodService foodService;
        SportService sportService;
        public FormReport(User _user)
        {
            InitializeComponent();
            user = _user;
            mealcategoryService = new MealCategoryService();
            waterService = new WaterService();
            mealdetailService = new MealDetailService();
            exerciseDetailService = new ExerciseDetailService();
            foodService = new FoodService();
            sportService = new SportService();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {

            AktiviteListesiDoldur();
            YemekListesiDoldur();
            SuListesiniDoldur();
            KalorileriYazdir();

        }
        private void SuListesiniDoldur()
        {
            lvSu.Items.Clear();
            List<Water> waters = waterService.GetWaterByBetweenDate(dtpTarih.Value.Date, dtpTarih2.Value.Date, user.UserID);
            ListViewItem lvi3;
            if (waters == null)
            {
                return;
            }
            foreach (Water item in waters)
            {
                lvi3 = new ListViewItem();
                lvi3.Text = item.Quantity.ToString();
                lvi3.SubItems.Add(item.WaterDate.ToString("d"));                
                lvSu.Items.Add(lvi3);
            }
        }


        
        private void AktiviteListesiDoldur()
        {
            lvAktiviteler.Items.Clear(); 
            List<ExerciseDetail> exerciseDetails = exerciseDetailService.GetExerciseDetailsBetweenDate(user.UserID, dtpTarih.Value.Date, dtpTarih2.Value.Date);
            ListViewItem lvi;
            if (exerciseDetails == null)
            {
                return;
            }
            foreach (ExerciseDetail item in exerciseDetails)
            {
                lvi = new ListViewItem();
                lvi.Text = item.Sport.SportName;
                lvi.SubItems.Add(item.BurningCalori.ToString());
                lvi.SubItems.Add(item.Minute.ToString());
                lvi.SubItems.Add(item.Exercise.ExerciseDate.ToString("d"));
                lvAktiviteler.Items.Add(lvi);
            }          
        }

        private void YemekListesiDoldur()
        {
            lvOgunler.Items.Clear();
            ListViewItem lvi2;
            List<MealDetail> mealDetails = mealdetailService.GetMealDetailsBetweenDate(user.UserID, dtpTarih.Value.Date, dtpTarih2.Value.Date);
            if (mealDetails == null)
            {
                return;
            }
            foreach (MealDetail item in mealDetails)
            {
                lvi2 = new ListViewItem();
                lvi2.Text = item.Food.FoodName;
                lvi2.SubItems.Add(item.Meal.MealCategory.MealCategoryName);
                lvi2.SubItems.Add(item.Food.FoodCategory.CategoryName);
                lvi2.SubItems.Add(item.Calori.ToString());
                lvi2.SubItems.Add(item.Portion.ToString());
                lvi2.SubItems.Add(item.Quantity.ToString());
                lvi2.SubItems.Add(item.Meal.MealTime.ToString("d"));
                lvOgunler.Items.Add(lvi2);
            }
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            lblFavoriYiyecek.Text = foodService.GetFavoriteFoodName(user.UserID);
            lblFavoriAktivite.Text = sportService.GetFavoriteSportByUserID(user.UserID); 
        }

        private void KalorileriYazdir()
        {
            List<ExerciseDetail> exerciseDetails = exerciseDetailService.GetExerciseDetailsBetweenDate(user.UserID, dtpTarih.Value.Date, dtpTarih2.Value.Date);

            List<MealDetail> mealDetails = mealdetailService.GetMealDetailsBetweenDate(user.UserID, dtpTarih.Value.Date, dtpTarih2.Value.Date);

            lblToplamKalori.Text = mealdetailService.GetSumCalori(mealDetails).ToString();
            lblYakilanKalori.Text = exerciseDetailService.GetSumCalori(exerciseDetails).ToString();
        }
    }
}
