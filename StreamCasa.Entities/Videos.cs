using StreamCasa.Abstractions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamCasa.Entities
{
    public class Videos : IEntity
    {
        public Guid Id { get ; set ; }
        public string Title { get; set ; }
        public string Source { get; set; }
        public string Description { get; set; }
        public List<UsersVideos> UsersVideos { get; set; }
    }
}
