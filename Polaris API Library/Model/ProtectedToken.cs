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
	/// The fields required to make protected method API calls.
	/// </summary>
	public class ProtectedToken
	{
		/// <summary>
		/// Parameterless contructor for this class.
		/// </summary>
		public ProtectedToken()
		{
		}

		/// <summary>
		/// Creates a protected method token and populates its fields with the provided values.
		/// </summary>
		/// <param name="token">The access token.</param>
		/// <param name="secret">The access secret.</param>
		/// <param name="expiration">The date this token expires.</param>
		public ProtectedToken(string token, string secret, DateTime expiration)
		{
			AccessToken = token;
			AccessSecret = secret;
			AuthExpDate = expiration;
		}

		/// <summary>
		/// The token required for protected method calls.
		/// </summary>
		public string AccessToken { get; set; }

		/// <summary>
		/// The secret required for protected method calls.
		/// </summary>
		public string AccessSecret { get; set; }

		/// <summary>
		/// The date this token expires.
		/// </summary>
		public DateTime AuthExpDate { get; set; }
	}
}