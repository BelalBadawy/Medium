using Azure.Core;
using MediumAPI.Dtos;
using MediumAPI.Entites;
using MediumAPI.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace MediumAPI.Controllers
{

    [ApiVersion("1.0")]
    public class PostsController : BaseApiController
    {
        private readonly ApplicationDbContext _dbContext;

        public PostsController(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> List()
        {
            try
            {
                var result = await _dbContext.Posts.Where(o => o.IsActive)
                          .Select(o => new PostDto
                          {
                              Id = o.Id,
                              Title = o.Title,
                              BannerImageUrl = o.BannerImageUrl,
                              CreatedDate = o.CreatedDate,
                              Description = o.Description,
                              PostCommentsCount = o.PostComments.Count(o => o.IsActive),
                              Slug = o.Slug,
                              UserId = o.UserId,
                              UserName = _dbContext.ApplicationUsers.First(x => x.Id == o.UserId).UserName,
                              ViewCount = o.ViewCount,
                              PostTags = o.PostTags.Where(x => x.Tags.IsActive).Select(t => t.Tags.Title).ToList(),
                              PostCategories = o.PostCategories.Where(x => x.Categories.IsActive).Select(c => c.Categories.Title).ToList()
                          })
                         .AsNoTracking().ToListAsync();
                return Ok(result);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult> PopularPosts(int postCounts = 3)
        {
            try
            {
                var result = await _dbContext.Posts
                       .Where(o => o.IsActive)
                       .OrderByDescending(o => o.ViewCount)
                       .Select(o => new PopularPostsDto
                       {
                           Id = o.Id,
                           Title = o.Title,
                           BannerImageUrl = o.BannerImageUrl,
                           CreatedDate = o.CreatedDate,
                           Slug = o.Slug,
                       })
                      .AsNoTracking().Take(postCounts).ToListAsync();
                return Ok(result);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult> PostsArchives(int year)
        {
            try
            {
                if (year == 0)
                {
                    year = DateTime.Now.Year;
                }

                var result = await _dbContext.Posts
                        .Where(o => o.IsActive && o.CreatedDate.Year == year)
                        .GroupBy(x => new
                        {
                            Year = x.CreatedDate.Year,
                            Month = x.CreatedDate.Month
                        },
                            (x, e) => new PostsArchivesDto
                            {
                                Id = x.Month + "-" + x.Year,
                                Year = x.Year,
                                Month = x.Month,
                                PostCounts = e.Count(),
                                MonthYearName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(x.Month) + " " + x.Year
                            }

                            )
                       .AsNoTracking().ToListAsync();

                return Ok(result);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}