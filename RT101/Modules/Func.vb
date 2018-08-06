Module Func
    Public Function siz(ByVal Size As String) As String
        If Size.Length < 4 Then
            Return Size & " Bytes"
            Exit Function
        End If
        Dim s As String = Size / 1024
        Dim F As String = " KB"
        Dim ss As Integer
        If InStr(s, ".") > 0 Then
            Dim j As Array = Split(s, ".")
            s = j(0)
            If j(1).ToString.Length > 3 Then
                ss = Mid(j(1), 1, 3)
            Else
                ss = j(1)
            End If
        End If
        If s.Length > 3 Then
            s = s / 1024
            F = " MB"
            If InStr(s, ".") > 0 Then
                Dim j As Array = Split(s, ".")
                s = j(0)
                If j(1).ToString.Length > 3 Then
                    ss = Mid(j(1), 1, 3)
                Else
                    ss = j(1)
                End If
            End If
        End If
        If s.Length > 3 Then
            s = s / 1024
            F = " GB"
            If InStr(s, ".") > 0 Then
                Dim j As Array = Split(s, ".")
                s = j(0)
                If j(1).ToString.Length > 3 Then
                    ss = Mid(j(1), 1, 3)
                Else
                    ss = j(1)
                End If
            End If
        End If
        Return s & "." & ss & F
    End Function
    Function SB(ByVal s As String) As Byte() ' string to byte()
        Return System.Text.Encoding.Default.GetBytes(s)
    End Function
    Function BS(ByVal b As Byte()) As String ' byte() to string
        Form1.long_1 = Convert.ToInt32(b.Length)
        Return System.Text.Encoding.Default.GetString(b)
    End Function

    Function fx(ByVal b As Byte(), ByVal WRD As String) As Array ' split bytes by word
        Dim a As New List(Of Byte())
        Dim M As New IO.MemoryStream
        Dim MM As New IO.MemoryStream
        Dim T As String() = Split(BS(b), WRD)
        M.Write(b, 0, T(0).Length)
        MM.Write(b, T(0).Length + WRD.Length, b.Length - (T(0).Length + WRD.Length))
        a.Add(M.ToArray)
        a.Add(MM.ToArray)
        M.Dispose()
        MM.Dispose()
        Return a.ToArray
    End Function

    Public Function DEB(ByRef s As String) As String ' Decode Base64
        Dim b As Byte() = Convert.FromBase64String(s)
        DEB = System.Text.Encoding.UTF8.GetString(b)
    End Function
    Public Function ENB(ByRef s As String) As String ' Encode base64
        Dim byt As Byte() = System.Text.Encoding.UTF8.GetBytes(s)
        ENB = Convert.ToBase64String(byt)
    End Function

    'AES Enc
    Public Function AES_Encrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
            Return input 'If encryption fails, return the unaltered input.
        End Try
    End Function
    'Decrypt a string with AES
    Public Function AES_Decrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(input)
            decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return decrypted
        Catch ex As Exception
            Return input 'If decryption fails, return the unaltered input.
        End Try
    End Function
End Module
