using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Protests.Api.Responses.AppResult
{
    public class ErrorResponse
    {

        public ErrorResponse(ModelStateDictionary modelState)
        {
            Errors = modelState.SelectMany(x => x.Value.Errors)
                .Select(x => x.ErrorMessage)
                .ToArray();
        }

        public IEnumerable<string> Errors { get; }
        public bool Success { get; set; } = false;

    }
}
