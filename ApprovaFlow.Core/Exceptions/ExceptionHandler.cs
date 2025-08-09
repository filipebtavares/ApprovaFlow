

using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace ApprovaFlow.Core.Exceptions
{
    public class ExceptionHandler : IExceptionHandler
    {
        public ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
