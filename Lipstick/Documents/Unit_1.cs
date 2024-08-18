namespace Lipstick.Documents
{
    public class Unit_1
    {
        #region Descover project
        /* ref: https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-controller?view=aspnetcore-7.0&tabs=visual-studio
         * 
         * Xin chào các bạn, hôm nay chúng ta sẽ cùng nhau tìm hiểu về kiến trúc của một project ASP.NET Core MVC.
         * 
         * Bước 1: Tạo project
         * 
         * Bước 2: Tìm hiểu về vai trò của các file trong project
         * 
         * Bước 2.1: Tìm hiểu về MVC
         * MVC là gì ?
         * MVC là một design pattern ( mẫu thiết kế) được sử dụng để phát triển các ứng dụng web.
         * Lưu ý: MVC là một kiến trúc, không phải là một ngôn ngữ lập trình.
         * 
         * Gồm 3 thàn phần chính: Model, View, Controller. 
         * Mục tiêu của MVC là phân tách các thành phần của ứng dụng để dễ dàng bảo trì và phát triển.
         * 
         * Thành phần của MVC:
         * Models: là một đối tượng và đại diện cho dữ liệu của ứng dụng.
         * Vd: trong dự án của chúng ta, thì models là các đối tượng như: Product, Category, User,...
         * 
         * Views: là thành phần hiển thị dữ liệu và tương tác với người dùng.
         * Controllers: là thành phần nhận yêu cầu và xử lý các yêu cầu đó.
         * 
         * 
         * Bước 3: Xây dựng kiến trúc project
         * Tại sao phải xây dựng kiến trúc project?
         * Chỉ đơn giản là để dễ dàng bảo trì và phát triển.
         * 
         * Trong ứng dụng của chúng ta sẽ chia ra 3 Layer:
         * + Presentation Layer: bao gồm các thao tác hiển thị dữ liệu và tương tác với người dùng.
         *      => Trong layer sẽ thêm 2 thành phần con là: Helpers và services
         *      Helpers: Lớp này sẽ xử lý các logic của view và trả về ViewModels. Tướng tác với controllers và Services.
         *      Services: Lớp này sẽ tương tác với Api để lấy dữ liệu về và trả về cho Helpers.
         * + Business Layer: bao gồm các thao tác xử lý nghiệp vụ.
         * + Data Access Layer: bao gồm các thao tác truy xuất dữ liệu.
         * 
         */
        #endregion

    }
}
