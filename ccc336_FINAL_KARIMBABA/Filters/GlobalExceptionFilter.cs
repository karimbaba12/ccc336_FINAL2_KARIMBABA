﻿using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ccc336_FINAL_KARIMBABA.Filters
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var statusCode = context.Exception switch
            {
                ValidationException => StatusCodes.Status400BadRequest
            };

            context.Result = new ObjectResult(new
            {
                error = context.Exception.Message,
                stackTrace = context.Exception.StackTrace
            })
            {
                StatusCode = statusCode
            };
        }
    }
}

