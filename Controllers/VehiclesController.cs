using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using netan.Controllers.Resources;
using netan.Models;
using netan.Persistence;

namespace netan.Controllers
{
    [Route("/api/vehicles")]
    public class VehiclesController : Controller
    {
        public NetanDbContext Context { get; }

        IMapper _mapper;
        public VehiclesController(NetanDbContext context, IMapper mapper )
        {
            Context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateVehicle([FromBody] VehicleResource vehicleResource)
        {
            var vehicle = _mapper.Map<VehicleResource, Vehicle>(vehicleResource);
            vehicle.LastUpdate = DateTime.UtcNow;
            var features = Context.Features.Where(f => vehicleResource.Features.Contains(f.Id)).ToList();
            //
            vehicle.Features = new List<Feature>();
            foreach ( var feature in features )
            {
                vehicle.Features.Add(feature);
            }
            //
            Context.Vehicles.Add(vehicle);   
            await Context.SaveChangesAsync();

            var result = _mapper.Map<Vehicle, VehicleResource>(vehicle);
            return Ok(result); 
        }                             
        
    }
}