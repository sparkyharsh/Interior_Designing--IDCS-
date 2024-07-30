Imports System.Data.SqlClient

Public Class Quotation

    Dim RandGen As New Random
    Dim a As String

    Private Sub Quotation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd1 As New SqlCommand("select InterObject from InteriorObject order by InterObject", conn)
        Dim d2 As SqlDataReader = cmd1.ExecuteReader
        While d2.Read
            ComboBox3.Items.Add(d2(0).ToString)
        End While


        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd2 As New SqlCommand("select Design from Designs order by Design", conn)
        Dim d3 As SqlDataReader = cmd2.ExecuteReader
        While d3.Read
            ComboBox4.Items.Add(d3(0).ToString)
        End While

        a = RandGen.Next(111, 499).ToString
        TextBox3.Text = "QO-" + a

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        saverecord()
    End Sub
    Sub saverecord()


        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("select *from Quotation where Id='" & TextBox3.Text & "'", conn)
        MsgBox("select *from Quotation where Id='" & TextBox3.Text & "'")
        Dim d1 As SqlDataReader = cmd0.ExecuteReader
        If d1.HasRows Then
            MsgBox("select *from Quotation where Id='" & TextBox3.Text & "'")
            MsgBox("record is already present")
            Exit Sub
        End If


        Dim q1var, q2var As String
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        q1var = "insert into Quotation("
        q2var = "values("
        q1var = q1var & "Id" & ","
        q2var = q2var & "'" & TextBox3.Text & "',"
        q1var = q1var & "Design" & ","
        q2var = q2var & "'" & ComboBox4.Text & "',"
        q1var = q1var & "IntObject" & ","
        q2var = q2var & "'" & ComboBox3.Text & "',"
        q1var = q1var & "Cost1" & ","
        q2var = q2var & "'" & TextBox1.Text & "',"
        q1var = q1var & "Cost2" & ","
        q2var = q2var & "'" & TextBox4.Text & "',"
        q1var = q1var & "TotalCost" & ")"
        q2var = q2var & "'" & TextBox2.Text & "')"

        MsgBox(q1var & q2var)
        Dim cmd1 As New SqlCommand(q1var & q2var, conn)
        cmd1.ExecuteNonQuery()
        MsgBox("data saved")
        TextBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox3.Text = ""
        TextBox1.Text = ""
        TextBox4.Text = ""
        TextBox2.Text = ""
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        disRecords()

    End Sub

    Sub disRecords()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim ds1 As New DataSet
        Dim adp As New SqlDataAdapter("select * from Quotation order by Id", conn)
        adp.Fill(ds1)
        DataGridView1.DataSource = ds1.Tables(0)
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        disRecords()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        pkvar = DataGridView1.CurrentRow.Cells(0).Value

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("select * from Quotation where Id ='" & pkvar & "'", conn)

        Dim d1 As SqlDataReader = cmd0.ExecuteReader
        If d1.HasRows Then
            d1.Read()

            TextBox3.Text = d1(0).ToString
            ComboBox4.Text = d1(1).ToString
            ComboBox3.Text = d1(2).ToString
            TextBox1.Text = d1(3).ToString
            TextBox4.Text = d1(4).ToString
            TextBox2.Text = d1(5).ToString
           
        Else

            TextBox3.Text = ""
            ComboBox4.Text = ""
            ComboBox3.Text = ""
            TextBox1.Text = ""
            TextBox4.Text = ""
            TextBox2.Text = ""
        End If
    End Sub

    'modify
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If vbNo = MsgBox("are you sure, you want to update?", MsgBoxStyle.YesNo, "update") Then Exit Sub
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd1 As New SqlCommand("delete from Quotation where Id='" & pkvar & "'", conn)
        cmd1.ExecuteNonQuery()
        If conn.State = ConnectionState.Open Then conn.Close()
        saverecord()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If vbNo = MsgBox("are you sure, you want to delete this?", MsgBoxStyle.YesNo, "delete") Then Exit Sub
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd1 As New SqlCommand("delete from Quotation where Id='" & pkvar & "'", conn)
        cmd1.ExecuteNonQuery()
        If conn.State = ConnectionState.Open Then conn.Close()
        disRecords()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowednos As String = "1234567890"
            If Not allowednos.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Please enter a price!")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub


    'for calculate
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        TextBox2.Text = ((Val(TextBox1.Text) + Val(TextBox4.Text))).ToString
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowednos As String = "1234567890"
            If Not allowednos.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Please enter a price!")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    'for calculate
    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        TextBox2.Text = ((Val(TextBox1.Text) + Val(TextBox4.Text))).ToString
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class