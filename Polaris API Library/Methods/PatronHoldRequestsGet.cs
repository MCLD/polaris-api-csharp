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
		/// Uses the supplied patron credentials to retrieve holds for that patron.
		/// </summary>
		/// <param name="barcode">The patron's barcode.</param>
		/// <param name="patronPIN">The patron's PIN.</param>
		/// <param name="status">Status of the holds you wish to retrieve.</param>
		/// <returns>PatronHoldRequestsGetResult</returns>
		/// <seealso cref="PatronHoldRequestsGetResult"/>
		/// <seealso cref="HoldStatus"/>
		public PatronHoldRequestsGetResult PatronHoldRequestsGet(string barcode, string patronPIN, HoldStatus status)
		{
			var request =
				new RestRequest(string.Format("public/v1/1033/100/1/patron/{0}/holdrequests/{1}", barcode, status.ToString()));
			request.AddUrlSegment("AccessToken", token.AccessToken);

			_client.Authenticator = new PolarisPublicAuthenticator(ApiUser, ApiKey, patronPIN);
			return Execute<PatronHoldRequestsGetResult>(request);
		}

		/// <summary>
		/// Uses the supplied patron credentials to retrieve all holds for that patron.
		/// </summary>
		/// <param name="barcode">The patron's barcode.</param>
		/// <param name="patronPIN">The patron's PIN.</param>
		/// <returns>PatronHoldRequestsGetResult</returns>
		/// <seealso cref="PatronHoldRequestsGetResult"/>
		public PatronHoldRequestsGetResult PatronHoldRequestsGetAll(string barcode, string patronPIN)
		{
			return PatronHoldRequestsGet(barcode, patronPIN, HoldStatus.all);
		}

		/// <summary>
		/// Retrieves holds for the supplied patron barcode as a staff member.
		/// </summary>
		/// <param name="barcode">The patron's barcode.</param>
		/// <param name="status">Status of the holds you wish to retrieve.</param>
		/// <returns>PatronHoldRequestsGetResult</returns>
		/// <seealso cref="PatronHoldRequestsGetResult"/>
		/// <seealso cref="HoldStatus"/>
		public PatronHoldRequestsGetResult Staff_PatronHoldRequestsGet(string barcode, HoldStatus status)
		{
			var request =
				new RestRequest(string.Format("public/v1/1033/100/1/patron/{0}/holdrequests/{1}", barcode, status.ToString()));
			request.AddUrlSegment("AccessToken", token.AccessToken);

			_client.Authenticator = new PolarisOverrideAuthenticator(ApiUser, ApiKey, token);
			return Execute<PatronHoldRequestsGetResult>(request);
		}

		/// <summary>
		/// Retrieves all hold requests for the supplied patron barcode as a staff mamber.
		/// </summary>
		/// <param name="barcode">The patron's barcode.</param>
		/// <returns>PatronHoldRequestsGetResult</returns>
		/// <seealso cref="PatronHoldRequestsGetResult"/>
		public PatronHoldRequestsGetResult staff_PatronHoldRequestsGetAll(string barcode)
		{
			return Staff_PatronHoldRequestsGet(barcode, HoldStatus.all);
		}
	}
}