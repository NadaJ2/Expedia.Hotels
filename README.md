## Build Status
Stable (master):
[![Build Status](https://travis-ci.org/NadaJ2/Expedia.Hotels.svg?branch=master)](https://travis-ci.org/NadaJ2/Expedia.Hotels)

The Application built using .Net core 2.0 Framework C# language.
To get and build the code in local sandbox please follow the instruction below:

# Prerequisites:
The following prerequisites are required:
- [Visual Studio 2017 15.5.7](https://www.visualstudio.com/downloads/)
- [.NET Core 2.0 SDK](https://www.microsoft.com/net/download/windows)

# Clone the repository
```
git clone https://github.com/NadaJ2/Expedia.Hotels.git 
```

### Build from Visual Studio
1. Just open the .sln file. (After running the build initialization from the command line and updating your Path if needed.)
2. NuGet packages will already have been restored, so you can switch off auto package restore in Visual Studio.

### Build from Command line
 - Open your cmd
 - To build the application
```
dotnet build
```
- To restore the packages
```
dotnet restore
```
- To run the application, this command will provide you the url to browse via your browser
```
dotnet run
```
[more details](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-build?tabs=netcore2x)
