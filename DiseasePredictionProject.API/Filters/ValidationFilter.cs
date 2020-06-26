using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiseasePredictionProject.API.DTOs;

namespace DiseasePredictionProject.API.Filters
{
    public class ValidationFilter:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                ErrorDto errordto = new ErrorDto();
                errordto.Status = 400;
                IEnumerable<ModelError> modelErrors = context.ModelState.Values.SelectMany(v =>
                  v.Errors);

                modelErrors.ToList().ForEach(x =>
                errordto.Errors.Add(x.ErrorMessage)
                );
                context.Result = new BadRequestObjectResult(errordto);
            }
        }
    }
}
