using MediumAPI.Dtos;
using MediumAPI.Entites;
using MediumAPI.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediumAPI.Controllers
{

    [ApiVersion("1.0")]
    public class TagsController : BaseApiController
    {
        private readonly ApplicationDbContext _dbContext;

        public TagsController(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            try
            {
                var result = await _dbContext.Tags
                            .Where(o => o.IsActive)
                            .Select(o => new TagDto() { Id = o.Id, Title = o.Title })
                            .OrderBy(o => o.Title)
                            .AsNoTracking()
                            .ToListAsync();
                return Ok(result);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


    }
}