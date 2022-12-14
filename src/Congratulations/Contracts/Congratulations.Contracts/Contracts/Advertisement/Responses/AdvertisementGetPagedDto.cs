namespace Sev1.Congratulations.AppServices.Contracts.Congratulation
{
    /// <summary>
    /// DTO одного объявления при запросе пагинации
    /// </summary>
    public sealed class CongratulationGetPagedDto
    {
        /// <summary>
        /// Id объявления
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// Заголовок объявления
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Текст объявления
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Пользователь, который создал объявление
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Когда создано
        /// </summary>
        public string CreatedAt { get; set; }

        /// <summary>
        /// Id категории
        /// </summary>
        public int? CategoryId { get; set; }

        /// <summary>
        /// Имя категории
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// Таги в виде массива строк
        /// </summary>
        public string[] Tags { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Имя региона
        /// </summary>
        public string RegionName { get; set; }

        /// <summary>
        /// Имя региона
        /// </summary>
        public int? RegionId { get; set; }

        /// <summary>
        /// Идентификаторы файлов
        /// </summary>
        public int?[] UserFiles { get; set; }
    }
}