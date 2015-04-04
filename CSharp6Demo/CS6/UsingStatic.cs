// <copyright file="UsingStatic.cs" company="Benedict W. Hazel">
//     Benedict W. Hazel, 2015
// </copyright>
// <author>Benedict W. Hazel</author>
// <summary>
//     UsingStatic: Class to demonstrate "using staic" statements.
// </summary>

namespace BWHazel.Experiments.CSharp6Demo.CS6
{
	using static System.Console;
	using static System.Convert;
	using static System.Math;

	/// <summary>
	/// Demonstrates "using static" statements.
	/// </summary>
	public static class UsingStatic
	{
		/// <summary>
		/// Raises a number to a power and prints the result to the console.
		/// </summary>
		public static void Run()
		{
			Write("Enter a number: ");
			double number = ToDouble(ReadLine());
			Write("Enter the power: ");
			double power = ToDouble(ReadLine());

			double raised = Pow(number, power);
			WriteLine($"Result = {raised}");
		}
	}
}
