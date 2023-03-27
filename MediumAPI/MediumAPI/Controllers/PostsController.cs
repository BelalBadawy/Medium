using Azure.Core;
using MediumAPI.Dtos;
using MediumAPI.Entites;
using MediumAPI.Extensions;
using MediumAPI.Infrastructure;
using MediumAPI.Models;
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
                var result = await _dbContext.Posts
                          .Where(o => o.IsActive)
                          .OrderBy(o => o.CreatedDate)
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


        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult> PostsPagedList(string searchValue = "", string orderBy = "", bool orderAscendingDirection = true, int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                PagedResult<PostDto> pagedResult = null;

                var query = _dbContext.Posts.Where(o => o.IsActive)
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
                              .AsNoTracking().AsQueryable();

                if (!string.IsNullOrEmpty(searchValue))
                {
                    if (!string.IsNullOrEmpty(searchValue))
                    {
                        query = query.Where(o => (string.IsNullOrEmpty(searchValue) || o.Title.ToUpper().Contains(searchValue)) && (string.IsNullOrEmpty(searchValue) || o.Description.ToUpper().Contains(searchValue)) && (string.IsNullOrEmpty(searchValue)));
                    }
                }


                if (!string.IsNullOrEmpty(orderBy))
                {
                    query = orderAscendingDirection ? query.OrderByDynamic(orderBy, AppEnums.DataOrderDirection.Asc) : query.AsQueryable().OrderByDynamic(orderBy, AppEnums.DataOrderDirection.Desc);
                }

                var totalRecords = await query.CountAsync();
                if (totalRecords > 0)
                {
                    var result = await query.Skip(pageSize * (pageIndex - 1))
                                            .Take(pageSize).ToListAsync();


                    pagedResult = new PagedResult<PostDto>(
                        result,
                        totalRecords,
                        pageIndex,
                        pageSize
                    );

                    return Ok(pagedResult);
                }
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

            return NoContent();
        }
    }
}