Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim query As String = "INSERT INTO `museum_db`.`artifacts_tbl` (`artifact_name`, `country`, `year_found`, `condition`) VALUES (@artifact_name, @country, @year_found, @condition);"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=museum_db;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@artifact_name", txtArtifactName.Text)
                    cmd.Parameters.AddWithValue("@country", txtCountry.Text)
                    cmd.Parameters.AddWithValue("@year_found", CInt(numYearFound.Text))
                    cmd.Parameters.AddWithValue("@condition", cbCondition.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("New artifact inserted!")
                    txtArtifactName.Clear()
                    txtCountry.Clear()
                    numYearFound.Value = 0
                    cbCondition.SelectedIndex = -1
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Dim query As String = "SELECT * FROM museum_db.artifacts_tbl WHERE is_deleted = 0;"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=museum_db;")
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
                DataGridView1.Columns("id").Visible = False
                DataGridView1.Columns("is_deleted").Visible = False
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtArtifactName.Text = selectedRow.Cells("artifact_name").Value.ToString()
            txtCountry.Text = selectedRow.Cells("country").Value.ToString()
            numYearFound.Text = selectedRow.Cells("year_found").Value.ToString()
            cbCondition.Text = selectedRow.Cells("condition").Value.ToString()
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim query As String = "UPDATE `museum_db`.`artifacts_tbl` 
                                SET `artifact_name` = @artifact_name, 
                                `country` = @country, 
                                `year_found` = @year_found 
                                WHERE (`id` = @id);"

        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=museum_db;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", txtArtifactName.Text)
                    cmd.Parameters.AddWithValue("@age", txtCountry.Text)
                    cmd.Parameters.AddWithValue("@email", CInt(numYearFound.Text))
                    cmd.Parameters.AddWithValue("@age", cbCondition.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record updated successfully!")
                    txtArtifactName.Clear()
                    txtCountry.Clear()
                    numYearFound.Value = 0
                    cbCondition.SelectedIndex = -1
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Dim query As String = "DELETE FROM `museum_db`.`artifacts_tbl` WHERE (`id` = @id);"
        Dim query As String = "UPDATE `museum_db`.`artifacts_tbl` 
                                SET is_deleted = 1
                                WHERE (`id` = @id);"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=museum_db;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", CInt(txtHiddenID.Text))
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record deleted successfully!")
                    txtArtifactName.Clear()
                    txtCountry.Clear()
                    numYearFound.Value = 0
                    cbCondition.SelectedIndex = -1
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
