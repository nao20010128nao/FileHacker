﻿'------------------------------------------------------------------------------
' <auto-generated>
'     このコードはツールによって生成されました。
'     ランタイム バージョン:4.0.30319.34014
'
'     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
'     コードが再生成されるときに損失したりします。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'このクラスは StronglyTypedResourceBuilder クラスが ResGen
    'または Visual Studio のようなツールを使用して自動生成されました。
    'メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    'ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    '''<summary>
    '''  ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("FileHacker.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  厳密に型指定されたこのリソース クラスを使用して、すべての検索リソースに対し、
        '''  現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
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
        '''  &lt;!DOCTYPE html&gt;
        '''&lt;html xmlns=&quot;http://www.w3.org/1999/xhtml&quot;&gt;
        '''&lt;head&gt;
        '''    &lt;!--請求のページ--&gt;
        '''    &lt;meta http-equiv=&quot;Content-Type&quot; content=&quot;text/html; charset=utf-8&quot; /&gt;
        '''    &lt;title&gt;&lt;/title&gt;
        '''    &lt;style&gt;
        '''        p#title {
        '''            background: #00ff21;
        '''            color: blue;
        '''            text-align: center;
        '''            -moz-box-flex: 1;
        '''            box-flex: 1;
        '''            font-size: 30px;
        '''        }
        '''
        '''        p#title2 {
        '''            background: yellow;
        '''            color: red;
        '''            text-align:  [残りの文字列は切り詰められました]&quot;; に類似しているローカライズされた文字列を検索します。
        '''</summary>
        Friend ReadOnly Property KakuSeikyu_Pay() As String
            Get
                Return ResourceManager.GetString("KakuSeikyu_Pay", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  &lt;!DOCTYPE html&gt;
        '''&lt;html xmlns=&quot;http://www.w3.org/1999/xhtml&quot;&gt;
        '''&lt;head&gt;
        '''    &lt;!--クリックさせるページ--&gt;
        '''    &lt;meta http-equiv=&quot;Content-Type&quot; content=&quot;text/html; charset=utf-8&quot; /&gt;
        '''    &lt;title&gt;&lt;/title&gt;
        '''    &lt;script&gt;
        '''        function Move() {
        '''            location.href=&quot;app-page:pay&quot;
        '''        }
        '''    &lt;/script&gt;
        '''    &lt;style&gt;
        '''        p.horizontal {
        '''            box-orient: horizontal;
        '''            -moz-box-orient: horizontal;
        '''        }
        '''
        '''        p#title {
        '''            background: #eeb6ee;
        '''            color: red;
        '''        [残りの文字列は切り詰められました]&quot;; に類似しているローカライズされた文字列を検索します。
        '''</summary>
        Friend ReadOnly Property KakuSeikyu_Show() As String
            Get
                Return ResourceManager.GetString("KakuSeikyu_Show", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
