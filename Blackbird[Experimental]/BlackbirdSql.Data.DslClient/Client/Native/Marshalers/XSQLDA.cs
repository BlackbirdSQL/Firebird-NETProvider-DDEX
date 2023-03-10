/*
 *    The contents of this file are subject to the Initial
 *    Developer's Public License Version 1.0 (the "License");
 *    you may not use this file except in compliance with the
 *    License. You may obtain a copy of the License at
 *    https://github.com/BlackbirdSQL/NETProvider/master/license.txt.
 *
 *    Software distributed under the License is distributed on
 *    an "AS IS" basis, WITHOUT WARRANTY OF ANY KIND, either
 *    express or implied. See the License for the specific
 *    language governing rights and limitations under the License.
 *
 *    All Rights Reserved.
 */

//$OriginalAuthors = Carlos Guzman Alvarez, Jiri Cincura (jiri@cincura.net)

using System.Runtime.InteropServices;

namespace BlackbirdSql.Data.Client.Native.Marshalers;

[StructLayout(LayoutKind.Sequential)]
internal struct XSQLDA
{
	public short version;
	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
	public string sqldaid;
	public int sqldabc;
	public short sqln;
	public short sqld;
}
