using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vega.Persistence;
using Microsoft.EntityFrameworkCore;
using Vega.Core.Models;
using Vega.Controllers.Resource;

namespace Vega.Controllers
{
    [Route("features")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly VegaDbContext context;
        private readonly IMapper mapper;

        public FeaturesController(VegaDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<KeyValuePairResource>> GetFeatures()
        {
            var features = await context.Features.ToListAsync();
            return mapper.Map<List<Feature>, List<KeyValuePairResource>>(features);
            //return features;
        }
    }
}
