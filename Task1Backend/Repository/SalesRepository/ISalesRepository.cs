using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task1.Models;

namespace Task1.Api.Repository.SalesRepository
{
    public interface ISalesRepository
    {
        
        Task<IEnumerable<Sales>> GetSales(string startDate,string endDate);

    }
}
