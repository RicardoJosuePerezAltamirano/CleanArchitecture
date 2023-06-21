using StreamCasa.Entities;
using StreamCasa.Entities.Abstractions.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamCasa.Repository.EFCore
{
    public class ProfilesRepository : IProfilesRepository
    {
        private readonly StreamDBContext streamDBContext;

        public ProfilesRepository(StreamDBContext streamDBContext)
        {
            this.streamDBContext = streamDBContext;
        }
        public async Task<Profiles> AddOrUpdate(Profiles profiles)
        {
            if (profiles.Id != Guid.Empty)
            {
                streamDBContext.Profiles.Update(profiles);
            }
            else
                await streamDBContext.Profiles.AddAsync(profiles);
            await streamDBContext.SaveChangesAsync();
            return profiles;
        }

        public async Task<Profiles> Delete(Profiles profiles)
        {
            streamDBContext.Profiles.Remove(profiles);
            await streamDBContext.SaveChangesAsync();
            return profiles;
        }
    }
}
