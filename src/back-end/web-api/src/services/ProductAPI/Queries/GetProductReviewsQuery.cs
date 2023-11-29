using Domain.Entities;
using MediatR;
using ProductAPI.Services;

namespace ProductAPI.Queries;

public class GetProductReviewsQuery : IRequest<List<ProductReview>>
{
    public int ProductId { get; set; }
}

public class GetProductReviewsQueryHandler : IRequestHandler<GetProductReviewsQuery, List<ProductReview>>
{
    private readonly IProductReviewService _productReviewService;

    public GetProductReviewsQueryHandler(IProductReviewService productReviewService)
    {
        _productReviewService = productReviewService;
    }

    public async Task<List<ProductReview>> Handle(GetProductReviewsQuery request, CancellationToken cancellationToken)
    {
        return await _productReviewService.GetProductReviews(request.ProductId);
    }
}