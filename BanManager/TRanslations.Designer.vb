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
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class TRanslations
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("BanManager.TRanslations", GetType(TRanslations).Assembly)
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
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {
        '''    &quot;TranslationsName&quot; : &quot;Türkçe&quot;,
        '''    &quot;WindowTitle&quot;: &quot;Yasaklama Yöneticisi&quot;,
        '''    &quot;SettingsTitle&quot;: &quot;Ayarlar&quot;,
        '''    &quot;IconURL&quot; : &quot;https://cdn.discordapp.com/attachments/602753672266383391/722335981159579658/elite2.ico&quot;,
        '''    &quot;MainPage&quot;: [
        '''        {
        '''            &quot;Control&quot;: &quot;lblOtherReason&quot;,
        '''            &quot;Value&quot;: &quot;Diğer Nedenler:&quot;
        '''        },
        '''        {
        '''            &quot;Control&quot;: &quot;lblOutCMD&quot;,
        '''            &quot;Value&quot;: &quot;Komut:&quot;
        '''        },
        '''        {
        '''            &quot;Control&quot;: &quot;lblBanDuration&quot;,
        '''            &quot;Value&quot;: [rest of string was truncated]&quot;;.
        '''</summary>
        Friend Shared ReadOnly Property Translastions_Turkish() As String
            Get
                Return ResourceManager.GetString("Translastions_Turkish", resourceCulture)
            End Get
        End Property
    End Class
End Namespace