// <copyright file="NullConditional.cs" company="Benedict W. Hazel">
//     Benedict W. Hazel, 2015
// </copyright>
// <author>Benedict W. Hazel</author>
// <summary>
//     NullConditional: Class to demonstrate the null-conditional operator.
// </summary>

namespace BWHazel.Experiments.CSharp6Demo.CS6
{
	using static System.Console;
	using BWHazel.Experiments.CSharp6Demo.CS6.Models;

	/// <summary>
	/// Demonstrates the null-conditional operator.
	/// </summary>
	public static class NullConditional
	{
		/// <summary>
		/// Creates a customer and prints its address properties on the console.
		/// </summary>
		public static void Run()
		{
			Customer customer = new Customer("Prime", "Minister");
			customer.Address = new Address()
			{
				Street = "10 Downing Street",
				City = "City of Westminster",
				County = "Greater London",
				Country = "Great Britain"
			};

			WriteLine($"Street: {customer?.Address?.Street ?? "Street not set."}");
			WriteLine($"Post Code: {customer?.Address?.PostCode ?? "Post code not set."}");

			customer.Address.PostCode = "SW1A 2AA";
			WriteLine($"Post Code: {customer?.Address?.PostCode ?? "Post code not set."}");
        }
	}
}
