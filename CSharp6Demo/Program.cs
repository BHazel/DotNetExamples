﻿// <copyright file="Program.cs" company="Benedict W. Hazel">
//     Benedict W. Hazel, 2015
// </copyright>
// <author>Benedict W. Hazel</author>
// <summary>
//     Program: Class for the main program logic.
// </summary>

namespace BWHazel.Experiments.CSharp6Demo
{
	using System;

	/// <summary>
	/// Main program logic.
	/// </summary>
	public class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		/// <param name="args">The command-line arguments.</param>
		public static void Main(string[] args)
		{
			// Program.RunCS5Examples();
			Program.RunCS6Examples();

			Console.ReadKey();
		}

		/// <summary>
		/// Runs the C# 5 examples.
		/// </summary>
		public static void RunCS5Examples()
		{
			// BWHazel.Experiments.CSharp6Demo.CS5.UsingStatic.Run();
			// BWHazel.Experiments.CSharp6Demo.CS5.AutoProperties.Run();
			// BWHazel.Experiments.CSharp6Demo.CS5.DictionaryInitialisers.Run();
			// BWHazel.Experiments.CSharp6Demo.CS5.ExceptionFilters.Run();
			// BWHazel.Experiments.CSharp6Demo.CS5.NameOf.Run();
			// BWHazel.Experiments.CSharp6Demo.CS5.StringInterpolation.Run();
			BWHazel.Experiments.CSharp6Demo.CS5.NullConditional.Run();
		}

		/// <summary>
		/// Runs the C# 6 examples.
		/// </summary>
		public static void RunCS6Examples()
		{
			// BWHazel.Experiments.CSharp6Demo.CS6.UsingStatic.Run();
			// BWHazel.Experiments.CSharp6Demo.CS6.AutoProperties.Run();
			// BWHazel.Experiments.CSharp6Demo.CS6.DictionaryInitialisers.Run();
			// BWHazel.Experiments.CSharp6Demo.CS6.ExceptionFilters.Run();
			// BWHazel.Experiments.CSharp6Demo.CS6.NameOf.Run();
			// BWHazel.Experiments.CSharp6Demo.CS6.StringInterpolation.Run();
			// BWHazel.Experiments.CSharp6Demo.CS6.NullConditional.Run();
			BWHazel.Experiments.CSharp6Demo.CS6.ExpressionsAndStructs.Run();
		}
	}
}
