// <copyright file="AutoProperties.cs" company="Benedict W. Hazel">
//     Benedict W. Hazel, 2015
// </copyright>
// <author>Benedict W. Hazel</author>
// <summary>
//     AutoProperties: Class to demonstrate enhancements to auto-properties.
// </summary>

namespace BWHazel.Experiments.CSharp6Demo.CS6
{
	using static System.Console;
	using BWHazel.Experiments.CSharp6Demo.CS6.Models;

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
	}
}
