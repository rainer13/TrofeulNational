namespace TrofeulNational.DAL
{
    class DBFactory
    {

        public static DBConection  getConnection(DBConection.MyDBType dbt)
        {
            switch (dbt)
            {
                case DBConection.MyDBType.Cloudscape:
                    return null;
                case DBConection.MyDBType.MySQL:
                    return new ConexiuneMySQL();
                case DBConection.MyDBType.Oracle:
                    return null;
                case DBConection.MyDBType.MSSQL:
                    return null;
                default:
                    return null;

            }
        }

    }
}
