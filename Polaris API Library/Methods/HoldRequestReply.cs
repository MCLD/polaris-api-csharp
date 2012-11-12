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
using System.Xml.Linq;
using RestSharp;

namespace Clc.Polaris.Api
{
	public partial class PolarisApiClient
	{
		/// <summary>
		/// Replies as a patron to a conditonal raised by a previous hold request creation.
		/// </summary>
		/// <param name="holdRequest">The result of the hold request that you are replying to.</param>
		/// <param name="requestingOrgID">The Org ID of the branch processing the request.</param>
		/// <param name="answer">The answer to the conditional.</param>
		/// <param name="state">Which conditional will this answer be replied to?</param>
		/// <param name="patronPIN">The patron's PIN.</param>
		/// <returns>An object containing the hold request creation result.</returns>
		/// <seealso cref="HoldRequestReplyData"/>
		/// <seealso cref="HoldRequestResult"/>
		public HoldRequestReplyData HoldRequestReply(HoldRequestResult holdRequest, int requestingOrgID, int answer, int state,
		                                             string patronPIN)
		{
			var doc = new XDocument(
				new XElement("HoldRequestReplyData",
				             new XElement("TxnGroupQualifier", holdRequest.TxnGroupQualifier),
				             new XElement("TxnQualifier", holdRequest.TxnQualifier),
				             new XElement("RequestingOrgID", requestingOrgID),
				             new XElement("Answer", answer),
				             new XElement("State", state)
					)
				);

			var request = new RestRequest(string.Format("public/v1/1033/100/1/holdrequest/{0}", holdRequest.RequestGUID),
			                              Method.PUT);
			request.AddParameter("text/xml", doc.ToString(), ParameterType.RequestBody);

			_client.Authenticator = new PolarisPublicAuthenticator(ApiUser, ApiKey, patronPIN);
			return Execute<HoldRequestReplyData>(request);
		}

		/// <summary>
		/// Replies as a staff member on the behalf of a patron to a conditonal raised by a previous hold request creation.
		/// </summary>
		/// <param name="holdRequest">The result of the hold request that you are replying to.</param>
		/// <param name="requestingOrgID">The Org ID of the branch processing the request.</param>
		/// <param name="answer">The answer to the conditional.</param>
		/// <param name="state">Which conditional will this answer be replied to?</param>
		/// <returns>An object containing the hold request creation result.</returns>
		/// <seealso cref="HoldRequestReplyData"/>
		/// <seealso cref="HoldRequestResult"/>
		public HoldRequestReplyData staff_HoldRequestReply(HoldRequestResult holdRequest, int requestingOrgID, int answer,
		                                                   int state)
		{
			var doc = new XDocument(
				new XElement("HoldRequestReplyData",
				             new XElement("TxnGroupQualifier", holdRequest.TxnGroupQualifier),
				             new XElement("TxnQualifier", holdRequest.TxnQualifier),
				             new XElement("RequestingOrgID", requestingOrgID),
				             new XElement("Answer", answer),
				             new XElement("State", state)
					)
				);

			var request = new RestRequest(string.Format("public/v1/1033/100/1/holdrequest/{0}", holdRequest.RequestGUID),
			                              Method.PUT);
			request.AddParameter("text/xml", doc.ToString(), ParameterType.RequestBody);

			_client.Authenticator = new PolarisProtectedAuthenticator(ApiUser, ApiKey, token);
			return Execute<HoldRequestReplyData>(request);
		}
	}
}