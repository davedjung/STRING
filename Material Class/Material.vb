Public MustInherit Class Material

    Protected materialName As String
    Protected identifier As String
    Protected isBurnable As Boolean
    Protected isPrefab As Boolean

    Public Function getName() As String
        Return Me.materialName
    End Function

    Public Function getIdentifier() As String
        Return Me.identifier
    End Function

    Public Function getBurnable() As Boolean
        Return Me.isBurnable
    End Function

    Public Function getPrefab() As Boolean
        Return Me.isPrefab
    End Function

    Public MustOverride Function toString() As String

End Class
