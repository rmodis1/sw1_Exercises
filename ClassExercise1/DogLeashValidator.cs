using System;
using FluentValidation;
using Products;

namespace Validators
{
	public class DogLeashValidator: AbstractValidator<DogLeash>
	{
		public DogLeashValidator()
		{
			RuleFor(dogLeash => dogLeash.Name).NotEmpty();
			RuleFor(dogLeash => dogLeash.Price).GreaterThan(0);
			RuleFor(dogLeash => dogLeash.Quantity).GreaterThan(0);
			RuleFor(dogLeash => dogLeash.Description).MinimumLength(10);
		}
	}
}

