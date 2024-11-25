Public Class User
    Public Property UserID As Integer
    Public Property Username As String
    Public Property Password As String
    Public Property PhoneNumber As String
    Public Property Birthdate As Date
    Public Property TastePreference As String


    Public Sub New(username As String, password As String, phoneNumber As String, birthdate As Date, tastPreference As String)
        Me.Username = username
        Me.Password = password
        Me.PhoneNumber = phoneNumber
        Me.Birthdate = birthdate
        Me.TastePreference = tastPreference
    End Sub
End Class