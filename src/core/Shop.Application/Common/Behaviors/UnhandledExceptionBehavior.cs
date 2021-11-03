using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shop.Application.Common.Behaviors
{
    public class UnhandledExceptionBehavior<IRequest, IReponse> : IPipelineBehavior<IRequest, IReponse>
    {
        private readonly ILogger<IRequest> _logger;


        public UnhandledExceptionBehavior(ILogger<IRequest> logger)
        {
            _logger = logger;
        }

        public async Task<IReponse> Handle(IRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<IReponse> next)
        {
            try
            {
                return await next();
            }
            catch (Exception ex)
            {
                var requestName = typeof(IRequest).Name;
                _logger.LogError(ex, "Shop Requests: Unhandled Exception for Request {Name} {@Request}", requestName, request);
                throw;
            }
        }
    }
}
