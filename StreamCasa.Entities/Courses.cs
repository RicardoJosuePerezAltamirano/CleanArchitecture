using StreamCasa.Abstractions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamCasa.Entities
{
    public class Courses : IEntity
    {
        public Guid Id { get; set ; }
        public string Name { get; set; }
        public DateTime Release { get; set; }
        public List<Favorites> Favorites { get; set; }
        
    }
}
