<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lstData = New System.Windows.Forms.ListView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ファイルFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HirakuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.新規作成NToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.終了XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.txtSearch.Location = New System.Drawing.Point(121, 73)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(784, 39)
        Me.txtSearch.TabIndex = 0
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.lblSearch.Location = New System.Drawing.Point(12, 79)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(86, 33)
        Me.lblSearch.TabIndex = 1
        Me.lblSearch.Text = "検索:"
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.AutoSize = True
        Me.btnSearch.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.btnSearch.Location = New System.Drawing.Point(911, 72)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(112, 43)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "検索"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnView.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnView.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.btnView.Location = New System.Drawing.Point(18, 562)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(182, 72)
        Me.btnView.TabIndex = 4
        Me.btnView.Text = "表示"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSubmit.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.btnSubmit.Location = New System.Drawing.Point(240, 562)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(182, 72)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "新規追加"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lstData
        '
        Me.lstData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstData.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.lstData.Location = New System.Drawing.Point(18, 124)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(1005, 335)
        Me.lstData.TabIndex = 6
        Me.lstData.UseCompatibleStateImageBehavior = False
        Me.lstData.View = System.Windows.Forms.View.Details
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.btnExit.Location = New System.Drawing.Point(841, 562)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(182, 72)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "終了"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルFToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1035, 42)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ファイルFToolStripMenuItem
        '
        Me.ファイルFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HirakuToolStripMenuItem, Me.新規作成NToolStripMenuItem, Me.ToolStripMenuItem1, Me.終了XToolStripMenuItem})
        Me.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem"
        Me.ファイルFToolStripMenuItem.Size = New System.Drawing.Size(121, 38)
        Me.ファイルFToolStripMenuItem.Text = "ファイル(&F)"
        '
        'HirakuToolStripMenuItem
        '
        Me.HirakuToolStripMenuItem.Name = "HirakuToolStripMenuItem"
        Me.HirakuToolStripMenuItem.Size = New System.Drawing.Size(324, 38)
        Me.HirakuToolStripMenuItem.Text = "開く(&O)"
        '
        '新規作成NToolStripMenuItem
        '
        Me.新規作成NToolStripMenuItem.Name = "新規作成NToolStripMenuItem"
        Me.新規作成NToolStripMenuItem.Size = New System.Drawing.Size(324, 38)
        Me.新規作成NToolStripMenuItem.Text = "新規作成(&N)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(321, 6)
        '
        '終了XToolStripMenuItem
        '
        Me.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem"
        Me.終了XToolStripMenuItem.Size = New System.Drawing.Size(324, 38)
        Me.終了XToolStripMenuItem.Text = "終了(&X)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1035, 646)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lstData)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lstData As ListView
    Friend WithEvents btnExit As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ファイルFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HirakuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 新規作成NToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents 終了XToolStripMenuItem As ToolStripMenuItem
End Class
