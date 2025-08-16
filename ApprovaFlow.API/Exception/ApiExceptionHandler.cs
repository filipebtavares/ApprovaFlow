using Microsoft.AspNetCore.Diagnostics;

namespace ApprovaFlow.API.Exception
{
    public class ApiExceptionHandler : IExceptionHandler
    {
        public ValueTask<bool> TryHandleAsync(HttpContext httpContext, System.Exception exception, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
