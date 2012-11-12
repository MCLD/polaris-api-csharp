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
using System.Xml.Linq;
using RestSharp;

namespace Clc.Polaris.Api
{
	public partial class PolarisApiClient
	{
		/// <summary>
		/// Uses patron supplied credentials to suspend a hold request.
		/// </summary>
		/// <param name="patronBarcode">The patron's barcode.</param>
		/// /// <param name="activationDate">The date the hold request will become active.</param>
		/// <param name="patronPIN">The patron's PIN.</param>
		/// <returns>An error code and message from the API, if any.</returns>
		/// <seealso cref="HoldRequestCancelResult"/>
		public HoldRequestActivationResult HoldRequestReactivateAllForPatron(string patronBarcode, DateTime activationDate, string patronPIN)
		{
			var doc = new XDocument(
				new XElement("HoldRequestActivationData",
				             new XElement("UserID", 1),
				             new XElement("ActivationDate", activationDate.ToString("yyyy-MM-dd"))
					)
				);
			var request = new RestRequest
				              {
					              Resource = string.Format("public/v1/1033/100/1/patron/{0}/holdrequests/{1}/active", patronBarcode, 0),
					              Method = Method.PUT
				              };
			request.AddParameter("text/xml", doc.ToString(), ParameterType.RequestBody);
			_client.Authenticator = new PolarisPublicAuthenticator(ApiUser, ApiKey, patronPIN);
			return Execute<HoldRequestActivationResult>(request);
		}

		/// <summary>
		/// Uses staff credentials to suspend a hold request for a user.
		/// </summary>
		/// <param name="patronBarcode">The patron's barcode.</param>
		/// <param name="activationDate">The date the hold request will become active.</param>
		/// <param name="patronPIN">The patron's PIN.</param>
		/// <returns>An error code and message from the API, if any.</returns>
		/// <seealso cref="HoldRequestCancelResult"/>
		public HoldRequestActivationResult staff_HoldRequestReactivateAllForPatron(string patronBarcode, DateTime activationDate, string patronPIN)
		{
			var doc = new XDocument(
				new XElement("HoldRequestActivationData",
				             new XElement("UserID", 1),
				             new XElement("ActivationDate", activationDate.ToString("yyyy-MM-dd"))
					)
				);
			var request = new RestRequest
				              {
					              Resource = string.Format("public/v1/1033/100/1/patron/{0}/holdrequests/{1}/active", patronBarcode, 0),
					              Method = Method.PUT
				              };
			request.AddParameter("text/xml", doc.ToString(), ParameterType.RequestBody);
			_client.Authenticator = new PolarisOverrideAuthenticator(ApiUser, ApiKey, token);
			return Execute<HoldRequestActivationResult>(request);
		}
	}
}