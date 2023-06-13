using Domain.Entities;
using MediatR;

namespace ProductAPI.Queries;
public class GetProductDetailQuery
{
    public class Query : IRequest<Product>
    {
        public int Id { get; set; }
    }

    public class Handler : IRequestHandler<Query, Product>
    {
        public Task<Product> Handle(Query request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
