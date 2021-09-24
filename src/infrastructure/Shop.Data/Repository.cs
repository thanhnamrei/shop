using Dapper;
using Microsoft.EntityFrameworkCore;
using Shop.Data.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class Repository
    {
        private readonly ShopDbContext _dbContext;

        public Repository(ShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        protected async Task<IEnumerable<T>> Query<T>(string name,object pars = null)
        {
            using var connect =  _dbContext.Database.GetDbConnection();
            return await connect.QueryAsync<T>(name,pars, commandType:CommandType.StoredProcedure);
        }

        protected async Task Excute(string name, object pars = null)
        {
            using var connect = _dbContext.Database.GetDbConnection();
            await connect.QueryAsync(name, pars, commandType: CommandType.StoredProcedure);
        }
    }
}
