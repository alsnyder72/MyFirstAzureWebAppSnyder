using Microsoft.EntityFrameworkCore;

namespace MyFirstAzureWebAppSnyder.Models
{
    public class ContactContext : DbContext
    {

        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        { }

        public DbSet<Contact> Contacts { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // you don't actually need to call this
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    Name = "Alan Snyder",
                    Phone = "555-123-4567",
                    Address = "123 Main Street, Anytown Iowa, USA",
                },
                new Contact
                {
                    ContactId = 2,
                    Name = "Sam Snyder",
                    Phone = "555-456-7890",
                    Address = "123 Main Street, Anytown Iowa, USA",
                },
                new Contact
                {
                    ContactId = 3,
                    Name = "James Smith",
                    Phone = "555-723-1234",
                    Address = "4567 Business Boulevard, Anytown Iowa, USA",
                }
            );
        }
    }
}
