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
		/// Determines whether the supplied barcode and PIN combination is valid.
		/// </summary>
		/// <param name="barcode">The patron's barcode.</param>
		/// <param name="patronPIN">The patron's PIN.</param>
		/// <returns>PatronValidateResult</returns>
		/// <seealso cref="PatronValidateResult"/>
		public PatronValidateResult PatronValidate(string barcode, string patronPIN)
		{
			var request = new RestRequest(string.Format("public/v1/1033/100/1/patron/{0}", barcode));
			_client.Authenticator = new PolarisPublicAuthenticator(ApiUser, ApiKey, patronPIN);
			return Execute<PatronValidateResult>(request);
		}

		/// <summary>
		/// Determines whether the supplied barcode is a valid patron barcode.
		/// </summary>
		/// <param name="barcode">The patron's barcode.</param>
		/// <returns>PatronValidateResult</returns>
		/// <seealso cref="PatronValidateResult"/>
		public PatronValidateResult staff_PatronValidate(string barcode)
		{
			var request = new RestRequest(string.Format("public/v1/1033/100/1/patron/{0}", barcode));
			_client.Authenticator = new PolarisOverrideAuthenticator(ApiUser, ApiKey, token);
			return Execute<PatronValidateResult>(request);
		}
	}
}