using StreamCasa.Abstractions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamCasa.Entities.Abstractions.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : IEntity
    {
        Task<TEntity> AddOrUpdate(TEntity user);
        Task<TEntity> Delete(TEntity user);
    }
}
