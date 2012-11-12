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
using System.Collections.Generic;

namespace Clc.Polaris.Api
{
	/// <summary>
	/// The result of a PatronItemsOutGet request.
	/// </summary>
	public class PatronItemsOutGetResult : PolarisApiResponse
	{
		/// <summary>
		/// A list of rows containing information about the items the patron has out.
		/// </summary>
		public List<PatronItemsOutGetRow> PatronItemsOutGetRows { get; set; }
	}

	/// <summary>
	/// Information for a title checked out by the patron.
	/// </summary>
	public class PatronItemsOutGetRow
	{
		/// <summary>
		/// The item's ID.
		/// </summary>
		public int ItemID { get; set; }

		/// <summary>
		/// The item's barcode.
		/// </summary>
		public string Barcode { get; set; }

		/// <summary>
		/// The ID of the bibliographic record this item is assigned to.
		/// </summary>
		public int BibID { get; set; }

		/// <summary>
		/// The ID of the item's format.
		/// </summary>
		public int FormatID { get; set; }

		/// <summary>
		/// The description of this item's format.
		/// </summary>
		public string FormatDescription { get; set; }

		/// <summary>
		/// The title of the item.
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// The author of the item.
		/// </summary>
		public string Author { get; set; }

		/// <summary>
		/// The call number of the item.
		/// </summary>
		public string CallNumber { get; set; }

		/// <summary>
		/// The date this itemw as checked out.
		/// </summary>
		public DateTime CheckOutDate { get; set; }

		/// <summary>
		/// The date this item is due back at the library.
		/// </summary>
		public DateTime DueDate { get; set; }

		/// <summary>
		/// The number of times this item has been renewed by this patron.
		/// </summary>
		public int RenewalCount { get; set; }

		/// <summary>
		/// Maximum number of times this item can be renewed by this patron.
		/// </summary>
		public int RenewalLimit { get; set; }

		/// <summary>
		/// The ID of the branch this item is assigned to.
		/// </summary>
		public int AssignedBranchID { get; set; }

		/// <summary>
		/// The name of the branch this item is assigned to.
		/// </summary>
		public string AssignedBranchName { get; set; }

		/// <summary>
		/// The ID of the branch this item was checked out from.
		/// </summary>
		public int LoaningBranchID { get; set; }

		/// <summary>
		/// The name of the branch this item was checked out from.
		/// </summary>
		public string LoaningBranchName { get; set; }
	}
}