using WebKhoaHoc_API.Models;

namespace WebKhoaHoc_API.Repository
{
    public interface IRepository<T>
    {
        public Task<List<T>> GetAllAsync();
        public Task<T> GetAsync(int id);
        public Task AddAsync(T item);
        public Task UpdateAsync(T item);
        public Task DeleteAsync(int id);
        //public Task<List<T>> GetSearchAsync(string item);
    }
}
