Public Class stockkeluar

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Formpilih.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan Semua form terisi")
        Else
            Dim njum As Integer = Val(TextBox6.Text) - Val(TextBox3.Text)
            Dim tblupdate As String = "Update stock set Jumlah = " & njum & " where kode = '" & TextBox1.Text & "'"
            Call simpandata(tblupdate)
            Dim tblsimpan As String = "INSERT INTO stock_masuk(Kode_barang,Jumlah_masuk,Tanggal)" _
                                      & "VALUES('" & TextBox1.Text & "','" & TextBox3.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "')"
            Call simpandata(tblsimpan)
            MsgBox("Data Stock Berhasil Ditambah", MsgBoxStyle.Information, "Information")
            Form5.isigrid()
            Me.Close()
        End If
    End Sub
End Class