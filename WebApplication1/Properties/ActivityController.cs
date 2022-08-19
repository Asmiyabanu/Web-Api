using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Properties
{
    [Route("api/[controller]")]
    [ApiController]

    public class ActivityController : ControllerBase
    {
        [HttpGet]

        public void GetActivityList()
        {
            List<mockActivity> mockactivivites = new List<mockActivity>();
            mockActivity mp = new mockActivity();
            mp.id = 1;
            mp.tittle = "future activity 1";
            mp.date = "2022-09-10 T13:16:36,71315";
            mp.description = "activity 1 month in future";
            mp.catagory = "music";
            mp.city = "london";
            mp.venue = "wembly statium";

        }

        [HttpPost]

        public IActionResult UpdateActivity([FromBody] mockActivity mockActivity)
        {
            return Ok();
        }

    }

    public class mockActivity
    {
        public int id { get; set; }

        public string? tittle { get; set; }

        public string? date { get; set; }

        public string? description { get; set; }

        public string? catagory { get; set; }

        public string? city { get; set; }

        public string? venue { get; set; }
    }
}

