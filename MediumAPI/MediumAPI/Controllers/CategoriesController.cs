using MediumAPI.Dtos;
using MediumAPI.Entites;
using MediumAPI.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediumAPI.Controllers
{

    [ApiVersion("1.0")]
    public class CategoriesController : BaseApiController
    {
        private readonly ApplicationDbContext _dbContext;

        public CategoriesController(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> CategoriesList()
        {
            try
            {
                var result = await _dbContext.Categories
                            .Where(o => o.IsActive)
                            .Select(o => new CategoryDto() { Id = o.Id, Title = o.Title })
                            .OrderBy(o => o.Title)
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