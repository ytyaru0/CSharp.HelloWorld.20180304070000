
# Console App

```csharp
using System;

public class HelloWorld
{
    static public void Main ()
    {
        Console.WriteLine ("Hello World!");
    }
}
```
```sh
$ mcs test.cs 
$ ./test.exe 
Hello World!
```

# HttpClient

```csharp
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main()
        {
            GetGoogle().GetAwaiter().GetResult();
        }
        public static async Task GetGoogle() 
        {
            using(var client = new HttpClient())
            {
                var result = await client.GetAsync("https://www.google.co.jp");
                Console.WriteLine(result.StatusCode);
            }
        }
    }
}
```
```sh
$ mcs /reference:System.Net.Http.dll http.cs 
$ ./http.exe 
```
https://docs.microsoft.com/ja-jp/aspnet/web-api/overview/advanced/calling-a-web-api-from-a-net-client#create-the-console-application




```sh
$ mcs System.Data.Entity.dll /reference:System.Data.Linq.dll /reference:System.Data.SQLite.dll Program.cs 
$ ./http.exe 
```
mcs /reference:System.Core.dll /reference:System.Data.Linq.dll /reference:System.Data.Entity SQLiteConfiguration.cs
mcs /reference:System.Data.Linq.dll /reference:System.Data.Entity Program.cs 
mcs /reference:System.Data.Linq.dll Program.cs 
mcs /reference:System.Data.Linq.dll /reference:EntityFramework.dll Program.cs 
https://msdn.microsoft.com/ja-jp/library/system.data.entity.dbcontext(v=vs.113).aspx



https://stackoverflow.com/questions/22959664/how-to-use-entityframework-6-with-mono-and-sqlite-for-c-sharp-cross-platform-dev


http://www.mono-project.com/docs/database-access/providers/sqlite/
$ csc SQLiteTest.cs -r:System.Data.dll -r:Mono.Data.SqliteClient.dll
Microsoft (R) Visual C# Compiler version 2.6.0.62309 (d3f6b8e7)
Copyright (C) Microsoft Corporation. All rights reserved.

error CS0006: Metadata file 'Mono.Data.SqliteClient.dll' could not be found

