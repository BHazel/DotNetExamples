// <copyright file="NameOf.cs" company="Benedict W. Hazel">
//     Benedict W. Hazel, 2015
// </copyright>
// <author>Benedict W. Hazel</author>
// <summary>
//     NameOf: Class to demonstrate the C#5 equivalent of the "nameof" expression.
// </summary>

namespace BWHazel.Experiments.CSharp6Demo.CS5
{
	using System;

	/// <summary>
	/// Demonstrates the C# 5 equivalent of the "nameof" expression.
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
				Console.WriteLine(string.Format("Parameter: {0}", ex.ParamName));
			}
		}

		/// <summary>
		/// Throws an argument exception.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <exception cref="ArgumentException">Exception thrown when the method runs.</exception>
		private static void ThrowException(string input)
		{
			throw new ArgumentException("Error!", "input");
		}
	}
}
