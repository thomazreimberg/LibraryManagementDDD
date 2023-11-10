using FluentValidation;
using LibraryManagement.Domain.Interfaces.Entities;
using LibraryManagement.Domain.Interfaces.Repositories;

namespace LibraryManagement.Domain.Services
{
    internal class ReviewService
    {
        private ReviewValidator _reviewValitor;
        public readonly IReviewRepository _reviewRepository;
        public ReviewService(IReviewRepository reviewRepository)
        {
            _reviewValitor = new ReviewValidator();
            _reviewRepository = reviewRepository;
        }

        public int Add(IReview entity)
        {
            Handler.Handler.Handle(_reviewValitor.Validate(entity));
            return _reviewRepository.Add(entity);
        }

        public IQueryable<IReview> GetAll() =>
            _reviewRepository.GetAll();

        public IReview GetById(int id) =>
            _reviewRepository.GetById(id);

        public void Update(int id, IReview entity)
        {
            Handler.Handler.Handle(_reviewValitor.Validate(entity));
            _reviewRepository.Update(id, entity);
        }
    }

    public class ReviewValidator : AbstractValidator<IReview>
    {
        public ReviewValidator()
        {
            RuleFor(review => review.Rate).NotNull();
        }
    }
}
