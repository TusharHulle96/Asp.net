//using ScratchDbContext.Api.Models.Domain;

using Scratch.Api.Models.Domain;

namespace Scratch.Api.Repositories
{
    public interface IRegionRepository
    {
       Task<IEnumerable<Region>> GetAllAsync();


        Task<Region> GetAsync(Guid id);


        Task<Region> AddAsync(Region region);


        Task<Region> DeleteAsync(Guid id);

        Task<Region> UpdateAsync(Guid id ,Region region);
        

    }
}
