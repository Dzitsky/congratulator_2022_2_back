using Sev1.Congratulations.Contracts.Enums;
using System.ComponentModel.DataAnnotations;

namespace Sev1.Congratulations.AppServices.Contracts.Congratulation.Requests
{
    /// <summary>
    /// DTO запроса на обновление объявления
    /// </summary>
    public sealed class CongratulationUpdateRequest
    {
        /// <summary>
        /// Id объявления
        /// </summary>
        [Required]
        [Range(1, 100_000_000_000, ErrorMessage = "Значение Id должно быть от 1 до 100_000_000_000")]
        public int? Id { get; set; }

        /// <summary>
        /// Заголовок объявления
        /// </summary>

        [Required]
        [MaxLength(100, ErrorMessage = "Максимальная длина заголовка не должна превышать 100 символов")]
        public string Title { get; set; }

        /// <summary>
        /// Текст объявления
        /// </summary>
        [Required]
        [MaxLength(1000, ErrorMessage = "Максимальная длина описания не должна превышать 1000 символов")]
        public string Body { get; set; }

        /// <summary>
        /// Стоимость
        /// </summary>
        [Required]
        [Range(0, 100_000_000_000, ErrorMessage = "Значение цены должно быть от 0 до 100_000_000_000")]
        public decimal Price { get; set; }

        /// <summary>
        /// Id категории
        /// </summary>
        [Required]
        [Range(1, 100_000_000_000, ErrorMessage = "Значение Id категории должно быть от 1 до 100_000_000_000")]
        public int? CategoryId { get; set; }

        /// <summary>
        /// Таги в виде массива строк
        /// </summary>
        public string[] TagBodies { get; set; }

        /// <summary>
        /// Статус объявления
        /// </summary>
        [Required]
        public CongratulationStatus Status { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Идентификатор региона
        /// </summary>
        [Required]
        public int? RegionId { get; set; }
    }
}