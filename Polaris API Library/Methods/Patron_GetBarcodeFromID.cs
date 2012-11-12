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
using System.Linq;
using RestSharp;

namespace Clc.Polaris.Api
{
	public partial class PolarisApiClient
	{
		/// <summary>
		/// Gets the barcode for the supplied PatronID.
		/// </summary>
		/// <param name="patronid">The patron's PatronID</param>
		/// <returns>The patron's barcode.</returns>
		public string Patron_GetBarcodeFromID(int patronid)
		{
			var request =
				new RestRequest(string.Format("protected/v1/1033/100/1/{0}/patron/barcode?patronid={1}", token.AccessToken, patronid));
			_client.Authenticator = new PolarisProtectedAuthenticator(ApiUser, ApiKey, token);
			return Execute<GetBarcodeAndPatronIDResult>(request).BarcodeAndPatronIDRows.First().Barcode;
		}
	}
}