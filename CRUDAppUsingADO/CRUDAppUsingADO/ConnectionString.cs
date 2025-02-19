namespace CRUDAppUsingADO
{
    public static class ConnectionString
    {
        private static string cs = "Server=DIYA\\SQLEXPRESS;database=CrudADOdb;Trusted_Connection=true;TrustServerCertificate=True;";
        public static string dbcs { get => cs; }
    }
}
