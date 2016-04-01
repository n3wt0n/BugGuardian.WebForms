# BugGuardian.WebForms

Easily track you Asp.net WebForms exceptions on VSTS and TFS
-------------------------------------------------------
**BugGuardian.WebForms** is an extension for *BugGuardian* specifically written to support Asp.net WebForms applications. It adds an Action Filter to your application to let you automatically intercept all the exceptions.

**BugGuardian** is a library, written in C# like Shared Project, that allows to easily create a Bug or a Task work item on your *Visual Studio Team Services* account or on your on-premises *Team Foundation Server 2015* in the case your application throws an Unhandled Exception.
It can also be invoked manually in try/catch blocks to keep track of handled exceptions.

It supports projects with .Net Framework 4.0 and above.
It supports also UWP apps (Windows 10) and .Net Core.


###Installation###

The **BugGuardian.WebForms** library will be available on NuGet

**WARNING**: If you are experiencing an error like *"BugGuardian.WebForms already has a dependency defined for XXX"*, update your NuGet client to the latest version


###Usage###

Refer to the [project documentation](https://github.com/n3wt0n/BugGuardian.WebForms/wiki/Home) to find more information about this library.

Refer to the [BugGuardian project documentation](https://github.com/n3wt0n/BugGuardian/wiki/Home) to find examples about that.


###Support###

If you encounter some issues trying this library, please let me know through the [Issues page](https://github.com/n3wt0n/BugGuardian.WebForms/issues) and I'll fix the problem as soon as possible!

