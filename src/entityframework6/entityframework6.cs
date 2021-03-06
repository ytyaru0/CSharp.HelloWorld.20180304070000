public class SQLiteConfiguration : DbConfiguration
{
    public SQLiteConfiguration()
    {
        SetProviderFactory("System.Data.SQLite", SQLiteFactory.Instance);
        SetProviderFactory("System.Data.SQLite.EF6", SQLiteProviderFactory.Instance);
        SetProviderServices("System.Data.SQLite", (DbProviderServices)SQLiteProviderFactory.Instance.GetService(typeof(DbProviderServices)));
    }
}
using System;
public class HelloWorld
{
    static public void Main ()
    {
        Console.WriteLine ("Hello World!");
    }
}
// https://stackoverflow.com/questions/22101150/sqlite-ef6-programmatically-set-connection-string-at-runtime/23105811#23105811
public FirmwareContext(string connectionString)
    : base(new SQLiteConnection() { ConnectionString = connectionString }, true)
{
}


https://www.codeproject.com/Articles/1158937/Using-SQLite-database-with-Csharp-Net-and-Entity-F
System.Data.SQLite


$ mcs /reference:System.Data.SQLite.dll ef6.cs 
$ ./http.exe 
