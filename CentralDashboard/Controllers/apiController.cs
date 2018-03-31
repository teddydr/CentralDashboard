
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CentralDashboard.Models;
using System.Linq;
using System;

namespace CentralDashboard.Controllers
{
  
    [Produces("application/json")]
    [Route("[controller]/[action]")]
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


        [HttpPost]
        public IEnumerable<LogDB> GetLatest(DateTime LastRequest)
        {

            return _context.LogsDB.Where(o => o.DateStamp > LastRequest).ToList();

        }

        
        [HttpGet]
        public IEnumerable<LogSum> GetSummary()
        {

            return _context.LogSum.ToList();

        } 

    }







   
}