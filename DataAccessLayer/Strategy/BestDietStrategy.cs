using Model.Entites;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Strategy
{
    public class BestDietStrategy : CreateDatabaseIfNotExists<BestDietDbContext>
    {
        protected override void Seed(BestDietDbContext context)
        {
            User user = new User()
            {
                UserID = "Admin",
                FirstName = "Admin",
                LastName = "Admin",
                Gender = Gender.Male,
                Height = 180,
                Weight=100,
                TargetWeight=90,
                BirthDate = DateTime.Now.AddYears(-30),
                IsActive = true,
                UserType = UserType.Admin,
                Password = "123"
            };
            context.Users.Add(user);
            

            List<Sport> sports = new List<Sport>();

            sports.Add(new Sport() { SportName = "Koşu", BurningCalori = 565,IsActive = true });
            sports.Add(new Sport() { SportName = "Yüzme", BurningCalori = 650, IsActive = true });
            sports.Add(new Sport() { SportName = "Yürüyüş", BurningCalori = 500, IsActive = true });
            sports.Add(new Sport() { SportName = "Bisiklet", BurningCalori = 600, IsActive = true });
            sports.Add(new Sport() { SportName = "Tenis", BurningCalori = 450, IsActive = true });
            sports.Add(new Sport() { SportName = "Futbol", BurningCalori = 588, IsActive = true });
            sports.Add(new Sport() { SportName = "Pilates", BurningCalori = 200, IsActive = true });
            sports.Add(new Sport() { SportName = "Basketbol", BurningCalori = 440, IsActive = true });
            sports.Add(new Sport() { SportName = "Voleybol", BurningCalori = 294, IsActive = true });
            sports.Add(new Sport() { SportName = "Golf", BurningCalori = 390, IsActive = true });
            sports.Add(new Sport() { SportName = "Ağırlık Çalışması", BurningCalori = 440, IsActive = true });

            context.Sports.AddRange(sports);

            List<FoodCategory> foodCategories = new List<FoodCategory>();

            foodCategories.Add(new FoodCategory() { CategoryName = "Beyaz Et" });
            foodCategories.Add(new FoodCategory() { CategoryName = "Kırmızı Et" });
            foodCategories.Add(new FoodCategory() { CategoryName = "Baklagil" });
            foodCategories.Add(new FoodCategory() { CategoryName = "Salata" });
            foodCategories.Add(new FoodCategory() { CategoryName = "Meyve" });
            foodCategories.Add(new FoodCategory() { CategoryName = "İçecek" });
            foodCategories.Add(new FoodCategory() { CategoryName = "Kuruyemiş" });
            foodCategories.Add(new FoodCategory() { CategoryName = "Temel Gıda" });
            foodCategories.Add(new FoodCategory() { CategoryName = "Atıştırmalık" });
            foodCategories.Add(new FoodCategory() { CategoryName = "Unlu Mamüller" });
            foodCategories.Add(new FoodCategory() { CategoryName = "Süt Ürünleri" });
            foodCategories.Add(new FoodCategory() { CategoryName = "Fast Food" });
            foodCategories.Add(new FoodCategory() { CategoryName = "Tatlı & Tuzlu" });
            foodCategories.Add(new FoodCategory() { CategoryName = "Sebze" });
           

            context.FoodCategories.AddRange(foodCategories);

            List<Food> foods = new List<Food>();

            foods.Add(new Food() { FoodName = "Tavuk Sote", Calori =288, FoodCategory = foodCategories[0], IsActive = true });
            foods.Add(new Food() { FoodName = "Tavuk Kanat", Calori =252, FoodCategory = foodCategories[0], IsActive = true });
            foods.Add(new Food() { FoodName = "Tavuk Çorbası", Calori =132, FoodCategory = foodCategories[0], IsActive = true });
            foods.Add(new Food() { FoodName = "Tavuk Baget", Calori =238, FoodCategory = foodCategories[0], IsActive = true });
            foods.Add(new Food() { FoodName = "Tavuk Göğüs", Calori =120, FoodCategory = foodCategories[0], IsActive = true });
            foods.Add(new Food() { FoodName = "Tavuk Şiş", Calori =208, FoodCategory = foodCategories[0], IsActive = true });
            foods.Add(new Food() { FoodName = "Tavuk Döner", Calori =149, FoodCategory = foodCategories[0], IsActive = true });
            foods.Add(new Food() { FoodName = "Tavuk Ciğer", Calori =167, FoodCategory = foodCategories[0], IsActive = true });
            foods.Add(new Food() { FoodName = "Tavuk Izgara", Calori =274, FoodCategory = foodCategories[0], IsActive = true });
            foods.Add(new Food() { FoodName = "Tavuk Tantuni", Calori =415, FoodCategory = foodCategories[0], IsActive = true });
            foods.Add(new Food() { FoodName = "Hindi But(1 but 546g)", Calori =1136, FoodCategory = foodCategories[0], IsActive = true });
            foods.Add(new Food() { FoodName = "Hindi Göğüs(1/2 864g)", Calori =1166, FoodCategory = foodCategories[0], IsActive = true });
            foods.Add(new Food() { FoodName = "Hindi Kanat", Calori =221, FoodCategory = foodCategories[0], IsActive = true });
            foods.Add(new Food() { FoodName = "Ördek(634g)", Calori =337, FoodCategory = foodCategories[0], IsActive = true });
            foods.Add(new Food() { FoodName = "Balık Kızartma(200g)", Calori =585, FoodCategory = foodCategories[0], IsActive = true });
            foods.Add(new Food() { FoodName = "Balık Izgara", Calori =230, FoodCategory = foodCategories[0], IsActive = true });
            foods.Add(new Food() { FoodName = "Balık Buğlama", Calori =398, FoodCategory = foodCategories[0], IsActive = true });
            foods.Add(new Food() { FoodName = "Balık Çorbası", Calori =146, FoodCategory = foodCategories[0], IsActive = true });
            foods.Add(new Food() { FoodName = "Fırında Balık", Calori =334, FoodCategory = foodCategories[0], IsActive = true });
            foods.Add(new Food() { FoodName = "Balık Nuget", Calori =196, FoodCategory = foodCategories[0], IsActive = true });
            foods.Add(new Food() { FoodName = "Ton Balık(80gr)", Calori =110, FoodCategory = foodCategories[0], IsActive = true });

            foods.Add(new Food() { FoodName = "Antrikot", Calori = 303, FoodCategory = foodCategories[1], IsActive = true });
            foods.Add(new Food() { FoodName = "İskender", Calori = 476, FoodCategory = foodCategories[1], IsActive = true });
            foods.Add(new Food() { FoodName = "Bonfile", Calori = 276, FoodCategory = foodCategories[1], IsActive = true });
            foods.Add(new Food() { FoodName = "Dana Kıyma", Calori = 172, FoodCategory = foodCategories[1], IsActive = true });
            foods.Add(new Food() { FoodName = "Kuzu Pirzola", Calori = 276, FoodCategory = foodCategories[1], IsActive = true });
            foods.Add(new Food() { FoodName = "Sığır Eti", Calori = 248, FoodCategory = foodCategories[1], IsActive = true });
            foods.Add(new Food() { FoodName = "Dana Kavurma", Calori = 360, FoodCategory = foodCategories[1], IsActive = true });
            foods.Add(new Food() { FoodName = "Sığır Eti", Calori = 248, FoodCategory = foodCategories[1], IsActive = true });
            foods.Add(new Food() { FoodName = "Et Şiş", Calori = 324, FoodCategory = foodCategories[1], IsActive = true });
            foods.Add(new Food() { FoodName = "Ciğer Şiş", Calori = 287, FoodCategory = foodCategories[1], IsActive = true });
            foods.Add(new Food() { FoodName = "Haşlama Çorbası", Calori = 159, FoodCategory = foodCategories[1], IsActive = true });
            foods.Add(new Food() { FoodName = "Etli Biber Dolması", Calori = 95, FoodCategory = foodCategories[1], IsActive = true });
            foods.Add(new Food() { FoodName = "Et Döner", Calori = 301, FoodCategory = foodCategories[1], IsActive = true });

            foods.Add(new Food() { FoodName = "Bamya", Calori = 33, FoodCategory = foodCategories[2], IsActive = true });
            foods.Add(new Food() { FoodName = "Bezelye", Calori = 42, FoodCategory = foodCategories[2], IsActive = true });
            foods.Add(new Food() { FoodName = "Barbunya Fasulye", Calori = 347, FoodCategory = foodCategories[2], IsActive = true });
            foods.Add(new Food() { FoodName = "Kuru Fasulye", Calori = 336, FoodCategory = foodCategories[2], IsActive = true });
            foods.Add(new Food() { FoodName = "Mercimek", Calori = 353, FoodCategory = foodCategories[2], IsActive = true });
            foods.Add(new Food() { FoodName = "Yeşil Mercimek", Calori = 257, FoodCategory = foodCategories[2], IsActive = true });
            foods.Add(new Food() { FoodName = "Nohut", Calori = 364, FoodCategory = foodCategories[2], IsActive = true });

            foods.Add(new Food() { FoodName = "Çoban Salata", Calori = 115, FoodCategory = foodCategories[3], IsActive = true });
            foods.Add(new Food() { FoodName = "Mevsim Salata", Calori = 59, FoodCategory = foodCategories[3], IsActive = true });
            foods.Add(new Food() { FoodName = "Sezar Salata", Calori = 466, FoodCategory = foodCategories[3], IsActive = true });
            foods.Add(new Food() { FoodName = "Tavuklu Salata", Calori = 130, FoodCategory = foodCategories[3], IsActive = true });
            foods.Add(new Food() { FoodName = "Ton Balıklı Salata", Calori = 327, FoodCategory = foodCategories[3], IsActive = true });

            foods.Add(new Food() { FoodName = "Ahududu", Calori = 64, FoodCategory = foodCategories[4], IsActive = true });
            foods.Add(new Food() { FoodName = "Ananas", Calori = 50, FoodCategory = foodCategories[4], IsActive = true });
            foods.Add(new Food() { FoodName = "Armut", Calori = 57, FoodCategory = foodCategories[4], IsActive = true });
            foods.Add(new Food() { FoodName = "Avokado", Calori = 160, FoodCategory = foodCategories[4], IsActive = true });
            foods.Add(new Food() { FoodName = "Ayva", Calori = 57, FoodCategory = foodCategories[4], IsActive = true });
            foods.Add(new Food() { FoodName = "Böğürtlen", Calori = 43, FoodCategory = foodCategories[4], IsActive = true });
            foods.Add(new Food() { FoodName = "Elma", Calori = 52, FoodCategory = foodCategories[4], IsActive = true });
            foods.Add(new Food() { FoodName = "Erik", Calori = 46, FoodCategory = foodCategories[4], IsActive = true });
            foods.Add(new Food() { FoodName = "Üzüm", Calori = 56, FoodCategory = foodCategories[4], IsActive = true });
            foods.Add(new Food() { FoodName = "İncir", Calori = 74, FoodCategory = foodCategories[4], IsActive = true });
            foods.Add(new Food() { FoodName = "Muz", Calori = 122, FoodCategory = foodCategories[4], IsActive = true });
            foods.Add(new Food() { FoodName = "Karpuz", Calori = 30, FoodCategory = foodCategories[4], IsActive = true });
            foods.Add(new Food() { FoodName = "Kayısı", Calori = 48, FoodCategory = foodCategories[4], IsActive = true });
            foods.Add(new Food() { FoodName = "Kiraz", Calori = 50, FoodCategory = foodCategories[4], IsActive = true });
            foods.Add(new Food() { FoodName = "Kivi", Calori = 61, FoodCategory = foodCategories[4], IsActive = true });
            foods.Add(new Food() { FoodName = "Limon", Calori = 29, FoodCategory = foodCategories[4], IsActive = true });
            foods.Add(new Food() { FoodName = "Mandalina", Calori = 53, FoodCategory = foodCategories[4], IsActive = true });
            foods.Add(new Food() { FoodName = "Nar", Calori = 83, FoodCategory = foodCategories[4], IsActive = true });
            foods.Add(new Food() { FoodName = "Portakal", Calori = 47, FoodCategory = foodCategories[4], IsActive = true });
            foods.Add(new Food() { FoodName = "Şeftali", Calori = 39, FoodCategory = foodCategories[4], IsActive = true });
            foods.Add(new Food() { FoodName = "Çilek", Calori = 32, FoodCategory = foodCategories[4], IsActive = true });
            foods.Add(new Food() { FoodName = "Şeftali", Calori = 39, FoodCategory = foodCategories[4], IsActive = true });
            foods.Add(new Food() { FoodName = "Kavun", Calori = 34, FoodCategory = foodCategories[4], IsActive = true });

            foods.Add(new Food() { FoodName = "Biber", Calori = 20, FoodCategory = foodCategories[13], IsActive = true });
            foods.Add(new Food() { FoodName = "Brokoli", Calori = 207, FoodCategory = foodCategories[13], IsActive = true });
            foods.Add(new Food() { FoodName = "Lahana", Calori = 8, FoodCategory = foodCategories[13], IsActive = true });
            foods.Add(new Food() { FoodName = "Domates", Calori = 20, FoodCategory = foodCategories[13], IsActive = true });
            foods.Add(new Food() { FoodName = "Ispanak", Calori = 78, FoodCategory = foodCategories[13], IsActive = true });
            foods.Add(new Food() { FoodName = "Kabak", Calori = 51, FoodCategory = foodCategories[13], IsActive = true });
            foods.Add(new Food() { FoodName = "Kara Lahana", Calori = 12, FoodCategory = foodCategories[13], IsActive = true });
            foods.Add(new Food() { FoodName = "Karnıbahar", Calori = 3, FoodCategory = foodCategories[13], IsActive = true });
            foods.Add(new Food() { FoodName = "Kırmızı Biber", Calori = 12, FoodCategory = foodCategories[13], IsActive = true });
            foods.Add(new Food() { FoodName = "Mantar", Calori = 22, FoodCategory = foodCategories[13], IsActive = true });
            foods.Add(new Food() { FoodName = "Mısır", Calori = 365, FoodCategory = foodCategories[13], IsActive = true });
            foods.Add(new Food() { FoodName = "Patates", Calori = 164, FoodCategory = foodCategories[13], IsActive = true });
            foods.Add(new Food() { FoodName = "Patlıcan", Calori = 115, FoodCategory = foodCategories[13], IsActive = true });
            foods.Add(new Food() { FoodName = "Pırasa", Calori = 61, FoodCategory = foodCategories[13], IsActive = true });
            foods.Add(new Food() { FoodName = "Roka", Calori = 1, FoodCategory = foodCategories[13], IsActive = true });
            foods.Add(new Food() { FoodName = "Salatalık", Calori = 33, FoodCategory = foodCategories[13], IsActive = true });
            foods.Add(new Food() { FoodName = "Sarımsak", Calori = 4, FoodCategory = foodCategories[13], IsActive = true });
            foods.Add(new Food() { FoodName = "Soğan", Calori = 34, FoodCategory = foodCategories[13], IsActive = true });
            foods.Add(new Food() { FoodName = "Turp", Calori = 34, FoodCategory = foodCategories[13], IsActive = true });
            foods.Add(new Food() { FoodName = "Havuç", Calori = 25, FoodCategory = foodCategories[13], IsActive = true });

            foods.Add(new Food() { FoodName = "Boza", Calori = 370, FoodCategory = foodCategories[5], IsActive = true });
            foods.Add(new Food() { FoodName = "Coca Cola", Calori = 139, FoodCategory = foodCategories[5], IsActive = true });
            foods.Add(new Food() { FoodName = "Gazoz", Calori = 105, FoodCategory = foodCategories[5], IsActive = true });
            foods.Add(new Food() { FoodName = "Ice Tea", Calori = 135, FoodCategory = foodCategories[5], IsActive = true });
            foods.Add(new Food() { FoodName = "Kahve", Calori = 2, FoodCategory = foodCategories[5], IsActive = true });
            foods.Add(new Food() { FoodName = "Cola Zero", Calori = 1, FoodCategory = foodCategories[5], IsActive = true });
            foods.Add(new Food() { FoodName = "Latte Macchiato", Calori = 57, FoodCategory = foodCategories[5], IsActive = true });
            foods.Add(new Food() { FoodName = "Limonata", Calori = 42, FoodCategory = foodCategories[5], IsActive = true });
            foods.Add(new Food() { FoodName = "Milkshake", Calori = 329, FoodCategory = foodCategories[5], IsActive = true });
            foods.Add(new Food() { FoodName = "Süt", Calori = 61, FoodCategory = foodCategories[5], IsActive = true });
            foods.Add(new Food() { FoodName = "Sıcak Çikolata", Calori = 89, FoodCategory = foodCategories[5], IsActive = true });
            foods.Add(new Food() { FoodName = "Türk Kahvesi", Calori = 2, FoodCategory = foodCategories[5], IsActive = true });
            foods.Add(new Food() { FoodName = "Çay", Calori = 2, FoodCategory = foodCategories[5], IsActive = true });
            foods.Add(new Food() { FoodName = "Bitki Çayı", Calori = 2, FoodCategory = foodCategories[5], IsActive = true });
            foods.Add(new Food() { FoodName = "Fanta", Calori = 140, FoodCategory = foodCategories[5], IsActive = true });
            foods.Add(new Food() { FoodName = "Meyveli Soda", Calori = 94, FoodCategory = foodCategories[5], IsActive = true });
            foods.Add(new Food() { FoodName = "Portakal Suyu", Calori = 90, FoodCategory = foodCategories[5], IsActive = true });
            foods.Add(new Food() { FoodName = "Ayran", Calori = 76, FoodCategory = foodCategories[5], IsActive = true });
            foods.Add(new Food() { FoodName = "Espresso", Calori = 151, FoodCategory = foodCategories[5], IsActive = true });
            foods.Add(new Food() { FoodName = "Frappuccino ", Calori = 258, FoodCategory = foodCategories[5], IsActive = true });
            foods.Add(new Food() { FoodName = "White Chocolate Mocha", Calori = 257, FoodCategory = foodCategories[5], IsActive = true });
            foods.Add(new Food() { FoodName = "Viski", Calori = 125, FoodCategory = foodCategories[5], IsActive = true });
            foods.Add(new Food() { FoodName = "Rakı", Calori = 131, FoodCategory = foodCategories[5], IsActive = true });
            foods.Add(new Food() { FoodName = "Bira", Calori = 138, FoodCategory = foodCategories[5], IsActive = true });
            foods.Add(new Food() { FoodName = "Şarap", Calori = 111, FoodCategory = foodCategories[5], IsActive = true });
            foods.Add(new Food() { FoodName = "Votka", Calori = 116, FoodCategory = foodCategories[5], IsActive = true });

            foods.Add(new Food() { FoodName = "Fındık", Calori = 154, FoodCategory = foodCategories[6], IsActive = true });
            foods.Add(new Food() { FoodName = "Badem", Calori = 150, FoodCategory = foodCategories[6], IsActive = true });
            foods.Add(new Food() { FoodName = "Ceviz", Calori = 164, FoodCategory = foodCategories[6], IsActive = true });
            foods.Add(new Food() { FoodName = "Lebleli", Calori = 24, FoodCategory = foodCategories[6], IsActive = true });
            foods.Add(new Food() { FoodName = "Antep Fıstığı", Calori = 101, FoodCategory = foodCategories[6], IsActive = true });
            foods.Add(new Food() { FoodName = "Kaju", Calori = 138, FoodCategory = foodCategories[6], IsActive = true });
            foods.Add(new Food() { FoodName = "Fıstık", Calori = 170, FoodCategory = foodCategories[6], IsActive = true });
            foods.Add(new Food() { FoodName = "Kabak Çekirdeği", Calori = 56, FoodCategory = foodCategories[6], IsActive = true });

            foods.Add(new Food() { FoodName = "Makarna", Calori = 141, FoodCategory = foodCategories[7], IsActive = true });
            foods.Add(new Food() { FoodName = "Pirinç Pilavı", Calori = 258, FoodCategory = foodCategories[7], IsActive = true });
            foods.Add(new Food() { FoodName = "Bulgur Pilavı", Calori = 149, FoodCategory = foodCategories[7], IsActive = true });

            foods.Add(new Food() { FoodName = "Cips", Calori = 124, FoodCategory = foodCategories[8], IsActive = true });
            foods.Add(new Food() { FoodName = "Patetes Kızartması", Calori = 250, FoodCategory = foodCategories[8], IsActive = true });

            foods.Add(new Food() { FoodName = "1 dilim Ekmek", Calori = 64, FoodCategory = foodCategories[9], IsActive = true });

            foods.Add(new Food() { FoodName = "Beyaz Peynir", Calori = 93, FoodCategory = foodCategories[10], IsActive = true });
            foods.Add(new Food() { FoodName = "Kaşar Peyniri", Calori = 71, FoodCategory = foodCategories[10], IsActive = true });
            foods.Add(new Food() { FoodName = "Yoğurt", Calori = 122, FoodCategory = foodCategories[10], IsActive = true });

            foods.Add(new Food() { FoodName = "Tavuk Burger", Calori = 274, FoodCategory = foodCategories[11], IsActive = true });
            foods.Add(new Food() { FoodName = "Hamburger", Calori = 386, FoodCategory = foodCategories[11], IsActive = true });
            foods.Add(new Food() { FoodName = "Cheeseburger", Calori = 410, FoodCategory = foodCategories[11], IsActive = true });

            foods.Add(new Food() { FoodName = "Sütlaç", Calori = 250, FoodCategory = foodCategories[12], IsActive = true });
            foods.Add(new Food() { FoodName = "Kazandibi", Calori = 200, FoodCategory = foodCategories[12], IsActive = true });
            foods.Add(new Food() { FoodName = "Baklava", Calori = 165, FoodCategory = foodCategories[12], IsActive = true });
            foods.Add(new Food() { FoodName = "Künefe", Calori = 420, FoodCategory = foodCategories[12], IsActive = true });

            context.Foods.AddRange(foods);

            List<MealCategory> mealCategories = new List<MealCategory>();
            mealCategories.Add(new MealCategory() { MealCategoryName = "Sabah" });
            mealCategories.Add(new MealCategory() { MealCategoryName = "Öğle" });
            mealCategories.Add(new MealCategory() { MealCategoryName = "Akşam" });
            mealCategories.Add(new MealCategory() { MealCategoryName = "Aperatif" });

            context.MealCategories.AddRange(mealCategories);

            context.SaveChanges();
        }
    }
}
