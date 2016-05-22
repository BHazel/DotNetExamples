// <copyright file="Point.cs" company="Benedict W. Hazel">
//     Benedict W. Hazel, 2015
// </copyright>
// <author>Benedict W. Hazel</author>
// <summary>
//     Point: Struct to represent a 2-dimensional point in C# 5.
// </summary>

namespace BWHazel.Experiments.CSharp6Demo.CS5.Models
{
	using static System.Console;

	/// <summary>
	/// Represents a 2-dimensional point in C# 5.
	/// </summary>
	/// <remarks>
	/// Due to restrictions in C# 5 and below it is not possible to replicate the C# 6 example.
	/// </remarks>
	public struct Point
	{
		/// <summary>
		/// Initialises a new instance of the <see cref="Point"/> struct with initial values.
		/// </summary>
		/// <param name="x">The X-coordinate.</param>
		/// <param name="y">The Y coordinate.</param>
		public Point(double x, double y)
		{
			this.X = x;
			this.Y = y;
		}

		/// <summary>
		/// Gets or sets the X coordinate.
		/// </summary>
		public double X { get; set; }

		/// <summary>
		/// Gets or sets the Y coordinate.
		/// </summary>
		public double Y { get; set; }

		/// <summary>
		/// Initialises a new instance of the <see cref="Point"/> struct with NaN values.
		/// </summary>
		/// <returns>A new point with NaN values.</returns>
		public static Point CreateNanPoint()
		{
			return new Point(double.NaN, double.NaN);
		}

		/// <summary>
		/// Creates a new point from a relative move of this point.
		/// </summary>
		/// <param name="dx">The move in the X direction.</param>
		/// <param name="dy">The move in the Y direction.</param>
		/// <returns>A new point from a relative move of this point.</returns>
		public Point Move(double dx, double dy)
		{
			return new Point(this.X + dx, this.Y + dy);
		}

		/// <summary>
		/// Adds two points.
		/// </summary>
		/// <param name="p1">The first point.</param>
		/// <param name="p2">The second point.</param>
		/// <returns>A new point with the sum of the two points.</returns>
		public static Point operator +(Point p1, Point p2)
		{
			return new Point(p1.X + p2.X, p1.Y + p2.Y);
		}

		/// <summary>
		/// Creates a string representation of this point.
		/// </summary>
		/// <returns>A string representation of theis point in the format (X, Y).</returns>
		public override string ToString()
		{
			return string.Format("({0}, {1})", this.X, this.Y);
		}
	}
}
