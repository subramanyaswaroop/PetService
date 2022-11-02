using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetService.Model.Data.Pet;
using PetService.Model.Data.PetOwner;

namespace PetService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        IPetOwnerRepo repo = new PetOwnerRepo();
        IPetRepo repo1 = new PetRepo();
        //public PetController(IPetOwnerRepo repo)
        //{
        //    this.repo = repo;
        //}
    }
}
