using StreamCasa.Abstractions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamCasa.Entities
{
    public class UsersVideos : IEntity
    {
        public Guid Id { get ; set; }
        public int UserId { get; set; }
        public int VideoId { get; set; }
        public DateTime DateRegistry { get; set; }
        public Users User { get; set; }
        public Videos Videos { get; set; }
    }
}
