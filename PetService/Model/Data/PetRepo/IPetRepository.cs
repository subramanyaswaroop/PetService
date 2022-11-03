using PetService.Model.Entities;

namespace PetService.Model.Data.PetRepo
{
    public interface IPetRepository
    {
        void AddPet(Pet pet);
        Pet getPetById(int id);
        void UpdatePet(Pet pet);
        void DeletePet(Pet pet);
        List<Pet> getPetsByPetOwnerId(int id);
    }
}
