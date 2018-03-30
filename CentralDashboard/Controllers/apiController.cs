
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using CentralDashboard.Models.Repository;
//using CentralDashboard.Models.DataManager;
using CentralDashboard.Models;

namespace CentralDashboard.Controllers
{
  
    [Produces("application/json")]
    [Route("api")]
    public class ApiController : Controller
    {

        private IDataRepository<LogDB, long> _iRepo;
        public ApiController(IDataRepository<LogDB, long> repo)
        {
            _iRepo = repo;
        }


        [HttpGet]
        public IEnumerable<LogDB> Get() {

            return _iRepo.GetAll();
        }
      


        

        





            

      

        }







   
}