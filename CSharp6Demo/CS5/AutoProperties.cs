// <copyright file="AutoProperties.cs" company="Benedict W. Hazel">
//     Benedict W. Hazel, 2015
// </copyright>
// <author>Benedict W. Hazel</author>
// <summary>
//     AutoProperties: Class to demonstrate the C# 5 equivalent to enhancements to auto-properties.
// </summary>

namespace BWHazel.Experiments.CSharp6Demo.CS5
{
	using System;

	/// <summary>
	/// Demonstrates the C# 5 equivalent to enhancements to auto-properties.
	/// </summary>
	public static class AutoProperties
	{
		public static void Run()
		{
			Customer customer = new Customer("Benedict", "Hazel");
			Console.WriteLine(string.Format("ID:\t{0}", customer.Id.ToString()));
			Console.WriteLine(string.Format("Name:\t{0}", customer.FullName));
			Console.WriteLine(string.Format("Send:\t{0}", customer.SendMarketing));
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
				this.Id = Guid.NewGuid();
				this.FirstName = firstName;
				this.LastName = lastName;
				this.FullName = string.Format("{0} {1}", firstName, lastName);
				this.SendMarketing = true;
			}

			/// <summary>
			/// Gets the ID.
			/// </summary>
			public Guid Id { get; private set; }

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
			public string FullName { get; private set; }

			/// <summary>
			/// Gets or sets a value whether the customer should be sent marketing correspondance.
			/// </summary>
			public bool SendMarketing { get; set; }
		}
	}
}
