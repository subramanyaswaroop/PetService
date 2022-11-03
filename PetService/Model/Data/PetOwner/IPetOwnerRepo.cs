using PetService.Model.Entities;

namespace PetService.Model.Data.PetOwnerRepo
{
    public interface IPetOwnerRepo
    {
        void AddPetOwner(PetOwner petOwner);
        void RemovePetOwner(PetOwner petOwner);
        PetOwner GetPetOwner(int id);
        void UpdatePetOwner(PetOwner petOwner);


    }
}
