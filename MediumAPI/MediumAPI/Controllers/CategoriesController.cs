using MediumAPI.Dtos;
using MediumAPI.Entites;
using MediumAPI.Infrastructure;
using Microsoft.AspNetCore.Authorization;
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
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> List()
        {
            try
            {
                var result = await _dbContext.Categories
                            .Where(o => o.IsActive)
                            .Select(o => new CategoryDto() { Id = o.Id, Title = o.Title })
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
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> ListWithPostCount()
        {
            try
            {
                var result = await _dbContext.Categories
                    .Where(o => o.IsActive)
                    .Select(o => new CategoryPostCountDto
                    {
                        Id = o.Id,
                        Title = o.Title,
                        PostCounts = o.PostCategories.Where(x => x.Posts.IsActive).Count(o => o.CategoryId == o.CategoryId)
                    })
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