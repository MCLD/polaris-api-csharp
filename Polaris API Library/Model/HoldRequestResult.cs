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
	/// Contains the results of a hold request creation.
	/// </summary>
	public class HoldRequestResult : PolarisApiResponse
	{
		/// <summary>
		/// Hold request GUID.
		/// </summary>
		public Guid RequestGUID { get; set; }

		/// <summary>
		/// TxnGroupQualifier of the hold request.
		/// </summary>
		public string TxnGroupQualifier { get; set; }

		/// <summary>
		/// TxnQualifier of the hold request.
		/// </summary>
		public string TxnQualifier { get; set; }

		/// <summary>
		/// Status type of the hold request.
		/// </summary>
		public int StatusType { get; set; }

		/// <summary>
		/// Status vlue of the hold request.
		/// </summary>
		public int StatusValue { get; set; }

		/// <summary>
		/// Display text.
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// Position of this hold in the queue.
		/// </summary>
		public int QueuePostition { get; set; }

		/// <summary>
		/// Total number of holds in the queue.
		/// </summary>
		public int QueueTotal { get; set; }
	}
}