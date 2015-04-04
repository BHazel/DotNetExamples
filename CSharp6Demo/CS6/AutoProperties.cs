// <copyright file="AutoProperties.cs" company="Benedict W. Hazel">
//     Benedict W. Hazel, 2015
// </copyright>
// <author>Benedict W. Hazel</author>
// <summary>
//     AutoProperties: Class to demonstrate enhancements to auto-properties.
// </summary>

namespace BWHazel.Experiments.CSharp6Demo.CS6
{
	using System;
	using static System.Console;

	/// <summary>
	/// Demonstrates enhancements to auto-properties.
	/// </summary>
	public static class AutoProperties
	{
		public static void Run()
		{
			Customer customer = new Customer("Benedict", "Hazel");
			WriteLine($"ID:\t{customer.Id.ToString()}");
			WriteLine($"Name:\t{customer.FullName}");
			WriteLine($"Send:\t{customer.SendMarketing}");
        }

		/// <summary>
		/// Represents a customer.
		/// </summary>
		public class Customer
		{
			/// <summary>
			/// Initialises a new instance of the <see cref="Customer"/> class with speified name.
			/// </summary>
			/// <param name="firstName">The first name.</param>
			/// <param name="LastName">The last name.</param>
			public Customer(string firstName, string lastName)
			{
				this.FullName = $"{firstName} {lastName}";
            }

			/// <summary>
			/// Gets the ID.
			/// </summary>
			public Guid Id { get; } = Guid.NewGuid();

			/// <summary>
			/// Gets or sets the first name.
			/// </summary>
			public string FirstName { get; set; }

			/// <summary>
			/// Gets or sets the last name.
			/// </summary>
			public string LastName { get; set; }

			/// <summary>
			/// Gets the full name.
			/// </summary>
			public string FullName { get; }

			/// <summary>
			/// Gets or sets a value whether the customer should be sent marketing correspondance.
			/// </summary>
			public bool SendMarketing { get; set; } = true;
		}
	}
}
