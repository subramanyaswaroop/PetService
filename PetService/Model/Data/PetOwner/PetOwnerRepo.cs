using PetService.Model.Data.PetServiceDb;
using PetService.Model.Entities;

namespace PetService.Model.Data.PetOwnerRepo
{
    public class PetOwnerRepo : IPetOwnerRepo
    {
        PetServiceDbContext db = new PetServiceDbContext();
        public void AddPetOwner(PetOwner petOwner)
        {
            db.PetOwners.Add(petOwner);
            db.SaveChanges();
        }

        public PetOwner GetPetOwner(int id)
        {
            return db.PetOwners.Find(id);
        }

        public void RemovePetOwner(PetOwner petOwner)
        {
            db.PetOwners.Remove(petOwner);
            db.SaveChanges();
        }

        public void UpdatePetOwner(PetOwner petOwner)
        {
            db.Entry(petOwner).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
