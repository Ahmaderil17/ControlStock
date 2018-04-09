Public Class kondisistock

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Formpilih.TextBox1.Text = "2"
        Formpilih.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan Semua form terisi")
        Else
            Dim tblsimpan As String = "INSERT INTO kondisi_stock(Kode_Barang,Status,Jumlah,keterangan,Tanggal)" _
                                      & "VALUES('" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & DateTimePicker1.Text & "')"
            Call simpandata(tblsimpan)
            MsgBox("Data Stock Berhasil Ditambah", MsgBoxStyle.Information, "Information")
            Form5.DataGridView1.Refresh()
            Me.Close()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class

