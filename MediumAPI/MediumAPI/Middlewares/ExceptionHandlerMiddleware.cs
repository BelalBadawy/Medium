
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MediumAPI.Middlewares
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlerMiddleware> _logger;

        public ExceptionHandlerMiddleware(RequestDelegate next, ILogger<ExceptionHandlerMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await ConvertException(context, ex);
            }
        }

        private Task ConvertException(HttpContext context, Exception exception)
        {
            HttpStatusCode httpStatusCode = HttpStatusCode.InternalServerError;

            context.Response.ContentType = "application/json";

            var result = string.Empty;

            //switch (exception)
            //{
            //    case Application.Exceptions.ValidationException validationException:
            //        httpStatusCode = validationException.StatusCode;
            //        result = JsonConvert.SerializeObject(validationException.Errors);
            //        break;
            //    case CustomException customException:
            //        httpStatusCode = customException.StatusCode;
            //        result = JsonConvert.SerializeObject(customException.Message);
            //        break;
            //}

            context.Response.StatusCode = (int)httpStatusCode;

            if (result == string.Empty)
            {
                result = JsonConvert.SerializeObject(new { error = exception.Message });
                _logger.LogError(result);
            }

            return context.Response.WriteAsync(result);
        }

            
#region Custom
#endregion Custom

}
}
