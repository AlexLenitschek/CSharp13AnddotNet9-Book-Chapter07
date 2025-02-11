using System.Globalization; // To use CultureInfo.
using System.Reflection; // To use AssemblyName.
using System.Reflection.Emit; // To use AssemblyBuilder.

WriteLine("This is an Ahead-Of-Time (AOT) compiled console app.");
WriteLine("Current culture: {0}", CultureInfo.CurrentCulture.DisplayName);
WriteLine("OS version: {0}", Environment.OSVersion);

Write("Press any key to exit.");
ReadKey(intercept: true); // Do not output the key that was pressed.

#region Publishing a native AOT project
// The following has the Tag [RequiresDynamicCodeAttribute] which can break when AOT compiling.
//AssemblyBuilder ab = AssemblyBuilder.DefineDynamicAssembly
//  (new AssemblyName("My Assembly"), AssemblyBuilderAccess.Run);
#endregion