Public Class stockkeluar

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Formpilih.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan Semua form terisi")
        Else
            Dim tblsimpan As String = "INSERT INTO stock_keluar(Kode_Barang,Jumlah,Tanggal_keluar)" _
                                & "VALUES('" & TextBox1.Text & "','" & TextBox3.Text & "','" & DateTimePicker1.Text & "')"
            Call simpandata(tblsimpan)
            MsgBox("Data Stock Berhasil Ditambah", MsgBoxStyle.Information, "Information")
            Form5.DataGridView1.Refresh()
            Me.Close()
        End If
    End Sub
End Class