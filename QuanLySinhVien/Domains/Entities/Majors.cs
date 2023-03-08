namespace QuanLySinhVien.Domains.Entities
{
    public class Majors
    {
        public int Id { get; set; }
        public string MajorsCode { get; set; } = string.Empty;
        public string MajorsName { get; set; } = string.Empty;
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
    }
}