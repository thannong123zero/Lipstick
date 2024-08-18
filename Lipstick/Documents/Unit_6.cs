namespace Lipstick.Documents
{
    public class Unit_6
    {
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
    }
}
