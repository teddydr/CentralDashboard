using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using CentralDashboard.Models;
using Confluent.Kafka;
using Confluent.Kafka.Serialization;
using System.Text;

namespace CentralDashboard.Controllers
{
  
    [Produces("application/json")]
    [Route("api")]
    public class ApiController : Controller
    {
       

        [HttpGet]
        public List<DataStream> Get() {
            Random r = new Random();
            int rInt = r.Next(1, 6);
           
            List<DataStream> DataList = new List<DataStream>();

           
               
                return DataList;
            }
      


        

        





            

      

        }







   
}