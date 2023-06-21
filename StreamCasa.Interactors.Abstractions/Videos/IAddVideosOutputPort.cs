using StreamCasa.Interactors.Abstractions.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamCasa.Interactors.Abstractions.Videos
{
    public interface IAddVideosOutputPort
    {
        VideosDTO Content { get; }
        Task Handle(VideosDTO ToAdd);
    }
}
