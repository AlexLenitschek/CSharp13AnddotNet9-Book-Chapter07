WriteLine("I can run everywhere!");
WriteLine($"OS Version is {Environment.OSVersion}.");

if (OperatingSystem.IsMacOS())
{
    WriteLine("I am macOS.");
}
else if (OperatingSystem.IsWindowsVersionAtLeast(major: 10, build: 22000))
{
    WriteLine("I am Windows 11.");
}
else if (OperatingSystem.IsWindowsVersionAtLeast(major: 10))
{
    WriteLine("I am Windows 10.");
}
else
{
    WriteLine("I am some other mysterious OS.");
}
WriteLine("Press any key to stop me.");
ReadKey(intercept: true); // Do not output the key that was pressed.

#region Publishing
/*
Use these to publish for a specific OS. self-contained such that .NET is not needed to be installed on target PC.
dotnet publish -c Release -r win-x64 --self-contained
dotnet publish -c Release -r osx-arm64 --self-contained
dotnet publish -c Release -r linux-x64 --self-contained

Use this if you want the published file to be inside Files instead of a Folder.
Returns one .exe which is the executable and one .pdb which is a program debug database.
dotnet publish -c Release -r win-x64 --self-contained /p:PublishSingleFile = true

add this in the<PropertyGroup> in the.csproj to embed the .pdb in the.exe and only return the.exe
<DebugType> embedded</DebugType>

Add this to the .csproj to enable trimming which removes unused assemblies, types and members.
<PublishTrimmed>true</PublishTrimmed> <!--Enable trimming.-->
Make the trimming partial by also adding:
<TrimMode>partial</TrimMode> <!--Set assembly-level trimming.-->

or add a flag when publishing
dotnet publish ... -p:PublishTrimmed=true
Make the trimming partial by also adding the tag:
dotnet publish ... -p:PublishTrimmed=true -p:TrimMode=partial


*/
#endregion