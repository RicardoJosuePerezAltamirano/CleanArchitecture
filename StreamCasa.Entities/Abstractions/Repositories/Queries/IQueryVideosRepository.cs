using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamCasa.Entities.Abstractions.Repositories.Queries
{
    public interface IQueryVideosRepository
    {
        Task<List<Videos>> GetAllVideosByTitle(string Title);
    }
}
