using RepositoryServices.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices.Core
{
    internal interface IUnitOfWork : IDisposable
    {
        IGameRepository Games { get; }
        IGenreRepository Genres { get; }
        ICompanyRepository Companies { get; }

        int Complete();
    }
}
