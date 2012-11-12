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
using System;

namespace Clc.Polaris.Api
{
	/// <summary>
	/// Contains the results of a patron validation request.
	/// </summary>
	public class PatronValidateResult : PolarisApiResponse
	{
		/// <summary>
		/// The patron's barcode.
		/// </summary>
		public string Barcode { get; set; }

		/// <summary>
		/// Indicates valid patron.
		/// </summary>
		public bool ValidPatron { get; set; }

		/// <summary>
		/// The patron's ID.
		/// </summary>
		public int PatronID { get; set; }

		/// <summary>
		/// The patron's code ID.
		/// </summary>
		public int PatronCodeID { get; set; }

		/// <summary>
		/// The patron's assigned branch ID.
		/// </summary>
		public int AssignedBranchID { get; set; }

		/// <summary>
		/// The name of the patron's assigned branch.
		/// </summary>
		public string AssignedBranchName { get; set; }

		/// <summary>
		/// The date this patron's registration expires.
		/// </summary>
		public DateTime ExpirationDate { get; set; }

		/// <summary>
		/// Indicates if the override was used in place of the patron's password.
		/// </summary>
		public bool OverridePasswordUsed { get; set; }
	}
}