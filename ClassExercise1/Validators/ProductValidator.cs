using System;
using FluentValidation;
using Products;

namespace Validators
{
	public class ProductValidator: AbstractValidator<Product>
	{
		public ProductValidator()
		{
			RuleFor(product => product.Name).NotEmpty();
			RuleFor(product => product.Price).GreaterThan(0);
			RuleFor(product => product.Quantity).GreaterThan(0);
			RuleFor(product => product.Description).MinimumLength(10);
		}
	}
}

