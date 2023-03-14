# Demo project for simple jenkins pipeline tests

This is a Jenkins pipeline script that has five stages to checkout code from a GitHub repository, restore NuGet packages, build a .NET application, run tests, and publish the application.

## Here is a breakdown of each stage:

- Github checkout: This stage uses the git step to checkout the code from the specified GitHub repository using the given credentials.

- Nuget Restore: This stage uses the dotnetRestore step to restore NuGet packages for the .NET application.

- Build .Net: This stage uses the dotnetBuild step to build the .NET application with the given configuration and target.

- Test: This stage uses the dotnetTest step to run tests for the .NET application.

- Publish .Net: This stage uses the dotnetPublish step to publish the .NET application with the given configuration.

Overall, this pipeline script automates the process of building, testing, and publishing a .NET application.

Note:- This pipeline script could be used only in .Net core applications
