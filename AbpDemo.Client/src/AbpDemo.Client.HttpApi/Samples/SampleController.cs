using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace AbpDemo.Client.Samples
{
    [RemoteService]
    [Route("api/Client/sample")]
    public class SampleController : ClientController, ISampleAppService
    {
        private readonly ISampleAppService _sampleAppService;

        public SampleController(ISampleAppService sampleAppService)
        {
            _sampleAppService = sampleAppService;
        }

        [HttpGet]
        public async Task<SampleDto> GetAsync()
        {
            return await _sampleAppService.GetAsync();
        }

        [HttpGet]
        [Route("authorized")]
        [Authorize]
        public async Task<SampleDto> GetAuthorizedAsync()
        {
            return await _sampleAppService.GetAsync();
        }

        [HttpGet]
        [Route("{id}")]
        [Authorize]
        public async Task<HedouUserDto> GetUserAsync(Guid id)
        {
            return await _sampleAppService.GetUserAsync(id);
        }
    }
}
