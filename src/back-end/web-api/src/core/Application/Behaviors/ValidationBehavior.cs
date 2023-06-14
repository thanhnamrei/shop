﻿using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Behaviors;

public class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
	   where TRequest : IRequest<TResponse>
{
	private readonly IEnumerable<IValidator<TResponse>> _validators;

	public ValidationBehavior(IEnumerable<IValidator<TResponse>> validators)
	{
		_validators = validators;
	}

	public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
	{
		if (!_validators.Any()) return await next();

		var context = new ValidationContext<TRequest>(request);
		var validationReuslts = await Task.WhenAll(_validators.Select(v => v.ValidateAsync(context, cancellationToken)));

		var failures = validationReuslts.SelectMany(r => r.Errors).Where(f => f != null).ToList();

		return await next();
	}
}