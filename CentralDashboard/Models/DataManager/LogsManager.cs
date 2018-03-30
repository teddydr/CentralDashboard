using CentralDashboard.Models.Repository;
using System.Collections.Generic;
using System.Linq;

namespace CentralDashboard.Models.DataManager
{
    public class LogsManager : IDataRepository<LogDB, long>
    {

        private LogContext ctx;

       
        public LogsManager(LogContext c)
        {
            ctx = c;
        }


        public IEnumerable<LogDB> GetAll()
        {

            var logs = ctx.LogsDB.ToList();
            return logs;
        }
    }
}
