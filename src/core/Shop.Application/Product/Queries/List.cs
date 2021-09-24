using Dapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Data.Context;
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

        public class Handler : Repository, IRequestHandler<Query, List<Product>>
        {
            private const string functionName = "production.get_products";
            public Handler(ShopDbContext dbContext) :base(dbContext)
            {
            }

            public async Task<List<Product>> Handle(Query request, CancellationToken cancellationToken)
            {
                return (List<Product>)await Query<Product>(functionName);
            }
        }
    }
}
