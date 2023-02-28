namespace BlogDataLibrary.Database
{
    public interface ISqlDataAccess
    {
        List<T> LoadData<T, U>(string sqlStatement, U parameters, string connectionStringName, bool isStoredProcedure);
        void SaveData<T, U>(string sqlStatement, U parameters, string connectionStringName, bool isStoredProcedure);
    }
}