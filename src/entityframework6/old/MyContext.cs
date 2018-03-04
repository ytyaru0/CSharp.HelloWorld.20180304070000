public class MyContext : DbContext
{
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        var model = modelBuilder.Build(Database.Connection);
        IDatabaseCreator sqliteDatabaseCreator = new SqliteDatabaseCreator();
        sqliteDatabaseCreator.Create(Database, model);
    }
    /*
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        var model = modelBuilder.Build(Database.Connection);
        ISqlGenerator sqlGenerator = new SqliteSqlGenerator();
        string sql = sqlGenerator.Generate(model.StoreModel);
    }
    */
}
