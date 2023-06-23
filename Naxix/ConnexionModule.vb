Imports System.Data.Common
Imports System.Data.Odbc
Module ConnexionModule
    Private connector As New DatabaseConnector()
    Public Class DatabaseConnector
        Private connectionString As String = "Driver={CData ODBC Driver for MariaDB};" &
                                              "Server=185.212.70.52;" &
                                              "Port=3306;" &
                                              "Database=u781313158_naxix;" &
                                              "User=u781313158_naxix;" &
                                              "Password=Alphonsine1995@;"

        Public Function Connect() As OdbcConnection
            Dim connection As New OdbcConnection(connectionString)
            connection.Open()
            Return connection
        End Function
    End Class
    Public Function ValidateUser(username As String, password As String) As Boolean
        Dim connection As OdbcConnection = connector.Connect()

        Dim query As String = "SELECT COUNT(*) FROM Profile_Utilisateurs WHERE NomUtilisateur = ? AND Motdepasse = ?"
        Using command As New OdbcCommand(query, connection)
            command.Parameters.AddWithValue("@Username", username)
            command.Parameters.AddWithValue("@Password", password)

            Dim count As Integer = CInt(command.ExecuteScalar())

            Return count > 0
        End Using
    End Function
End Module
