namespace SharedLibrary.DTO
{
    public class BaseDTO
    {
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        // Khi nao nguoi dung xoa thi dung thuoc tinh nay
        public bool IsDeleted { get; set; }
        // Khi nao nguoi dung khong muon hien thi o webapplication thi dung thuoc tinh nay
        public bool IsActive { get; set; }
        public BaseDTO()
        {
            CreatedOn = DateTime.Now;
            ModifiedOn = DateTime.Now;
        }
    }
}
