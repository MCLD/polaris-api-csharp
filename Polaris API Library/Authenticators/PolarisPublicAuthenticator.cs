﻿#region license
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
using System.Configuration;
using System.Security.Cryptography;
using System.Text;
using RestSharp;

namespace Clc.Polaris.Api
{
	/// <summary>
	/// Used to authenticate Polaris API public methods as a patron using their barcode and PIN.
	/// </summary>
	public class PolarisPublicAuthenticator : IAuthenticator
	{
		private readonly string _apiKey;
		private readonly string _apiUser;
		private readonly string _hashHostName;
		private readonly string _password;

		/// <summary>
		/// Initializes a new authenticator with the supplied values.
		/// </summary>
		/// <param name="apiUser">The API username</param>
		/// <param name="apiKey">The API key for the API username</param>
		/// <param name="patronPIN">The patron's password/PIN</param>
		public PolarisPublicAuthenticator(string apiUser, string apiKey, string patronPIN)
		{
			_apiKey = apiKey;
			_apiUser = apiUser;
			_password = patronPIN;
			_hashHostName = ConfigurationManager.AppSettings["papi_hash_hostname"];
		}

		#region IAuthenticator Members

		/// <summary>
		/// Adds the necessary authentication to the request.
		/// </summary>
		/// <param name="client">The RestClient to authenticate.</param>
		/// <param name="request">The RestClient to authenticate.</param>
		public void Authenticate(IRestClient client, IRestRequest request)
		{
			string url = string.Format("{0}{1}", _hashHostName, request.Resource);
			string gmtTime = DateTime.Now.ToUniversalTime().ToString("R");
			string hash = GetPAPIHash(_apiKey, request.Method.ToString(), url, gmtTime, _password);

			request.AddHeader("PolarisDate", gmtTime);
			request.AddHeader("Authorization", "PWS " + _apiUser + ":" + hash);
		}

		#endregion

		private static string GetPAPIHash(string strAccessKey, string strHTTPMethod, string strURI, string strHTTPDate,
		                                  string strPatronPassword)
		{
			byte[] secretBytes = Encoding.UTF8.GetBytes(strAccessKey);
			var hmac = new HMACSHA1(secretBytes);

			// Computed hash is based on different elements defined by URI

			byte[] dataBytes = strPatronPassword.Length > 0
				                   ? Encoding.UTF8.GetBytes(strHTTPMethod + strURI + strHTTPDate + strPatronPassword)
				                   : Encoding.UTF8.GetBytes(strHTTPMethod + strURI + strHTTPDate);

			byte[] computedHash = hmac.ComputeHash(dataBytes);
			string computedHashString = Convert.ToBase64String(computedHash);

			return computedHashString;
		}
	}
}