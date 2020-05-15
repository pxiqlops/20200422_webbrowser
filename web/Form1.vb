Public Class Form1
    Private buttonNo As Integer
    Private myURL As Uri
    Dim strURL As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '初期表示としてGoogleのトップページを表示
        WebBrowser1.Navigate("https://www.google.com/")
    End Sub
    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.
                                              WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        'ページ読み込み完了時にアドレスバーにURLを表示させる
        URL.Text = WebBrowser1.Url.ToString()
    End Sub
    Private Sub sendbt_Click(sender As Object, e As EventArgs) Handles sendbt.Click
        'アドレスバーにURLを入力後、GOボタンでページ遷移処理
        WebBrowser1.Navigate(URL.Text)
    End Sub
    Private Sub URL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles URL.KeyPress
        'アドレスバーでEnterキー押下時にもページ遷移処理
        If e.KeyChar = Chr(13) Then
            WebBrowser1.Navigate(URL.Text)
        End If
    End Sub
    Private Sub backbt_Click(sender As Object, e As EventArgs) Handles backbt.Click
        '戻るボタン押下時の処理
        WebBrowser1.GoBack()
    End Sub
    Private Sub forbt_Click(sender As Object, e As EventArgs) Handles forbt.Click
        '進むボタン押下時の処理
        WebBrowser1.GoForward()
    End Sub
    Private Sub reloadbt_Click(sender As Object, e As EventArgs) Handles reloadbt.Click
        '更新（リロード）ボタン押下時の処理
        WebBrowser1.Refresh()
    End Sub
    Private Sub homebt_Click(sender As Object, e As EventArgs) Handles homebt.Click
        '家マーク（HOME）ボタン押下時の処理、Googleのトップページを表示
        WebBrowser1.Navigate("https://www.google.com/")
    End Sub
End Class
