using Microsoft.AspNetCore.Mvc;
using PetService.Model.Data.PetOwnerRepo;
using PetService.Model.Data.PetRepo;

namespace PetService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        IPetOwnerRepo Orepo = new PetOwnerRepo();
        IPetRepository Prepo = new PetRepository();
        
    }
}
