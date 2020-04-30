using AbpDemo.Client.Samples;
using AbpDemo.Client.Users;
using AutoMapper;

namespace AbpDemo.Client
{
    public class ClientApplicationAutoMapperProfile : Profile
    {
        public ClientApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<HedouUser, HedouUserDto>(MemberList.Destination);
        }
    }
}