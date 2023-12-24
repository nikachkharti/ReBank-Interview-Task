using System.ComponentModel.DataAnnotations;

namespace NetworkManagmentAPI.Helper
{
    public class ExpireDateAttribute : ValidationAttribute
    {
        private readonly string _releaseDatePropertyName;
        public ExpireDateAttribute(string releaseDatePropertyName)
        {
            _releaseDatePropertyName = releaseDatePropertyName;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var propertyInfo = validationContext.ObjectType.GetProperty(_releaseDatePropertyName);

            if (propertyInfo == null)
                return new ValidationResult($"Unknown property: {_releaseDatePropertyName}");

            var releaseDateValue = (DateTime)propertyInfo.GetValue(validationContext.ObjectInstance);
            var expireDateValue = (DateTime)value;

            if (expireDateValue <= releaseDateValue)
                return new ValidationResult("ExpireDate must be later than ReleaseDate.");

            return ValidationResult.Success;

        }
    }
}
