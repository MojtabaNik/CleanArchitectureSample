namespace GhabzeTo.Infra.Resources.SystemErrors
{
    public static class SystemErrorResourceKeys
    {
        public static string SystemUnhandledException = GetValue(nameof(SystemUnhandledException));
        public static string DatabaseSaveChangesException = GetValue(nameof(DatabaseSaveChangesException));
        public static string EntityNotFound = GetValue(nameof(EntityNotFound));

        private static string GetValue(string key)
        {
            return SystemErrorsResource.ResourceManager.GetString(key);
        }
    }
}
