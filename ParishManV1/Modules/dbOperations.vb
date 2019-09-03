Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Configuration

Public Class dbOperations
    Dim dbConnectionString As String = My.Settings.parishdbConnectionString.ToString
    Dim schema As String = My.Settings.schema.ToString
    Public Function dbCheck() As Boolean
        Dim connection As New MySqlConnection(dbConnectionString)
        Try
            connection.Open()
            Return True
            Dim fo As New fileOperations
            fo.write("system.log", "INFO: " & Now() & dbConnectionString.ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
            Dim fo As New fileOperations
            fo.write("error.log", "ERR: " & Now() & ex.Message)

            Return False
        Finally
            connection.Close()
        End Try
    End Function


    Function getConnection() As MySqlConnection
        Dim con As New MySqlConnection(dbConnectionString)
        Return con
    End Function

    Public Function getStringFromDB(table As String, column As String, Optional condition As String = "") As String
        Dim result As String = ""
        If Not dbCheck() Then
            Return result
        End If

        Dim dbConnection As New MySqlConnection(dbConnectionString)
        Dim dbSelectQuery As New MySqlCommand("select " & column & " from " & schema & "." & table & " where " & condition & " limit 1;", dbConnection)
        Try

            dbConnection.Open()
            Console.Write(dbSelectQuery.CommandText)
            result = Convert.ToString(dbSelectQuery.ExecuteScalar)
            Dim fo As New fileOperations
            fo.write("system.log", "INFO: " & Now() & dbSelectQuery.CommandText.ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
            result = ""
            Dim fo As New fileOperations
            fo.write("error.log", "ERR: " & Now() & ex.Message)
        Finally
            dbConnection.Close()
        End Try
        Return result
    End Function

    Public Function getId(table As String, value As String, Optional withPlace As Boolean = False) As String
        Dim result As String = ""
        If Not dbCheck() Then
            Return result
        End If
        Dim dbConnection As New MySqlConnection(dbConnectionString)
        Dim query As String
        If withPlace Then
            query = "select " & table.Trim & "id from " & schema & ".vw_alltable where " & table.Trim & " in (@value)  limit 1;"
        Else
            query = "select " & table.Trim & "id from " & schema & ".vw_alltable where " & table.Trim & "name in (@value)  limit 1;"
        End If
        Dim dbSelectQuery As New MySqlCommand(query, dbConnection)
        dbSelectQuery.Parameters.AddWithValue("@value", value)
        Try

            dbConnection.Open()
            Console.Write(dbSelectQuery.CommandText)
            result = Convert.ToString(dbSelectQuery.ExecuteScalar)
            Dim fo As New fileOperations
            fo.write("system.log", "INFO: " & Now() & dbSelectQuery.CommandText.ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
            result = ""
            Dim fo As New fileOperations
            fo.write("error.log", "ERR: " & Now() & ex.Message)

        Finally
            dbConnection.Close()
        End Try
        Return result
    End Function
    Public Function instertToDB(query As String) As Boolean
        If Not dbCheck() Then
            Return False
        End If

        Dim dbConnection As New MySqlConnection(dbConnectionString)
        Dim dbInsertQuery As New MySqlCommand(query, dbConnection)
        Try
            dbConnection.Open()
            Console.Write(query)
            dbInsertQuery.ExecuteNonQuery()
            Return True
            Dim fo As New fileOperations
            fo.write("system.log", "INFO: " & Now() & dbInsertQuery.CommandText.ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
            Dim fo As New fileOperations
            fo.write("error.log", "ERR: " & Now() & ex.Message)

            Return False
        Finally
            dbConnection.Close()
        End Try
    End Function


    Public Function instertToDB(query As MySqlCommand) As Boolean
        If Not dbCheck() Then
            Return False
        End If

        Dim dbConnection As New MySqlConnection(dbConnectionString)
        query.Connection = dbConnection

        Try
            dbConnection.Open()
            Console.Write(query)
            query.ExecuteNonQuery()
            Return True
            Dim fo As New fileOperations
            fo.write("system.log", "INFO: " & Now() & query.CommandText.ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
            Dim fo As New fileOperations
            fo.write("error.log", "ERR: " & Now() & ex.Message)
            Return False
        Finally
            dbConnection.Close()
        End Try


    End Function

    Public Function deleteFromDB(id As Integer, table As String) As Boolean
        If Not dbCheck() Then
            Return False
        End If

        Dim dbConnection As New MySqlConnection(dbConnectionString)
        Dim dbDeleteQuery As New MySqlCommand("DELETE FROM " & schema & ".`" & table & "` WHERE " & table & "id=" & id & ";", dbConnection)
        Try
            dbConnection.Open()
            Console.Write(dbDeleteQuery.CommandText)
            dbDeleteQuery.ExecuteNonQuery()
            MsgBox("Deleted!")
            Return True
            Dim fo As New fileOperations
            fo.write("system.log", "INFO: " & Now() & dbDeleteQuery.CommandText.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
            Dim fo As New fileOperations
            fo.write("error.log", "ERR: " & Now() & ex.Message)

            Return False
        Finally
            dbConnection.Close()
        End Try
    End Function

    Public Function fillData(table As String, columns As String, Optional withwherecondition As String = "") As DataSet
        Dim dbConnection As New MySqlConnection(dbConnectionString)
        Dim dbSelectQuery As String = "select " & columns & " from " & schema & "." & table & " " & withwherecondition
        Dim dbAdapter As New MySqlDataAdapter(dbSelectQuery, dbConnection)
        Dim ds As New DataSet
        Try
            dbConnection.Open()
            dbAdapter.Fill(ds)
            Return ds
            Dim fo As New fileOperations
            fo.write("system.log", "INFO: " & Now() & dbSelectQuery.ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
            Dim fo As New fileOperations
            fo.write("error.log", "ERR: " & Now() & ex.Message)
            Return ds
        Finally
            dbConnection.Close()
        End Try
    End Function

    Public Function fillCombo(table As String, column As String, cbo As ComboBox, Optional withwherecondition As String = "") As Boolean
        Dim dbConnection As New MySqlConnection(dbConnectionString)
        Dim dbSelectQuery As String = "select  distinct " & column & " from " & schema & "." & table & " " & withwherecondition & " order by 1"
        Dim dbAdapter As New MySqlDataAdapter(dbSelectQuery, dbConnection)
        Dim dt As New DataTable
        Try
            dbConnection.Open()
            dbAdapter.Fill(dt)
            cbo.Items.Clear()
            For row As Integer = 0 To dt.Rows.Count - 1
                cbo.Items.Add(dt.Rows(row).Item(0).ToString)
            Next
            Return True
            Dim fo As New fileOperations
            fo.write("system.log", "INFO: " & Now() & dbSelectQuery.ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
            Dim fo As New fileOperations
            fo.write("error.log", "ERR: " & Now() & ex.Message)

            Return False
        Finally
            dbConnection.Close()
        End Try
    End Function

    Public Function fillCombo(table As String, column As String, cbo As ComboBox, includeId As Boolean, Optional withwherecondition As String = "") As Boolean
        Dim dbConnection As New MySqlConnection(dbConnectionString)
        If column.EndsWith("name") And includeId Then
            column = "concat(" & column.Replace("name", "id") & ",'. ', " & column & ") as " & column
        End If
        Dim dbSelectQuery As String = "select  distinct " & column & " from " & schema & "." & table & " " & withwherecondition & " order by 1"
        Dim dbAdapter As New MySqlDataAdapter(dbSelectQuery, dbConnection)
        Dim dt As New DataTable
        Try
            dbConnection.Open()
            dbAdapter.Fill(dt)
            cbo.Items.Clear()
            For row As Integer = 0 To dt.Rows.Count - 1
                cbo.Items.Add(dt.Rows(row).Item(0).ToString)
            Next
            Return True
            Dim fo As New fileOperations
            fo.write("system.log", "INFO: " & Now() & dbSelectQuery.ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
            Dim fo As New fileOperations
            fo.write("error.log", "ERR: " & Now() & ex.Message)

            Return False
        Finally
            dbConnection.Close()
        End Try
    End Function

    Public Function fillCombo(table As String, column As String, cbo As ToolStripComboBox, Optional withwherecondition As String = "") As Boolean
        Dim dbConnection As New MySqlConnection(dbConnectionString)
        Dim dbSelectQuery As String = "select  distinct " & column & " from " & schema & "." & table & " " & withwherecondition & " order by 1"
        Dim dbAdapter As New MySqlDataAdapter(dbSelectQuery, dbConnection)
        Dim dt As New DataTable
        Try
            dbConnection.Open()
            dbAdapter.Fill(dt)
            cbo.Items.Clear()
            For row As Integer = 0 To dt.Rows.Count - 1
                cbo.Items.Add(dt.Rows(row).Item(0).ToString)
            Next
            Return True
            Dim fo As New fileOperations
            fo.write("system.log", "INFO: " & Now() & dbSelectQuery.ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
            Dim fo As New fileOperations
            fo.write("error.log", "ERR: " & Now() & ex.Message)
            Return False
        Finally
            dbConnection.Close()
        End Try
    End Function

End Class
