using System.ComponentModel.DataAnnotations.Schema;
using WebKhoaHoc_API.Models;

namespace WebKhoaHoc_API.Data
{
    public class ChatModel
    {
        public String NoiDung { get; set; } = string.Empty;
        public DateTime NgayGui { get; set; } = DateTime.Now;

        public int MaKH { get; set; }
        
    }
}
