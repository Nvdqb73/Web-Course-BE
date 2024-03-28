using WebKhoaHoc_API.Models;

namespace WebKhoaHoc_API.Repository
{
    public interface ISearchKH
    {
        public Task<List<KhoaHoc>> SearchAsync(string query);
    }
}
