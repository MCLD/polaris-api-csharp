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
		/// Uses patron supplied credentials to cancel a hold request.
		/// </summary>
		/// <param name="patronBarcode">The patron's barcode.</param>
		/// <param name="patronPIN">The patron's PIN.</param>
		/// <param name="workstationID">The ID of the workstation processing the request.</param>
		/// <param name="userID">The ID of the user processing the request..</param>
		/// <returns>An error code and message from the API, if any.</returns>
		/// <seealso cref="HoldRequestCancelResult"/>
		public HoldRequestCancelAllResult HoldRequestCancelAllForPatron(string patronBarcode, string patronPIN, int workstationID = 1, int userID = 1)
		{
			var request = new RestRequest
				              {
					              Resource = string.Format("public/v1/1033/100/1/patron/{0}/holdrequests/{1}/cancelled?wsid={2}&userid={3}", patronBarcode, 0, workstationID, userID),
					              Method = Method.PUT
				              };
			_client.Authenticator = new PolarisPublicAuthenticator(ApiUser, ApiKey, patronPIN);
			return Execute<HoldRequestCancelAllResult>(request);
		}

		/// <summary>
		/// Uses staff credentials to cancel a hold request for a user.
		/// </summary>
		/// <param name="patronBarcode">The patron's barcode.</param>
		/// <param name="workstationID">The ID of the workstation processing the request.</param>
		/// <param name="userID">The ID of the user processing the request..</param>
		/// <returns>An error code and message from the API, if any.</returns>
		/// <seealso cref="HoldRequestCancelResult"/>
		public HoldRequestCancelAllResult staff_HoldRequestCancelAllForPatron(string patronBarcode, int workstationID = 1, int userID = 1)
		{
			var request = new RestRequest
				              {
					              Resource = string.Format("public/v1/1033/100/1/patron/{0}/holdrequests/{1}/cancelled?wsid={2}&userid={3}", patronBarcode, 0, workstationID, userID),
					              Method = Method.PUT
				              };
			_client.Authenticator = new PolarisOverrideAuthenticator(ApiUser, ApiKey, token);
			return Execute<HoldRequestCancelAllResult>(request);
		}
	}
}