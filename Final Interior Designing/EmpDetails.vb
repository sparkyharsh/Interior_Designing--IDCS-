Imports System.Data.SqlClient

Public Class EmpDetails


    Dim RandGen As New Random
    Dim a As String

    'save
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        saverecord()
    End Sub
    Sub saverecord()

        If TextBox1.Text = "" Then
            MsgBox("Please enter the Employee id.")
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MsgBox("Please enter the Employee Name.")
        End If
        If TextBox3.Text = "" Then
            MsgBox("Please enter the Email address.")
        End If
        If TextBox4.Text = "" Then
            MsgBox("Please enter the phone number.")
        End If
        If TextBox5.Text = "" Then
            MsgBox("Please enter the address.")
        End If
        If ComboBox1.Text = "" Then
            MsgBox("Please select the Specialization")
        End If

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("select *from EmpDetails where EmpId='" & TextBox1.Text & "'", conn)
        MsgBox("select *from EmpDetails where EmpId='" & TextBox1.Text & "'")
        Dim d1 As SqlDataReader = cmd0.ExecuteReader
        If d1.HasRows Then
            MsgBox("select *from EmpDetails where EmpId='" & TextBox1.Text & "'")
            MsgBox("record is already present")
            Exit Sub
        End If

        Dim q1var, q2var As String
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        q1var = "insert into EmpDetails("
        q2var = "values("

        q1var = q1var & "EmpId" & ","
        q2var = q2var & "'" & TextBox1.Text & "',"
        q1var = q1var & "EmpName" & ","
        q2var = q2var & "'" & TextBox2.Text & "',"
        q1var = q1var & "Email" & ","
        q2var = q2var & "'" & TextBox3.Text & "',"
        q1var = q1var & "Phone" & ","
        q2var = q2var & "'" & TextBox4.Text & "',"
        q1var = q1var & "Address" & ","
        q2var = q2var & "'" & TextBox5.Text & "',"
        q1var = q1var & "Specialization" & ")"
        q2var = q2var & "'" & ComboBox1.Text & "')"



        MsgBox(q1var & q2var)
        Dim cmd1 As New SqlCommand(q1var & q2var, conn)
        cmd1.ExecuteNonQuery()
        MsgBox("data saved")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox1.Text = ""

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        disRecords()

    End Sub


    Sub disRecords()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim ds1 As New DataSet
        Dim adp As New SqlDataAdapter("select * from EmpDetails order by EmpId", conn)
        adp.Fill(ds1)
        DataGridView1.DataSource = ds1.Tables(0)
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub

    'modify
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If vbNo = MsgBox("are you sure, you want to update?", MsgBoxStyle.YesNo, "update") Then Exit Sub
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd1 As New SqlCommand("delete from EmpDetails where EmpId='" & pkvar & "'", conn)
        cmd1.ExecuteNonQuery()
        If conn.State = ConnectionState.Open Then conn.Close()
        saverecord()
    End Sub

    'delete
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If vbNo = MsgBox("are you sure, you want to delete this?", MsgBoxStyle.YesNo, "delete") Then Exit Sub
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd1 As New SqlCommand("delete from EmpDetails where EmpId='" & pkvar & "'", conn)
        cmd1.ExecuteNonQuery()
        If conn.State = ConnectionState.Open Then conn.Close()
        disRecords()
    End Sub

    'close
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    'DGV
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        pkvar = DataGridView1.CurrentRow.Cells(0).Value

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("select * from EmpDetails where EmpId='" & pkvar & "'", conn)

        Dim d1 As SqlDataReader = cmd0.ExecuteReader
        If d1.HasRows Then
            d1.Read()
            TextBox1.Text = d1(0).ToString
            TextBox2.Text = d1(1).ToString
            TextBox3.Text = d1(2).ToString
            TextBox4.Text = d1(3).ToString
            TextBox5.Text = d1(4).ToString
            ComboBox1.Text = d1(5).ToString

        Else
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            ComboBox1.Text = ""

        End If
    End Sub

    Private Sub EmpDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        disRecords()
        a = RandGen.Next(9001, 9999).ToString
        TextBox1.Text = "EI-" + a
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not (Asc(e.KeyChar) = 8) And Not (Asc(e.KeyChar) = 32) Then
            Dim allowednos As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
            If Not allowednos.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("please enter a character")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyz"
            Dim allowednos As String = "1234567890"
            Dim allowedsymbols As String = "@."
            If Not allowednos.Contains(e.KeyChar.ToString.ToLower) And Not allowedchars.Contains(e.KeyChar.ToString) And Not allowedsymbols.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("please enter a valid email")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowednos As String = "1234567890"
            If Not allowednos.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("please enter a number!")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class