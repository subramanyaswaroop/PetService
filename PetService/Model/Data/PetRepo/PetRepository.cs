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

        public void DeletePet(Pet pet)
        {
            db.Pets.Remove(pet);
            db.SaveChanges();
        }

        public Pet getPetById(int id)
        {
            return db.Pets.Find(id);
        }
        public List<Pet> getPetsByPetOwnerId(int id)
        {
            return(from Pet in db.Pets 
                   where Pet.PetOwnerId == id 
                   select Pet).ToList();
        }

        public void UpdatePet(Pet pet)
        {
            db.Entry(pet).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
