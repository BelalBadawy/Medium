using Microsoft.AspNetCore.Mvc;

namespace MediumAPI.Infrastructure
{
    // [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]



    [Route("/api/v{version:apiVersion}/[controller]/[action]")]





    [ApiController]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public class BaseApiController : ControllerBase
    {
        public BaseApiController()
        {

        }


        #region Custom
        #endregion Custom

    }
}
