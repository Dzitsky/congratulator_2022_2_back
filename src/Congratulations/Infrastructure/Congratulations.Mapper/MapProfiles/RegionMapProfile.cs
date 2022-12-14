using Mapster;
using Sev1.Congratulations.Contracts.Contracts.Region.Responses;
using Sev1.Congratulations.Contracts.Contracts.Tag.Requests;

namespace Sev1.Congratulations.MapsterMapper.MapProfiles
{
    public class RegionMapProfile
    {
        public static TypeAdapterConfig GetConfiguredMappingConfig()
        {
            var config = TypeAdapterConfig.GlobalSettings;

            config.NewConfig<Domain.Region, RegionGetResponse>()
                .Ignore(dest => dest.ParentRegionId)
                .AfterMapping((src, dest) =>
                {
                    if (src.ParentRegionId != 1) dest.ParentRegionId = src.ParentRegionId;
                });

            config.NewConfig<Domain.Region, RegionGetResponseV2>();

            return config;
        }
    }
}