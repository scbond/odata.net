'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34014
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On


'Generation date: 2/10/2015 4:10:31 PM
Namespace Foo.NamespacePrefixWithDoubleNamespaces
    '''<summary>
    '''There are no comments for EntityContainer in the schema.
    '''</summary>
    Partial Public Class EntityContainer
        Inherits Global.Microsoft.OData.Client.DataServiceContext
        '''<summary>
        '''Initialize a new EntityContainer object.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
        Public Sub New(ByVal serviceRoot As Global.System.Uri)
            MyBase.New(serviceRoot, Global.Microsoft.OData.Client.ODataProtocolVersion.V4)
            Me.ResolveName = AddressOf Me.ResolveNameFromType
            Me.ResolveType = AddressOf Me.ResolveTypeFromName
            Me.OnContextCreated
            Me.Format.LoadServiceModel = AddressOf GeneratedEdmModel.GetInstance
            Me.Format.UseJson()
        End Sub
        Partial Private Sub OnContextCreated()
        End Sub
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
        Private Shared ROOTNAMESPACE As String = GetType(EntityContainer).Namespace.Remove(GetType(EntityContainer).Namespace.LastIndexOf("Foo.NamespacePrefixWithDoubleNamespaces"))
        '''<summary>
        '''Since the namespace configured for this service reference
        '''in Visual Studio is different from the one indicated in the
        '''server schema, use type-mappers to map between the two.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
        Protected Function ResolveTypeFromName(ByVal typeName As String) As Global.System.Type
            Dim resolvedType As Global.System.Type = Me.DefaultResolveType(typeName, "NamespacePrefixWithDoubleNamespaces2", String.Concat(ROOTNAMESPACE, "Foo.NamespacePrefixWithDoubleNamespaces2"))
            If (Not (resolvedType) Is Nothing) Then
                Return resolvedType
            End If
            resolvedType = Me.DefaultResolveType(typeName, "NamespacePrefixWithDoubleNamespaces", String.Concat(ROOTNAMESPACE, "Foo.NamespacePrefixWithDoubleNamespaces"))
            If (Not (resolvedType) Is Nothing) Then
                Return resolvedType
            End If
            Return Nothing
        End Function
        '''<summary>
        '''Since the namespace configured for this service reference
        '''in Visual Studio is different from the one indicated in the
        '''server schema, use type-mappers to map between the two.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
        Protected Function ResolveNameFromType(ByVal clientType As Global.System.Type) As String
            If clientType.Namespace.Equals(String.Concat(ROOTNAMESPACE, "Foo.NamespacePrefixWithDoubleNamespaces2"), Global.System.StringComparison.OrdinalIgnoreCase) Then
                Return String.Concat("NamespacePrefixWithDoubleNamespaces2.", clientType.Name)
            End If
            If clientType.Namespace.Equals(String.Concat(ROOTNAMESPACE, "Foo.NamespacePrefixWithDoubleNamespaces"), Global.System.StringComparison.OrdinalIgnoreCase) Then
                Return String.Concat("NamespacePrefixWithDoubleNamespaces.", clientType.Name)
            End If
            Return Nothing
        End Function
        '''<summary>
        '''There are no comments for Set1 in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
        Public ReadOnly Property Set1() As Global.Microsoft.OData.Client.DataServiceQuery(Of EntityType)
            Get
                If (Me._Set1 Is Nothing) Then
                    Me._Set1 = MyBase.CreateQuery(Of EntityType)("Set1")
                End If
                Return Me._Set1
            End Get
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
        Private _Set1 As Global.Microsoft.OData.Client.DataServiceQuery(Of EntityType)
        '''<summary>
        '''There are no comments for Set2 in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
        Public ReadOnly Property Set2() As Global.Microsoft.OData.Client.DataServiceQuery(Of EntityType)
            Get
                If (Me._Set2 Is Nothing) Then
                    Me._Set2 = MyBase.CreateQuery(Of EntityType)("Set2")
                End If
                Return Me._Set2
            End Get
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
        Private _Set2 As Global.Microsoft.OData.Client.DataServiceQuery(Of EntityType)
        '''<summary>
        '''There are no comments for Set1 in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
        Public Sub AddToSet1(ByVal entityType As EntityType)
            MyBase.AddObject("Set1", entityType)
        End Sub
        '''<summary>
        '''There are no comments for Set2 in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
        Public Sub AddToSet2(ByVal entityType As EntityType)
            MyBase.AddObject("Set2", entityType)
        End Sub
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
        Private MustInherit Class GeneratedEdmModel
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
            Private Shared ParsedModel As Global.Microsoft.OData.Edm.IEdmModel = LoadModelFromString
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
            Private Const Edmx As String = "<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">" & _
 "  <edmx:DataServices>" & _
 "    <Schema Namespace=""NamespacePrefixWithDoubleNamespaces"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">" & _
 "      <ComplexType Name=""ComplexType"">" & _
 "        <Property Name=""Value"" Type=""Edm.String"" Nullable=""false"" />" & _
 "      </ComplexType>" & _
 "      <EntityType Name=""EntityType"">" & _
 "        <Key>" & _
 "          <PropertyRef Name=""Id"" />" & _
 "        </Key>" & _
 "        <Property Name=""Id"" Type=""Edm.Guid"" Nullable=""false"" />" & _
 "        <Property Name=""Complex"" Type=""NamespacePrefixWithDoubleNamespaces.ComplexType"" Nullable=""true"" />" & _
 "      </EntityType>" & _
 "      <EntityContainer Name=""EntityContainer"">" & _
 "        <EntitySet Name=""Set1"" EntityType=""NamespacePrefixWithDoubleNamespaces.EntityType"" />" & _
 "        <EntitySet Name=""Set2"" EntityType=""NamespacePrefixWithDoubleNamespaces.EntityType"" />" & _
 "      </EntityContainer>" & _
 "    </Schema>" & _
 "    <Schema Namespace=""NamespacePrefixWithDoubleNamespaces2"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">" & _
 "      <ComplexType Name=""ComplexType"">" & _
 "        <Property Name=""Value"" Type=""Edm.String"" Nullable=""false"" />" & _
 "      </ComplexType>" & _
 "      <EntityType Name=""EntityType"">" & _
 "        <Key>" & _
 "          <PropertyRef Name=""Id"" />" & _
 "        </Key>" & _
 "        <Property Name=""Id"" Type=""Edm.Guid"" Nullable=""false"" />" & _
 "        <Property Name=""Complex"" Type=""NamespacePrefixWithDoubleNamespaces2.ComplexType"" Nullable=""true"" />" & _
 "      </EntityType>" & _
 "    </Schema>" & _
 "  </edmx:DataServices>" & _
 "</edmx:Edmx>"
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
            Public Shared Function GetInstance() As Global.Microsoft.OData.Edm.IEdmModel
                Return ParsedModel
            End Function
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
            Private Shared Function LoadModelFromString() As Global.Microsoft.OData.Edm.IEdmModel
                Dim reader As Global.System.Xml.XmlReader = CreateXmlReader(Edmx)
                Try
                    Return Global.Microsoft.OData.Edm.Csdl.EdmxReader.Parse(reader)
                Finally
                    CType(reader,Global.System.IDisposable).Dispose
                End Try
            End Function
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
            Private Shared Function CreateXmlReader(ByVal edmxToParse As String) As Global.System.Xml.XmlReader
                Return Global.System.Xml.XmlReader.Create(New Global.System.IO.StringReader(edmxToParse))
            End Function
        End Class
    End Class
    '''<summary>
    '''There are no comments for ComplexType in the schema.
    '''</summary>
    Partial Public Class ComplexType
        '''<summary>
        '''Create a new ComplexType object.
        '''</summary>
        '''<param name="value">Initial value of Value.</param>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
        Public Shared Function CreateComplexType(ByVal value As String) As ComplexType
            Dim complexType As ComplexType = New ComplexType()
            complexType.Value = value
            Return complexType
        End Function
        '''<summary>
        '''There are no comments for Property Value in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
        Public Property Value() As String
            Get
                Return Me._Value
            End Get
            Set
                Me.OnValueChanging(value)
                Me._Value = value
                Me.OnValueChanged
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
        Private _Value As String
        Partial Private Sub OnValueChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnValueChanged()
        End Sub
    End Class
    '''<summary>
    '''There are no comments for EntityTypeSingle in the schema.
    '''</summary>
    Partial Public Class EntityTypeSingle
        Inherits Global.Microsoft.OData.Client.DataServiceQuerySingle(Of EntityType)
        ''' <summary>
        ''' Initialize a new EntityTypeSingle object.
        ''' </summary>
        Public Sub New(ByVal context As Global.Microsoft.OData.Client.DataServiceContext, ByVal path As String)
            MyBase.New(context, path)
        End Sub

        ''' <summary>
        ''' Initialize a new EntityTypeSingle object.
        ''' </summary>
        Public Sub New(ByVal context As Global.Microsoft.OData.Client.DataServiceContext, ByVal path As String, ByVal isComposable As Boolean)
            MyBase.New(context, path, isComposable)
        End Sub

        ''' <summary>
        ''' Initialize a new EntityTypeSingle object.
        ''' </summary>
        Public Sub New(ByVal query As Global.Microsoft.OData.Client.DataServiceQuerySingle(Of EntityType))
            MyBase.New(query)
        End Sub
    End Class
    '''<summary>
    '''There are no comments for EntityType in the schema.
    '''</summary>
    '''<KeyProperties>
    '''Id
    '''</KeyProperties>
    <Global.Microsoft.OData.Client.Key("Id")>  _
    Partial Public Class EntityType
        Inherits Global.Microsoft.OData.Client.BaseEntityType
        '''<summary>
        '''Create a new EntityType object.
        '''</summary>
        '''<param name="ID">Initial value of Id.</param>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
        Public Shared Function CreateEntityType(ByVal ID As Global.System.Guid) As EntityType
            Dim entityType As EntityType = New EntityType()
            entityType.Id = ID
            Return entityType
        End Function
        '''<summary>
        '''There are no comments for Property Id in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
        Public Property Id() As Global.System.Guid
            Get
                Return Me._Id
            End Get
            Set
                Me.OnIdChanging(value)
                Me._Id = value
                Me.OnIdChanged
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
        Private _Id As Global.System.Guid
        Partial Private Sub OnIdChanging(ByVal value As Global.System.Guid)
        End Sub
        Partial Private Sub OnIdChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Complex in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
        Public Property Complex() As Foo.NamespacePrefixWithDoubleNamespaces.ComplexType
            Get
                Return Me._Complex
            End Get
            Set
                Me.OnComplexChanging(value)
                Me._Complex = value
                Me.OnComplexChanged
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
        Private _Complex As Foo.NamespacePrefixWithDoubleNamespaces.ComplexType
        Partial Private Sub OnComplexChanging(ByVal value As Foo.NamespacePrefixWithDoubleNamespaces.ComplexType)
        End Sub
        Partial Private Sub OnComplexChanged()
        End Sub
    End Class
    ''' <summary>
    ''' Class containing all extension methods
    ''' </summary>
    Public Module ExtensionMethods
        ''' <summary>
        ''' Get an entity of type Foo.NamespacePrefixWithDoubleNamespaces.EntityType as Foo.NamespacePrefixWithDoubleNamespaces.EntityTypeSingle specified by key from an entity set
        ''' </summary>
        ''' <param name="source">source entity set</param>
        ''' <param name="keys">dictionary with the names and values of keys</param>
        <Global.System.Runtime.CompilerServices.Extension()>
        Public Function ByKey(ByVal source As Global.Microsoft.OData.Client.DataServiceQuery(Of Foo.NamespacePrefixWithDoubleNamespaces.EntityType), ByVal keys As Global.System.Collections.Generic.Dictionary(Of String, Object)) As Foo.NamespacePrefixWithDoubleNamespaces.EntityTypeSingle
            Return New Foo.NamespacePrefixWithDoubleNamespaces.EntityTypeSingle(source.Context, source.GetKeyPath(Global.Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)))
        End Function
        ''' <summary>
        ''' Get an entity of type Foo.NamespacePrefixWithDoubleNamespaces.EntityType as Foo.NamespacePrefixWithDoubleNamespaces.EntityTypeSingle specified by key from an entity set
        ''' </summary>
        ''' <param name="source">source entity set</param>
        ''' <param name="id">The value of id</param>
        <Global.System.Runtime.CompilerServices.Extension()>
        Public Function ByKey(ByVal source As Global.Microsoft.OData.Client.DataServiceQuery(Of Foo.NamespacePrefixWithDoubleNamespaces.EntityType),
            id As Global.System.Guid) As Foo.NamespacePrefixWithDoubleNamespaces.EntityTypeSingle
            Dim keys As Global.System.Collections.Generic.Dictionary(Of String, Object) = New Global.System.Collections.Generic.Dictionary(Of String, Object)() From
            {
                { "Id", id }
            }
            Return New Foo.NamespacePrefixWithDoubleNamespaces.EntityTypeSingle(source.Context, source.GetKeyPath(Global.Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)))
        End Function
    End Module
End Namespace
Namespace Foo.NamespacePrefixWithDoubleNamespaces2
    '''<summary>
    '''There are no comments for ComplexType in the schema.
    '''</summary>
    Partial Public Class ComplexType
        '''<summary>
        '''Create a new ComplexType object.
        '''</summary>
        '''<param name="value">Initial value of Value.</param>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
        Public Shared Function CreateComplexType(ByVal value As String) As ComplexType
            Dim complexType As ComplexType = New ComplexType()
            complexType.Value = value
            Return complexType
        End Function
        '''<summary>
        '''There are no comments for Property Value in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
        Public Property Value() As String
            Get
                Return Me._Value
            End Get
            Set
                Me.OnValueChanging(value)
                Me._Value = value
                Me.OnValueChanged
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
        Private _Value As String
        Partial Private Sub OnValueChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnValueChanged()
        End Sub
    End Class
    '''<summary>
    '''There are no comments for EntityTypeSingle in the schema.
    '''</summary>
    Partial Public Class EntityTypeSingle
        Inherits Global.Microsoft.OData.Client.DataServiceQuerySingle(Of EntityType)
        ''' <summary>
        ''' Initialize a new EntityTypeSingle object.
        ''' </summary>
        Public Sub New(ByVal context As Global.Microsoft.OData.Client.DataServiceContext, ByVal path As String)
            MyBase.New(context, path)
        End Sub

        ''' <summary>
        ''' Initialize a new EntityTypeSingle object.
        ''' </summary>
        Public Sub New(ByVal context As Global.Microsoft.OData.Client.DataServiceContext, ByVal path As String, ByVal isComposable As Boolean)
            MyBase.New(context, path, isComposable)
        End Sub

        ''' <summary>
        ''' Initialize a new EntityTypeSingle object.
        ''' </summary>
        Public Sub New(ByVal query As Global.Microsoft.OData.Client.DataServiceQuerySingle(Of EntityType))
            MyBase.New(query)
        End Sub
    End Class
    '''<summary>
    '''There are no comments for EntityType in the schema.
    '''</summary>
    '''<KeyProperties>
    '''Id
    '''</KeyProperties>
    <Global.Microsoft.OData.Client.Key("Id")>  _
    Partial Public Class EntityType
        Inherits Global.Microsoft.OData.Client.BaseEntityType
        '''<summary>
        '''Create a new EntityType object.
        '''</summary>
        '''<param name="ID">Initial value of Id.</param>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
        Public Shared Function CreateEntityType(ByVal ID As Global.System.Guid) As EntityType
            Dim entityType As EntityType = New EntityType()
            entityType.Id = ID
            Return entityType
        End Function
        '''<summary>
        '''There are no comments for Property Id in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
        Public Property Id() As Global.System.Guid
            Get
                Return Me._Id
            End Get
            Set
                Me.OnIdChanging(value)
                Me._Id = value
                Me.OnIdChanged
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
        Private _Id As Global.System.Guid
        Partial Private Sub OnIdChanging(ByVal value As Global.System.Guid)
        End Sub
        Partial Private Sub OnIdChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Complex in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
        Public Property Complex() As Foo.NamespacePrefixWithDoubleNamespaces2.ComplexType
            Get
                Return Me._Complex
            End Get
            Set
                Me.OnComplexChanging(value)
                Me._Complex = value
                Me.OnComplexChanged
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")>  _
        Private _Complex As Foo.NamespacePrefixWithDoubleNamespaces2.ComplexType
        Partial Private Sub OnComplexChanging(ByVal value As Foo.NamespacePrefixWithDoubleNamespaces2.ComplexType)
        End Sub
        Partial Private Sub OnComplexChanged()
        End Sub
    End Class
    ''' <summary>
    ''' Class containing all extension methods
    ''' </summary>
    Public Module ExtensionMethods
        ''' <summary>
        ''' Get an entity of type Foo.NamespacePrefixWithDoubleNamespaces2.EntityType as Foo.NamespacePrefixWithDoubleNamespaces2.EntityTypeSingle specified by key from an entity set
        ''' </summary>
        ''' <param name="source">source entity set</param>
        ''' <param name="keys">dictionary with the names and values of keys</param>
        <Global.System.Runtime.CompilerServices.Extension()>
        Public Function ByKey(ByVal source As Global.Microsoft.OData.Client.DataServiceQuery(Of Foo.NamespacePrefixWithDoubleNamespaces2.EntityType), ByVal keys As Global.System.Collections.Generic.Dictionary(Of String, Object)) As Foo.NamespacePrefixWithDoubleNamespaces2.EntityTypeSingle
            Return New Foo.NamespacePrefixWithDoubleNamespaces2.EntityTypeSingle(source.Context, source.GetKeyPath(Global.Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)))
        End Function
        ''' <summary>
        ''' Get an entity of type Foo.NamespacePrefixWithDoubleNamespaces2.EntityType as Foo.NamespacePrefixWithDoubleNamespaces2.EntityTypeSingle specified by key from an entity set
        ''' </summary>
        ''' <param name="source">source entity set</param>
        ''' <param name="id">The value of id</param>
        <Global.System.Runtime.CompilerServices.Extension()>
        Public Function ByKey(ByVal source As Global.Microsoft.OData.Client.DataServiceQuery(Of Foo.NamespacePrefixWithDoubleNamespaces2.EntityType),
            id As Global.System.Guid) As Foo.NamespacePrefixWithDoubleNamespaces2.EntityTypeSingle
            Dim keys As Global.System.Collections.Generic.Dictionary(Of String, Object) = New Global.System.Collections.Generic.Dictionary(Of String, Object)() From
            {
                { "Id", id }
            }
            Return New Foo.NamespacePrefixWithDoubleNamespaces2.EntityTypeSingle(source.Context, source.GetKeyPath(Global.Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)))
        End Function
    End Module
End Namespace
