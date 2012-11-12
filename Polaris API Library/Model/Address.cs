#region license
// This file is part of Polaris API Library.
// 
// Polaris API Library is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// Polaris API Library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with Polaris API Library. If not, see http://www.gnu.org/licenses.
#endregion
namespace Clc.Polaris.Api
{
	/// <summary>
	/// Patron address information.
	/// </summary>
	public struct PatronAddress
	{
		/// <summary>
		/// The ID of the address.
		/// </summary>
		public int AddressId { get; set; }

		/// <summary>
		/// The free text label associated with the address.
		/// </summary>
		public string FreeTextLabel { get; set; }

		/// <summary>
		/// The first street of the address.
		/// </summary>
		public string StreetOne { get; set; }

		/// <summary>
		/// The second street of the address.
		/// </summary>
		public string StreetTwo { get; set; }

		/// <summary>
		/// The city of the address.
		/// </summary>
		public string City { get; set; }

		/// <summary>
		/// The state of the address.
		/// </summary>
		public string State { get; set; }

		/// <summary>
		/// The county the address is in.
		/// </summary>
		public string County { get; set; }

		/// <summary>
		/// The ZIP code of the address.
		/// </summary>
		public int PostalCode { get; set; }

		/// <summary>
		/// The country of the address.
		/// </summary>
		public string Country { get; set; }

		/// <summary>
		/// The ID number of this address' country.
		/// </summary>
		public int CountryID { get; set; }

		/// <summary>
		/// The address type of this address.
		/// </summary>
		public int AddressTypeID { get; set; }
	}
}