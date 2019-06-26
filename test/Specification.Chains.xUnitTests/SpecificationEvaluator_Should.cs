using Specification.Chains.Entities;
using Specification.Chains.Evaluator;
using Specification.Chains.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Specification.Chains.xUnitTests
{
    public class SpecificationEvaluator_Should
    {
        [Fact]
        public void ReturnMcdonalds_ForGoodAndAmerican()
        {
            var restaurantData = _getRestaurants();

            var isGoodRestaurant = new GoodRestaurantSpecification();
            var isAmerican = new AmericanRestaurantSpecification();

            var evaluator = new SpecificationEvaluator<Restaurant>();
            var mySpecification = isGoodRestaurant.And(isAmerican);

            var results = evaluator.ApplySpecification(restaurantData, mySpecification).AsEnumerable();

            Assert.Single(results);
            Assert.Contains(restaurantData.First(), results);
        }

        [Fact]
        public void ReturnBoth_ForGoodOrItalian()
        {
            var restaurantData = _getRestaurants();

            var isGoodRestaurant = new GoodRestaurantSpecification();
            var isItalian = new ItalianRestaurantSpecification();

            var evaluator = new SpecificationEvaluator<Restaurant>();
            var mySpecification = isGoodRestaurant.Or(isItalian);

            var results = evaluator.ApplySpecification(restaurantData, mySpecification).AsEnumerable();

            Assert.Equal(2, results.Count());
            Assert.Contains(restaurantData.First(), results);
            Assert.Contains(restaurantData.ElementAt(1), results);
        }

        [Fact]
        public void ReturnNone_ForGoodItalianFood()
        {
            var restaurantData = _getRestaurants();

            var isItalian = new ItalianRestaurantSpecification();
            var goodRestaurant = new GoodRestaurantSpecification();

            var evaluator = new SpecificationEvaluator<Restaurant>();
            var mySpecification = isItalian.And(goodRestaurant);

            var results = evaluator.ApplySpecification(restaurantData, mySpecification).AsEnumerable();

            Assert.Empty(results);
        }
        
        private IQueryable<Restaurant> _getRestaurants()
        {
            List<Restaurant> restaurants = new List<Restaurant>()
            {
                new Restaurant()
                {
                    Id = 1,
                    Name = "McDonald's",
                    Rating = 4.8,
                    Street = "1234 McDonalds Way", City = "Dallas", State = "Texas", Country = "USA", ZipCode = "75206",
                    Categories = new List<RestaurantCategory>() { RestaurantCategory.American },
                    Menu = new Menu()
                    {
                        Id = 1,
                        Published = new DateTime(2000, 01, 01),
                        RestaurantId = 1,
                        Categories = new List<MenuCategory>()
                        {
                            new MenuCategory()
                            {
                                Id = 1,
                                MenuId = 1,
                                Name = "Dollar Menu",
                                Items = new List<MenuItem>()
                                {
                                    new MenuItem() { Id = 1, MenuCategoryId = 1, Name = "McDouble", Description = string.Empty },
                                    new MenuItem() { Id = 2, MenuCategoryId = 1, Name = "McChicken", Description = string.Empty },
                                }
                            },
                            new MenuCategory()
                            {
                                Id = 2,
                                MenuId = 1,
                                Name = "Breakfast",
                                Items = new List<MenuItem>()
                                {
                                    new MenuItem() { Id = 3, MenuCategoryId = 2, Name = "Egg McMuffin", Description = string.Empty },
                                    new MenuItem() { Id = 4, MenuCategoryId = 2, Name = "McGriddle with Egg", Description = string.Empty },
                                }
                            }
                        }
                    }
                },
                new Restaurant()
                {
                    Id = 2,
                    Name = "Olive Garden",
                    Rating = 3.1,
                    Street = "1234 Pasta Drive", City = "Dallas", State = "Texas", Country = "USA", ZipCode = "75206",
                    Categories = new List<RestaurantCategory>() { RestaurantCategory.Italian },
                    Menu = new Menu()
                    {
                        Id = 2,
                        Published = new DateTime(1995, 01, 15),
                        RestaurantId = 2,
                        Categories = new List<MenuCategory>()
                        {
                            new MenuCategory()
                            {
                                Id = 3,
                                MenuId = 2,
                                Name = "Appetizers",
                                Items = new List<MenuItem>()
                                {
                                    new MenuItem() { Id = 5, MenuCategoryId = 3, Name = "Garlic Bread", Description = string.Empty },
                                    new MenuItem() { Id = 6, MenuCategoryId = 3, Name = "McChicken", Description = string.Empty },
                                }
                            },
                            new MenuCategory()
                            {
                                Id = 4,
                                MenuId = 2,
                                Name = "Dinner Entrees",
                                Items = new List<MenuItem>()
                                {
                                    new MenuItem() { Id = 7, MenuCategoryId = 4, Name = "Pasta with Clams", Description = string.Empty },
                                    new MenuItem() { Id = 8, MenuCategoryId = 4, Name = "Fettucini Alredo", Description = string.Empty },
                                }
                            }
                        }
                    }
                }
            };

            return restaurants.AsQueryable();
        }
    }
}
