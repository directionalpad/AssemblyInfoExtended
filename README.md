# AssemblyInfoExtended

[![NuGet](https://img.shields.io/nuget/v/AssemblyInfoExtended.svg?maxAge=2592000?style=plastic)](https://www.nuget.org/packages/AssemblyInfoExtended)



AssemblyInfoExtended is a .NET library that provdes additional attributes for use in your applications AssemblyInfo.cs.

### Requirements

AssemblyInfoExtended is built against .NET 4.6.1 and requires the .NET Framework version 4.6.1 or later.

### Installation

A NuGet package is available. To install it simply use `Install-Package AssemblyInfoExtended` from the NuGet console. In addition you can clone the repository and compile it locally for use in your project or add it as a git submodule to your existing project.

### Usage

AssemblyInfoExtended adds new attribute tags directly to the `System.Reflection` namespace. This means that by simply adding a 
reference to AssemblyInfoExtended.dll to your project all of the new `[assembly: ` attribute tags will become available to for usage.

Currently AssemblyInfoExtended provides the following additional attributes:

##### AssemblyCommitHash
Provides a field that allows you to insert the full or partial commit hash that your application is being built from.

Example
```[assembly: AssemblyCommitHash("a3b6d0d7")]```


##### AssemblyInternalVersion
Provides a field that allows you to use an internal versioning number or system for a given application. This can be useful 
if your company or project has internal build numbers that are different for purposes of testing or QA that does not reflect
the applications publicly facing/consumer version.

Example
```[assembly: AssemblyInternalVersion("1.0.4.9")]```


### License

AssemblyInfoExtended is provided under the MIT License. See [LICENSE](https://github.com/directionalpad/AssemblyInfoExtended/blob/master/LICENSE) for more information.

