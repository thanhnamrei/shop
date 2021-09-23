using MediatR;
using Microsoft.EntityFrameworkCore;
using Shop.Data.Contexts;
using Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shop.Application.Queries
{
    public class List
    {
        public class Query : IRequest<List<Product>> { }

        public class Handler : IRequestHandler<Query, List<Product>>
        {
            private readonly ShopDbContext _dbContext;

            public Handler(ShopDbContext dbContext)
            {
                _dbContext = dbContext;
            }
            public async Task<List<Product>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _dbContext.Products.ToListAsync();
            }
        }
    }
}
