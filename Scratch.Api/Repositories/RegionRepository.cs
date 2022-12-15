using Microsoft.EntityFrameworkCore;
using Scratch.Api.Data;
using Scratch.Api.Models.Domain;
//using ScratchDbContext.Api.Models.Domain;

namespace Scratch.Api.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly NzWalksDbContext nzWalksDbContext;

        public RegionRepository(NzWalksDbContext nzWalksDbContext)
        {
            this.nzWalksDbContext = nzWalksDbContext;
        }



        public async Task<IEnumerable<Region>> GetAllAsync()
        {
         
        //IEnumerable<Region> IRegionRepository.GetAll()
        //{
            return await nzWalksDbContext.Regions.ToListAsync();
        }
    }
}
