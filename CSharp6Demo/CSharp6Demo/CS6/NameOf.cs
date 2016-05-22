// <copyright file="NameOf.cs" company="Benedict W. Hazel">
//     Benedict W. Hazel, 2015
// </copyright>
// <author>Benedict W. Hazel</author>
// <summary>
//     NameOf: Class to demonstrate the "nameof" expression.
// </summary>

namespace BWHazel.Experiments.CSharp6Demo.CS6
{
	using System;
	using static System.Console;

	/// <summary>
	/// Demonstrates the "nameof" expression.
	/// </summary>
	public static class NameOf
	{
		/// <summary>
		/// Calls an exception-throwing method and prints the parameter name to the console.
		/// </summary>
		public static void Run()
		{
			try
			{
				NameOf.ThrowException("input");
			}
			catch (ArgumentException ex)
			{
				WriteLine($"Parameter: {ex.ParamName}");
            }
		}

		/// <summary>
		/// Throws an argument exception.
		/// </summary>
		/// <param name="input"></param>
		/// <exception cref="ArgumentException">Exception thrown when the method runs.</exception>
		public static void ThrowException(string input)
		{
			throw new ArgumentException("Error!", nameof(input));
		}
	}
}
