// <copyright file="ExpressionBodies.cs" company="Benedict W. Hazel">
//     Benedict W. Hazel, 2015
// </copyright>
// <author>Benedict W. Hazel</author>
// <summary>
//     ExpressionBodies: Class to demonstrate expression-bodied function members and struct enhancements.
// </summary>

namespace BWHazel.Experiments.CSharp6Demo.CS6
{
	using static System.Console;
	using BWHazel.Experiments.CSharp6Demo.CS6.Models;

	/// <summary>
	/// Demonstrates expression-bodied function members and struct enhancements.
	/// </summary>
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
			WriteLine($"(Sum: {sumPoint.ToString()}");

			Point nanPoint = new Point();
			WriteLine($"NaN Point: {nanPoint.ToString()}");

			Point defaultPoint = default(Point);
			WriteLine($"Default Point: {defaultPoint.ToString()}");
        }
	}
}
