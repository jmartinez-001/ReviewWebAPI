namespace ReviewWebAPI.Migrations
{
    using ReviewWebAPI.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ReviewWebAPI.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ReviewWebAPI.Models.ApplicationDbContext context)
        {
            //This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.E.g.

            //context.Authors.AddOrUpdate(
            //  new Author() { Id = 2, FirstName = "John", LastName = "W", UserId = "9fc208d2-b07e-469c-8987-c25f7a1b6c7e" },
            //  new Author() { Id = 3, FirstName = "Jane", LastName = "D", UserId = "9f9da9e2-be69-4d24-b6ad-6f5c27ccd9ac" }
            //);

            //context.Reviews.AddOrUpdate(

            //    new Review()
            //    {
            //        Id = 1,
            //        AuthorId = 2,
            //        ContractorId = 3,
            //        ClientId = 1,
            //        JobType = "Repair",
            //        Title = "Leaking Bathroom Faucet",
            //        Content = "Jane, was a great client. She was very thorough in explaining what she wanted done, which helped get started faster." +
            //        "Worn out gaskets had to be replaced, only took a few hours. All in all, Jane knows what she wants and is clear with her needs.",
            //        Date = DateTime.ParseExact("2019-05-14", "yyyy-MM-dd", null),
            //        Rating = 5,
            //        Budget = "At Budget",
            //        Helpful = 0,
            //        Comments = null
            //    },
            //    new Review()
            //    {
            //        Id = 2,
            //        AuthorId = 3,
            //        ContractorId = 3,
            //        ClientId = 1,
            //        JobType = "Repair",
            //        Title = "Bathroom Faucet Leaking",
            //        Content = "John, is a very knowledgable. He knew exactly what I needed when he came for the estimate. He was timely throughout our interactions." +
            //        " He kept a clean workplace and cleaned up after himself. I would recommend John for any future repair or handyman needs.",
            //        Date = DateTime.ParseExact("2019-05-14", "yyyy-MM-dd", null),
            //        Rating = 5,
            //        Budget = "At Budget",
            //        Helpful = 0,
            //        Comments = null
            //    }
            //);


        }
    }
}