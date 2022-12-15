//using ScratchDbContext.Api.Models.Domain;

using Scratch.Api.Models.Domain;

namespace Scratch.Api.Repositories
{
    public interface IRegionRepository
    {
       Task<IEnumerable<Region>> GetAllAsync();
    }
}
