using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebKhoaHoc_API.Models;
using WebKhoaHoc_API.Repository;

namespace WebKhoaHoc_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchKhoaHocsController : ControllerBase
    {
        private readonly ISearchKH _repository;
        private readonly IMapper _mapper;

        public SearchKhoaHocsController(ISearchKH repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        [HttpGet]
        public async Task<ActionResult<List<KhoaHoc>>> SearchAsync(string query)
        {
            var results = await _repository.SearchAsync(query);
            return Ok(results);
        }



    }
}
