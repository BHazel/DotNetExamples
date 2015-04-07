// <copyright file="ExpressionBodies.cs" company="Benedict W. Hazel">
//     Benedict W. Hazel, 2015
// </copyright>
// <author>Benedict W. Hazel</author>
// <summary>
//     ExpressionBodies: Class to demonstrate the C# 5 equivalent of expression-bodied function members and struct enhancements.
// </summary>

namespace BWHazel.Experiments.CSharp6Demo.CS5
{
	using System;
	using BWHazel.Experiments.CSharp6Demo.CS5.Models;

	/// <summary>
	/// Demonstrates the C# 5 equivalent of expression-bodied function members and struct enhancements.
	/// </summary>
	/// <remarks>
	/// Due to restrictions in C# 5 and below it is not possible to replicate the C# 6 example.
	/// </remarks>
	public static class ExpressionsAndStructs
	{
		/// <summary>
		/// Creates several points and prints them on the console.
		/// </summary>
		public static void Run()
		{
			Point point1 = new Point(5, 10);
			Point point2 = new Point(20, 25);
			Point sumPoint = point1 + point2;
			Console.WriteLine(string.Format("(Sum: {0}", sumPoint.ToString()));

			Point nanPoint = Point.CreateNanPoint();
			Console.WriteLine(string.Format("NaN Point: {0}", nanPoint.ToString()));

			Point defaultPoint = default(Point);
			Console.WriteLine(string.Format("Default Point: {0}", defaultPoint.ToString()));
		}
	}
}
