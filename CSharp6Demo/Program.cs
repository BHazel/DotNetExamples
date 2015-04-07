// <copyright file="Program.cs" company="Benedict W. Hazel">
//     Benedict W. Hazel, 2015
// </copyright>
// <author>Benedict W. Hazel</author>
// <summary>
//     Program: Class for the main program logic.
// </summary>

namespace BWHazel.Experiments.CSharp6Demo
{
	using System;
	using static System.Console;
	using static System.Convert;
	using System.Configuration;
	using System.Reflection;

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
			bool runDemosCSharp5 = GetVersionSettings("5");
			bool runDemosCSharp6 = GetVersionSettings("6");

			if (runDemosCSharp5 == true)
			{
				RunDemos("5");
			}

			if (runDemosCSharp6 == true)
			{
				RunDemos("6");
			}

			WriteLine("Press any key to exit...");
			ReadKey();
		}

		/// <summary>
		/// Gets the app setting for the specifid version of C#.
		/// </summary>
		/// <param name="cSharpVersion">The C# version as an integer.</param>
		/// <returns><c>true</c> if this version of C# is set in app settings, otherwise <c>false</c>.</returns>
		public static bool GetVersionSettings(string cSharpVersion)
		{
			return ToBoolean(ConfigurationManager.AppSettings[$"RunDemosCsharp{cSharpVersion}"]);
		}

		/// <summary>
		/// Runs the demos for the specified version of C#.
		/// </summary>
		/// <param name="cSharpVersion">The C# version as an integer.</param>
		public static void RunDemos(string cSharpVersion)
		{
			WriteLine($"*** Running Demos for C# {cSharpVersion}... ***");
            foreach (string key in ConfigurationManager.AppSettings.AllKeys)
			{
				if (key.StartsWith("RunDemosCSharp"))
				{
					continue;
				}

				if (ToBoolean(ConfigurationManager.AppSettings[key]) == true)
				{
					WriteLine($"*** Running Demo {key}... ***");
					Type demoType = Assembly.GetExecutingAssembly().GetType($"BWHazel.Experiments.CSharp6Demo.CS{cSharpVersion}.{key}");
					MethodInfo demoRunMethod = demoType.GetMethod("Run");
					demoRunMethod.Invoke(demoType, null);
				}
            }
		}
	}
}
