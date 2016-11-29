# BugGuardian.WebForms
![](https://dbtek.visualstudio.com/_apis/public/build/definitions/31dcc845-6a11-47d7-90a5-1c340cebf0f1/34/badge)

Easily track you Asp.net WebForms exceptions on VSTS and TFS
-------------------------------------------------------
**BugGuardian.WebForms** is an extension for [*BugGuardian*](https://github.com/n3wt0n/BugGuardian) (a library that allows to easily create a Bug or a Task work item on your *Visual Studio Team Services* account or on your on-premises *Team Foundation Server 2015* in the case your application throws an Unhandled Exception) specifically written to support Asp.net WebForms applications. 

It supports projects with .Net Framework 4.0 and above.


###Installation###

The **BugGuardian.WebForms** library is available on [NuGet](https://www.nuget.org/packages/DBTek.BugGuardian.WebForms).
Just search *BugGuardian.WebForms* in the **Package Manager GUI** or run the following command in the **Package Manager Console**:
```
Install-Package DBTek.BugGuardian.WebForms
```

**WARNING**: If you are experiencing an error like *"BugGuardian.WebForms already has a dependency defined for XXX"*, update your NuGet client to the latest version


###Usage###

Refer to the [project documentation](https://github.com/n3wt0n/BugGuardian.WebForms/wiki/Home) to find more information about this library.

Refer to the [BugGuardian project documentation](https://github.com/n3wt0n/BugGuardian/wiki/Home) to find examples about that.


###Support###

If you encounter some issues trying this library, please let me know through the [Issues page](https://github.com/n3wt0n/BugGuardian.WebForms/issues) and I'll fix the problem as soon as possible!


###Credits###
I have to thanks ***Marco Minerva*** ([@marcominerva](https://twitter.com/marcominerva), [https://github.com/marcominerva](https://github.com/marcominerva)) for the suggestion about the Async implementation in the HttpModule.
