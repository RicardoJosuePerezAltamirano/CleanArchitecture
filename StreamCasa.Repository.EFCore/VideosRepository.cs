using Microsoft.EntityFrameworkCore;
using StreamCasa.Entities;
using StreamCasa.Entities.Abstractions.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamCasa.Repository.EFCore
{
    public class VideosRepository : IVideosRepository
    {
        private readonly StreamDBContext context;

        public VideosRepository(StreamDBContext context)
        {
            this.context = context;
        }
        public async Task<Videos> AddOrUpdate(Videos video)
        {
            if(video.Id != Guid.Empty)
            {
                context.Videos.Update(video);
            }
            else
                await context.Videos.AddAsync(video);
            await context.SaveChangesAsync();
            return video;
        }

        public async Task<Videos> Delete(Videos video)
        {
            context.Remove(video);
            await context.SaveChangesAsync();
            return video;
        }

        public async Task<List<Videos>> GetAll()
        {
            return await context.Videos.ToListAsync();
        }
    }
}
