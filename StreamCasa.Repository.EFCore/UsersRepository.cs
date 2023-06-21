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
    public class UsersRepository : IUsersRepository
    {
        private readonly StreamDBContext streamDBContext;

        public UsersRepository(StreamDBContext streamDBContext)
        {
            this.streamDBContext = streamDBContext;
        }
        public async Task<Users> AddOrUpdate(Users user)
        {
            if (user.Id != Guid.Empty)
            {
                streamDBContext.Users.Update(user);
            }
            else
                await streamDBContext.Users.AddAsync(user);
            await streamDBContext.SaveChangesAsync();
            return user;
        }

        public async Task<Users> Delete(Users user)
        {
            streamDBContext.Users.Remove(user);
            await streamDBContext.SaveChangesAsync();
            return user;
        }

        public async Task<Users> GetByUsermane(string username)
        {
            return await streamDBContext.Users.Where(o => o.Name == username).FirstOrDefaultAsync();
        }
    }
}
