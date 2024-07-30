Imports System.Data.SqlClient

Public Class Bill

    Dim RandGen As New Random
    Dim a As String


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        saverecord()
    End Sub
    Sub saverecord()


        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("select *from Bill where ReceiptNo='" & TextBox1.Text & "'", conn)
        MsgBox("select *from Bill where ReceiptNo='" & TextBox1.Text & "'")
        Dim d1 As SqlDataReader = cmd0.ExecuteReader
        If d1.HasRows Then
            MsgBox("select *from Bill where ReceiptNo='" & TextBox1.Text & "'")
            MsgBox("record is already present")
            Exit Sub
        End If

        Dim q1var, q2var As String
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        q1var = "insert into Bill("
        q2var = "values("
        q1var = q1var & "ReceiptNo" & ","
        q2var = q2var & "'" & TextBox1.Text & "',"
        q1var = q1var & "CustId" & ","
        q2var = q2var & "'" & ComboBox3.Text & "',"
        q1var = q1var & "EmpId" & ","
        q2var = q2var & "'" & ComboBox4.Text & "',"
        q1var = q1var & "EmpName" & ","
        q2var = q2var & "'" & TextBox2 .Text & "',"
        q1var = q1var & "QuotationId" & ","
        q2var = q2var & "'" & ComboBox1.Text & "',"
        q1var = q1var & "TotalCost" & ","
        q2var = q2var & "'" & TextBox3.Text & "',"
        q1var = q1var & "Date" & ")"
        q2var = q2var & "'" & DateTimePicker1.Text & "')"

      
       
        MsgBox(q1var & q2var)
        Dim cmd1 As New SqlCommand(q1var & q2var, conn)
        cmd1.ExecuteNonQuery()
        MsgBox("data saved")
        ComboBox1.Text = ""
        ComboBox3.Text = ""
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        disRecords()

    End Sub

    Sub disRecords()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim ds1 As New DataSet
        Dim adp As New SqlDataAdapter("select * from Bill order by ReceiptNo", conn)
        adp.Fill(ds1)
        DataGridView1.DataSource = ds1.Tables(0)
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If vbNo = MsgBox("are you sure, you want to update?", MsgBoxStyle.YesNo, "update") Then Exit Sub
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd1 As New SqlCommand("delete from Bill where ReceiptNo='" & pkvar & "'", conn)
        cmd1.ExecuteNonQuery()
        If conn.State = ConnectionState.Open Then conn.Close()
        saverecord()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If vbNo = MsgBox("are you sure, you want to delete this?", MsgBoxStyle.YesNo, "delete") Then Exit Sub
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd1 As New SqlCommand("delete from Bill where ReceiptNo='" & pkvar & "'", conn)
        cmd1.ExecuteNonQuery()
        If conn.State = ConnectionState.Open Then conn.Close()
        disRecords()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Bill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

        Dim cmd0 As New SqlCommand("select Id from Quotation order by Id", conn)
        Dim d1 As SqlDataReader = cmd0.ExecuteReader
        While d1.Read
            ComboBox1.Items.Add(d1(0).ToString)
        End While



        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd2 As New SqlCommand("select CustId from CustDetails order by CustId", conn)
        Dim d3 As SqlDataReader = cmd2.ExecuteReader
        While d3.Read
            ComboBox3.Items.Add(d3(0).ToString)
        End While

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd3 As New SqlCommand("select EmpId from EmpDetails order by EmpId", conn)
        Dim d4 As SqlDataReader = cmd3.ExecuteReader
        While d4.Read
            ComboBox4.Items.Add(d4(0).ToString)
        End While





        a = RandGen.Next(501, 999).ToString
        TextBox1.Text = "BK-" + a




    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        pkvar = DataGridView1.CurrentRow.Cells(0).Value

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("select * from Bill where ReceiptNo='" & pkvar & "'", conn)

        Dim d1 As SqlDataReader = cmd0.ExecuteReader
        If d1.HasRows Then
            d1.Read()
            TextBox1.Text = d1(0).ToString
            ComboBox3.Text = d1(1).ToString
            ComboBox4.Text = d1(2).ToString
            TextBox2.Text = d1(3).ToString
            ComboBox1.Text = d1(4).ToString
            TextBox3.Text = d1(5).ToString


        Else
            TextBox1.Text = ""
            ComboBox3.Text = ""
            ComboBox4.Text = ""
            TextBox2.Text = ""
            ComboBox1.Text = ""
            TextBox3.Text = ""

        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        disRecords()
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim Cmd4 As New SqlCommand("select EmpName from EmpDetails where EmpId='" & ComboBox4.Text & "'", conn)
        Dim D4 As SqlDataReader = Cmd4.ExecuteReader()
        If D4.Read() Then
            TextBox2.Text = D4(0).ToString
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim Cmd4 As New SqlCommand("select TotalCost from Quotation where Id='" & ComboBox1.Text & "'", conn)
        Dim D4 As SqlDataReader = Cmd4.ExecuteReader()
        If D4.Read() Then
            TextBox3.Text = D4(0).ToString
        End If
    End Sub
End Class