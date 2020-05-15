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
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.URL = New System.Windows.Forms.TextBox()
        Me.sendbt = New System.Windows.Forms.Button()
        Me.backbt = New System.Windows.Forms.Button()
        Me.forbt = New System.Windows.Forms.Button()
        Me.reloadbt = New System.Windows.Forms.Button()
        Me.homebt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(49, 63)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1402, 675)
        Me.WebBrowser1.TabIndex = 0
        '
        'URL
        '
        Me.URL.Location = New System.Drawing.Point(259, 19)
        Me.URL.Name = "URL"
        Me.URL.Size = New System.Drawing.Size(1145, 22)
        Me.URL.TabIndex = 2
        '
        'sendbt
        '
        Me.sendbt.Location = New System.Drawing.Point(1410, 19)
        Me.sendbt.Name = "sendbt"
        Me.sendbt.Size = New System.Drawing.Size(41, 23)
        Me.sendbt.TabIndex = 3
        Me.sendbt.Text = "GO"
        Me.sendbt.UseVisualStyleBackColor = True
        '
        'backbt
        '
        Me.backbt.Location = New System.Drawing.Point(49, 17)
        Me.backbt.Name = "backbt"
        Me.backbt.Size = New System.Drawing.Size(50, 25)
        Me.backbt.TabIndex = 4
        Me.backbt.Text = "戻る"
        Me.backbt.UseVisualStyleBackColor = True
        '
        'forbt
        '
        Me.forbt.Location = New System.Drawing.Point(105, 17)
        Me.forbt.Name = "forbt"
        Me.forbt.Size = New System.Drawing.Size(50, 25)
        Me.forbt.TabIndex = 5
        Me.forbt.Text = "進む"
        Me.forbt.UseVisualStyleBackColor = True
        '
        'reloadbt
        '
        Me.reloadbt.Location = New System.Drawing.Point(161, 17)
        Me.reloadbt.Name = "reloadbt"
        Me.reloadbt.Size = New System.Drawing.Size(50, 25)
        Me.reloadbt.TabIndex = 6
        Me.reloadbt.Text = "更新"
        Me.reloadbt.UseVisualStyleBackColor = True
        '
        'homebt
        '
        Me.homebt.Location = New System.Drawing.Point(217, 17)
        Me.homebt.Name = "homebt"
        Me.homebt.Size = New System.Drawing.Size(36, 25)
        Me.homebt.TabIndex = 7
        Me.homebt.Text = "🏡"
        Me.homebt.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1505, 750)
        Me.Controls.Add(Me.homebt)
        Me.Controls.Add(Me.reloadbt)
        Me.Controls.Add(Me.forbt)
        Me.Controls.Add(Me.backbt)
        Me.Controls.Add(Me.sendbt)
        Me.Controls.Add(Me.URL)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Name = "Form1"
        Me.Text = "WebBrowser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents URL As TextBox
    Friend WithEvents sendbt As Button
    Friend WithEvents backbt As Button
    Friend WithEvents forbt As Button
    Friend WithEvents reloadbt As Button
    Friend WithEvents homebt As Button
End Class
