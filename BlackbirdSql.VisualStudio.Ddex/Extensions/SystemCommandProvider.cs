// $License = https://github.com/BlackbirdSQL/NETProvider-DDEX/blob/master/Docs/license.txt
// $Authors = GA Christos (greg@blackbirdsql.org)

using System.Runtime.InteropServices;

using BlackbirdSql.Common.Extensions.Commands;



namespace BlackbirdSql.VisualStudio.Ddex.Extensions
{
	[Guid(DataToolsCommands.SystemQueryCommandProviderGuid)]


	// =========================================================================================================
	//										SystemQueryCommandProvider Class
	//
	/// <summary>
	/// Implements the new query command on System Object nodes
	/// </summary>
	// =========================================================================================================
	internal class SystemCommandProvider : AbstractCommandProvider
	{

		/// <summary>
		/// Identifies this <see cref="AbstractCommandProvider"/> as spawned off of a System Object SE node
		/// </summary>
		protected override DataToolsCommands.DataObjectType CommandObjectType
		{
			get { return DataToolsCommands.DataObjectType.System; }
		}

	}
}
