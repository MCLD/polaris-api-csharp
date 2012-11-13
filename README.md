# Polaris API Library for .NET

## Installation

### Via Nuget

	Install-Package PolarisApiLibrary
	
### Sample Usage

#### Sample AppSettings

      <appSettings>
		<!-- The following keys are required in the config file of the base project using the library -->
		<add key="papi_key" value="Your Polaris API Key" />
		<add key="papi_user" value="Your Polaris API User" />
		<add key="papi_hash_hostname" value="https://polprodpac.clcdpc.org/PAPIService/REST/" />
		<add key="papi_request_hostname" value="https://catalog.clcohio.org/PAPIService/REST/" />
		<!-- the active directory username and password to be used to make protected method calls -->
		<add key="staff_username" value="username" />
		<add key="staff_password" value="password" />
		<add key="staff_domain" value="domain" />
	  </appSettings>
	
#### Example Code
	using Clc.Polaris.Api;
	var polaris = new PolarisApiClient();
	var patron = polaris.PatronBasicDataGet("11223344556677", "1234");
	Console.WriteLine("Hello {0} {1}", patron.PatronBasicData.NameFirst, patron.PatronBasicData.NameLast);