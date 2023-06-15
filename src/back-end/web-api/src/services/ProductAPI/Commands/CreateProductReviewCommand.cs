using Data;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.SignalR;
using ProductAPI.Hub;

namespace ProductAPI.Commands;

public class CreateProductReviewCommand : IRequest<Unit>
{
	public int ProductId { get; set; }
	public string ReviewerName { get; set; }
	public DateTime? ReviewDate { get; set; } = DateTime.Now;
	public string EmailAddress { get; set; }
	public string Comments { get; set; }
}

public class CreateProductReviewCommandHandler : IRequestHandler<CreateProductReviewCommand, Unit>
{
	private readonly AppDbContext _context;
	private readonly IHubContext<ProductHub> _hubContext;

	public CreateProductReviewCommandHandler(AppDbContext context, IHubContext<ProductHub> hubContext)
	{
		_context = context;
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
		};

		_context.ProductReviews.Add(entity);

		await _hubContext.Clients.All.SendAsync("ProductReviewAdded");

		await _context.SaveChangesAsync(cancellationToken);

		return Unit.Value;
	}
}