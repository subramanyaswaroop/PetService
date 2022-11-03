using PetService.Model.Data.PetServiceDb;
using PetService.Model.Entities;

namespace PetService.Model.Data.PetRepo
{
    public class PetRepository : IPetRepository
    {
        PetServiceDbContext db = new PetServiceDbContext();
        public void AddPet(Pet pet)
        {
            db.Pets.Add(pet);
            db.SaveChanges();
        }

        public Pet GetPet(int id)
        {
            return db.Pets.Find(id);
        }

        public void DeletePet(Pet pet)
        {
            db.Pets.Remove(pet);
            db.SaveChanges();
        }

        public void UpdatePet(Pet pet)
        {
            db.Entry(pet).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public List<Pet> GetAllPetByUserId(int id)
        {
            return (from pet in db.Pets
                    where pet.PetOwnerId == id
                    select pet).ToList();
        }
    }
}
