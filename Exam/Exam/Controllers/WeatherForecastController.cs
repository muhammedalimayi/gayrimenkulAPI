using DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace Exam.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private Db_Context _db;

        public WeatherForecastController(
          Db_Context db


          )
        {
            _db = db;
        }
        [HttpGet]
        [Route("[action]")]
        public IActionResult Test()
        {
            try
            {
                //_db.Advertisements.ToList();
                return Ok(_db.Advertisements.ToList());
            }
            catch (Exception e)
            {
                return Ok();
            }
        }


    }
}