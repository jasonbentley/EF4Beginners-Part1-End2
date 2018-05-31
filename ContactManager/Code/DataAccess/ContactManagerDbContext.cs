using ContactManager.Code.Model;
using System.Data.Entity;

namespace ContactManager.Code.DataAccess
{
    public class ContactManagerDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}