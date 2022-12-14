using System.Threading;
using System.Threading.Tasks;
using Sev1.Congratulations.Contracts.Contracts.GetPaged.Requests;
using Sev1.Congratulations.Contracts.Contracts.Region.Responses;

namespace Sev1.Congratulations.AppServices.Services.Region.Interfaces
{
    public interface IRegionService
    {
        /// <summary>
        /// Возвращает регион по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор региона</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        Task<RegionGetResponse> GetById(
            int? id,
            CancellationToken cancellationToken);

        /// <summary>
        /// Возвращает Regions с пагинацией
        /// </summary>
        /// <param name="request">Параметры пагинации</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        Task<RegionGetPagedResponse> GetPaged(
            GetPagedRequest request,
            CancellationToken cancellationToken);

        /// <summary>
        /// Возвращает Regions с пагинацией (V2)
        /// </summary>
        /// <param name="request">Параметры пагинации</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        Task<RegionGetPagedResponseV2> GetPagedV2(
            GetPagedRequest request,
            CancellationToken cancellationToken);
    }
}