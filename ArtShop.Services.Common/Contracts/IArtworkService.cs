﻿using ArtShop.Data.Models;

namespace ArtShop.Services.Common.Contracts
{
    public interface IArtworkService
    {
        Task<IEnumerable<Artwork>> GetAllArtworksAsync();
    }
}
