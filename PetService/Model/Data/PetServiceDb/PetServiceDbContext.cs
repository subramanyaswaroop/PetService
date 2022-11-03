using Microsoft.EntityFrameworkCore;
using PetService.Model.Entities;

namespace PetService.Model.Data.PetServiceDb
{
    public class PetServiceDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            OptionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=PetServiceDb;Integrated Security=True");
        }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<PetOwner> PetOwners { get; set; }
    }
}
