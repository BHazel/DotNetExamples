// <copyright file="CatchAwait.cs" company="Benedict W. Hazel">
//     Benedict W. Hazel, 2015
// </copyright>
// <author>Benedict W. Hazel</author>
// <summary>
//     CatchAwait: Class to demonstrate using "await" in "catch" blocks.
// </summary>

namespace BWHazel.Experiments.CSharp6Demo.CS6
{
	using System;
	using static System.Console;
	using System.Threading.Tasks;

	/// <summary>
	/// Demonstrates using "await" in "catch" blocks.
	/// </summary>
	/// <remarks>
	/// The delays in the "catch" and "finally" blocks will interfere will other demo output.
	/// </remarks>
	public static class CatchAwait
	{
		/// <summary>
		/// Runs a method to throw and catch an exception.
		/// </summary>
		public static void Run()
		{
			CatchAwait.ThrowAndCatchException();
		}

		/// <summary>
		/// Throws and handles an exception and asynchronously delays the task.
		/// </summary>
		public static async void ThrowAndCatchException()
		{
			try
			{
				throw new Exception("Error");
			}
			catch (Exception)
			{
				await Task.Delay(2000);
				WriteLine("Caught Exception...");
			}
			finally
			{
				await Task.Delay(2000);
				WriteLine("Finally...");
			}
		}
	}
}
