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
    public partial class FormFoodAdd : Form
    {
        FoodService foodService;
        FoodCategoryService foodCategoryService;
        int foodId = 0;
        public FormFoodAdd()
        {
            InitializeComponent();
            foodService = new FoodService();
            foodCategoryService = new FoodCategoryService();
        }
        public FormFoodAdd(int _foodID)
        {
            InitializeComponent();
            foodService = new FoodService();
            foodCategoryService = new FoodCategoryService();
            foodId = _foodID;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(foodId == 0)
            {
                try
                {
                    Food food = new Food();
                    food.FoodName = txtYemekAdi.Text;
                    food.Calori = Convert.ToInt32(nudKalori.Value);
                    food.FoodCategoryID = Convert.ToInt32(cmbKategoriler.SelectedValue);
                    food.ImagePath = txtResimYolu.Text;
                    food.IsActive = true;
                    if (foodService.Insert(food)) MessageBox.Show("Yeni yemek eklendi");
                    else throw new Exception("Yemek ekleme esnasında bir hata oluştu :(");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                Food food = foodService.GetByFoodID(foodId);

                food.FoodName = txtYemekAdi.Text.Trim();
                food.Calori = (int)nudKalori.Value;
                food.ImagePath = txtResimYolu.Text.Trim();
                food.FoodCategoryID = (int)cmbKategoriler.SelectedValue;
                if (foodService.Update(food))
                    MessageBox.Show("Başarıyla güncellendi");
            }
            this.Close();
        }

        private void FormFoodAdd_Load(object sender, EventArgs e)
        {
            List<FoodCategory> foodCategories = foodCategoryService.GetFoodCategories();
            cmbKategoriler.DataSource = foodCategories;
            cmbKategoriler.ValueMember = "FoodCategoryID"; 
            cmbKategoriler.DisplayMember = "CategoryName";

            if(foodId != 0)
            {
                FillForm();
            }
        }
        private void FillForm()
        {
            Food food = foodService.GetByFoodID(foodId);
            cmbKategoriler.Text = food.FoodCategory.CategoryName;
            txtYemekAdi.Text = food.FoodName;
            nudKalori.Value = food.Calori;
            txtResimYolu.Text = food.ImagePath;
            if(!string.IsNullOrWhiteSpace(food.ImagePath))
                pbResim.ImageLocation = food.ImagePath;
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pbResim.ImageLocation = openFileDialog1.FileName;
            txtResimYolu.Text = openFileDialog1.FileName;
        }
    }
}
