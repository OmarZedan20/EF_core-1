using EF_core_1.Context;
using Microsoft.EntityFrameworkCore;

namespace EF_core_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ItiDbContext dbContext = new ItiDbContext();

            dbContext.Students.Where(S => S.Id == 1);

           // dbContext.Database.Migrate();

        }

    }
}
