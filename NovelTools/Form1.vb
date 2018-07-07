Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim csvRecords As New ArrayList()
        Dim lstDataColumns As New ArrayList()

        lstDataColumns = ReadCsvFile("Category\アンダードッグ カテゴリ.csv")
        If lstDataColumns Is Nothing Then
            Return
        End If

        csvRecords = ReadCsvFile("File\アンダードッグ.csv") 'そのうちファイル名を変更できるようにする
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

        For k = 0 To lstDataColumns.Count - 1
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

    'Private Function Tabtab(ByRef targetData As String, ByRef keta As Integer, ByRef moji As String) As String
    '    If targetData Is Nothing Then
    '        targetData = ""
    '    End If

    '    Dim pad As Char

    '    Dim value As String = String.Empty
    '    'パディングする文字数を演算
    '    '(文字数=桁-(対象文字列のバイト数-対象文字列の文字列数))
    '    Dim PadLength As Integer = keta - (System.Text.Encoding.GetEncoding(65001).GetByteCount(targetData) - targetData.Length)
    '    pad = Convert.ToChar(" ")

    '    value = targetData.PadRight(PadLength, moji.ToCharArray()(0))

    '    Return value

    'End Function

    '    Function padRight(ByVal st As String, ByVal len As Integer) As String
    '        Dim len0 As Integer
    '        len0 = LenB(st)
    '        If len - len0 < 4 Then
    '            Do Until len - len0 < 4
    '                len = len + 1
    '            Loop
    '        Else
    '            Return RTrim(st) & Space(len - len0)
    '        End If
    '    End Function

    '    Private Shared Function LenB(ByVal str As String) As Integer
    '        'Shift JISに変換したときに必要なバイト数を返す
    '        Return System.Text.Encoding.GetEncoding(65001).GetByteCount(str)
    '    End Function

    '    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
    '        Application.Exit()
    '    End Sub
End Class
