namespace QuanLySinhVien.Model;

public class Response<T>
{
    public Response(bool success, string message, string error, T data)
    {
        Success = success;
        Message = message;
        Data = data;
        Error = error;
    }
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public string Error { get; set; } = string.Empty;
    public T Data { get; set; }
}