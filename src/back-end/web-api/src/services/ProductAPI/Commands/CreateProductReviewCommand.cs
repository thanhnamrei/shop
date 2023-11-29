using Domain.Entities;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.SignalR;
using ProductAPI.Hub;
using ProductAPI.Services;

namespace ProductAPI.Commands;

public class CreateProductReviewCommand : IRequest<Unit>
{
    public int ProductId { get; set; }
    public string ReviewerName { get; set; } = string.Empty;
    public DateTime? ReviewDate { get; set; } = DateTime.Now;
    public string EmailAddress { get; set; } = string.Empty;
    public string Comments { get; set; } = string.Empty;
    public int Rating { get; set; }
}

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

public class CreateProductReviewCommandHandler : IRequestHandler<CreateProductReviewCommand, Unit>
{
    private readonly IProductReviewService _productReviewService;
    private readonly IHubContext<ProductHub> _hubContext;

    public CreateProductReviewCommandHandler(IProductReviewService productReviewService, IHubContext<ProductHub> hubContext)
    {
        _productReviewService = productReviewService;
        _hubContext = hubContext;
    }

    public async Task<Unit> Handle(CreateProductReviewCommand request, CancellationToken cancellationToken)
    {
        var entity = new ProductReview
        {
            ProductId = request.ProductId,
            ReviewerName = request.ReviewerName,
            EmailAddress = request.EmailAddress,
            Comments = request.Comments,
            ReviewDate = request.ReviewDate ?? DateTime.Now,
            Rating = request.Rating,
        };

        await _productReviewService.AddReview(entity);

        return Unit.Value;
    }
}