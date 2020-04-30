using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace AbpDemo.Client.Samples
{
    public interface ISampleAppService : IApplicationService
    {
        Task<SampleDto> GetAsync();

        Task<SampleDto> GetAuthorizedAsync();

        Task<HedouUserDto> GetUserAsync(Guid id);
    }
}
