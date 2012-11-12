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
	/// <summary>
	/// The available search fields.
	/// </summary>
	public enum SearchQualifiers
	{
		/// <summary>
		/// Keyword
		/// </summary>
		KW,

		/// <summary>
		/// Title
		/// </summary>
		TI,

		/// <summary>
		/// Author
		/// </summary>
		AU,

		/// <summary>
		/// Subject
		/// </summary>
		SU,

		/// <summary>
		/// General notes
		/// </summary>
		NOTE,

		/// <summary>
		/// Publisher
		/// </summary>
		PUB,

		/// <summary>
		/// Genre
		/// </summary>
		GENRE,

		/// <summary>
		/// Series
		/// </summary>
		SE,

		/// <summary>
		/// International Standard Book Number
		/// </summary>
		ISBN,

		/// <summary>
		/// International Standard Serial Number
		/// </summary>
		ISSN,

		/// <summary>
		/// Library of Congress Control Number
		/// </summary>
		LCCN,

		/// <summary>
		/// Publisher's number
		/// </summary>
		PN,

		/// <summary>
		/// Library of Congress classification
		/// </summary>
		LC,

		/// <summary>
		/// Dewey classification
		/// </summary>
		DD,

		/// <summary>
		/// Local call number
		/// </summary>
		LOCAL,

		/// <summary>
		/// Superintendent of Documents classification number
		/// </summary>
		SUDOC,

		/// <summary>
		/// Identifier for scientific and technical periodicals
		/// </summary>
		CODEN,

		/// <summary>
		/// Standard Technical Report Number
		/// </summary>
		STRN,

		/// <summary>
		/// Control Number
		/// </summary>
		CN,

		/// <summary>
		/// Barcode
		/// </summary>
		BC
	}
}