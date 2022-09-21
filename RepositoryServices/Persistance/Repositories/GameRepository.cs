using Entities;
using MyDatabase;
using RepositoryServices.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices.Persistance.Repositories
{
    public class GameRepository : GenericRepository<Game>, IGameRepository
    {
        public GameRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<Game> GetBestGames()
        {
            return table.OrderBy(x => x.Rating).Take(5).ToList();
        }

        public IEnumerable<Game> GetGamesOrderedByAscending()
        {
            return table.OrderBy(x => x.Title).ToList();
        }

        public IEnumerable<Game> GetOldestGames()
        {
            return table.OrderBy(x => x.ReleaseDate).ToList();
        }

        public IEnumerable<Game> GetNewestGames()
        {
            return table.OrderByDescending(x => x.ReleaseDate).ToList();
        }

        public IEnumerable<Game> GetGamesByPriceAsc()
        {
            return table.OrderBy(x => x.Price).ToList();
        }

        public IEnumerable<Game> GetGamesByPriceDesc()
        {
            return table.OrderByDescending(x => x.Price).ToList();
        }
    }
}
