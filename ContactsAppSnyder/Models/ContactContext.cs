using Microsoft.EntityFrameworkCore;

namespace ContactsAppSnyder.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options) { }

        public DbSet<Contact> Contact { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    Name = "Christi",
                    Phone = "123-456-7890",
                    Address = "123 Sunshine Lane"
                },
                new Contact
                {
                    ContactId = 2,
                    Name = "Sam",
                    Phone = "234-567-8901",
                    Address = "346 Sunshine Lane"
                },
                new Contact
                {
                    ContactId = 3,
                    Name = "George",
                    Phone = "234-567-8901",
                    Address = "346 Sunshine Lane"
                }
                );
        }
    }
}
