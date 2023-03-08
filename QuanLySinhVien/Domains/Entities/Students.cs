namespace QuanLySinhVien.Domains.Entities;

public class Students
{
    public int Id { get; set; }
    public string StudentCode { get; set; } = string.Empty;
    public string StudentName { get; set; } = string.Empty;
    public int ClassId { get; set; }
    public bool IsClassMonitor { get; set; }
    public bool IsClassVice { get; set; }
    public int Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public int CreatedBy { get; set; }
}