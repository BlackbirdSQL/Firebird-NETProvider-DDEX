﻿#region Assembly Community.VisualStudio.Toolkit, Version=17.0.430.0, Culture=neutral, PublicKeyToken=79441d341a79572c
// C:\Users\GregChristos\.nuget\packages\community.visualstudio.toolkit.17\17.0.430\lib\net48\Community.VisualStudio.Toolkit.dll
// Decompiled with ICSharpCode.Decompiler 7.1.0.6543
#endregion

using System;

namespace BlackbirdSql.VisualStudio.Ddex.Extensions
{
	//
	// Summary:
	//     Apply this attribute on a get/set property in the Community.VisualStudio.Toolkit.BaseOptionModel`1
	//     class to specify the type and mechanism used to store/retrieve the value of this
	//     property in the Microsoft.VisualStudio.Settings.SettingsStore. If not specified,
	//     the default mechanism is used is based on the property type.
	[AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
	public class OverrideDataTypeAttribute : Attribute
	{
		//
		// Summary:
		//     Specifies the type and method used to store and retrieve the value of the attributed
		//     property in the Microsoft.VisualStudio.Settings.SettingsStore.
		public SettingDataType SettingDataType { get; }

		//
		// Summary:
		//     If true, and the type has a System.ComponentModel.TypeConverterAttribute that
		//     allows for conversion to Community.VisualStudio.Toolkit.OverrideDataTypeAttribute.SettingDataType,
		//     this will be used to convert and store the property value. If the Community.VisualStudio.Toolkit.OverrideDataTypeAttribute.SettingDataType
		//     is Legacy or Serialized this has no effect. For other Community.VisualStudio.Toolkit.OverrideDataTypeAttribute.SettingDataType,
		//     false will use the default conversion mechanism of System.Convert.ChangeType(System.Object,System.Type,System.IFormatProvider),
		//     using System.Globalization.CultureInfo.InvariantCulture.
		public bool UseTypeConverter { get; }

		//
		// Summary:
		//     Alters the default type and mechanism used to store/retrieve the value of this
		//     property in the Microsoft.VisualStudio.Settings.SettingsStore.
		//
		// Parameters:
		//   settingDataType:
		//     Specifies the type and/or method used to store and retrieve the value of the
		//     attributed property in the Microsoft.VisualStudio.Settings.SettingsStore.
		//
		//   useTypeConverter:
		//     (Optional, default false) If true, and the type has a System.ComponentModel.TypeConverterAttribute
		//     that allows for conversion to settingDataType, this will be used to convert and
		//     store the property value. If the settingDataType is Legacy or Serialized this
		//     has no effect. For other Community.VisualStudio.Toolkit.OverrideDataTypeAttribute.SettingDataType
		//     values, false will use the default conversion mechanism of System.Convert.ChangeType(System.Object,System.Type,System.IFormatProvider),
		//     using System.Globalization.CultureInfo.InvariantCulture.
		public OverrideDataTypeAttribute(SettingDataType settingDataType, bool useTypeConverter = false)
		{
			SettingDataType = settingDataType;
			UseTypeConverter = useTypeConverter;
		}
	}
}
#if false // Decompilation log
'213' items in cache
------------------
Resolve: 'mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.8\mscorlib.dll'
------------------
Resolve: 'Microsoft.VisualStudio.Interop, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'Microsoft.VisualStudio.Interop, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Users\GregChristos\.nuget\packages\microsoft.visualstudio.interop\17.0.31902.203\lib\net472\Microsoft.VisualStudio.Interop.dll'
------------------
Resolve: 'Microsoft.VisualStudio.Text.UI.Wpf, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'Microsoft.VisualStudio.Text.UI.Wpf, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Users\GregChristos\.nuget\packages\microsoft.visualstudio.text.ui.wpf\17.0.487\lib\net472\Microsoft.VisualStudio.Text.UI.Wpf.dll'
------------------
Resolve: 'Microsoft.VisualStudio.Threading, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'Microsoft.VisualStudio.Threading, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Users\GregChristos\.nuget\packages\microsoft.visualstudio.threading\17.0.64\lib\net472\Microsoft.VisualStudio.Threading.dll'
------------------
Resolve: 'Microsoft.VisualStudio.Shell.Framework, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'Microsoft.VisualStudio.Shell.Framework, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Users\GregChristos\.nuget\packages\microsoft.visualstudio.shell.framework\17.0.31902.203\lib\net472\Microsoft.VisualStudio.Shell.Framework.dll'
------------------
Resolve: 'Microsoft.VisualStudio.Text.Logic, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'Microsoft.VisualStudio.Text.Logic, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Users\GregChristos\.nuget\packages\microsoft.visualstudio.text.logic\17.0.487\lib\net472\Microsoft.VisualStudio.Text.Logic.dll'
------------------
Resolve: 'Microsoft.VisualStudio.Text.Data, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'Microsoft.VisualStudio.Text.Data, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Users\GregChristos\.nuget\packages\microsoft.visualstudio.text.data\17.0.487\lib\net472\Microsoft.VisualStudio.Text.Data.dll'
------------------
Resolve: 'Microsoft.VisualStudio.Text.UI, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'Microsoft.VisualStudio.Text.UI, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Users\GregChristos\.nuget\packages\microsoft.visualstudio.text.ui\17.0.487\lib\net472\Microsoft.VisualStudio.Text.UI.dll'
------------------
Resolve: 'Microsoft.VisualStudio.Shell.15.0, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'Microsoft.VisualStudio.Shell.15.0, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Users\GregChristos\.nuget\packages\microsoft.visualstudio.shell.15.0\17.0.31902.203\lib\net472\Microsoft.VisualStudio.Shell.15.0.dll'
------------------
Resolve: 'PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35'
Could not find by name: 'PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35'
------------------
Resolve: 'Microsoft.VisualStudio.Imaging.Interop.14.0.DesignTime, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'Microsoft.VisualStudio.Imaging.Interop.14.0.DesignTime, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Users\GregChristos\.nuget\packages\microsoft.visualstudio.imaging.interop.14.0.designtime\17.0.31902.203\lib\net472\Microsoft.VisualStudio.Imaging.Interop.14.0.DesignTime.dll'
------------------
Resolve: 'System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Could not find by name: 'System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
------------------
Resolve: 'PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35'
Could not find by name: 'PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35'
------------------
Resolve: 'System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.8\System.dll'
------------------
Resolve: 'System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.8\System.Core.dll'
------------------
Resolve: 'Microsoft.VisualStudio.Package.LanguageService.15.0, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'Microsoft.VisualStudio.Package.LanguageService.15.0, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Users\GregChristos\.nuget\packages\microsoft.visualstudio.package.languageservice.15.0\17.0.31902.203\lib\net45\Microsoft.VisualStudio.Package.LanguageService.15.0.dll'
------------------
Resolve: 'System.ComponentModel.Composition, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'System.ComponentModel.Composition, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.8\System.ComponentModel.Composition.dll'
------------------
Resolve: 'Microsoft.VisualStudio.Language, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'Microsoft.VisualStudio.Language, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Users\GregChristos\.nuget\packages\microsoft.visualstudio.language\17.0.487\lib\net472\Microsoft.VisualStudio.Language.dll'
------------------
Resolve: 'System.Collections.Immutable, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Collections.Immutable, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Users\GregChristos\.nuget\packages\system.collections.immutable\5.0.0\lib\net461\System.Collections.Immutable.dll'
------------------
Resolve: 'System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Could not find by name: 'System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
------------------
Resolve: 'Microsoft.VisualStudio.ComponentModelHost, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'Microsoft.VisualStudio.ComponentModelHost, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Users\GregChristos\.nuget\packages\microsoft.visualstudio.componentmodelhost\17.0.487\lib\net472\Microsoft.VisualStudio.ComponentModelHost.dll'
------------------
Resolve: 'Microsoft.VisualStudio.CoreUtility, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'Microsoft.VisualStudio.CoreUtility, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Users\GregChristos\.nuget\packages\microsoft.visualstudio.coreutility\17.0.487\lib\net472\Microsoft.VisualStudio.CoreUtility.dll'
------------------
Resolve: 'WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35'
Could not find by name: 'WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35'
------------------
Resolve: 'Microsoft.VisualStudio.Editor, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'Microsoft.VisualStudio.Editor, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Users\GregChristos\.nuget\packages\microsoft.visualstudio.editor\17.0.487\lib\net472\Microsoft.VisualStudio.Editor.dll'
------------------
Resolve: 'Microsoft.VisualStudio.Validation, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'Microsoft.VisualStudio.Validation, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Users\GregChristos\.nuget\packages\microsoft.visualstudio.validation\17.0.28\lib\netstandard2.0\Microsoft.VisualStudio.Validation.dll'
------------------
Resolve: 'Microsoft.VisualStudio.Imaging, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'Microsoft.VisualStudio.Imaging, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Users\GregChristos\.nuget\packages\microsoft.visualstudio.imaging\17.0.31902.203\lib\net472\Microsoft.VisualStudio.Imaging.dll'
------------------
Resolve: 'Microsoft.VisualStudio.ImageCatalog, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'Microsoft.VisualStudio.ImageCatalog, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Users\GregChristos\.nuget\packages\microsoft.visualstudio.imagecatalog\17.0.31902.203\lib\net472\Microsoft.VisualStudio.ImageCatalog.dll'
------------------
Resolve: 'Microsoft.VisualStudio.Utilities, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'Microsoft.VisualStudio.Utilities, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Users\GregChristos\.nuget\packages\microsoft.visualstudio.utilities\17.0.31902.203\lib\net472\Microsoft.VisualStudio.Utilities.dll'
#endif