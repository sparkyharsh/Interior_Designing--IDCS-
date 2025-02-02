﻿Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging

Public Class Objects

    Dim con1 As New SqlConnection("server=.;Database=images;integrated security=true")


    'For Browse button
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            With OpenFileDialog1
                .Filter = ("images|*.png; *.bmp; *.jpg; *.jpeg; *.gif; *ico;")
                .FilterIndex = 1
            End With
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    'for insert
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim command1 As New SqlCommand("Insert into Objects(Object,Details,ImageDisplay)values(@Object,@Details,@ImageDisplay)", conn)

        command1.Parameters.Add("@Object", SqlDbType.VarChar).Value = ComboBox1.Text
        command1.Parameters.Add("@Details", SqlDbType.VarChar).Value = TextBox2.Text

        Dim memstr As New MemoryStream
        PictureBox1.Image.Save(memstr, PictureBox1.Image.RawFormat)
        command1.Parameters.Add("@ImageDisplay", SqlDbType.Image).Value = memstr.ToArray

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        command1.ExecuteNonQuery()
        MessageBox.Show("Image inserted")
        conn.Close()
        bind1()


    End Sub



    Private Sub bind1()
        Dim command1 As New SqlCommand("select *from Objects order by Object desc", conn)
        Dim adapter As New SqlDataAdapter(command1)

        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.RowTemplate.Height = 90

        Dim pic1 As New DataGridViewImageColumn
        DataGridView1.DataSource = table
        pic1 = DataGridView1.Columns(2)
        pic1.ImageLayout = DataGridViewImageCellLayout.Stretch
    End Sub

    Private Sub Designs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bind1()

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd1 As New SqlCommand("select InterObject from InteriorObject order by InterObject", conn)
        Dim d2 As SqlDataReader = cmd1.ExecuteReader
        While d2.Read
            ComboBox1.Items.Add(d2(0).ToString)
        End While

    End Sub

    'for close
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub


    'for delete
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim delete1 As String = "Delete from Objects where Object='" & ComboBox1.Text & "'"
        Dim command1 As New SqlCommand(delete1, conn)

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        command1.ExecuteNonQuery()
        MessageBox.Show("Image deleted")

        conn.Close()
        bind1()
    End Sub



    'for update
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim delete1 As String = "Delete from Objects where Object='" & ComboBox1.Text & "'"
        Dim command2 As New SqlCommand(delete1, conn)

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        command2.ExecuteNonQuery()
        MessageBox.Show("Image deleted")

        conn.Close()
        bind1()



        Dim command1 As New SqlCommand("Insert into Objects(Object,Details,ImageDisplay)values(@Object,@Details,@ImageDisplay)", conn)

        command1.Parameters.Add("@Object", SqlDbType.VarChar).Value = ComboBox1.Text
        command1.Parameters.Add("@Details", SqlDbType.VarChar).Value = TextBox2.Text

        Dim memstr As New MemoryStream
        PictureBox1.Image.Save(memstr, PictureBox1.Image.RawFormat)
        command1.Parameters.Add("@ImageDisplay", SqlDbType.Image).Value = memstr.ToArray

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        command1.ExecuteNonQuery()
        MessageBox.Show("Image inserted")
        conn.Close()
        bind1()


    End Sub


    'for DGV click
    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click

        ComboBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value

        Dim img As Byte()
        img = DataGridView1.CurrentRow.Cells(2).Value

        Dim memstr As New MemoryStream(img)

        PictureBox1.Image = Image.FromStream(memstr)

    End Sub
End Class