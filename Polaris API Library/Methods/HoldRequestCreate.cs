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
		/// Places a hold request on the Bibliographic Record for the Patron as supplied in the HoldRequestCreateParams object. This method places the hold as a patron.
		/// </summary>
		/// <param name="holdParams">The object containing all of the possible options for creating the hold request.</param>
		/// <param name="patronPIN">The patron's PIN.</param>
		/// <returns>An object containing the hold request creation result.</returns>
		/// <seealso cref="HoldRequestCreateParams"/>
		/// <seealso cref="HoldRequestResult"/>
		public HoldRequestResult PatronHoldRequestCreate(HoldRequestCreateParams holdParams, string patronPIN)
		{
			Require.Argument("PatronID", holdParams.PatronID);
			Require.Argument("BibID", holdParams.BibID);

			string xml = GenerateHoldRequestXMLDocument(holdParams);

			var request = new RestRequest("public/v1/1033/100/1/holdrequest", Method.POST);
			request.AddParameter("text/xml", xml, ParameterType.RequestBody);

			_client.Authenticator = new PolarisPublicAuthenticator(ApiUser, ApiKey, patronPIN);
			return Execute<HoldRequestResult>(request);
		}

		/// <summary>
		/// Places a Bibliographic Record on hold for a Patron. This method places the hold as a patron.
		/// </summary>
		/// <param name="patronID">The patron's PatronID, NOT barcode.</param>
		/// <param name="patronPIN">The patron's PIN</param>
		/// <param name="bibID">The BibliographicRecordID of the Bibliographic Record being placed on hold.</param>
		/// <param name="pickupLocation">OrganizationID of the location where the hold will be picked up.</param>
		/// <param name="requestingOrgID">OrganizationID of the location where the hold is being placed.</param>
		/// <param name="notes">Notes you wish to associate with the hold.</param>
		/// <param name="activationDate">The date the hold becomes active.</param>
		/// <returns>An object containing the hold request creation result.</returns>
		/// <seealso cref="HoldRequestCreateParams"/>
		/// <seealso cref="HoldRequestResult"/>
		public HoldRequestResult PatronHoldRequestCreate(int patronID, string patronPIN, int bibID, int pickupLocation,
		                                                 int requestingOrgID, string notes = "",
		                                                 DateTime activationDate = default(DateTime))
		{
			activationDate = activationDate == default(DateTime) ? DateTime.Today : activationDate;

			var holdParams = new HoldRequestCreateParams
				                 {
					                 PatronID = patronID,
					                 BibID = bibID,
					                 PickupOrgID = pickupLocation,
					                 ActivationDate = activationDate,
					                 RequestingOrgID = requestingOrgID,
					                 PatronNotes = notes
				                 };

			return PatronHoldRequestCreate(holdParams, patronPIN);
		}

		/// <summary>
		/// Places a hold request on the Bibliographic Record for the Patron as supplied in the HoldRequestCreateParams object. This method places the hold as a staff member.
		/// </summary>
		/// <param name="holdParams">The object containing all of the possible options for creating the hold request.</param>
		/// <returns>An object containing the hold request creation result.</returns>
		/// <seealso cref="HoldRequestCreateParams"/>
		/// <seealso cref="HoldRequestResult"/>
		public HoldRequestResult staff_HoldRequestCreate(HoldRequestCreateParams holdParams)
		{
			Require.Argument("PatronID", holdParams.PatronID);
			Require.Argument("BibID", holdParams.BibID);

			string xml = GenerateHoldRequestXMLDocument(holdParams);

			var request = new RestRequest("public/v1/1033/100/1/holdrequest", Method.POST);
			request.AddParameter("text/xml", xml, ParameterType.RequestBody);

			_client.Authenticator = new PolarisOverrideAuthenticator(ApiUser, ApiKey, token);
			return Execute<HoldRequestResult>(request);
		}

		/// <summary>
		/// Places a Bibliographic Record on hold for a Patron. This method places the hold as a staff member.
		/// </summary>
		/// <param name="patronID">The patron's PatronID, NOT barcode.</param>
		/// <param name="bibID">The BibliographicRecordID of the Bibliographic Record being placed on hold.</param>
		/// <param name="pickupLocation">OrganizationID of the location where the hold will be picked up.</param>
		/// <param name="requestingOrgID">OrganizationID of the location where the hold is being placed.</param>
		/// <param name="notes">Notes you wish to associate with the hold.</param>
		/// <param name="activationDate">The date the hold becomes active.</param>
		/// <returns>An object containing the hold request creation result.</returns>
		/// <seealso cref="HoldRequestCreateParams"/>
		/// <seealso cref="HoldRequestResult"/>
		public HoldRequestResult staff_HoldRequestCreate(int patronID, int bibID, int pickupLocation, int requestingOrgID,
		                                                 string notes = "", DateTime activationDate = default(DateTime))
		{
			activationDate = activationDate == default(DateTime) ? DateTime.Today : activationDate;

			var holdParams = new HoldRequestCreateParams
				                 {
					                 PatronID = patronID,
					                 BibID = bibID,
					                 PickupOrgID = pickupLocation,
					                 ActivationDate = activationDate,
					                 RequestingOrgID = requestingOrgID,
					                 PatronNotes = notes
				                 };

			return staff_HoldRequestCreate(holdParams);
		}

		private string GenerateHoldRequestXMLDocument(HoldRequestCreateParams holdParams)
		{
			var doc = new XDocument();
			var root = new XElement("HoldRequestCreateData");

			root.Add(new XElement("PatronID", holdParams.PatronID));
			root.Add(new XElement("BibID", holdParams.BibID));
			root.Add(new XElement("ItemBarcode", holdParams.ItemBarcode ?? ""));
			root.Add(new XElement("VolumeNumber", holdParams.VolumeNumber ?? ""));
			root.Add(new XElement("Designation", holdParams.Designation ?? ""));
			root.Add(new XElement("PickupOrgID", holdParams.PickupOrgID));
			root.Add(new XElement("IsBorrowByMail", holdParams.IsBorrowByMail));
			root.Add(new XElement("PatronNotes", holdParams.PatronNotes));
			root.Add(new XElement("ActivationDate", holdParams.ActivationDate.ToString("yyyy-MM-dd")));
			root.Add(new XElement("WorkstationID", holdParams.WorkstationID));
			root.Add(new XElement("UserID", holdParams.UserID));
			root.Add(new XElement("RequestingOrgID", holdParams.RequestingOrgID));
			root.Add(new XElement("TargetGUID", holdParams.TargetGUID ?? new Guid()));

			doc.Add(root);

			return doc.ToString();
		}
	}
}