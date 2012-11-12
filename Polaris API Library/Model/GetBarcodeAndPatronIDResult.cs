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
using System.Collections.Generic;

namespace Clc.Polaris.Api
{
	/// <summary>
	/// Contains the result of a Patron_GetBarcodeFromID request.
	/// </summary>
	public class GetBarcodeAndPatronIDResult : PolarisApiResponse
	{
		/// <summary>
		/// A collection of rows containing a PatronID and barcode.
		/// </summary>
		public List<BarcodeAndPatronIDRow> BarcodeAndPatronIDRows { get; set; }
	}

	/// <summary>
	/// A simple row that contains a PatronID and barcode.
	/// </summary>
	public class BarcodeAndPatronIDRow
	{
		/// <summary>
		/// The patron's ID
		/// </summary>
		public int PatronID { get; set; }

		/// <summary>
		/// The patron's barcode
		/// </summary>
		public string Barcode { get; set; }
	}
}