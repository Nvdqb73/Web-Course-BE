using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebKhoaHoc_API.Models;

namespace WebKhoaHoc_API.Repository
{
    public class SearchRepo : ISearchKH
    {
        private readonly WebKhoaHocDbContext _dbContext;
        private readonly IMapper _mapper;

        public SearchRepo(WebKhoaHocDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<KhoaHoc>> SearchAsync(string item)
        {
            IQueryable<KhoaHoc> query = _dbContext.KhoaHoc;
            if (!string.IsNullOrWhiteSpace(item))
            {
                var keywords = item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var keyword in keywords)
                {
                    query = query.Where(e => e.TenKH!.Contains(keyword));
                }
            }

            return await query.ToListAsync();

        }
    }
}
