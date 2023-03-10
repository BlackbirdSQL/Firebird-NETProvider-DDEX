//
// $License = https://github.com/BlackbirdSQL/NETProvider-DDEX/blob/master/Docs/license.txt
// $Authors = GA Christos (greg@blackbirdsql.org)
//



using System.Windows.Markup;

namespace BlackbirdSql.VisualStudio.Ddex.Configuration;


// =========================================================================================================
//										PackageData Class
//
/// <summary>
/// Container class for all package specific constants
/// </summary>
// =========================================================================================================
static class PackageData
{

	// ---------------------------------------------------------------------------------
	#region Non language based required constant strings
	// ---------------------------------------------------------------------------------


	public const string ServiceName = "BlackbirdSql DDEX 2.0 Provider Object Factory";

	// public const string CodeBase = "%ProgramFiles%\\BlackbirdSql\\BlackbirdDDEX.9.1.0\\BlackbirdSql.VisualStudio.Ddex.dll";


	#endregion Constants





	// ---------------------------------------------------------------------------------
	#region GUIDs
	// ---------------------------------------------------------------------------------


	public const string AssemblyGuid = "D5A9B07D-5302-42A5-9509-F877DEC4BEDB";

	public const string PackageGuid = "c21e1c58-3772-4572-88e9-0f2188268741";
	public const string PackageGuideNET = "7787981E-E42A-412F-A42B-9AD07A7DE169";

	public const string EdmxUIContextRuleGuid = "{e000c7e5-dba5-4682-abe0-7f6ce57b236d}";
	public const string ShellInitializedContextRuleGuid = "{E80EF1CB-6D64-4609-8FAA-FEACFD3BC89F}";

	public const string ProviderGuid = "43015F6E-757F-408B-966E-C2BCE34686BA";
	public const string ProviderGuidNET = "66F5BB69-4C70-4319-8947-A2E0643A4CE";

	public const string ObjectFactoryServiceGuid = "B0640FC7-F798-4CC0-81F9-2587762D4957";
	public const string ObjectFactoryServiceGuidNET = "AE2CB68C-0AA2-46A7-910A-CBDA1464DCB0";


	// WPF Pages 
	public const string WpfDebugOptionsGiud = "7E2D7C87-1FAD-42D1-AE67-4EEA3281E52C";


	#endregion GUIDs





	// ---------------------------------------------------------------------------------
	#region Security tokens
	// ---------------------------------------------------------------------------------


	public const string PublicTokenString = "d39a163eb11ac91a";
	public const string PublicTokenStringNET = "";

	public const string PublicHashString = "002400000480000094000000060200000024000052534131000400000100010099b99763c990a25eb0fad128c99cefa4dd9716e5edd609fcc245d0e19fdbcc5b4ac8b1f33349a0a231cc5d0e7702e8289e29d6f6e28074e3e844b24726c7368151dcfa97d109de847521febfead7937cae2933418583cc97630263d849425645721ef381de3c33ef27d3d01c805a8082721f94d5e664c09390f3a3fbf9faa9ca";
	public const string PublicHashStringNET = "";


	#endregion Security tokens

};