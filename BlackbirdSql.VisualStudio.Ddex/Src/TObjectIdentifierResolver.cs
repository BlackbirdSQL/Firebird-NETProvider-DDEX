/*
 *  Visual Studio DDEX Provider for FirebirdClient (BlackbirdSql)
 * 
 *     The contents of this file are subject to the Initial 
 *     Developer's Public License Version 1.0 (the "License"); 
 *     you may not use this file except in compliance with the 
 *     License. You may obtain a copy of the License at 
 *     http://www.blackbirdsql.org/index.php?op=doc&id=idpl
 *
 *     Software distributed under the License is distributed on 
 *     an "AS IS" basis, WITHOUT WARRANTY OF ANY KIND, either 
 *     express or implied.  See the License for the specific 
 *     language governing rights and limitations under the License.
 * 
 *  Copyright (c) 2023 GA Christos
 *  All Rights Reserved.
 *   
 *  Contributors:
 *    GA Christos
 */

using System;
using Microsoft.VisualStudio.Data.Framework;
using Microsoft.VisualStudio.Data.Services;

using BlackbirdSql.Common;
using BlackbirdSql.VisualStudio.Ddex.Schema;



namespace BlackbirdSql.VisualStudio.Ddex;

internal class TObjectIdentifierResolver : DataObjectIdentifierResolver
{
	#region � Private Fields �

	#endregion

	#region � Constructors �

	public TObjectIdentifierResolver() : base()
	{
		Diag.Trace();
	}

	public TObjectIdentifierResolver(IVsDataConnection connection) : base(connection)
	{
		Diag.Trace();
	}

	#endregion

	#region � Methods �

	public override object[] ContractIdentifier(string typeName, object[] fullIdentifier)
	{
		Diag.Trace();
		if (typeName == null)
		{
			Diag.Dug(true, "Null argument: typeName");
			throw new ArgumentNullException("typeName");
		}

		/*
		string str = "";

		if (fullIdentifier != null)
		{
			foreach (object item in fullIdentifier)
			{
				str += (item != null ? item.ToString() : "null") + ", ";
			}
		}
		Diag.Trace(String.Format("typeName: {0} Identifiers: {1}", typeName, str));
		*/

		if (typeName == DslObjectTypes.Root)
		{
			return base.ContractIdentifier(typeName, fullIdentifier);
		}


		int length = this.GetIdentifierLength(typeName);
		if (length == -1)
		{
			Diag.Dug(true, "Not supported");
			throw new NotSupportedException();
		}
		object[] identifier = new object[length];

		fullIdentifier?.CopyTo(identifier, length - fullIdentifier.Length);

		if (identifier.Length > 0)
		{
			identifier[0] = null;
		}

		if (identifier.Length > 1)
		{
			identifier[1] = null;
		}

		return identifier;
	}

	public override object[] ExpandIdentifier(string typeName, object[] partialIdentifier)
	{
		Diag.Trace();
		// Diag.Trace(String.Format("ExpandIdentifier({0},...)", typeName));

		if (typeName == null)
		{
			Diag.Dug(true, "Null argument: typeName");
			throw new ArgumentNullException("typeName");
		}

		int length = this.GetIdentifierLength(typeName);
		if (length == -1)
		{
			Diag.Dug(true, "Not supported");
			throw new NotSupportedException();
		}
		// Create an identifier array of the correct full length based on
		// the object type
		object[] identifier = new object[length];

		// If the input identifier is not null, copy it to the full
		// identifier array.  If the input identifier's length is less
		// than the full length we assume the more specific parts are
		// specified and thus copy into the rightmost portion of the
		// full identifier array.
		if (partialIdentifier != null)
		{
			if (partialIdentifier.Length > length)
			{
				Diag.Dug(true, "Invalid operation");
				throw new InvalidOperationException();
			}

			partialIdentifier.CopyTo(identifier, length - partialIdentifier.Length);
		}

		if (length > 0)
		{
			identifier[0] = null;
		}

		if (length > 1)
		{
			identifier[1] = null;
		}

		return identifier;
	}

	#endregion

	#region � Private Methods �

	private int GetIdentifierLength(string typeName)
	{
		Diag.Trace();
		// Diag.Trace(String.Format("GetIdentifierLength({0})", typeName));

		switch (typeName)
		{
			case DslObjectTypes.Root:
				return 0;

			case DslObjectTypes.Table:
			case DslObjectTypes.View:
			case DslObjectTypes.StoredProcedure:
			case DslObjectTypes.ScalarFunction:
				return 3;

			case DslObjectTypes.TableColumn:
			case DslObjectTypes.TableIndex:
			case DslObjectTypes.TableUniqueKey:
			case DslObjectTypes.TableForeignKey:
			case DslObjectTypes.ViewColumn:
			case DslObjectTypes.StoredProcedureParameter:
			case DslObjectTypes.StoredProcedureColumn:
			case DslObjectTypes.ScalarFunctionParameter:
				return 4;

			case DslObjectTypes.TableIndexColumn:
			case DslObjectTypes.TableUniqueKeyColumn:
			case DslObjectTypes.TableForeignKeyColumn:
				return 5;

			default:
				return -1;
		}
	}

	#endregion
}