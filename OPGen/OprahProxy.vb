Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json

Public Class OprahProxy
    Dim client_type As String
    Dim client_key As String
    Dim session As CookieContainer
    Dim device_id As String
    Dim device_id_hash As String
    Dim device_password As String

    Dim postData As String = ""
    Dim res As String

    Public Sub New(cltype As String, clkey As String)
        client_type = cltype
        client_key = clkey
        session = New CookieContainer
    End Sub

    Public Function getUsername() As String
        Return device_id_hash
    End Function

    Public Function getPassword() As String
        Return device_password
    End Function

    Sub register_subscriber()
        Try
            Dim email_user As String = Guid.NewGuid().ToString()
            'Dim email As String = $"{email_user}@mailinator.com"
            Dim email As String = $"{email_user}@{client_type}.surfeasy.vpn"
            Dim password As String = Guid.NewGuid().ToString
            Dim password_hash As String = hashSHA1(password)
            postData = $"email={email}&password={password_hash}"
            res = postURL("https://api.surfeasy.com/v2/register_subscriber", postData)
        Catch ex As Exception
            Log($"Register Subscriber ERROR : {ex.Message}")
        End Try

    End Sub

    Sub register_device()
        Try
            postData = $"client_type={client_type}&device_hash=4BE7D6F1BD040DE45A371FD831167BC108554111&device_name=Opera-Browser-Client"
            res = postURL("https://api.surfeasy.com/v2/register_device", postData)
            res = res.Replace(":{", ":[{")
            res = res.Replace("}}", "}]}")
            res = res.Replace("},", "}],")
            Dim xSet As DataSet = JsonConvert.DeserializeObject(Of DataSet)(res)
            device_id = xSet.Tables("data").Rows(0)("device_id").ToString
            device_id_hash = hashSHA1(device_id)
            device_password = xSet.Tables("data").Rows(0)("device_password").ToString
        Catch ex As Exception
            Log($"Register Device ERROR : {ex.Message}")
        End Try

    End Sub

#Region "Function"

    Private Function hashSHA1(strToHash As String)
        Dim sha1Obj As New System.Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

        bytesToHash = sha1Obj.ComputeHash(bytesToHash)

        Dim strResult As String = ""

        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next

        Return strResult
    End Function

    Function postURL(url As String, postData As String) As String
        Try
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.CookieContainer = session
            request.Method = "POST"
            request.Headers.Add($"SE-Client-Type:{client_type}")
            request.Headers.Add($"SE-Client-API-Key:{client_key}")
            request.Headers.Add($"SE-Operating-System:Windows")

            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = byteArray.Length
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse()
            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            reader.Close()
            dataStream.Close()
            response.Close()
            Return responseFromServer
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Private Sub Log(logMessage As String)
        Using w As StreamWriter = File.AppendText($"log.csv")
            w.WriteLine($"{DateTime.Now.ToLongDateString()};{DateTime.Now.ToLongTimeString()};{logMessage}")
        End Using
    End Sub

#End Region
End Class
