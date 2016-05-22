// <copyright file="NullConditional.cs" company="Benedict W. Hazel">
//     Benedict W. Hazel, 2015
// </copyright>
// <author>Benedict W. Hazel</author>
// <summary>
//     NullConditional: Class to demonstrate the C# 5 equivalent of the null-conditional operator.
// </summary>

namespace BWHazel.Experiments.CSharp6Demo.CS5
{
	using System;
	using BWHazel.Experiments.CSharp6Demo.CS5.Models;

	/// <summary>
	/// Demonstrates the C# 5 equivalent of the null-conditional operator.
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

			string street = "Street not set.";
			string postCode = "Post code not set.";
			if (customer != null)
			{
				if (customer.Address != null)
				{
					if (customer.Address.Street != null)
					{
						street = customer.Address.Street;
					}

					if (customer.Address.PostCode != null)
					{
						postCode = customer.Address.PostCode;
					}
				}
			}

			Console.WriteLine(string.Format("Street: {0}", street));
			Console.WriteLine(string.Format("Post Code: {0}", postCode));

			customer.Address.PostCode = "SW1A 2AA";
			if (customer.Address.PostCode != null)
			{
				postCode = customer.Address.PostCode;
			}

			Console.WriteLine(string.Format("Post Code: {0}", postCode));
		}
	}
}
