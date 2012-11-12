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
		private readonly XDocument itemRenewDoc = new XDocument(
			new XElement("ItemsOutActionData",
			             new XElement("Action", "renew"),
			             new XElement("LogonBranchID", 1),
			             new XElement("LogonUserID", 1),
			             new XElement("LogonWorkstationID", 1),
			             new XElement("RenewData",
			                          new XElement("IgnoreOverrideErrors", true))
				)
			);

		/// <summary>
		/// Uses the supplied patron credentials to renew an item.
		/// </summary>
		/// <param name="barcode">The patron's barcode.</param>
		/// <param name="patronPIN">The patron's PIN.</param>
		/// <param name="item_id">The ID of the item to renew, NOT barcode.</param>
		/// <returns>An item containing the result of the item renewal.</returns>
		/// <seealso cref="ItemsOutActionResult"/>
		public ItemsOutActionResult ItemRenew(string barcode, string patronPIN, int item_id)
		{
			var request = new RestRequest
				              {
					              Method = Method.PUT,
					              Resource = string.Format("public/v1/1033/100/1/patron/{0}/itemsout/{1}", barcode, item_id)
				              };
			request.AddParameter("text/xml", itemRenewDoc.ToString(), ParameterType.RequestBody);

			_client.Authenticator = new PolarisPublicAuthenticator(ApiUser, ApiKey, patronPIN);

			return Execute<ItemsOutActionResult>(request);
		}

		/// <summary>
		/// Renews an item for a patron as a staff member.
		/// </summary>
		/// <param name="barcode">The patron's barcode.</param>
		/// <param name="item_id">The ID of the item to renew, NOT barcode.</param>
		/// <returns>An item containing the result of the item renewal.</returns>
		/// <seealso cref="ItemsOutActionResult"/>
		public ItemsOutActionResult ItemRenew(string barcode, int item_id)
		{
			var request = new RestRequest
				              {
					              Method = Method.PUT,
					              Resource = string.Format("public/v1/1033/100/1/patron/{0}/itemsout/{1}", barcode, item_id)
				              };
			request.AddParameter("text/xml", itemRenewDoc.ToString(), ParameterType.RequestBody);

			_client.Authenticator = new PolarisOverrideAuthenticator(ApiUser, ApiKey, token);

			return Execute<ItemsOutActionResult>(request);
		}
	}
}