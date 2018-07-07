Public Class FrmSelect
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim myform As New Form1
        myform.Show(Me)
    End Sub

    Private Sub FrmSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ファイルパスからファイル名を取得する
        Dim files As String() = System.IO.Directory.GetFiles("File\", "*.csv", System.IO.SearchOption.TopDirectoryOnly)
        Dim i As Integer
        For i = 0 To files.Length - 1
            files(i) = Replace(files(i), "File\", "", 1, 1, CompareMethod.Binary)
            files(i) = Replace(files(i), ".csv", "", 1, 1, CompareMethod.Binary)
        Next
        'ListBox1に結果を表示する
        cmbFile.Items.AddRange(files)
    End Sub

End Class