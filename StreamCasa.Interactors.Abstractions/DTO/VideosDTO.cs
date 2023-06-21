using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamCasa.Interactors.Abstractions.DTO
{
    public class VideosDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Source { get; set; }
        public string Description { get; set; }
    }
}
