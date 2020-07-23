using Microsoft.AspNetCore.Mvc;

namespace Repo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        var userModel = new UserModel();
    }
}
