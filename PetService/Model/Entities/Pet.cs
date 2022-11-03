namespace PetService.Model.Entities
{
    public class Pet
    {
        public int PetId { get; set; }
        public string PetName { get; set; }
        public string species { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public string BloodGroup { get; set; }
        public int PetOwnerId { get; set; }
    }
}
