﻿Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

   Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles AcceptButton.Click
      Oracle.UserName = txtUsername.Text
      Oracle.PassWd = txtPassword.Text
      Oracle.Server = txtHost.Text



      Oracle.myOracleConnection.ConnectionString = "user id=" & Oracle.UserName & ";data source=" & Oracle.Server &
                                      ";password=" & Oracle.PassWd & ";persist security info=False"



      Oracle.myOracleCommand.CommandType = CommandType.Text
      Oracle.myOracleCommand.CommandText = "Select * from booking"
      Oracle.myOracleCommand.Connection = Oracle.myOracleConnection

      Oracle.myOracleDataAdapter.SelectCommand = Oracle.myOracleCommand
      Oracle.myOracleCommandBuilder = New System.Data.OracleClient.OracleCommandBuilder(Oracle.myOracleDataAdapter)

      Try

         Oracle.myOracleDataAdapter.Fill(Oracle.myTable)

         Hide()

         Form1.Show()

      Catch ex As Exception

      End Try

   End Sub

   Private Sub cnclButton_Click(sender As Object, e As EventArgs) Handles cnclButton.Click
      Close()
   End Sub
End Class
