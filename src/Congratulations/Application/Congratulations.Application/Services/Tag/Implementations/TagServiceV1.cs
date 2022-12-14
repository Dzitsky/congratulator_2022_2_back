using MapsterMapper;
using Sev1.Congratulations.AppServices.Services.Tag.Interfaces;
using Sev1.Congratulations.AppServices.Services.Tag.Repositories;

namespace Sev1.Congratulations.AppServices.Services.Tag.Implementations
{
    public sealed partial class TagServiceV1 : ITagService
    {
        private readonly ITagRepository _tagRepository;
        private readonly IMapper _mapper;

        public TagServiceV1(
            ITagRepository tagRepository,
            IMapper mapper)
        {
            _tagRepository = tagRepository;
            _mapper = mapper;
        }
    }
}