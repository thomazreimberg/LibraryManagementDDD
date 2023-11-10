using AutoMapper;
using GerenciamentoBiblioteca.Data.Context;
using GerenciamentoBiblioteca.Data.Entities;
using LibraryManagement.Domain.Interfaces.Entities;

namespace LibraryManagement.Data.Repositories
{
    internal class ReviewRepository
    {
        public readonly LibraryManagementContext _libraryManagementContext;
        private readonly IMapper _mapper;

        public ReviewRepository(LibraryManagementContext libraryManagementContext, IMapper mapper)
        {
            _libraryManagementContext = libraryManagementContext;
            _mapper = mapper;
        }
        public int Add(IReview entity)
        {
            var review = _mapper.Map<Review>(entity);

            _libraryManagementContext.Add(review);
            _libraryManagementContext.SaveChanges();

            return review.Id;
        }

        public IQueryable<IReview> GetAll() => _libraryManagementContext.Review;

        public IReview GetById(int id)
        {
            var review = _libraryManagementContext.Review.FirstOrDefault(x => x.Id == id);
            return review ?? throw new Exception("Review was not found."); ;
        }

        public void Update(int id, IReview entity)
        {
            var clientUpdate = _mapper.Map<Review>(entity);
            var client = GetById(id);

            client.Rate = clientUpdate.Rate;
            client.Comment = clientUpdate.Comment;
            client.BookId = clientUpdate.BookId;

            _libraryManagementContext.SaveChanges();
        }
    }
}
