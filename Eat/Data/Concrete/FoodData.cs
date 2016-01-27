using Eat.Data.Abstract;
using Eat.Entity;
using Eat.Service.Abstract;

namespace Eat.Data.Concrete
{
    public class FoodData : IFoodData
    {
        IFoodService foodService;

        public FoodData(IFoodService foodService)
        {
            this.foodService = foodService;
        }

        private void CreateFood(string name, string brand, int quantity, int calories)
        {
            foodService.Save(new Food
            {
                Name = name,
                Brand = brand,
                Quantity = quantity,
                Calories = calories
            });
        }

        public void Create()
        {
            CreateFood("Oatmeal, medium", "Mornflake", 40, 148);
            CreateFood("Blueberries", "", 100, 57);
            CreateFood("Walnuts", "", 100, 618);
            CreateFood("Milk, skimmed", "", 100, 35);
            CreateFood("Protein Powder", "Matrix", 30, 110);
            CreateFood("Shredded Wheat", "", 100, 363);
            CreateFood("Banana", "", 100, 89);
            CreateFood("Yogurt, low fat natural", "Waitrose", 100, 63);
            CreateFood("Apple", "", 100, 52);
            CreateFood("Honey", "", 100, 304);
            CreateFood("Almonds", "", 100, 576);
            CreateFood("Chicken, raw", "", 100, 110);
            CreateFood("Chicken, grilled", "", 125, 170);
            CreateFood("Broccoli, raw", "", 100, 38);
            CreateFood("Pecans", "", 100, 690);
            CreateFood("Cucumber", "", 100, 12);
            CreateFood("Crispbread, wholegrain", "", 100, 435);
            CreateFood("Beef, roast slices", "Sainsburys", 100, 120);
            CreateFood("Ham, lean slices", "Sainsburys", 100, 98);
            CreateFood("Avocado", "", 100, 160);
            CreateFood("Tomato", "", 100, 17);
            CreateFood("Tortillam, wholemeal", "Discovery", 100, 273);
            CreateFood("Raspberries", "", 100, 53);
            CreateFood("Egg, boiled", "", 100, 155);
            CreateFood("Egg White, raw", "", 100, 52);
            CreateFood("Feta Cheese", "Tesco", 100, 280);
            CreateFood("Spinach, organic", "Sainsburys", 100, 29);
            CreateFood("Bread, wholemeal", "Warburton", 100, 244);
            CreateFood("Pear", "", 100, 42);
            CreateFood("Cottage cheese, light", "Tesco", 100, 75);
            CreateFood("Cheddar cheese, light", "Cathedral City", 100, 314);
            CreateFood("Bread, wholemeal", "Tesco", 100, 235);
            CreateFood("Vanilla extract", "", 100, 288);
            CreateFood("Tuna steak", "", 100, 136);
            CreateFood("Rice, whole grain, raw", "Waitrose", 100, 335);
            CreateFood("Olive oil", "", 100, 822);
            CreateFood("Teriyaki sauce", "Waitrose", 100, 215);
            CreateFood("Salmon fillet, raw?", "", 100, 200);
            CreateFood("Asparagus tips", "", 100, 28);
            CreateFood("Pasta, wholewheat fusili, uncooked", "Tesco", 100, 335);
            CreateFood("Cantaloupe", "", 100, 34);
            CreateFood("Melba toast", "", 100, 388);
            CreateFood("Egg yolk, boiled", "", 17, 55);
            CreateFood("Oatmeal, medium", "Mornflake", 100, 370);
            CreateFood("Carrots", "", 100, 41);
            CreateFood("Mayonnaise, super low fat", "Sainsburys", 100, 90);
            CreateFood("Muffins, wholemeal", "Sainsburys", 100, 217);
            CreateFood("Seeds, mixed", "Waitrose", 100, 554);
            CreateFood("Rice, brown, uncooked", "Tesco easy cook", 100, 350);
            CreateFood("Tomato ketchup", "Tesco", 100, 105);
            CreateFood("Strawberries", "", 100, 33);
            CreateFood("Egg, raw, whole", "", 100, 143);
            CreateFood("Protein Bar, high protein", "Maximuscle Promax Meal", 100, 348);
            CreateFood("Muesli", "Jordans Natural", 100, 357);
            CreateFood("Ham", "Tesco Finest Wiltshire Cured", 100, 140);
            CreateFood("Grapes", "", 100, 64);
            CreateFood("Pitta, wholemeal", "Tesco", 100, 255);
            CreateFood("Olive oil", "", 100, 824);
            CreateFood("Peppers", "", 100, 37);
            CreateFood("Peanut butter", "Whole Earth Original Smooth", 100, 645);
            CreateFood("Corn on the cob", "", 100, 120);
            CreateFood("Garden peas, frozen", "", 100, 68);
            CreateFood("Turkey", "", 100, 130);
            CreateFood("Orange", "", 100, 47);
            CreateFood("Flax seeds", "", 100, 568);
            CreateFood("Turkey", "Sainsburys fancy stuff", 100, 150);
            CreateFood("Red onion", "", 100, 41);
            CreateFood("Crispbread, wholegrain", "Dr Karg 3 Seed with olive oil", 100, 465);
            CreateFood("Yogurt, low fat", "Tesco", 100, 70);
            CreateFood("Steak", "", 100, 134);
            CreateFood("Parmesan, grated", "Tesco", 100, 390);
            CreateFood("Lemon juice, freshly squeezed ", "", 47, 12);
            CreateFood("Clams, boiled", "", 100, 92);
            CreateFood("Tomato, canned", "", 100, 80);
            CreateFood("Garlic", "", 100, 149);
            CreateFood("Protein Powder", "Maximuscle Promax", 100, 391);
            CreateFood("Salmon fillet", "Sainsburys Taste The Difference", 100, 150);
            CreateFood("Semi-skimmed milk", "", 100, 50);
            CreateFood("Sugar", "", 100, 387);
            CreateFood("Whisky (ml)", "", 100, 222);
            CreateFood("Mayonnaise, super light", "Helmann's Light than light", 100, 70);
            CreateFood("Bread, wholemeal ", "Hovis", 100, 221);
            CreateFood("Smoked salmon", "Sainsbury's Scottish Mild", 100, 220);
            CreateFood("Mushroom", "", 100, 22);
            CreateFood("Muesli", "Dorset Simply Fruity", 100, 336);
            CreateFood("Clementine", "Tesco Sweet Easy Peeler", 100, 47);
            CreateFood("Salmon Maki", "Wasabi", 100, 216);
            CreateFood("Salmon Nigiri", "Wasabi", 100, 180);
            CreateFood("Salmon ?", "Wasabi", 100, 145);
            CreateFood("Chocolate", "Mandel Orange", 100, 568);
            CreateFood("Beer", "Stella Artois", 568, 244);
            CreateFood("Courgette", "", 100, 17);
            CreateFood("Spring Onion", "", 100, 32);
            CreateFood("Coconut Oil", "", 100, 857);
        }
    }
}