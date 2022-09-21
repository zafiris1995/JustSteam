using MyDatabase;
using RepositoryServices.Core;
using RepositoryServices.Core.Repositories;
using RepositoryServices.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext context;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            context = dbContext;
            Games = new GameRepository(context);
            Genres = new GenreRepository(context);
            Companies = new CompanyRepository(context);
            
        }

        public IGameRepository Games { get; private set; }

        public IGenreRepository Genres { get; private set; }

        public ICompanyRepository Companies { get; private set; }

        public int Complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
