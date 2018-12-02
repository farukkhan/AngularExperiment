using AngularAspNetCore.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularAspNetCore.Filters
{
    public class WeatherForeCastsResultFilter:ResultFilterAttribute
    {
        public override async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            var actionResult = context.Result as ObjectResult;

            if(actionResult?.Value==null || actionResult.StatusCode<200 || actionResult.StatusCode>300)
            {
                await next();
                return;
            }

            actionResult.Value = Mapper.Map<IEnumerable<WeatherForecastForClient>>(actionResult.Value);

            await next();
        }
    }
}
