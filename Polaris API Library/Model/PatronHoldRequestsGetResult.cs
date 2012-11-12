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
	/// Information about the hold requests of a patron.
	/// </summary>
	public class PatronHoldRequestsGetResult : PolarisApiResponse
	{
		/// <summary>
		/// A list of rows containing information about a hold.
		/// </summary>
		public List<PatronHoldRequestsGetRow> PatronHoldRequestsGetRows { get; set; }
	}

	/// <summary>
	/// Information about a hold a patron has placed.
	/// </summary>
	public class PatronHoldRequestsGetRow
	{
		/// <summary>
		/// The ID of the hold request.
		/// </summary>
		public int HoldRequestID { get; set; }

		/// <summary>
		/// The ID of the bibliographic record on hold.
		/// </summary>
		public int BibID { get; set; }

		/// <summary>
		/// The status ID of the hold.
		/// </summary>
		public int StatusID { get; set; }

		/// <summary>
		/// The status description of the hold.
		/// </summary>
		public string StatusDescription { get; set; }

		/// <summary>
		/// Title of the item on hold.
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Author of the item on hold.
		/// </summary>
		public string Author { get; set; }

		/// <summary>
		/// Call number of the item on hold.
		/// </summary>
		public string CallNumber { get; set; }

		/// <summary>
		/// Format ID of the item on hold.
		/// </summary>
		public int FormatID { get; set; }

		/// <summary>
		/// Format description of the item on hold.
		/// </summary>
		public string FormatDescription { get; set; }

		/// <summary>
		/// ID of the branch the hold will be picked up at.
		/// </summary>
		public int PickupBranchID { get; set; }

		/// <summary>
		/// Name of the branch the hold will be picked up at.
		/// </summary>
		public string PickupBranchName { get; set; }

		/// <summary>
		/// Date the item can be picked up by.
		/// </summary>
		public DateTime? PickupByDate { get; set; }

		/// <summary>
		/// Position of this hold in the hold queue.
		/// </summary>
		public int QueuePosition { get; set; }

		/// <summary>
		/// Total number of holds in the hold queue.
		/// </summary>
		public int QueueTotal { get; set; }

		/// <summary>
		/// Date this hold will become active.
		/// </summary>
		public DateTime ActivationDate { get; set; }

		/// <summary>
		/// Date this hold expires.
		/// </summary>
		public DateTime ExpirationDate { get; set; }

		/// <summary>
		/// Name used to identify a group of titles that can satisfy this hold request
		/// </summary>
		public string GroupName { get; set; }

		/// <summary>
		/// Is the hold an item level hold.
		/// </summary>
		public bool ItemLevelHold { get; set; }

		/// <summary>
		/// Is a borrow by mail request.
		/// </summary>
		public bool IsBorrowByMail { get; set; }
	}
}