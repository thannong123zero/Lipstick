namespace API.Document
{
    public class Document
    {
        #region architecture software
        /*
         * Moi Mot entity se co cac api co ban sau: Getall, getbyid, create, update, checkpermissiontodelete, softdelete, delete.
         * API se tra ve ca 2 ngon ngu: tieng anh va tieng viet. Vi he thong nay nho nen khong can thiet tra theo 1 tung ngon ngu.
         * 
         * 
         * 
         */
        #endregion
        #region Entity Core Document
        /*
        Install Libraries:
        Microsoft.EntityFrameworkCore.SqlServer
        Microsoft.EntityFrameworkCore.Design
        Microsoft.EntityFrameworkCore.Tools

        Context object presents a session with the database
        The context object allows querying database and saving data.
        DatabaseContext in EF core allows us to perform the following tasks:
        1. Manage database connection
        2. Configure model & relationship
        3. Querying database
        4. Saving data to the database
        5. Configure change tracking
        6. Caching
        7. Transaction management

        The DbSet<Tentity> type allows EF Core to query and save instance of the specified entity to the database

        There are two ways using which you can create a database and schema:
        1. Using the EnsureCreated() method.
        2. Using Migration API


        Entity State: https://learn.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.entitystate?view=efcore-8.0

        Migration:
        Add-Migration command doest not create database. It just creates the two snapshot files in the Migration folder.

        add-migration _Name_
        update-database
         

        Convention in EF Core
        conventions are default rules using which EF builds a model based on your domain (entity) classes.

        Configurations
        There are two ways to configure domain classes in EF Core
        1. By using Data Annotation Atributes
        2. By using Fluent API
         */


        #endregion
        #region Repository and Unit of work pattern
        /*
         * https://learn.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application
         * 
         * Hom nay chung ta se tim hieu ve Repository an Unit of work parrten
         * Repository la lop o giua Data access va Bisiness logic 
         * 
         * Thay vi chung ta viet tat ca ma nguon vao file DatabaseContext de xu ly thi chung ta tach no ra va tao thanh repository pattern
         * de thuan tien cho muc dich test va maintaince
         * 
         * Unit of work dung de quan ly repository de tranh viec khoi tao nhieu databasecontext va gay ra loi khong dang co.
         * 
         * Note IQueryable: When you create and modify IQueryable variables, no query is sent to the database. The query is not executed until you convert the IQueryable object into a collection by calling a method such as ToList. Therefore, this code results in a single query that is not executed until the return View statement.
         * 
         * 
         */
        #endregion
        #region Middleware
        /*
         * ref: https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-8.0
         * 
         * Middleware xu ly cac requests va responses
         * 
         * 
         * 
         * 
         */
        #endregion
        #region HTTP Requests
        /*
         * Characteristics:
         * A request method is idempotent if it can be seccessfully processed multiple times without changing the result.
         * A request method is cacheable when it corresponding response can be stored for reuse.
         * A request method is considered a safe method if it doesn't modify the state of a resource.
         * 
         * HTTP status codes:
         * + Information status codes
         * + Seccessful status codes
         * + Redirection status codes
         * + Client error status codes
         * + Server error status codes
         * 
         * 
         * 
         */
        #endregion
        #region HTTP Clients
        // ref: https://learn.microsoft.com/en-us/dotnet/fundamentals/networking/http/httpclient
        // ref: https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=net-8.0
        #endregion
        #region HttpResponseMessage 
        #endregion
    }
}
