# Polaris API Library for .NET

## Installation

### Via Nuget

	Install-Package PolarisApiLibrary
	
### Sample Usage

#### Required Web.config AppSettings

	##### Required API components
	papi_key - Your Polaris API key
    papi_user - The Polaris API user for your API key
    papi_hash_hostname - The hostname to be used to build the Polaris API hashes
    papi_request_hostname - The hostname to be used to execute the Polaris API requests
	
	##### Staff account to be used to create protected requests
    staff_username
    staff_password
    staff_domain
	
#### Example Code
	using Clc.Polaris.Api;
	var polaris = new PolarisApiClient();
	var patron = polaris.PatronBasicDataGet("11223344556677", "1234");
	Console.WriteLine("Hello {0} {1}", patron.PatronBasicData.NameFirst, patron.PatronBasicData.NameLast);