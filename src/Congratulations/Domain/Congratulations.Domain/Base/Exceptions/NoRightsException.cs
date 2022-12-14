using Sev1.Congratulations.Domain.Base.Exceptions.Base;

namespace Sev1.Congratulations.Domain.Base.Exceptions
{
    /// <summary>
    /// Доменное исключение при отсутствии прав
    /// </summary>
    public class NoRightsException : DomainException
    {
        public NoRightsException(string message) : base(message)
        {
        }
    }
}