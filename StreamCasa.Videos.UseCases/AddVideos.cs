using StreamCasa.Builders;
using StreamCasa.Entities.Abstractions.Repositories;
using StreamCasa.Interactors.Abstractions.DTO;
using StreamCasa.Interactors.Abstractions.Videos;

namespace StreamCasa.Videos.UseCases
{
    public class AddVideos : IAddVideosInputPort
    {
        private readonly IAddVideosOutputPort addVideosOutputPort;
        private readonly IVideosRepository videosRepository;
        private readonly VideosBuilder videosBuilder;

        public AddVideos(IAddVideosOutputPort addVideosOutputPort
            ,IVideosRepository videosRepository
            , VideosBuilder videosBuilder)
        {
            this.addVideosOutputPort = addVideosOutputPort;
            this.videosRepository = videosRepository;
            this.videosBuilder = videosBuilder;
        }
        public async Task Handle(VideosDTO ToAdd)
        {
            if(ToAdd.Title.Contains("princesas"))
            {
                ToAdd.Title += " Para niños";
            }
            var ToRegistry = videosBuilder.Convert(ToAdd);
            await videosRepository.AddOrUpdate(ToRegistry);
            await addVideosOutputPort.Handle(ToAdd);
        }
    }
}