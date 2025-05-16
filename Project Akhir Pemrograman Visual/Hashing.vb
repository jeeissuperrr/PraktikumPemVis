Imports System.Security.Cryptography
Imports System.Text
Module Hashing
    Public Function Sha256Encryption(input As String) As String
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(input)
        Dim hashBytes As Byte() = SHA256.HashData(bytes)
        Dim builder As New StringBuilder()
        For Each b As Byte In hashBytes
            builder.Append(b.ToString("x2"))
        Next
        Return builder.ToString()
    End Function
End Module