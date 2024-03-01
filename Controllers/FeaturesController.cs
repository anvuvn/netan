using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using netan.Controllers.Resources;
using netan.Models;
using netan.Persistence;

namespace netan.Controllers
{
    public class FeaturesController : Controller
    {
        public FeaturesController(NetanDbContext context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper; 
        }

        public NetanDbContext Context { get; }
        public IMapper Mapper { get; }

        [HttpGet("/api/features")]
        public async Task<IEnumerable<FeatureResource>> GetFeatures()
        {
            var features = await Context.Features.ToListAsync();            
            return Mapper.Map<List<FeatureResource>>(features); 
        }
        


    }
}