// <copyright file="ExceptionFilters.cs" company="Benedict W. Hazel">
//     Benedict W. Hazel, 2015
// </copyright>
// <author>Benedict W. Hazel</author>
// <summary>
//     ExceptionFilters: Class to demonstrate the C# 5 equivalent of exception filters.
// </summary>

namespace BWHazel.Experiments.CSharp6Demo.CS5
{
	using System;

	/// <summary>
	/// Demonstrates he C# 5 equivalent of exception filters.
	/// </summary>
	public static class ExceptionFilters
	{
		/// <summary>
		/// Throws an exception which is filtered when caught.
		/// </summary>
		public static void Run()
		{
			try
			{
				throw new Exception("Error");
			}
			catch (Exception ex)
			{
				if (ex.Message == "Error")
				{
					Console.WriteLine("A terrible error has occurred!");
				}
				else if (ex.Message == "Fatal")
				{
					Console.WriteLine("Something carastrophic has happened!");
				}
				else
				{
					Console.WriteLine(string.Format("An unknown error has occurred: {0}", ex.Message));
				}
			}
		}
	}
}
