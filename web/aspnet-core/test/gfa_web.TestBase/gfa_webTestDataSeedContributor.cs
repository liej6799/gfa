using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using gfa_web.Configs;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Guids;
using Volo.Abp.MultiTenancy;

namespace gfa_web
{
    public class gfa_webTestDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Config, Guid> _configRepository;
        private readonly IGuidGenerator _guidGenerator;

        public gfa_webTestDataSeedContributor(
            IRepository<Config, Guid> configRepository,
            IGuidGenerator guidGenerator)
        {
            _configRepository = configRepository;
            _guidGenerator = guidGenerator;
        }
        
        public async Task SeedAsync(DataSeedContext context)
        {
            /* Seed additional test data... */
    
        }
    }
}