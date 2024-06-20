using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Desafio_DB1.Domain.Validations
{
    public class MaxItems : ValidationAttribute
    {
        private readonly int _maxItems;
        public MaxItems(int maxItems)
        {
            _maxItems = maxItems;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is IList list && list.Count > _maxItems)
            {
                return new ValidationResult($"A lista não pode conter mais de {_maxItems} itens.");
            }

            return ValidationResult.Success;
        }
    }
}
