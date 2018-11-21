using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_RESTful_Ex.Controllers
{
    [Route("/")]
    [ApiVersion("1.0")]
    public class RootController : Controller
    {
        [HttpGet(Name = nameof(GetRoot))]
        public IActionResult GetRoot()
        {
            var response = new
            {
                href = Url.Link(nameof(GetRoot), null),
                rooms = new { href = Url.Link(nameof(RoomsController.GetRooms), null) }
            };

            return Ok(response);
        }
    }
}