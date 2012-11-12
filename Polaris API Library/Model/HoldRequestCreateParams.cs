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
	/// Contains the parameters required to create a hold request.
	/// </summary>
	public class HoldRequestCreateParams
	{
		/// <summary>
		/// Initializes an object with default values for WorkstationID, UserID, RequestingOrgID, and ActivationDate
		/// </summary>
		public HoldRequestCreateParams()
		{
			WorkstationID = 1;
			UserID = 1;
			RequestingOrgID = 1;
			ActivationDate = DateTime.Today;
		}

		/// <summary>
		/// The patron's PatronID.
		/// </summary>
		public int PatronID { get; set; }

		/// <summary>
		/// The bibliographic record's BibliograhpicRecordID
		/// </summary>
		public int BibID { get; set; }

		/// <summary>
		/// The barcode of the item for a title level hold.
		/// </summary>
		public string ItemBarcode { get; set; }

		/// <summary>
		/// Volume of the hold request.
		/// </summary>
		public string VolumeNumber { get; set; }

		/// <summary>
		/// Serial designation of the hold request.
		/// </summary>
		public string Designation { get; set; }

		/// <summary>
		/// OrganizationID of the hold pickup location.
		/// </summary>
		public int PickupOrgID { get; set; }

		/// <summary>
		/// If the request is a Borrow by Mail request.
		/// </summary>
		public int IsBorrowByMail { get; set; }

		/// <summary>
		/// Notes created by patron.
		/// </summary>
		public string PatronNotes { get; set; }

		/// <summary>
		/// The date this hold request will become active.
		/// </summary>
		public DateTime ActivationDate { get; set; }

		/// <summary>
		/// ID of the workstation where this hold request was created.
		/// </summary>
		public int WorkstationID { get; set; }

		/// <summary>
		/// ID of the Polaris user that created this request.
		/// </summary>
		public int UserID { get; set; }

		/// <summary>
		/// ID of branch where this hold request was created.
		/// </summary>
		public int RequestingOrgID { get; set; }

		/// <summary>
		/// GUID of search target. ONLY USED IF NOT LOCAL.
		/// </summary>
		public Guid? TargetGUID { get; set; }
	}
}