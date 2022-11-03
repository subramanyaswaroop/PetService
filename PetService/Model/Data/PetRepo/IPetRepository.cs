using PetService.Model.Entities;

namespace PetService.Model.Data.PetRepo
{
    public interface IPetRepository
    {
        void AddPet(Pet pet);
        void UpdatePet(Pet pet);
        Pet GetPet(int id);
        void DeletePet(Pet pet);
        List<Pet> GetAllPetByUserId(int id);
    }
}
