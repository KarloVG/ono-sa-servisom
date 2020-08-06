using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Protests.Api.Responses.AppResult
{
    public static class AppResponse
    {
        public static SuccessResponse Success(object data) => new SuccessResponse(data);
        // public static ErrorResponse<T> Error(T errors) => new ErrorResponse<T>(errors);
    }
}
