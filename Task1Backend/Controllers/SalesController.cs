using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task1.Api.Repository.SalesRepository;

namespace Task1.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {

        private readonly ISalesRepository salesRepository;

        public SalesController(ISalesRepository salesRepository)
        {
            this.salesRepository = salesRepository;
        }


        [HttpGet("{startDate}/{endDate}")]
        public async Task<ActionResult> GetSales(string startDate, string endDate)
        {
            try
            {
                return Ok(await salesRepository.GetSales(startDate,endDate));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
    }
}
