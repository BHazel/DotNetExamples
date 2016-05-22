// <copyright file="CatchAwait.cs" company="Benedict W. Hazel">
//     Benedict W. Hazel, 2015
// </copyright>
// <author>Benedict W. Hazel</author>
// <summary>
//     CatchAwait: Class to demonstrate the C# 5 equivalent of using "await" in "catch" blocks.
// </summary>

namespace BWHazel.Experiments.CSharp6Demo.CS5
{
	using System;
	using System.Threading.Tasks;

	/// <summary>
	/// Demonstrates the C# 5 equivalent of using "await" in "catch" blocks.
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
			Exception caughtException = null;
			bool finallyExecuted = false;

			try
			{
				throw new Exception("Error");
			}
			catch (Exception ex)
			{
				caughtException = ex;
			}
			finally
			{
				finallyExecuted = true;
			}

			if (caughtException != null)
			{
				await Task.Delay(2000);
				Console.WriteLine("Caught Exception...");
			}

			if (finallyExecuted)
			{
				await Task.Delay(2000);
				Console.WriteLine("Finally...");
			}
		}
	}
}
