# Polaris API Library for .NET

The Polaris API library has been tested with Polaris 4.0 and Polaris 4.1, and requires .NET 3.5. Complete documentation for the Polaris API can be found on the [Polaris Developer's Network][1]

## Installation Via Nuget

	Install-Package PolarisApiLibrary
	
## Sample Usage

### Sample AppSettings section of App.Config/Web.Config

      <appSettings>
		<!-- The following keys are required in the config file of the base project using the library -->
		<add key="papi_key" value="Your Polaris API Key" />
		<add key="papi_user" value="Your Polaris API User" />
		<add key="papi_hash_hostname" value="https://polprodpac.clcdpc.org/PAPIService/REST/" /> <!-- Internal PAC URL -->
		<add key="papi_request_hostname" value="https://catalog.clcohio.org/PAPIService/REST/" /> <!-- External PAC URL -->
		<!-- The active directory username and password to be used to make protected method calls -->
		<!-- These values are only required if you wish to make protected method calls -->
		<add key="staff_username" value="username" />
		<add key="staff_password" value="password" />
		<add key="staff_domain" value="domain" />
	  </appSettings>
	
### Example Code

```csharp
using Clc.Polaris.Api;
var polaris = new PolarisApiClient();
var patron = polaris.PatronBasicDataGet("11223344556677", "1234");
Console.WriteLine("Hello {0} {1}", patron.PatronBasicData.NameFirst, patron.PatronBasicData.NameLast);
```

[1]: http://developer.polarislibrary.com/