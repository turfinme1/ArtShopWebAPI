using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtShop.Data.Common.Repositories
{
    public interface IRepositoryManager
    {
        IArtworkRepository Artwork { get; }

        IReviewRepository Review { get; }

        Task<int> SaveChangesAsync();
    }
}
