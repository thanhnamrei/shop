using MediatR;
using MediatR.Pipeline;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shop.Application.Common.Behaviors
{
    public class LoggingBehavior<IRequest> : IRequestPreProcessor<IRequest>
    {
        private readonly ILogger<IRequest> _logger;

        public LoggingBehavior(ILogger<IRequest> logger)
        {
            _logger = logger;
        }
        public async Task Process(IRequest request, CancellationToken cancellationToken)
        {
            var requestName = typeof(IRequest).Name;
            _logger.LogInformation("Shop Request: {@Request}", requestName, request);        
        }
    }
}
