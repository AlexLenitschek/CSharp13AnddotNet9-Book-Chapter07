using System.Xml.Linq; // To use XDocument
using System; // To use String.
using Packt.Shared;


XDocument doc = new();

#region Relating C# keywords to .NET types
// Capital Letters symbolize the .NET types from System.
// Use the C# types which are denoted by non-capital letters.
string s1 = "Hello";
String s2 = "World!";
WriteLine($"{s1} {s2}");
WriteLine();
#endregion

#region Testing your class library package

Write("Enter a color value in hex: ");
string? hex = ReadLine();
WriteLine("Is {0} a valid color value? {1}",
  arg0: hex, arg1: hex.IsValidHex());

Write("Enter a XML element: ");
string? xmlTag = ReadLine();
WriteLine("Is {0} a valid XML element? {1}",
  arg0: xmlTag, arg1: xmlTag.IsValidXmlTag());

Write("Enter a password: ");
string? password = ReadLine();
WriteLine("Is {0} a valid password? {1}",
  arg0: password, arg1: password.IsValidPasswort());

#endregion
