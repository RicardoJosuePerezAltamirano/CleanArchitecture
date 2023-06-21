using Microsoft.EntityFrameworkCore.Metadata.Internal;
using StreamCasa.Entities;
using StreamCasa.Entities.Abstractions.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamCasa.Repository.EFCore
{
    public class UsersVideosRepository : IUsersVideosRepository
    {
        private readonly StreamDBContext streamDBContext;

        public UsersVideosRepository(StreamDBContext streamDBContext)
        {
            this.streamDBContext = streamDBContext;
        }
        public async Task<UsersVideos> AddOrUpdate(UsersVideos user)
        {
            if (user.Id != Guid.Empty)
            {
                streamDBContext.UsersVideos.Update(user);
            }
            else
                await streamDBContext.UsersVideos.AddAsync(user);
            await streamDBContext.SaveChangesAsync();
            return user;

        }

        public async Task<UsersVideos> Delete(UsersVideos user)
        {
          
            streamDBContext.UsersVideos.Remove(user);
            await streamDBContext.SaveChangesAsync();
            return user;
        }
    }
}
