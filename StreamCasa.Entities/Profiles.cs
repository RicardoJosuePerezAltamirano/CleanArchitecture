using StreamCasa.Abstractions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamCasa.Entities
{
    public class Profiles : IEntity
    {
        public Guid Id { get ; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public Users User { get; set; }
    }
}
