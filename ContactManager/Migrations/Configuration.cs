namespace ContactManager.Migrations
{
    using ContactManager.Code.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ContactManager.Code.DataAccess.ContactManagerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ContactManager.Code.DataAccess.ContactManagerDbContext context)
        {
            context.Contacts.AddOrUpdate<Contact>(new Contact { FirstName = "Harry", HomePhone = "555-555-5555", ID = 1, IsActive = true, LastName = "Bosch", MobilePhone = "555-555-5556" });
            context.Contacts.AddOrUpdate<Contact>(new Contact { FirstName = "Dalinar", HomePhone = "555-555-5555", ID = 2, IsActive = true, LastName = "Kholin", MobilePhone = "555-555-5556" });
            context.Contacts.AddOrUpdate<Contact>(new Contact { FirstName = "Mat", HomePhone = "555-555-5555", ID = 3, IsActive = true, LastName = "Cauthon", MobilePhone = "555-555-5556" });
            context.Contacts.AddOrUpdate<Contact>(new Contact { FirstName = "Eddard", HomePhone = "555-555-5555", ID = 4, IsActive = true, LastName = "Stark", MobilePhone = "555-555-5556" });
            context.Contacts.AddOrUpdate<Contact>(new Contact { FirstName = "Albus", HomePhone = "555-555-5555", ID = 5, IsActive = true, LastName = "Dumbledore", MobilePhone = "555-555-5556" });
            context.Contacts.AddOrUpdate<Contact>(new Contact { FirstName = "Bruce", HomePhone = "555-555-5555", ID = 6, IsActive = true, LastName = "Wayne", MobilePhone = "555-555-5556" });
            context.Contacts.AddOrUpdate<Contact>(new Contact { FirstName = "Elayne", HomePhone = "555-555-5555", ID = 7, IsActive = true, LastName = "Trakand", MobilePhone = "555-555-5556" });
            context.Contacts.AddOrUpdate<Contact>(new Contact { FirstName = "George", HomePhone = "555-555-5555", ID = 8, IsActive = true, LastName = "Smiley", MobilePhone = "555-555-5556" });
            context.Contacts.AddOrUpdate<Contact>(new Contact { FirstName = "Jack", HomePhone = "555-555-5555", ID = 9, IsActive = true, LastName = "Ryan", MobilePhone = "555-555-5556" });
            context.Contacts.AddOrUpdate<Contact>(new Contact { FirstName = "Locke", HomePhone = "555-555-5555", ID = 10, IsActive = true, LastName = "Lamora", MobilePhone = "555-555-5556" });
            context.Contacts.AddOrUpdate<Contact>(new Contact { FirstName = "Jamie", HomePhone = "555-555-5555", ID = 11, IsActive = true, LastName = "Lannister", MobilePhone = "555-555-5556" });
            context.Contacts.AddOrUpdate<Contact>(new Contact { FirstName = "Mitch", HomePhone = "555-555-5555", ID = 12, IsActive = true, LastName = "Rapp", MobilePhone = "555-555-5556" });
        }
    }
}
