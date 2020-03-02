# BugGuardian.WebForms

![Build Status](https://dbtek.visualstudio.com/_apis/public/build/definitions/31dcc845-6a11-47d7-90a5-1c340cebf0f1/34/badge)
[![Release](https://img.shields.io/github/release/n3wt0n/BugGuardian.WebForms.svg)](https://github.com/n3wt0n/BugGuardian.WebForms/releases/latest)
[![License](https://img.shields.io/github/license/n3wt0n/BugGuardian.WebForms.svg)](https://github.com/n3wt0n/BugGuardian.WebForms/blob/master/LICENSE)

## Easily track you ASP.NET Core exceptions on Azure DevOps and TFS

**BugGuardian.WebForms** is an extension for [*BugGuardian*](https://github.com/n3wt0n/BugGuardian) (a library that allows to easily create a Bug or a Task work item on your *Azure DevOps* account or on your on-premises *Azure DevOps Server* and *Team Foundation Server 2015, 2017 and 2018* in the case your application throws an Unhandled Exception) specifically written to support ASP.NET WebForms applications.

It supports projects with .Net Framework 4.5 and above.

### Installation

The **BugGuardian.WebForms** library is available on [NuGet](https://www.nuget.org/packages/DBTek.BugGuardian.WebForms).
Just search *BugGuardian.WebForms* in the **Package Manager GUI** or run the following command in the **Package Manager Console**:

```PowerShell
Install-Package DBTek.BugGuardian.WebForms
```

> **WARNING**: If you are experiencing an error like *"BugGuardian.WebForms already has a dependency defined for XXX"*, update your NuGet client to the latest version

### Usage

Refer to the [project documentation](https://github.com/n3wt0n/BugGuardian.WebForms/wiki/Home) to find more information about this library.

Refer to the [BugGuardian project documentation](https://github.com/n3wt0n/BugGuardian/wiki/Home) to find examples about that.

> **WARNING**: From Dec 9, 2019 Azure DevOps does not support "Alternate Credentials" anymore. Please be sure to use a "Personal Access Token" instead (more info: https://devblogs.microsoft.com/devops/azure-devops-will-no-longer-support-alternate-credentials-authentication/)

### Support

If you encounter some issues trying this library, please let me know through the [Issues page](https://github.com/n3wt0n/BugGuardian.WebForms/issues) and I'll fix the problem as soon as possible!

### Credits

I have to thanks ***Marco Minerva*** ([@marcominerva](https://twitter.com/marcominerva), [https://github.com/marcominerva](https://github.com/marcominerva)) for the suggestion about the Async implementation in the HttpModule.
