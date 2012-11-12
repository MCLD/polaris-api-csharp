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
		private PatronItemsOutGetResult _PatronItemsOutGet(string barcode, string patronPIN, string status)
		{
			var request = new RestRequest(string.Format("public/v1/1033/100/1/patron/{0}/itemsout/{1}", barcode, status));
			request.AddUrlSegment("AccessToken", token.AccessToken);

			_client.Authenticator = new PolarisPublicAuthenticator(ApiUser, ApiKey, patronPIN);
			return Execute<PatronItemsOutGetResult>(request);
		}

		private PatronItemsOutGetResult _PatronItemsOutGet(string barcode, string status)
		{
			var request = new RestRequest(string.Format("public/v1/1033/100/1/patron/{0}/itemsout/{1}", barcode, status));
			request.AddUrlSegment("AccessToken", token.AccessToken);

			_client.Authenticator = new PolarisOverrideAuthenticator(ApiUser, ApiKey, token);
			return Execute<PatronItemsOutGetResult>(request);
		}

		/// <summary>
		/// Gets all items out for the supplied patron barcode and PIN.
		/// </summary>
		/// <param name="barcode">The patron's barcode.</param>
		/// <param name="patronPIN">The patron's PIN.</param>
		/// <returns>PatronItemsOutGetResult</returns>
		/// <seealso cref="PatronItemsOutGetResult"/>
		public PatronItemsOutGetResult PatronItemsOutGetAll(string barcode, string patronPIN)
		{
			return _PatronItemsOutGet(barcode, patronPIN, "all");
		}

		/// <summary>
		/// Gets all items out for the supplied patron barcode.
		/// </summary>
		/// <param name="barcode">The patron's barcode.</param>
		/// <returns>PatronItemsOutGetResult</returns>
		/// <seealso cref="PatronItemsOutGetResult"/>
		public PatronItemsOutGetResult staff_PatronItemsOutGet(string barcode)
		{
			return _PatronItemsOutGet(barcode, "all");
		}

		/// <summary>
		/// Gets overdue items out for the supplied patron barcode and PIN.
		/// </summary>
		/// <param name="barcode">The patron's barcode.</param>
		/// <param name="patronPIN">The patron's PIN.</param>
		/// <returns>PatronItemsOutGetResult</returns>
		/// <seealso cref="PatronItemsOutGetResult"/>
		public PatronItemsOutGetResult PatronOverdueItemsOutGet(string barcode, string patronPIN)
		{
			return _PatronItemsOutGet(barcode, patronPIN, "overdue");
		}

		/// <summary>
		/// Gets overdue items out for the supplied patron barcode.
		/// </summary>
		/// <param name="barcode">The patron's barcode.</param>
		/// <returns>PatronItemsOutGetResult</returns>
		/// <seealso cref="PatronItemsOutGetResult"/>
		public PatronItemsOutGetResult staff_PatronOverdueItemsOutGet(string barcode)
		{
			return _PatronItemsOutGet(barcode, "overdue");
		}

		/// <summary>
		/// Gets lost items out for the supplied patron barcode and PIN.
		/// </summary>
		/// <param name="barcode">The patron's barcode.</param>
		/// <param name="patronPIN">The patron's PIN.</param>
		/// <returns>PatronItemsOutGetResult</returns>
		/// <seealso cref="PatronItemsOutGetResult"/>
		public PatronItemsOutGetResult PatronLostItemsOutGet(string barcode, string patronPIN)
		{
			return _PatronItemsOutGet(barcode, patronPIN, "Lost");
		}

		/// <summary>
		/// Gets lost items out for the supplied patron barcode.
		/// </summary>
		/// <param name="barcode">The patron's barcode.</param>
		/// <returns>PatronItemsOutGetResult</returns>
		/// <seealso cref="PatronItemsOutGetResult"/>
		public PatronItemsOutGetResult staff_PatronLostItemsOutGet(string barcode)
		{
			return _PatronItemsOutGet(barcode, "Lost");
		}
	}
}