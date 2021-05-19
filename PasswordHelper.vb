''' <summary>
''' Klasa statyczna
''' </summary>
Public Module PasswordHelper

    Public Function BlowFishEncryp(StringToEncrypt As String, YourKey As String) As String
        Dim sRaw$, sRetStr$
        Dim b As New BlowFish

        Dim i As Integer

        b.Password(YourKey)

        sRaw = b.EncryptString(StringToEncrypt)

        For i = 1 To Len(sRaw)
            sRetStr = sRetStr & Right("0" & Hex(Asc(Mid(sRaw, i, 1))), 2)
        Next i

        BlowFishEncryp = sRetStr
    End Function

    Public Function BlowFishDecrypt(StringToDecrypt As String, YourKey As String) As String
        Dim sR$, RetStr$
        Dim b As New BlowFish

        b.Password(YourKey)

        Dim i As Integer

        Dim sHex As String
        Dim decHex As Integer
        Dim sChr As String

        For i = 1 To (Len(StringToDecrypt) / 2)
            sHex = Mid$(StringToDecrypt, i * 2 - 1, 2)
            decHex = Convert.ToUInt16(sHex, 16)
            sChr = Chr(decHex)
            RetStr += sChr
        Next i

        sR = b.DecryptString(RetStr)

        BlowFishDecrypt = sR
    End Function
End Module
