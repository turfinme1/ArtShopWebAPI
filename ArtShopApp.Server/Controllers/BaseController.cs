using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ArtShopApp.Server.Controllers
{
    [Authorize]
    public abstract class BaseController : ControllerBase
    {
    }
}
