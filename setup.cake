#load nuget:https://www.myget.org/F/cake-contrib/api/v2?package=Cake.Recipe&version=0.3.0-unstable0371

Environment.SetVariableNames();

BuildParameters.SetParameters(context: Context,
                            buildSystem: BuildSystem,
                            sourceDirectoryPath: "./src",
                            title: "Cake.Terraform",
                            repositoryOwner: "cake-contrib",
                            repositoryName: "Cake.Terraform",
                            appVeyorAccountName: "cake-contrib",
                            webHost: "cake-contrib.github.io",
                            webLinkRoot: "Cake.Terraform",
                            webBaseEditUrl: "https://github.com/cake-contrib/Cake.Terraform/tree/develop/docs/input"
                            );

BuildParameters.PrintParameters(Context);

ToolSettings.SetToolSettings(context: Context,
                            dupFinderExcludePattern: new string[] {
                                BuildParameters.RootDirectoryPath + "/src/Cake.Terraform.Tests/**/*.cs"
                            },
                            dupFinderThrowExceptionOnFindingDuplicates: false,
                            testCoverageFilter: "+[*]* -[xunit.*]* -[Cake.Core]* -[Cake.Testing]* -[*.Tests]* ",
                            testCoverageExcludeByAttribute: "*.ExcludeFromCodeCoverage*",
                            testCoverageExcludeByFile: "*/*Designer.cs;*/*.g.cs;*/*.g.i.cs");

Build.RunDotNetCore();
