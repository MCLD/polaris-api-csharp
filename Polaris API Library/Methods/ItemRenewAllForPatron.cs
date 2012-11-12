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
namespace Clc.Polaris.Api
{
	public partial class PolarisApiClient
	{
		/// <summary>
		/// Uses the supplied patron credentials to renew all of their items.
		/// </summary>
		/// <param name="barcode">The patron's barcode.</param>
		/// <param name="patronPIN">The patron's PIN.</param>
		/// <returns>An item containing the result of the renewal.</returns>
		/// <seealso cref="ItemsOutActionResult"/>
		public ItemsOutActionResult ItemRenewAllForPatron(string barcode, string patronPIN)
		{
			return ItemRenew(barcode, patronPIN, 0);
		}

		/// <summary>
		/// Renews all of a patron's items as a staff member.
		/// </summary>
		/// <param name="barcode">The patron's barcode.</param>
		/// <returns>An item containing the result of the renewal.</returns>
		/// <seealso cref="ItemsOutActionResult"/>
		public ItemsOutActionResult ItemRenewAllForPatron(string barcode)
		{
			return ItemRenew(barcode, 0);
		}
	}
}