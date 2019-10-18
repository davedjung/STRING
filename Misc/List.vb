Public Class List

    Private index As Integer
    Private list(255) As Object

    Public Sub New()
        index = -1
    End Sub

    Public Sub addItem(ByVal item As Object)
        index += 1
        list(index) = item
    End Sub
    Public Sub addItem(ByVal item As Object, ByVal index As Integer)
        If index > -1 And index <= Me.index Then
            list(index) = item
        End If
    End Sub

    Public Function getItem(ByVal index As Integer) As Object
        If index > Me.index Then
            Return Nothing
        Else
            Return list(index)
        End If
    End Function

    Public Sub removeItem(ByVal index As Integer)
        If index <= -1 Then
            Exit Sub
        End If
        For i = index To Me.index - 1
            list(i) = list(i + 1)
        Next
        Me.index -= 1
    End Sub

    Public Function length() As Integer
        Return index
    End Function

    Public Function isEmpty() As Boolean
        If index = -1 Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
