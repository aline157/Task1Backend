using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task1.Api.Models;
using Task1.Models;

namespace Task1.Api.Repository.SalesRepository
{
    public class SalesRepository : ISalesRepository
    {
        private readonly AppDbContext appDbContext;

        public SalesRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Sales>> GetSales(string startDate, string endDate)
        {
            return await appDbContext.Sales
                .Include(e=> e.Customer)
                .Include(e=>e.Product)
                .Where(e => e.Date >= Convert.ToDateTime(startDate) && e.Date <= Convert.ToDateTime(endDate) )
                .ToListAsync();
        }
    }
}