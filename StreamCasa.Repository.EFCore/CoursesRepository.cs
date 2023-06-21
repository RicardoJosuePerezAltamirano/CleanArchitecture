using StreamCasa.Entities;
using StreamCasa.Entities.Abstractions.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamCasa.Repository.EFCore
{
    public class CoursesRepository : ICoursesRepository
    {
        private readonly StreamDBContext streamDBContext;

        public CoursesRepository(StreamDBContext streamDBContext)
        {
            this.streamDBContext = streamDBContext;
        }
        public async Task<Courses> AddOrUpdate(Courses courses)
        {
            if (courses.Id != Guid.Empty)
            {
                streamDBContext.Courses.Update(courses);
            }
            else
                await streamDBContext.Courses.AddAsync(courses);
            await streamDBContext.SaveChangesAsync();
            return courses;
        }

        public async Task<Courses> Delete(Courses courses)
        {
            streamDBContext.Courses.Remove(courses);
            await streamDBContext.SaveChangesAsync();
            return courses;
        }
    }
}
