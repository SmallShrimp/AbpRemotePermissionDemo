using System;
using System.Threading.Tasks;
using AbpDemo.Client.Users;
using Microsoft.AspNetCore.Authorization;

namespace AbpDemo.Client.Samples
{
    public class SampleAppService : ClientAppService, ISampleAppService
    {

        private readonly IHedouUserLookupService _hedouUserLookupService;
        public SampleAppService(IHedouUserLookupService hedouUserLookupService)
        {
            _hedouUserLookupService = hedouUserLookupService;
        }

        public Task<SampleDto> GetAsync()
        {
            return Task.FromResult(
                new SampleDto
                {
                    Value = 42
                }
            );
        }

        [Authorize]
        public Task<SampleDto> GetAuthorizedAsync()
        {
            return Task.FromResult(
                new SampleDto
                {
                    Value = 42
                }
            );
        }

        public async Task<HedouUserDto> GetUserAsync(Guid id)
        {
            var user = await _hedouUserLookupService.FindByIdAsync(id);
            return ObjectMapper.Map<HedouUser, HedouUserDto>(user);
        }
    }
}