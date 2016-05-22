// <copyright file="Address.cs" company="Benedict W. Hazel">
//     Benedict W. Hazel, 2015
// </copyright>
// <author>Benedict W. Hazel</author>
// <summary>
//     Address: Class to represent an address.
// </summary>

namespace BWHazel.Experiments.CSharp6Demo.CS5.Models
{
	/// <summary>
	/// Represents an address.
	/// </summary>
	public class Address
	{
		/// <summary>
		/// Gets or sets the street.
		/// </summary>
		public string Street { get; set; }

		/// <summary>
		/// Gets or sets the city.
		/// </summary>
		public string City { get; set; }

		/// <summary>
		/// Gets or sets the county.
		/// </summary>
		public string County { get; set; }

		/// <summary>
		/// Gets or sets the post code.
		/// </summary>
		public string PostCode { get; set; }

		/// <summary>
		/// Gets or sets the country.
		/// </summary>
		public string Country { get; set; }
	}
}