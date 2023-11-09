using LibraryManagement.Application;
using LibraryManagement.Application.Dtos.Author;
using LibraryManagement.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AuthorController : Controller
    {
        private IAuthorAppService _authorAppService { get; set; }

        public AuthorController(IAuthorAppService authorAppService)
        {
            _authorAppService = authorAppService;
        }
        /// <summary>
        /// GetAll.
        /// </summary>
        /// <returns>200: List<AuthorDtoGet></returns>
        [HttpGet]
        public ActionResult<List<AuthorDtoGet>> GetAll() =>
            Ok(_authorAppService.GetAll());

        /// <summary>
        /// GetById.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>200: AuthorDtoGetById</returns>
        [HttpGet("{id}")]
        public ActionResult<AuthorDtoGetById> GetById(int id) =>
            Ok(_authorAppService.GetById(id));

        /// <summary>
        /// Add.
        /// </summary>
        /// <param name="author"></param>
        /// <returns>200: Id</returns>
        [HttpPost]
        public ActionResult<int> Add([FromBody] AuthorDto author) =>
            Ok(_authorAppService.Add(author));

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="id"></param>
        /// <param name="author"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody] AuthorDto author)
        {
            _authorAppService.Update(id, author);
            return Ok();
        }
    }
}