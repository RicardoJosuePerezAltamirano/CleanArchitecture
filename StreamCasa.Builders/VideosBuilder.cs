using StreamCasa.Entities;
using StreamCasa.Interactors.Abstractions.DTO;

namespace StreamCasa.Builders
{
    public class VideosBuilder : BuilderBase<Videos, VideosDTO>
    {
        public override Videos Convert(VideosDTO param)
        {
            return new Videos()
            {
                Description = param.Description,
                Id = param.Id,
                Source = param.Source,
                Title = param.Title
            };
        }

        public override VideosDTO Convert(Videos param)
        {
            return new VideosDTO()
            {
                Description = param.Description,
                Id = param.Id,
                Source = param.Source,
                Title = param.Title
            };
        }
    }
}