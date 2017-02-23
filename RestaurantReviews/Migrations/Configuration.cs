namespace RestaurantReviews.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RestaurantReviewsDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "RestaurantReviews.Models.RestaurantReviewsDb";
        }

        protected override void Seed(RestaurantReviewsDb context)
        {
            context.Restaurants.AddOrUpdate(r => r.Name,
                new Restaurant { Name = "Ozone", City = "Khartoum", Country = "Sudan" },
                new Restaurant { Name = "Le Grill", City = "Paris", Country = "France" },
                new Restaurant
                {
                    Name = "Italy Pizza",
                    City = "Rome",
                    Country = "Italy",
                    Reviews = new List<RestaurantReview>
                    {
                        new RestaurantReview {Rating = 9, Body="Great Food!", ReviewerName="Mike" }
                    }
                });

            for (int i = 0; i < 1000; i++)
            {
                context.Restaurants.AddOrUpdate(r => r.Name,
                    new Restaurant { Name = i.ToString(), City = "Nowhere", Country = "USA" });
            }
        }
    }
}
