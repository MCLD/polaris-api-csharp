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
	/// The available search sorting options.
	/// </summary>
	public enum SearchSortOptions
	{
		/// <summary>
		/// Relevance
		/// </summary>
		RELEVANCE,

		/// <summary>
		/// Most Popular
		/// </summary>
		MP,

		/// <summary>
		/// Author
		/// </summary>
		AU,

		/// <summary>
		/// Title
		/// </summary>
		TI,

		/// <summary>
		/// Call Number
		/// </summary>
		CALL,

		/// <summary>
		/// Publication Date Descending
		/// </summary>
		PD,

		/// <summary>
		/// Author then Title
		/// </summary>
		AUTI,

		/// <summary>
		/// Author then Publication Date Descending
		/// </summary>
		AUPD,

		/// <summary>
		/// Title then Author
		/// </summary>
		TIAU,

		/// <summary>
		/// Title then Publication Date Descending
		/// </summary>
		TIPD,

		/// <summary>
		/// Publication Date Descending then Author
		/// </summary>
		PDAU,

		/// <summary>
		/// Publication Date Descending then Title
		/// </summary>
		PDTI,

		/// <summary>
		/// Call Number then Author
		/// </summary>
		CALLAU,

		/// <summary>
		/// Call Number then Title
		/// </summary>
		CALLTI,

		/// <summary>
		/// Call Number then Publication Date Descending
		/// </summary>
		CALLPD
	}
}