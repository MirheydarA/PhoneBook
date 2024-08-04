using Microsoft.EntityFrameworkCore;
using PhoneBook.Models;
using System.Configuration;

namespace PhoneBookl
{
    public class AppDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
            (@"Server=DESKTOP-00LV7K0\SQLEXPRESS01;Database=PhoneBook1;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
