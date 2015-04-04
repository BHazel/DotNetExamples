// <copyright file="UsingStatic.cs" company="Benedict W. Hazel">
//     Benedict W. Hazel, 2015
// </copyright>
// <author>Benedict W. Hazel</author>
// <summary>
//     UsingStatic: Class to demonstrate the C# 5 equivalent of "using static" statements.
// </summary>

namespace BWHazel.Experiments.CSharp6Demo.CS5
{
	using System;

	/// <summary>
	/// Demonstrates the C# 5 equivalent of "using static" statements.
	/// </summary>
	public static class UsingStatic
	{
		/// <summary>
		/// Raises a number to a power and prints the result to the console.
		/// </summary>
		public static void Run()
		{
			Console.Write("Enter a number: ");
			double number = Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter the power: ");
			double power = Convert.ToDouble(Console.ReadLine());

			double raised = Math.Pow(number, power);
			Console.WriteLine(string.Format("Result = {0}", raised));
		}
	}
}
