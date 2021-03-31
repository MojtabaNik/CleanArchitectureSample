namespace GhabzeTo.Infra.Resources.Validations
{
    public static class ValidationResourceKeys
    {
        public static string NotNull = GetValue(nameof(NotNull));
        public static string LengthIsNotInRange = GetValue(nameof(LengthIsNotInRange));
        public static string ValidationErrorMessage = GetValue(nameof(ValidationErrorMessage));
        public static string RequestBodyNull = GetValue(nameof(RequestBodyNull));
        public static string InputDataTypeProblem = GetValue(nameof(InputDataTypeProblem));

        public static string GetValue(string key)
        {
            return ValidationsResource.ResourceManager.GetString(key);
        }
    }
}
