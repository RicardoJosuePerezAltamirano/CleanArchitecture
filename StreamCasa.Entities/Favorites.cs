using StreamCasa.Abstractions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamCasa.Entities
{
    public class Favorites : IEntity
    {
        public Guid Id { get; set; }
        public int CourseId { get; set; }
        public int UserId { get; set; }
        public Courses Course { get; set; }
        public Users User { get; set; }
    }
}
