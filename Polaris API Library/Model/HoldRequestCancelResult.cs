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
	/// The reply to a HoldRequestCancelAll call.
	/// </summary>
	public class HoldRequestCancelAllResult : PolarisApiResponse
	{
		/// <summary>
		/// Information about cancelled holds.
		/// </summary>
		public List<HoldRequestCancelRow> HoldRequestCancelRows { get; set; }
	}

	/// <summary>
	/// The information about an individual cancelled hold request.
	/// </summary>
	public class HoldRequestCancelRow
	{
		/// <summary>
		/// The ID of the hold request.
		/// </summary>
		public int SysHoldRequestID { get; set; }

		/// <summary>
		/// The code returned by the Polaris API.
		/// </summary>
		public int ReturnCode { get; set; }

		/// <summary>
		/// The error message returned by the Polaris API.
		/// </summary>
		public string ErrorMessage { get; set; }
	}
}