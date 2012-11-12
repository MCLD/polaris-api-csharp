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
		/// Gets the information for the supplied BibliographicRecordID.
		/// </summary>
		/// <param name="bibID">The BibliographicRecordID for the record you wish to retrieve.</param>
		/// <returns>An object containing Bibliographic Record information.</returns>
		/// <seealso cref="BibGetResult"/>
		public BibGetResult BibGet(int bibID)
		{
			var request = new RestRequest(string.Format("public/v1/1033/100/1/bib/{0}", bibID));
			_client.Authenticator = new PolarisPublicAuthenticator(ApiUser, ApiKey, "");
			return Execute<BibGetResult>(request);
		}
	}
}