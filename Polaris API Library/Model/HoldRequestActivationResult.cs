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
	/// The result of a HoldRequestActivation.
	/// </summary>
	public class HoldRequestActivationResult : PolarisApiResponse
	{
		/// <summary>
		/// Information about activated holds.
		/// </summary>
		public List<HoldActivationRow> HoldActivationRows { get; set; }
	}

	/// <summary>
	/// Information about activated holds.
	/// </summary>
	public class HoldActivationRow
	{
		/// <summary>
		/// The SysHoldRequestID of the hold.
		/// </summary>
		public int SysHoldRequestID { get; set; }

		/// <summary>
		///  0 - Success
		/// -1 - Failure
		/// </summary>
		public int ReturnCode { get; set; }

		/// <summary>
		/// The new activation date of the hold request.
		/// </summary>
		public DateTime NewActivationDate { get; set; }

		/// <summary>
		/// The new expiration date of the hold request.
		/// </summary>
		public DateTime NewExpirationDate { get; set; }

		/// <summary>
		/// The error message if not sucessful.
		/// </summary>
		public string ErrorMessage { get; set; }
	}
}