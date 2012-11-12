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
using RestSharp.Validation;

namespace Clc.Polaris.Api
{
	public partial class PolarisApiClient
	{
		/// <summary>
		/// Updates a phone notification.
		/// </summary>
		/// <summary>
		/// Currently only supports phone notifications; DeliveryOptionIDs 3, 4, and 5
		/// </summary>
		/// <param name="updateParams">Contains all of the relevant parameters to process a NotificationUpdate.</param>
		/// <returns>An object containing the result of the NotificationUpdate.</returns>
		/// <seealso cref="NotificationUpdateParams"/>
		/// <seealso cref="NotificationUpdateResult"/>
		public NotificationUpdateResult NotificationUpdate(NotificationUpdateParams updateParams)
		{
			Require.Argument("AccessToken", token.AccessToken);
			Require.Argument("NotificationTypeID", updateParams.NotificationTypeId);
			Require.Argument("NotificationStatusID", updateParams.CallStatus);
			Require.Argument("DeliveryOptionID", updateParams.DeliveryOptionId);
			Require.Argument("DeliveryString", updateParams.DeliveryString);
			Require.Argument("Details", updateParams.Details);
			Require.Argument("PatronID", updateParams.PatronId);
			Require.Argument("ItemRecordID", updateParams.ItemRecordId);

			var doc = new XDocument(
				new XElement("NotificationUpdateData",
				             new XElement("LogonBranchID", 1),
				             new XElement("LogonUserID", 1),
				             new XElement("LogonWorkstationID", 1),
				             new XElement("NotificationStatusID", updateParams.CallStatus),
				             new XElement("NotificationDeliveryDate", DateTime.Today.ToString("yyyy-MM-dd")),
				             new XElement("DeliveryOptionID", updateParams.DeliveryOptionId),
				             new XElement("DeliveryString", updateParams.DeliveryString),
				             new XElement("Details", updateParams.Details),
				             new XElement("PatronID", updateParams.PatronId),
				             new XElement("ItemRecordID", updateParams.ItemRecordId)
					)
				);

			var request = new RestRequest
				              {
					              Method = Method.PUT,
					              Resource =
						              string.Format("protected/v1/1033/100/1/{0}/notification/{1}", token.AccessToken,
						                            updateParams.NotificationTypeId)
				              };
			request.AddParameter("text/xml", doc.ToString(), ParameterType.RequestBody);

			_client.Authenticator = new PolarisProtectedAuthenticator(ApiUser, ApiKey, token);

			return Execute<NotificationUpdateResult>(request);
		}
	}
}