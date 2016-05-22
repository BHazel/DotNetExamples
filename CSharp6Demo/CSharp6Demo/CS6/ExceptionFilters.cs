// <copyright file="ExceptionFilters.cs" company="Benedict W. Hazel">
//     Benedict W. Hazel, 2015
// </copyright>
// <author>Benedict W. Hazel</author>
// <summary>
//     ExceptionFilters: Class to demonstrate exception filters.
// </summary>

namespace BWHazel.Experiments.CSharp6Demo.CS6
{
	using System;
	using static System.Console;
	using System.Configuration;
	using static System.Configuration.ConfigurationManager;

	/// <summary>
	/// Demonstrates exception filters.
	/// </summary>
	public static class ExceptionFilters
	{
		/// <summary>
		/// Throws an exception which is filtered when caught.
		/// </summary>
		public static void Run()
		{
			string exceptionMessage = ConfigurationManager.AppSettings["DemoExceptionFiltersExceptionMessage"];
            try
			{
				throw new Exception(exceptionMessage);
            }
			catch (Exception ex) when (ex.Message == "Error")
			{
				WriteLine("A terrible error has occurred!");
			}
			catch (Exception ex) when (ex.Message == "Fatal")
			{
				WriteLine("Something carastrophic has happened!");
			}
			catch (Exception ex)
			{
				WriteLine($"An unknown error has occurred: {ex.Message}");
            }
		}
	}
}
