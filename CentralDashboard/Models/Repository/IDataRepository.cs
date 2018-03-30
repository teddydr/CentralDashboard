using System.Collections.Generic;

namespace CentralDashboard.Models.Repository
{
    public interface IDataRepository<TEntity, U> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
    
       
    }

}