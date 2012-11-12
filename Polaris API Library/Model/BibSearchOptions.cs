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
	/// Contains the parameters needed to perform a bibliographic search.
	/// </summary>
	public class BibSearchOptions
	{
		/// <summary>
		/// Creates a new instance of the BibSearchOptions object and populates necessary fields with defaults.
		/// </summary>
		public BibSearchOptions()
		{
			qualifier = SearchQualifiers.KW;
			branch = 1;
			page = 1;
			bibsperpage = 10;
			sort = SearchSortOptions.MP;
		}

		/// <summary>
		/// Area of the record to search.
		/// </summary>
		/// <seealso cref="SearchQualifiers"/>
		public SearchQualifiers qualifier { get; set; }

		/// <summary>
		/// Search term.
		/// </summary>
		public string term { get; set; }

		/// <summary>
		/// The branch to search. Defaults to system.
		/// </summary>
		public int branch { get; set; }

		/// <summary>
		/// Which page of results to return. Defaults to 1, for first page.
		/// </summary>
		public int page { get; set; }

		/// <summary>
		/// Number of records per page. Defaults to 10;
		/// </summary>
		public int bibsperpage { get; set; }

		/// <summary>
		/// How to sort the results. Defaults to most popular.
		/// </summary>
		public SearchSortOptions sort { get; set; }
	}
}