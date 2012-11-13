if not exist Download\package\lib\3.5 mkdir Download\package\lib\3.5

copy "Polaris API Library\bin\Release\polaris*" Download\package\lib\3.5\
copy license.txt Download\

tools\nuget.exe update -self
tools\nuget.exe pack PolarisApiLibrary.nuspec -BasePath Download\Package -o Download