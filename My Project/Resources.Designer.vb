﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("STREAM_Input_Generator.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        '''</summary>
        Friend ReadOnly Property icon() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("icon", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property logo() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("logo", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to UO2
        '''Fuel gram density (g/cc)#U-235 Enrichment (weight %)# 
        '''10.1# # 
        '''GAP
        '''Material# # 
        '''AIR# # 
        '''GAD
        '''Fuel gram density (g/cc)#U-235 Enrichment (weight %)#Gd2O3 Content (weight %)
        '''10.1# # 
        '''ERB
        '''Fuel gram density (g/cc)#U-235 Enrichment (weight %)#Er2O3 Content (weight %)
        '''10.1# # 
        '''PYREX
        '''Gram density (g/cc)#B2O3 Content (weight %)# 
        '''2.25#12.5# 
        '''COO
        '''Coolant temperature (K)#Boron concentration (ppm)# 
        ''' #700.0# 
        '''ZIR2
        '''Gram density (g/cc)# # 
        '''6.55# # 
        '''ZIR4
        '''Gram density (g/cc)# # 
        '''6.55# # 
        '''ZIRLO
        ''' [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property MAT_DATA() As String
            Get
                Return ResourceManager.GetString("MAT_DATA", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to XSLIB
        '''E71JD40#E71#E70#E68
        '''DEPLIB
        '''E71JD40#E71#E70#E68
        '''KAPPALIB
        '''OTF
        '''DET
        '''92235 FISSION 45103 CAPTURE
        '''ON
        '''RUP#HOMADF#RESTART#STN#THE
        '''CRI
        '''1
        '''BRANCH
        '''0#1#2#3#4
        '''END OF FILE.
        '''</summary>
        Friend ReadOnly Property OPTION_DATA() As String
            Get
                Return ResourceManager.GetString("OPTION_DATA", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to XSLIB
        '''ENDF/B-VII.1 &amp; JENDL-4.0 [Default]#ENDF/B-VII.1#ENDF/B-VII.0#ENDF/B-VI.8
        '''DEPLIB
        '''ENDF/B-VII.1 &amp; JENDL-4.0 [Default]#ENDF/B-VII.1#ENDF/B-VII.0#ENDF/B-VI.8
        '''KAPPALIB
        '''OTF
        '''DET
        '''92235 FISSION 45103 CAPTURE
        '''CRI
        '''1
        '''BRANCH
        '''0#1#2 [Default]#3#4
        '''H2O
        '''
        '''700.0
        '''DEP
        '''36.85
        '''80
        '''END OF FILE.
        '''</summary>
        Friend ReadOnly Property OPTION_SETTING() As String
            Get
                Return ResourceManager.GetString("OPTION_SETTING", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
