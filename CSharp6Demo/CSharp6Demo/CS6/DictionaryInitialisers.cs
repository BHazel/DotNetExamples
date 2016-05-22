// <copyright file="DictionaryInitialisers.cs" company="Benedict W. Hazel">
//     Benedict W. Hazel, 2015
// </copyright>
// <author>Benedict W. Hazel</author>
// <summary>
//     DictionaryInitialisers: Class to demonstrate new dictionary initialisers.
// </summary>

namespace BWHazel.Experiments.CSharp6Demo.CS6
{
	using static System.Console;
	using System.Collections.Generic;

	/// <summary>
	/// Demonstrates new dictionary initialisers.
	/// </summary>
	public static class DictionaryInitialisers
	{
		/// <summary>
		/// Creates and populates a dictionary and prints its values to the console.
		/// </summary>
		public static void Run()
		{
			Dictionary<string, double> prices = new Dictionary<string, double>()
			{
				["Apples"] = 0.99,
				["Beer"] = 2.99,
				["Cola"] = 1.49
			};

			foreach (KeyValuePair<string, double> item in prices)
			{
				WriteLine($"{item.Key}: {item.Value}");
            }
		}
	}
}
