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
	/// The result of a PatronBasicDataGet API call.
	/// </summary>
	public class PatronBasicDataGetResult : PolarisApiResponse
	{
		/// <summary>
		/// Patron information for the supplied patron.
		/// </summary>
		public PatronData PatronBasicData { get; set; }
	}

	/// <summary>
	/// Information about a patron.
	/// </summary>
	public class PatronData
	{
		/// <summary>
		/// The patron's ID.
		/// </summary>
		public int PatronID { get; set; }

		/// <summary>
		/// The patron's barcode.
		/// </summary>
		public string Barcode { get; set; }

		/// <summary>
		/// The patron's first name.
		/// </summary>
		public string NameFirst { get; set; }

		/// <summary>
		/// The patron's last name.
		/// </summary>
		public string NameLast { get; set; }

		/// <summary>
		/// The patron's middle name.
		/// </summary>
		public string NameMiddle { get; set; }

		/// <summary>
		/// The patron's phone number.
		/// </summary>
		public string PhoneNumber { get; set; }

		/// <summary>
		/// The patron's email address.
		/// </summary>
		public string EmailAddress { get; set; }

		/// <summary>
		/// The number of items the patron has out.
		/// </summary>
		public int ItemsOutCount { get; set; }

		/// <summary>
		/// The number of overdue items the patron has out.
		/// </summary>
		public int ItemsOverdueCount { get; set; }

		/// <summary>
		/// The number of lost items the patron has out.
		/// </summary>
		public int ItemsOutLostCount { get; set; }

		/// <summary>
		/// The total number of hold requests the patron has.
		/// </summary>
		public int HoldRequestsTotalCount { get; set; }

		/// <summary>
		/// The number of shipped hold requests the patron has.
		/// </summary>
		public int HoldRequestsShippedCount { get; set; }

		/// <summary>
		/// The number of unclaimed hold requests the patron has.
		/// </summary>
		public int HoldRequestsUnclaimedCount { get; set; }

		/// <summary>
		/// The patron's charge balance.
		/// </summary>
		public decimal ChargeBalance { get; set; }

		/// <summary>
		/// The patron's credit balance.
		/// </summary>
		public decimal CreditBalance { get; set; }

		/// <summary>
		/// The patron's deposit balance.
		/// </summary>
		public decimal DepositBalance { get; set; }

		/// <summary>
		/// The patron's title.
		/// </summary>
		public string NameTitle { get; set; }

		/// <summary>
		/// The patron's suffix.
		/// </summary>
		public string NameSuffix { get; set; }

		/// <summary>
		/// The patron's second phone number.
		/// </summary>
		public string PhoneNumber2 { get; set; }

		/// <summary>
		/// The patron's second phone number.
		/// </summary>
		public string PhoneNumber3 { get; set; }

		/// <summary>
		/// The carrier for the patron's first phone.
		/// </summary>
		public int Phone1CarrierID { get; set; }

		/// <summary>
		/// he carrier for the patron's second phone.
		/// </summary>
		public int Phone2CarrierID { get; set; }

		/// <summary>
		/// he carrier for the patron's third phone.
		/// </summary>
		public int Phone3CarrierID { get; set; }

		/// <summary>
		/// The patron's cell phone number.
		/// </summary>
		public string CellPhone { get; set; }

		/// <summary>
		/// The carrier for the patron's cell phone.
		/// </summary>
		public int CellPhoneCarrierID { get; set; }

		/// <summary>
		/// The patron's alternate email address.
		/// </summary>
		public string AltEmailAddress { get; set; }

		/// <summary>
		/// The patron's birth date.
		/// </summary>
		public DateTime? BirthDate { get; set; }

		/// <summary>
		/// The date the patron registered.
		/// </summary>
		public DateTime RegistrationDate { get; set; }

		/// <summary>
		/// The date of this patron's last activity.
		/// </summary>
		public DateTime LastActivityDate { get; set; }

		/// <summary>
		/// The date this patron will require an access check.
		/// </summary>
		public DateTime AddrCheckDate { get; set; }

		/// <summary>
		/// The number of new messages the patron has.
		/// </summary>
		public int MessageNewCount { get; set; }

		/// <summary>
		/// The number of read messages the patron has.
		/// </summary>
		public int MessageReadCount { get; set; }

		/// <summary>
		/// A list of the patron's addresses.
		/// </summary>
		public List<PatronAddress> PatronAddresses { get; set; }

		/// <summary>
		/// The patron's mobile phone number.
		/// </summary>
		public string MobilePhone { get; set; }
	}
}