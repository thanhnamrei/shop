using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shop.Application.Common.Behaviors
{
    public class PerformanceBehavior<IRequest, IReponse> : IPipelineBehavior<IRequest, IReponse>
    {
        private readonly Stopwatch _timer;
        private readonly ILogger<IRequest> _logger;


        public PerformanceBehavior(ILogger<IRequest> logger)
        {
            _logger = logger;
            _timer = new Stopwatch();
        }


        public async Task<IReponse> Handle(IRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<IReponse> next)
        {
            _timer.Start();
            var response = await next();
            _timer.Stop();

            var elapsedMilliseconds = _timer.ElapsedMilliseconds;
            if (elapsedMilliseconds <= 500) return response;

            var requestName = typeof(IRequest).Name;
            _logger.LogWarning("Shop Long Running Request: {Name} ({ElapsedMilliseconds} milliseconds) {@Request}", 
                requestName, elapsedMilliseconds, request);

            return response;
        }
    }
}
