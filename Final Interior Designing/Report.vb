Imports System.Data.SqlClient

Public Class Report

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim ds1 As New DataSet
        Dim adp As New SqlDataAdapter("select * from Bill order by ReceiptNo", conn)
        adp.Fill(ds1)
        DataGridView1.DataSource = ds1.Tables(0)
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub

   

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim Xpos, Ypos As Long
        Ypos = 50
        Dim myfont As New Font("Algerian", 22)
        Xpos = 10
        e.Graphics.DrawString("Interior Designing", myfont, Brushes.Black, Xpos, Ypos)
        e.Graphics.DrawString("___________________", myfont, Brushes.Black, Xpos, Ypos)
        Ypos += 50
        myfont = New Font("Comic Sans MS", 18)
        e.Graphics.DrawString("UNITY BUILDING, Bengaluru, Karnataka 560002. ", myfont, Brushes.Black, Xpos, Ypos)
        Ypos += 100
        Xpos = 10
        e.Graphics.DrawString("Billing Report : ", myfont, Brushes.Black, Xpos, Ypos)
        e.Graphics.DrawString("__________", myfont, Brushes.Black, Xpos, Ypos)
        Ypos += 50
        Xpos = 10

        myfont = New Font("Bookman Old Style", 14)
        e.Graphics.DrawString("Receipt No", myfont, Brushes.Black, Xpos, Ypos)
        Xpos = Xpos + 110
        e.Graphics.DrawString("Cust-Id", myfont, Brushes.Black, Xpos, Ypos)
        Xpos = Xpos + 110
        e.Graphics.DrawString("Emp-Id", myfont, Brushes.Black, Xpos, Ypos)
        Xpos = Xpos + 110
        e.Graphics.DrawString("Emp Name", myfont, Brushes.Black, Xpos, Ypos)
        Xpos = Xpos + 110
        e.Graphics.DrawString("Quotation", myfont, Brushes.Black, Xpos, Ypos)
        Xpos = Xpos + 110
        e.Graphics.DrawString("Amount", myfont, Brushes.Black, Xpos, Ypos)
        Xpos = Xpos + 110
        e.Graphics.DrawString("Date", myfont, Brushes.Black, Xpos, Ypos)
        Xpos = Xpos + 110
        Ypos += 25

        For Each r As DataGridViewRow In DataGridView1.Rows
            Xpos = 10
            e.Graphics.DrawString(r.Cells(0).Value, myfont, Brushes.Black, Xpos, Ypos)
            Xpos = Xpos + 110
            e.Graphics.DrawString(r.Cells(1).Value, myfont, Brushes.Black, Xpos, Ypos)
            Xpos = Xpos + 110
            e.Graphics.DrawString(r.Cells(2).Value, myfont, Brushes.Black, Xpos, Ypos)
            Xpos = Xpos + 110
            e.Graphics.DrawString(r.Cells(3).Value, myfont, Brushes.Black, Xpos, Ypos)
            Xpos = Xpos + 110
            e.Graphics.DrawString(r.Cells(4).Value, myfont, Brushes.Black, Xpos, Ypos)
            Xpos = Xpos + 110
            e.Graphics.DrawString(r.Cells(5).Value, myfont, Brushes.Black, Xpos, Ypos)
            Xpos = Xpos + 110
            e.Graphics.DrawString(r.Cells(6).Value, myfont, Brushes.Black, Xpos, Ypos)
            Xpos = Xpos + 110
            Ypos += 25
        Next

        myfont = New Font("Comic Sans MS", 16)
        Xpos = 50
        e.Graphics.DrawString("Thankyou for the business!! ", myfont, Brushes.Black, Xpos, Ypos)
        Ypos += 80


    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim pkVar As String
        pkVar = DataGridView1.CurrentRow.Cells(0).Value
        TextBox1.Text = pkVar
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim ds1 As New DataSet
        Dim adp As New SqlDataAdapter("select * from Bill where receiptno='" & TextBox1.Text & "' order by ReceiptNo", conn)
        adp.Fill(ds1)
        DataGridView1.DataSource = ds1.Tables(0)
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub
End Class