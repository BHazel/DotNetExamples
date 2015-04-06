// <copyright file="StringInterpolation.cs" company="Benedict W. Hazel">
//     Benedict W. Hazel, 2015
// </copyright>
// <author>Benedict W. Hazel</author>
// <summary>
//     StringInterpolation: Class to demonstrate the C# 5 equivalent of string interpolation.
// </summary>

namespace BWHazel.Experiments.CSharp6Demo.CS5
{
	using System;
	using System.Globalization;
	using BWHazel.Experiments.CSharp6Demo.CS5.Models;

	public static class StringInterpolation
	{
		public static void Run()
		{
			Console.Write("Enter customer first name: ");
			string firstName = Console.ReadLine();
			Console.Write("Enter customer last name: ");
			string lastName = Console.ReadLine();
			Console.Write("Enter customer birth date as dd/mm/yyyy: ");
			DateTime birthDate = DateTime.Parse(Console.ReadLine());

			Customer customer = new Customer(firstName, lastName);
			customer.BirthDate = birthDate;
			Console.WriteLine(string.Format("Added customer: {0}, {1}", customer.LastName.ToUpper(), customer.FirstName));

			TimeSpan customerAge = DateTime.Now - customer.BirthDate;
			Console.WriteLine(string.Format("Customer age: {0:D3} years old", (customerAge.Days / 365)));
		}
	}
}
