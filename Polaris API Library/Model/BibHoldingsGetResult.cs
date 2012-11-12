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
	/// Contains the results of a bibliographic holdings search.
	/// </summary>
	public class BibHoldingsGetResult : PolarisApiResponse
	{
		/// <summary>
		/// Contains a list of holdings data.
		/// </summary>
		public List<BibHoldingsGetRow> BibHoldingsGetRows { get; set; }
	}

	/// <summary>
	/// Contains information for a bibliographic holding.
	/// </summary>
	public class BibHoldingsGetRow
	{
		/// <summary>
		/// OrganizationID of the location of this piece.
		/// </summary>
		public int LocationID { get; set; }

		/// <summary>
		/// Name of the location of this piece.
		/// </summary>
		public string LocationName { get; set; }

		/// <summary>
		/// ID of the collection this piece belongs to.
		/// </summary>
		public int CollectionID { get; set; }

		/// <summary>
		/// Name of the collection this piece belongs to.
		/// </summary>
		public string CollectionName { get; set; }

		/// <summary>
		/// Barcode of this piece. If this piece is not associated with an piece record then this value will be NULL.
		/// </summary>
		public string Barcode { get; set; }

		/// <summary>
		/// Public note assigned to this piece.
		/// </summary>
		public string PublicNote { get; set; }

		/// <summary>
		/// Call number of this piece.
		/// </summary>
		public string CallNumber { get; set; }

		/// <summary>
		/// Designation of this piece. If this piece is not associated with a serial then this value will be NULL.
		/// </summary>
		public string Designation { get; set; }

		/// <summary>
		/// Volume number of this piece.
		/// </summary>
		public string VolumeNumber { get; set; }

		/// <summary>
		/// Shelf location of this piece.
		/// </summary>
		public string ShelfLocation { get; set; }

		/// <summary>
		/// Circulation status of this piece.
		/// </summary>
		public string CircStatus { get; set; }

		/// <summary>
		/// Last circulation of this piece. If this piece is not associated with an item record then this value will be NULL.
		/// </summary>
		public DateTime? LastCircDate { get; set; }

		/// <summary>
		/// Material type of this piece. If this piece is not associated with an item record then this value will be NULL.
		/// </summary>
		public string MaterialType { get; set; }

		/// <summary>
		/// Textual holdngs note associated with the assigned location/collection.
		/// </summary>
		public string TextualHoldingsNote { get; set; }

		/// <summary>
		/// Retention statement associated with the assigned location.
		/// </summary>
		public string RetentionStatement { get; set; }

		/// <summary>
		/// Holdings statement associated with the asigned location.
		/// </summary>
		public string HoldingsStatement { get; set; }

		/// <summary>
		/// Holdings note associated with the assigned location.
		/// </summary>
		public string HoldingsNote { get; set; }

		/// <summary>
		/// Total number of pieces associated with the assigned location.
		/// </summary>
		public int ItemsTotal { get; set; }

		/// <summary>
		/// Number of pieces associated with the assigned location available for checkout.
		/// </summary>
		public int ItemsIn { get; set; }

		/// <summary>
		/// Specifies if a hold can be placed on this piece.
		/// </summary>
		public bool Holdable { get; set; }

		/// <summary>
		/// Specifies when the item is due back to the library.
		/// </summary>
		public DateTime? DueDate { get; set; }
	}
}