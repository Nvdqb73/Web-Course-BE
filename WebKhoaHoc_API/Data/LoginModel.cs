using System.ComponentModel.DataAnnotations;

namespace WebKhoaHoc_API.Data
{
    public class LoginModel
    {
        [MaxLength(100)]
        public string TenDangNhap { get; set; } = string.Empty;
        [MaxLength(100)]
        public string Password { get; set; } = string.Empty;
    }
}
