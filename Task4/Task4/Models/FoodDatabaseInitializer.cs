using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Task4.Models
{
    public class FoodDatabaseInitializer : DropCreateDatabaseIfModelChanges<foodcontext>
    {
        protected override void Seed(foodcontext context)
        {
            GetCategory().ForEach(c => context.Categories.Add(c));
            GetFoods().ForEach(p => context.Food.Add(p));
        }

        private static List<category> GetCategory()
        {
            var categories = new List<category> {
                new category
                {
                    CategoryID = 1,
                    CategoryName = "Comfort Food"
                },
                new category
                {
                    CategoryID = 2,
                    CategoryName = "Healthy"
                },
                new category
                {
                    CategoryID = 3,
                    CategoryName = "Dessert"
                },
                new category
                {
                    CategoryID = 4,
                    CategoryName = "Snacks"
                },
                new category
                {
                    CategoryID = 5,
                    CategoryName = "Local"
                },
            };

            return categories;
        }
        private static List<food> GetFoods()
        {
            var foods = new List<food> {
                new food
                {
                    FoodID = 1,
                    FoodName = "Burrito",
                    Description = "Pillow",
                    ImagePath="~/images/burrito.jpg",
                    UnitPrice = 12.90,
                    CategoryID = 1
               },
                new food
                {
                    FoodID = 2,
                    FoodName = "Fried Chicken",
                    Description = "Deep fried finger licking gooooooood",
                    ImagePath="~/images/friedchicken.jpg",
                    UnitPrice = 7.90,
                     CategoryID = 1
               },
                new food
                {
                    FoodID = 3,
                    FoodName = "Jjampong",
                    Description = "Spicy soup",
                    ImagePath="carfast.png",
                    UnitPrice = 21.60,
                    CategoryID = 5
                },
                new food
                {
                    FoodID = 4,
                    FoodName = "Loaded Baked Potato",
                    Description = "Creamy potato",
                    ImagePath="~/images/loadedbakedpotato.jpg",
                    UnitPrice = 6.50,
                    CategoryID = 1
                },
                new food
                {
                    FoodID = 5,
                    FoodName = "Mapo Tofu",
                    Description = "Spicy goodness",
                    ImagePath="~/images/mapotofu.jpg",
                    UnitPrice = 13.50,
                    CategoryID = 5
                },
                new food
                {
                    FoodID = 6,
                    FoodName = "Pho",
                    Description = "Soup",
                    ImagePath="~/images/pho.jpg",
                    UnitPrice = 8.20,
                    CategoryID = 5
                },
                new food
                {
                    FoodID = 7,
                    FoodName = "Pizza",
                    Description = "Greasy dough of goodness",
                    ImagePath="~/images/pizza.jpg",
                    UnitPrice = 23.20,
                    CategoryID = 1
                },
                new food
                {
                    FoodID = 8,
                    FoodName = "Salad",
                    Description = "Ceaser Salad",
                    ImagePath="~/images/salad.jpg",
                    UnitPrice = 7.80,
                    CategoryID = 2
                },
                new food
                {
                    FoodID = 9,
                    FoodName = "Hamburger",
                    Description = "Juicy beef yum yums.",
                    ImagePath="~/images/shakeshack.jpg",
                    UnitPrice = 15.80,
                    CategoryID = 1
                },
                new food
                {
                    FoodID = 10,
                    FoodName = "Sushi Platter",
                    Description = "To be one with the fishes",
                    ImagePath="~/images/sushiplatter.jpg",
                    UnitPrice = 22.80,
                    CategoryID = 5
                }
            };
            return foods;
        }
    }
}