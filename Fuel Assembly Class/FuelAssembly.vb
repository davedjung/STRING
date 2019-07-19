Public Class FuelAssembly

    Private FAIndex As String
    Private dimension As Integer
    Private pinPitch As String
    Private FAMaterial As String
    Private inletTemperature As String
    Private pinConfiguration(,) As Integer
    Private halfAssemGap As String

    Public Sub New(index As String)
        Me.FAIndex = index
    End Sub

    Public Function getIndex() As String
        Return Me.FAIndex
    End Function

    Public Function getDimension() As Integer
        Return Me.dimension
    End Function

    Public Function getPitch() As String
        Return Me.pinPitch
    End Function

    Public Function getMaterial() As String
        Return Me.FAMaterial
    End Function

    Public Function getInletTemperature() As String
        Return Me.inletTemperature
    End Function

    Public Function getPinConfiguration() As Integer(,)
        Return Me.pinConfiguration
    End Function

    Public Function getHalfAssemGap() As String
        Return Me.halfAssemGap
    End Function

    Public Sub setDimension(dimension As Integer)
        Me.dimension = dimension
    End Sub

    Public Sub setPitch(pitch As String)
        Me.pinPitch = pitch
    End Sub

    Public Sub setMaterial(material As String)
        Me.FAMaterial = material
    End Sub

    Public Sub setInletTemperature(temperature As String)
        Me.inletTemperature = temperature
    End Sub

    Public Sub setPinConfiguration(config As Integer(,))
        Me.pinConfiguration = config
    End Sub

    Public Sub setHalfAssemGap(gap As String)
        Me.halfAssemGap = gap
    End Sub

End Class
