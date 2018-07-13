Imports System.IO
Public Class Form1
    Dim csvRecords As New ArrayList()
    Dim lstDataColumns As New ArrayList()
    Dim CategoryFileName As String
    Dim FileName As String


    Private Sub HirakuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HirakuToolStripMenuItem.Click

        Dim OFD As New OpenFileDialog
        OFD.InitialDirectory = "File\"
        OFD.Filter = "CSVファイル(*.csv)|*.html;*.htm|すべてのファイル(*.*)|*.*"
        OFD.FilterIndex = 2
        'タイトルを設定する
        OFD.Title = "開くファイルを選択してください"
        'ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
        OFD.RestoreDirectory = True
        '存在しないファイルの名前が指定されたとき警告を表示する
        'デフォルトでTrueなので指定する必要はない
        OFD.CheckFileExists = True
        '存在しないパスが指定されたとき警告を表示する
        'デフォルトでTrueなので指定する必要はない
        OFD.CheckPathExists = True

        'ダイアログを表示する
        If OFD.ShowDialog() = DialogResult.OK Then
            'OKボタンがクリックされたとき、選択されたファイルを表示する


            'CategoryFileName = OFD.FileName.Replace(".csv", " カテゴリー.csv")
            'FileName = OFD.FileName

            'lstDataColumns = ReadCsvFile(CategoryFileName) 'カテゴリはそのうちファイルを統合する
            'If lstDataColumns Is Nothing Then
            '    Return
            'End If

            csvRecords = ReadCsvFile(OFD.FileName)
            If csvRecords Is Nothing Then
                Return
            End If

            Dim csvColumnOut As New ArrayList
            Dim csvFieldOut As New ArrayList
            'Dim lstDataColumnOut As New ArrayList

            Dim i As Int32
            Dim j As Int32
            '        Dim k As Int32
            For i = 0 To csvRecords.Count - 1
                csvColumnOut = csvRecords(0)
                'Do Until i + 1 <= csvRecords.Count
                csvFieldOut = csvRecords(i)

                lstData.Items.Add(csvFieldOut(0), i) '名前要素をアイテムとして追加

                For j = 1 To csvFieldOut.Count - 1 '名前以外をサブアイテムとして追加
                    lstData.Items(i).SubItems.Add(csvFieldOut(j))
                Next
                'Loop
            Next


            'lstData.Columns.AddRange(csvColumnOut.ToArray(csvRecords(0)))
            For k = 0 To csvColumnOut.Count - 1 '=0 'カラム要素
                If lstData.Items.Count > 0 Then '名前がリストビューに入ってたら
                    lstData.Columns.Add(csvColumnOut(k), 100, HorizontalAlignment.Left)
                End If
            Next

        End If

    End Sub


    Private Function ReadCsvFile(name As String) As ArrayList

        Dim strLine As String '1行
        Dim strTemp() As String '戻り配列
        Dim intCnt As Integer '配列添字
        Dim strData As String = "" 'データ

        Try
            Dim objFile As New StreamReader(name, System.Text.Encoding.Default)
            Dim csvRecords As New ArrayList()

            '次の行へ
            strLine = objFile.ReadLine()

            While (strLine <> "")
                '行単位データをカンマで分割し、配列に格納
                strTemp = Split(strLine, ",")

                'フィールドデータ用配列
                Dim csvFields As New ArrayList

                For intCnt = 0 To UBound(strTemp)
                    '列データ strTemp(intCnt)を取得
                    csvFields.Add(strTemp(intCnt))
                Next

                'レコードサイズを固定
                csvFields.TrimToSize()
                csvRecords.Add(csvFields)

                '次の行へ
                strLine = objFile.ReadLine()

            End While
            'レコードサイズを固定
            csvRecords.TrimToSize()

            'ファイルのクローズ
            objFile.Close()

            Return csvRecords

        Catch ex As System.IO.FileNotFoundException
            'ファイルが存在しないとき
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try

    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        lstData.Items.Clear()
        Dim csvRecords As New ArrayList()
        Dim lstDataColumns As New ArrayList()

        lstDataColumns = ReadCsvFile(CategoryFileName)
        If lstDataColumns Is Nothing Then
            Return
        End If

        csvRecords = ReadCsvFile(FileName) 'そのうちファイル名を変更できるようにする
        If csvRecords Is Nothing Then
            Return
        End If

        Dim csvFieldOut As New ArrayList
        Dim lstDataColumnOut As New ArrayList

        Dim i As Int32
        Dim j As Int32
        Dim k As Int32
        Dim h As Integer = 0

        For i = 0 To csvRecords.Count - 1
            csvFieldOut = csvRecords(i)
            If csvFieldOut(0).indexof(txtSearch.Text) <> -1 Then
                lstData.Items.Add(csvFieldOut(0), h)
                For j = 1 To csvFieldOut.Count - 1
                    lstData.Items(h).SubItems.Add(csvFieldOut(j))
                Next
                h = h + 1
            End If
        Next

    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click

    End Sub

End Class
