// <copyright file="Customer.cs" company="Benedict W. Hazel">
//     Benedict W. Hazel, 2015
// </copyright>
// <author>Benedict W. Hazel</author>
// <summary>
//     Customer: Class to represent a customer.
// </summary>

namespace BWHazel.Experiments.CSharp6Demo.CS6.Models
{
	using System;

	/// <summary>
	/// Represents a customer.
	/// </summary>
	public class Customer
	{
		/// <summary>
		/// Initialises a new instance of the <see cref="Customer"/> class with speified name.
		/// </summary>
		/// <param name="firstName">The first name.</param>
		/// <param name="lastName">The last name.</param>
		public Customer(string firstName, string lastName)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
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
		/// Gets or sets the address.
		/// </summary>
		public Address Address { get; set; }

		/// <summary>
		/// Gets or sets the birth date.
		/// </summary>
		public DateTime BirthDate { get; set; }

		/// <summary>
		/// Gets or sets a value whether the customer should be sent marketing correspondance.
		/// </summary>
		public bool SendMarketing { get; set; } = true;
	}
}
