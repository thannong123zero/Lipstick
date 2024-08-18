namespace Lipstick.Documents
{
    public class Explain
    {
        #region Requirement
        /*           
            Hi, Xin chào tất cả các bạn. Chào mừng các bạn đến với series về 
            asp.net core mvc và asp.net core api (.net 7)

            Series này đưọc thực hiện dựa trên phong cách kết hợp lý thuyết và thực hành,
            Nhầm giúp các bạn có thể hiểu rõ hơn về asp.net core mvc và asp.net core api.

            Yêu cầu:
            - Đã học về một ngôn ngữ lập trình bất kỳ.
            - Biết một ít về html, css, js.
            - Đã học về hệ quản trị cơ sở dữ liệu.
            - * Đã học về lập trình hướng đối tuợng (object oriented programming).

            Sau khoá học này, bạn sẽ nhận được:
            - Kiến thức về phát triển web với asp.net core mvc va  asp.net core api.
            - Kiến thức về entity framework.
            - Sản phẩm web hoàn chỉnh.
            - Tự tin ứng tuyển vào vị trí phát triển web.
          
         */
        #endregion
        #region Summary ASP.NET Core
        /*
        
            Trước tiên chúng ta sẽ tìm hiểu về asp.net core
            - ASP.NET core là gì?
                + ASP.NET Core là một framework phát triển web được phát triển bởi Microsoft.
                + Mã nguồn mở
                + Đa nền tảng.
                => Ref: https://dotnet.microsoft.com/en-us/apps/aspnet
            - Khác nhau giữa ASP.NET core và ASP.NET framework?
                + ASP.NET core hổ trợ đa nền tảng còn ASP.NET framework chỉ chạy trên windown.
                + ASP.NET core được cải tiến từ ASP.NET framework. 
                => Vì vậy mà ASP.NET core có phần vượt trội hơn ASP.NET framework.
                => Ref:https://learn.microsoft.com/en-us/aspnet/core/fundamentals/choose-aspnet-framework?view=aspnetcore-7.0


            Tìm hiểu về quá trình phát triển web.
            Như chúng ta đã biết, Một trang web động thì sẽ có các phần như sau:
            + Giao diện người dùng (font end).
            + Xử lý logic và tương tác với csdl ( back end).

            Vì vậy, đối với website lớn thì người ta sẽ chia ra làm 2 dự án:
            + Web UI 
            + Web API

            Thông thường sẽ có 2 sự lựa chọn về việc phát triển web UI, đó là:
            + Multiple page: Ví dụ điển hình là: Asp .Net core MVC ( có nhiều công nghệ khác). 
                - Khi người dùng click vào một link thì sẽ gửi request lên server và server sẽ trả về một trang web mới.
            + Single page: Ví dụ điển hình là: Reactjs (có nhiều công nghệ khác).
                - Khi người dùng click vào một link thì sẽ không trả về một trang web mới mà sẽ render lại trang web hiện tại.
            
            Việc lựa chọn sẽ phụ thuộc vào yêu cầu của dự án.
            Đối với dự án đặt nặng về trải nghiệm người dùng thì sẽ chọn single page.
            Đối với dự án đặt nặng về SEO thì sẽ chọn multiple page.
           
            => Để biết thêm thông tin về sự khác nhau này thì search key word: 
            "Difference between single page and multiple page application"
        
            Trong ASP.Net core sẽ hỗ trợ chúng ta công nghệ làm web UI như sau:
            + ASP.NET Core Blazor
            + ASP.NET Core Razor Pages
            + ASP.NET Core MVC
            + ASP.NET Core Single Page Applications (SPA) with frontend JavaScript frameworks
            => Ref: https://learn.microsoft.com/en-us/aspnet/core/tutorials/choose-web-ui?view=aspnetcore-7.0

         */
        #endregion
        #region Summary ASP.NET CORE MVC
        /*      
            ASP.NET CORE MVC là web ui được render ở phía server và được phát triển dựa trên design pattern MVC.                  
            Ref: https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-7.0&tabs=visual-studio     
         */

        #endregion
        #region Introduce Project
        /*
         
            Chúng ta sẽ làm về trang web thương mại điện tử bán son môi.
            Ref:https://lipstick.vn/
        
            Trong dự án này chúng ta sẽ chia làm 3 phần:
            + Web Client (ASP.Net Core MVC): Vai trò, trang web sẽ hiển thị thông tin sản phẩm và tương tác với khách hàng.
            + Web CRM (ASP.Net Core MVC): Vai trò, trang web sẽ tương tác với người quản lý trong việc thêm, xoá, sửa thông tin sản phẩm.
            + Web API (ASP.Net Core API): Vai trò, xử lý logic và tương tác với Web Client, Web CRM.
           
            Tính năng       
            Web Client
             - Hiển thị danh sách category
             - Hiển thị danh sách subcategory
             - Hiển thị danh sách product
             - Hiển thị chi tiết product
             - Thêm product vào giỏ hàng
             - Cập nhật giỏ hàng
             - Thanh toán
             - Sử dụng bên thứ 3: recaptcha,facebook messenger

            Web CRM 
             - Thêm,xóa,sửa category
             - Thêm,xóa,sửa subcategory
             - Thêm,xóa,sửa product
             - Hiển thị danh sách order
             - Hiển thi chi tiết order
             - Xác nhận order


            Công nghệ thực hiện dự án:
            + Framework: Asp.net core API, Asp.net core MVC, Entity.
            + Progamming languages: C#, Js.
            + Markup languages: Html
            + Style sheet languages: Css ( chúng ta sẽ viết theo Sass 'Syntactically Awesome Stylesheet' rồi biên dịch thành css).
            + Labaries: Bootstrap, Jquery.

         */
        #endregion
        #region Setup Project
        /*
        
            Cài đặt Visual Studio 2022
        
            Cài đặt ASP.NET And web development

            Cài đặt exensions Compilor

         */
        #endregion
        #region AI Support
        /*
         * Ref: https://zzzcode.ai/answer-question
         */
        #endregion
        // Discover
        #region Create Project
        #endregion
        #region Project Architecture
        #endregion
        #region Model
        #endregion
        #region View
        #endregion
        #region Controller
        #endregion
        // RoadMap
        #region Study Roadmap
        /*
            1. Hiểu Cơ Bản về ASP.NET Core và MVC:
                Tìm hiểu về kiến trúc và nguyên tắc của ASP.NET Core.
                Nắm vững khái niệm của MVC (Model-View-Controller).

            2. Cài Đặt Môi Trường Phát Triển:
                Cài đặt Visual Studio hoặc Visual Studio Code.
                Cài đặt ASP.NET Core SDK.

            3. Tạo Dự Án ASP.NET Core MVC Đầu Tiên:
                Tạo một dự án mới sử dụng ASP.NET Core MVC Template.
                Hiểu cấu trúc của dự án và các file quan trọng.

            4. Routing và Controllers:
                Hiểu về cách ASP.NET Core xử lý routing.
                Tạo các controllers và actions.

            5. Models và Views:
                Tìm hiểu cách tạo và sử dụng models trong MVC.
                Hiểu cách tạo views và làm thế nào chúng kết hợp với models.

            6. Entity Framework Core và Database:
                Sử dụng Entity Framework Core để tương tác với cơ sở dữ liệu.
                Thực hiện các thao tác CRUD (Create, Read, Update, Delete).

            7. Validation và Error Handling:
                Áp dụng validation cho dữ liệu nhập.
                Xử lý lỗi và hiển thị thông báo lỗi.

            8. Authentication và Authorization:
                Bảo vệ các phần của ứng dụng bằng cách sử dụng authentication và authorization.
                Hiểu về Identity Framework trong ASP.NET Core.

            9. Dependency Injection:
                Hiểu về Dependency Injection và cách nó được sử dụng trong ASP.NET Core.
                Áp dụng DI trong ứng dụng của bạn.

            10. Unit Testing:
                Tìm hiểu cách viết unit tests cho controllers, services, và models.
                Sử dụng các thư viện kiểm thử như xUnit hoặc NUnit.

            11. Front-end Development:
                Sử dụng Razor Views và Tag Helpers.
                Integrate JavaScript và CSS vào dự án.

            12. API Development (Tuỳ chọn):
                Nếu bạn quan tâm đến phát triển API, học cách tạo API sử dụng ASP.NET Core.

            13. Deployment:
                Tìm hiểu về các phương pháp triển khai ứng dụng ASP.NET Core, chẳng hạn như triển khai lên Azure, AWS, hoặc các nền tảng khác.
            
            14. Continuous Integration và Continuous Deployment (CI/CD):
                Hiểu và triển khai CI/CD cho dự án của bạn để tự động hóa quy trình phát triển.

            15. Performance Optimization và Security:
                Tối ưu hóa hiệu suất ứng dụng.
                Xác định và giảm thiểu các rủi ro bảo mật.

            16. Mở Rộng Kiến Thức (Tùy Chọn):
                Tìm hiểu về các chủ đề nâng cao như SignalR, gRPC, GraphQL, Docker, và Microservices. 
         */
        #endregion
    }
}
