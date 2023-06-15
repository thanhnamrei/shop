using FluentValidation;

namespace ProductAPI.Commands;
public class CreateProductReviewCommandValidator : AbstractValidator<CreateProductReviewCommand>
{
    public CreateProductReviewCommandValidator()
    {
        RuleFor(c => c.ProductId)
            .NotNull()
            .NotEmpty()
            .WithMessage("ProductId is required.");

        RuleFor(c => c.ReviewerName)
            .NotEmpty()
            .WithMessage("ReviewerName is required.");

        RuleFor(c => c.EmailAddress)
            .NotNull()
            .NotEmpty()
            .WithMessage("EmailAddress is required.");
    }
}
