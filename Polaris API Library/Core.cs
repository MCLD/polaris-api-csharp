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
using System.Configuration;
using System.Reflection;
using System.Xml.Linq;
using RestSharp;

namespace Clc.Polaris.Api
{
	/// <summary>
	/// Polaris API wrapper
	/// </summary>
	public partial class PolarisApiClient
	{
		private static ProtectedToken _token;
		private readonly RestClient _client;

		/// <summary>
		/// Initializes a new client with the credentials supplied in the web.config
		/// </summary>
		public PolarisApiClient()
		{
			ApiUser = ConfigurationManager.AppSettings["papi_user"];
			ApiKey = ConfigurationManager.AppSettings["papi_key"];
			RequestHostName = ConfigurationManager.AppSettings["papi_request_hostname"];
			StaffUsername = ConfigurationManager.AppSettings["staff_username"];
			StaffPassword = ConfigurationManager.AppSettings["staff_password"];
			StaffDomain = ConfigurationManager.AppSettings["staff_domain"];

			var assembly = Assembly.GetExecutingAssembly();
			var assemblyName = new AssemblyName(assembly.FullName);
			var version = assemblyName.Version;

			//PatronData p = new PatronData();

			_client = new RestClient
				          {
					          UserAgent = "clc-polaris-library/" + version, 
							  BaseUrl = RequestHostName
				          };
		}

		private string RequestHostName { get; set; }

		private string ApiUser { get; set; }
		private string ApiKey { get; set; }

		private string StaffUsername { get; set; }
		private string StaffPassword { get; set; }
		private string StaffDomain { get; set; }

		private ProtectedToken token
		{
			get
			{
				_token = _token == null
					         ? _token = GetProtectedMethodToken()
					         : _token.AuthExpDate.Date == DateTime.Today ? GetProtectedMethodToken() : _token;
				return _token;
			}
		}

		/// <summary>
		/// Executes the supplied request and returns a deserialized object of the supplied type.
		/// </summary>
		/// <typeparam name="T">The object that represents the data contained in the response.</typeparam>
		/// <param name="request">The request to be executed.</param>
		/// <returns>The response to request deserialized to an object of type T</returns>
		public T Execute<T>(RestRequest request) where T : new()
		{
			var response = _client.Execute<T>(request);

			if (response.Data != null)
			{
				if (response.Data.GetType().BaseType == typeof(PolarisApiResponse))
				{
					var data = response.Data as PolarisApiResponse;
					data.RawResponse = response;
					return (T)Convert.ChangeType(data, typeof(T));
				}
			}

			return response.Data;
		}

		/// <summary>
		/// Uses the staff credentials supplied in the web.config file to build a protected method token.
		/// </summary>
		/// <returns>A ProtectedToken object containing the necessary parameters to create protected method calls.</returns>
		/// <seealso cref="ProtectedToken"/>
		private ProtectedToken GetProtectedMethodToken()
		{
			//Create request XML document
			var doc = new XDocument(
				new XElement("AuthenticationData",
				             new XElement("Domain", StaffDomain),
				             new XElement("Username", StaffUsername),
				             new XElement("Password", StaffPassword)
					)
				);

			var request = new RestRequest("protected/v1/1033/100/1/authenticator/staff", Method.POST);
			request.AddParameter("text/xml", doc.ToString(), ParameterType.RequestBody);
			_client.Authenticator = new PolarisPublicAuthenticator(ApiUser, ApiKey, "");

			return Execute<ProtectedToken>(request);
		}
	}
}