using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using netan.Controllers.Resources;
using netan.Models;
using netan.Persistence;

namespace netan.Controllers
{
    public class MakesController : Controller
    {
        public MakesController(NetanDbContext context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;

        }

        public NetanDbContext Context { get; }
        public IMapper Mapper { get; }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var result = await Context.Makes.Include(m => m.Models).ToListAsync();
            return Mapper.Map<List<MakeResource>>(result);
        }
        
    }
}