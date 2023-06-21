using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamCasa.Builders
{
    public abstract class BuilderBase<TEntity,TDTO>
    {
        public abstract TEntity Convert(TDTO param);
        public abstract TDTO Convert(TEntity param);
        public List<TDTO> Convert(List<TEntity> param)
        {
            List<TDTO> response= new List<TDTO>();
            response= param.Select(o=>Convert(o)).ToList();
            return response;
        }

    }
}
