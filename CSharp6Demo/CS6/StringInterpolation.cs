// <copyright file="StringInterpolation.cs" company="Benedict W. Hazel">
//     Benedict W. Hazel, 2015
// </copyright>
// <author>Benedict W. Hazel</author>
// <summary>
//     StringInterpolation: Class to demonstrate string interpolation.
// </summary>

namespace BWHazel.Experiments.CSharp6Demo.CS6
{
	using System;
	using static System.Console;
	using System.Globalization;
	using BWHazel.Experiments.CSharp6Demo.CS6.Models;

	public static class StringInterpolation
	{
		public static void Run()
		{
			Write("Enter customer first name: ");
			string firstName = ReadLine();
			Write("Enter customer last name: ");
			string lastName = ReadLine();
			Write("Enter customer birth date as dd/mm/yyyy: ");
			DateTime birthDate = DateTime.Parse(ReadLine());

			Customer customer = new Customer(firstName, lastName);
			customer.BirthDate = birthDate;
			WriteLine($"Added customer: {customer.LastName.ToUpper()}, {customer.FirstName}");

			TimeSpan customerAge = DateTime.Now - customer.BirthDate;
			WriteLine($"Customer age: {(customerAge.Days / 365):D3} years old");
        }
	}
}
