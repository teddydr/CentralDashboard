
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CentralDashboard.Models;
using System.Linq;
using System;

namespace CentralDashboard.Controllers
{
  
    [Produces("application/json")]
    [Route("api")]
    public class ApiController : Controller
    {

        /* private IDataRepository<LogDB, long> _iRepo;
         public ApiController(IDataRepository<LogDB, long> repo)
         {
             _iRepo = repo;
         }*/


        private readonly LogContext _context;

        public ApiController(LogContext context)
        {
            _context = context;
          
        }

        [HttpGet]
        public IEnumerable<LogDB> Get() {

            return _context.LogsDB.ToList();
        }


        [HttpGet ("{LastRequest}")]
        public IEnumerable<LogDB> GetLatest(DateTime LastRequest)
        {
            /*var query = _context.LogsDB.AsQueryable();
            query = query.Where(o => o.DateStamp > LastRequest);
            var  querylog = ((ObjectQuery<querylog>)query).ToList();
            return _context.LogsDB.ToList(); */

            return _context.LogsDB.Where(o => o.DateStamp > LastRequest).ToList();

        }

    }







   
}