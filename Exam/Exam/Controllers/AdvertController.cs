using DAL;
using DAL.Domain.Advertisement;
using Exam.DTOModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Exam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertController : ControllerBase
    {
        private Db_Context _db;

        public AdvertController(
          Db_Context db
          )
        {
            _db = db;
        }
        [HttpGet]
        [Route("[action]")]
        public IActionResult GetAllAdverts()
        {
            try
            {
                return Ok(_db.Advertisements.ToList());
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);

            }
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult GetFilteredAdverts(FilterDTO dto)
        {
            try
            {
                IQueryable<Advertisement> query = _db.Advertisements;
                if (!dto.FilterByMaxPrice && !dto.FilterByMinPrice && !dto.FilterByFitment && !dto.FilterByStatus)
                {
                    return Ok(query.ToList());
                }
                // Filtreleri uygula
                query = query.Where(advertisement =>
                    (!dto.FilterByMaxPrice || advertisement.Price <= dto.MaxPrice) &&
                    (!dto.FilterByMinPrice || advertisement.Price >= dto.MinPrice) &&
                    (!dto.FilterByFitment || dto.FitmentList.Contains(advertisement.Fitment)) &&
                    (!dto.FilterByStatus || dto.StatusList.Contains(advertisement.Status))
                );
                var response = query.ToList();
                return Ok(query);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);

            }
        }

        [HttpPost]
        [Route("[action]/{title}")]
        public IActionResult GetFilterAndTitle(FilterDTO dto, string title)
        {
            try
            {
                IQueryable<Advertisement> query = _db.Advertisements;
                if (!dto.FilterByMaxPrice && !dto.FilterByMinPrice && !dto.FilterByFitment && !dto.FilterByStatus)
                {
                    return Ok(query.Where(o => o.Title.Contains(title)).ToList());
                }
                // Filtreleri uygula
                query = query.Where(advertisement =>
                    (!dto.FilterByMaxPrice || advertisement.Price <= dto.MaxPrice) &&
                    (!dto.FilterByMinPrice || advertisement.Price >= dto.MinPrice) &&
                    (!dto.FilterByFitment || dto.FitmentList.Contains(advertisement.Fitment)) &&
                    (!dto.FilterByStatus || dto.StatusList.Contains(advertisement.Status))
                     && advertisement.Title.Contains(title)
                );
                var response = query.ToList();
                return Ok(query);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);

            }
        }
    }
}
