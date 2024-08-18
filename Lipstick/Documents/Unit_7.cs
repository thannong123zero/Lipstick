namespace Lipstick.Documents
{
    public class Unit_7
    {
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
    }
}
