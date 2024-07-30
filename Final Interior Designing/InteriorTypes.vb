﻿Imports System.Data.SqlClient

Public Class InteriorTypes

    'For Save button 
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        saverecord()
    End Sub

    Sub saverecord()
        If TextBox1.Text = "" Then
            MsgBox("please enter the Interior Type.")
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MsgBox("plaese enter the Details.")
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("select *from InteriorTypes where InterType='" & TextBox1.Text & "'", conn)
        MsgBox("select *from InteriorTypes where InterType='" & TextBox1.Text & "'")
        Dim d1 As SqlDataReader = cmd0.ExecuteReader
        If d1.HasRows Then
            MsgBox("select *from InteriorTypes where InterType='" & TextBox1.Text & "'")
            MsgBox("record is already present")
            Exit Sub
        End If

        Dim q1var, q2var As String
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        q1var = "insert into InteriorTypes("
        q2var = "values("
        q1var = q1var & "InterType" & ","
        q2var = q2var & "'" & TextBox1.Text & "',"
        q1var = q1var & "Details" & ")"
        q2var = q2var & "'" & TextBox2.Text & "')"
        MsgBox(q1var & q2var)
        Dim cmd1 As New SqlCommand(q1var & q2var, conn)
        cmd1.ExecuteNonQuery()
        MsgBox("data saved")
        TextBox1.Text = ""
        TextBox2.Text = ""
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        disRecords()

    End Sub

    Sub disRecords()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim ds1 As New DataSet
        Dim adp As New SqlDataAdapter("select * from InteriorTypes order by InterType", conn)
        adp.Fill(ds1)
        DataGridView1.DataSource = ds1.Tables(0)
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub


    'For Update button
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If vbNo = MsgBox("are you sure, you want to update?", MsgBoxStyle.YesNo, "update") Then Exit Sub
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd1 As New SqlCommand("delete from InteriorTypes where InterType='" & pkvar & "'", conn)
        cmd1.ExecuteNonQuery()
        If conn.State = ConnectionState.Open Then conn.Close()
        saverecord()
    End Sub

    'For Delete button
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If vbNo = MsgBox("are you sure, you want to delete this?", MsgBoxStyle.YesNo, "delete") Then Exit Sub
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd1 As New SqlCommand("delete from InteriorTypes where InterType='" & pkvar & "'", conn)
        cmd1.ExecuteNonQuery()
        If conn.State = ConnectionState.Open Then conn.Close()
        disRecords()
    End Sub

    'For Close button
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    'For DataGridView
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        pkvar = DataGridView1.CurrentRow.Cells(0).Value

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("select * from InteriorTypes where InterType='" & pkvar & "'", conn)

        Dim d1 As SqlDataReader = cmd0.ExecuteReader
        If d1.HasRows Then
            d1.Read()
            TextBox1.Text = d1(0).ToString
            TextBox2.Text = d1(1).ToString
        Else
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
    End Sub

    'For Form Load(To display the data present in DataGridView)
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        disRecords()
    End Sub
End Class