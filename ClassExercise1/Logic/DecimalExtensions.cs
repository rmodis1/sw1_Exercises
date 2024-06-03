using System;
namespace Extensions
{
	public static class DecimalExtensions
	{
		public static decimal DiscountThisPrice(this decimal value)
		{
			return Math.Round((value * 0.9M), 2);
		}
	}
}

