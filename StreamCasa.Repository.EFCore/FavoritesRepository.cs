using StreamCasa.Entities;
using StreamCasa.Entities.Abstractions.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamCasa.Repository.EFCore
{
    public class FavoritesRepository : IFavoritesRepository
    {
        private readonly StreamDBContext streamDBContext;

        public FavoritesRepository(StreamDBContext streamDBContext)
        {
            this.streamDBContext = streamDBContext;
        }
        public async Task<Favorites> AddOrUpdate(Favorites favorites)
        {
            if (favorites.Id != Guid.Empty)
            {
                streamDBContext.Favorites.Update(favorites);
            }
            else
                await streamDBContext.Favorites.AddAsync(favorites);
            await streamDBContext.SaveChangesAsync();
            return favorites;
        }

        public async Task<Favorites> Delete(Favorites favorites)
        {
            streamDBContext.Favorites.Remove(favorites);
            await streamDBContext.SaveChangesAsync();
            return favorites;
        }
    }
}
