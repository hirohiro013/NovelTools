Imports System.IO
Public Class Form1
    Dim myform As FrmSelect
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim csvRecords As New ArrayList()
        Dim lstDataColumns As New ArrayList()


        myform = CType(Me.Owner, FrmSelect)
        Dim filename As String
        filename = myform.cmbFile.SelectedItem


        lstDataColumns = ReadCsvFile("File\Category\" & filename & " カテゴリ.csv")
        If lstDataColumns Is Nothing Then
            Return
        End If

        csvRecords = ReadCsvFile("File\" & filename & ".csv") 'そのうちファイル名を変更できるようにする
        If csvRecords Is Nothing Then
            Return
        End If

        Dim csvFieldOut As New ArrayList
        Dim lstDataColumnOut As New ArrayList

        Dim i As Int32
        Dim j As Int32
        Dim k As Int32
        For i = 0 To csvRecords.Count - 1

            csvFieldOut = csvRecords(i)

            lstData.Items.Add(csvFieldOut(0), i)

            For j = 1 To csvFieldOut.Count - 1
                lstData.Items(i).SubItems.Add(csvFieldOut(j))
            Next
        Next

        For k = 0 To lstDataColumns.Count - 1 '=0
            lstDataColumnOut = lstDataColumns(k)
            If lstData.Items.Count > 0 Then
                For i = 0 To lstDataColumnOut.Count - 1
                    lstData.Columns.Add(lstDataColumnOut(i), 100, HorizontalAlignment.Left)
                Next
            End If
        Next

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


        myform = CType(Me.Owner, FrmSelect)
        Dim filename As String
        filename = myform.cmbFile.SelectedItem


        lstDataColumns = ReadCsvFile("File\Category\" & filename & " カテゴリ.csv")
        If lstDataColumns Is Nothing Then
            Return
        End If

        csvRecords = ReadCsvFile("File\" & filename & ".csv") 'そのうちファイル名を変更できるようにする
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
End Class
