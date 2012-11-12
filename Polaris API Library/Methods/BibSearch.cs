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
using RestSharp.Contrib;

namespace Clc.Polaris.Api
{
	public partial class PolarisApiClient
	{
		/// <summary>
		/// Returns list of bibliographic records that match search criteria supplied in the BibSearchOptions object.
		/// </summary>
		/// <param name="options">The object containing the options for performing the search.</param>
		/// <returns>An object containing a list of Bibliographic Record information that meet search criteria.</returns>
		/// <seealso cref="BibSearchOptions"/>
		/// <seealso cref="BibSearchResult"/>
		public BibSearchResult BibSearch(BibSearchOptions options)
		{
			var request =
				new RestRequest(
					string.Format("public/v1/1300/100/{0}/search/bibs/keyword/{1}?q={2}&sort={3}&page={4}&bibsperpage={5}",
					              options.branch,
					              options.qualifier,
					              HttpUtility.UrlEncode(options.term),
					              options.sort,
					              options.page,
					              options.bibsperpage));
			_client.Authenticator = new PolarisPublicAuthenticator(ApiUser, ApiKey, "");
			return Execute<BibSearchResult>(request);
		}

		/// <summary>
		/// Returns list of bibliographic records that match search criteria.
		/// </summary>
		/// <param name="term">Keyword term you wish to search for.</param>
		/// <param name="branch">Branch you wish to search. Default is 1 for system.</param>
		/// <param name="page">Page you wish to display. Default is 1 for first page.</param>
		/// <param name="bibsperpage">Number of records per page. Default is 10.</param>
		/// <param name="sort">Sort method. Default is most popular.</param>
		/// <returns>An object containing a list of Bibliographic Record information that meet search criteria.</returns>
		/// <seealso cref="BibSearchResult"/>
		/// <seealso cref="SearchSortOptions"/>
		public BibSearchResult BibKeywordSearch(string term, int branch = 1, int page = 1, int bibsperpage = 10,
		                                        SearchSortOptions sort = SearchSortOptions.MP)
		{
			return
				BibSearch(new BibSearchOptions
					          {qualifier = SearchQualifiers.KW, branch = branch, term = term, bibsperpage = bibsperpage, sort = sort});
		}

		/// <summary>
		/// Returns list of bibliographic records that match search criteria.
		/// </summary>
		/// <param name="author">Author you'd like to search for.</param>
		/// <param name="branch">Branch you wish to search. Default is 1 for system.</param>
		/// <param name="page">Page you wish to display. Default is 1 for first page.</param>
		/// <param name="bibsperpage">Number of records per page. Default is 10.</param>
		/// <param name="sort">Sort method. Default is most popular.</param>
		/// <returns>An object containing a list of Bibliographic Record information that meet search criteria.</returns>
		/// <seealso cref="BibSearchResult"/>
		/// <seealso cref="SearchSortOptions"/>
		public BibSearchResult BibAuthorSearch(string author, int branch = 1, int page = 1, int bibsperpage = 10,
		                                       SearchSortOptions sort = SearchSortOptions.MP)
		{
			return
				BibSearch(new BibSearchOptions
					          {qualifier = SearchQualifiers.AU, branch = branch, term = author, bibsperpage = bibsperpage, sort = sort});
		}

		/// <summary>
		/// Returns list of bibliographic records that match search criteria.
		/// </summary>
		/// <param name="title">Title you'd like to search for.</param>
		/// <param name="branch">Branch you wish to search. Default is 1 for system.</param>
		/// <param name="page">Page you wish to display. Default is 1 for first page.</param>
		/// <param name="bibsperpage">Number of records per page. Default is 10.</param>
		/// <param name="sort">Sort method. Default is most popular.</param>
		/// <returns>An object containing a list of Bibliographic Record information that meet search criteria.</returns>
		/// <seealso cref="BibSearchResult"/>
		/// <seealso cref="SearchSortOptions"/>
		public BibSearchResult BibTitleSearch(string title, int branch = 1, int page = 1, int bibsperpage = 10,
		                                      SearchSortOptions sort = SearchSortOptions.MP)
		{
			return
				BibSearch(new BibSearchOptions
					          {qualifier = SearchQualifiers.TI, branch = branch, term = title, bibsperpage = bibsperpage, sort = sort});
		}
	}
}