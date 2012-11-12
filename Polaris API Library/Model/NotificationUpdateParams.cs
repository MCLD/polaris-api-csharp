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
	/// The parameters required to perform a NotificationUpdate.
	/// </summary>
	public struct NotificationUpdateParams
	{
		/// <summary>
		/// The DeliveryOptionID of the notification. Currently only phone notifications are supported; DeliveryOptionIDs 3, 4, and 5.
		/// </summary>
		public int DeliveryOptionId { get; set; }

		/// <summary>
		/// How the message was delivered. In the currently implementation this is the patron's phone number.
		/// </summary>
		public string DeliveryString { get; set; }

		/// <summary>
		/// The ID of the patron.
		/// </summary>
		public int PatronId { get; set; }

		/// <summary>
		/// The ID of the item record on the notification.
		/// </summary>
		public int ItemRecordId { get; set; }

		/// <summary>
		/// Any additional data/notes.
		/// </summary>
		public string Details { get; set; }

		/// <summary>
		/// The status of the call.
		/// </summary>
		public int CallStatus { get; set; }

		/// <summary>
		/// The type of notification it was.
		/// </summary>
		public int NotificationTypeId { get; set; }
	}
}