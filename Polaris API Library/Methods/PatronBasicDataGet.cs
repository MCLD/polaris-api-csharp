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
using RestSharp;

namespace Clc.Polaris.Api
{
	public partial class PolarisApiClient
	{
		/// <summary>
		/// Uses the supplied patron credentials to retrieve patron information.
		/// </summary>
		/// <param name="barcode">The patron's barcode.</param>
		/// <param name="patronPIN">The patron's PIN.</param>
		/// <param name="getAddresses">Determines whether you want to get address data. Default is false.</param>
		/// <returns>An object containing patron information.</returns>
		/// <seealso cref="PatronData"/>
		public PatronBasicDataGetResult PatronBasicDataGet(string barcode, string patronPIN, bool getAddresses = false)
		{
			var request =
				new RestRequest(string.Format("public/v1/1033/100/1/patron/{0}/basicdata?addresses={1}", barcode,
				                              (getAddresses) ? "1" : "0"));
			_client.Authenticator = new PolarisPublicAuthenticator(ApiUser, ApiKey, patronPIN);
			return Execute<PatronBasicDataGetResult>(request);
		}

		/// <summary>
		/// Retrieves patron information for the specified barcode as a staff member.
		/// </summary>
		/// <param name="barcode">The patron's barcode.</param>
		/// <param name="getAddresses">Determines whether you want to get address data. Default is false.</param>
		/// <returns>An object containing patron information.</returns>
		/// <seealso cref="PatronData"/>
		public PatronBasicDataGetResult staff_PatronBasicDataGet(string barcode, bool getAddresses = false)
		{
			var request =
				new RestRequest(string.Format("public/v1/1033/100/1/patron/{0}/basicdata?addresses={1}", barcode,
				                              (getAddresses) ? "1" : "0"));
			_client.Authenticator = new PolarisOverrideAuthenticator(ApiUser, ApiKey, token);
			return Execute<PatronBasicDataGetResult>(request);
		}
	}
}