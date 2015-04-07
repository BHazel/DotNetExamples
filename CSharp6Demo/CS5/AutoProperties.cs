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
	using BWHazel.Experiments.CSharp6Demo.CS5.Models;

	/// <summary>
	/// Demonstrates the C# 5 equivalent to enhancements to auto-properties.
	/// </summary>
	public static class AutoProperties
	{
		/// <summary>
		/// Creates a customer and prints its properties on the console.
		/// </summary>
		public static void Run()
		{
			Customer customer = new Customer("Benedict", "Hazel");
			Console.WriteLine(string.Format("ID:\t{0}", customer.Id.ToString()));
			Console.WriteLine(string.Format("Name:\t{0}", customer.FullName));
			Console.WriteLine(string.Format("Send:\t{0}", customer.SendMarketing));
		}
	}
}
