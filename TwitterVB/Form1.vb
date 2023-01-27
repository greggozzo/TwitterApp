Imports Tweetinvi
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load   
     
    End Sub

    Private Shared APIKey As String = ""
    Private Shared APISecret As String = ""
    Private Shared APIToken As String = ""
    Private Shared APITokenSecret As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim client = New TwitterClient(APIKey, APISecret, APIToken, APITokenSecret)              
        Dim msgBoxResult As DialogResult = MessageBox.Show("Publish Tweet? Yes or No?", "Choose", MessageBoxButtons.YesNo)
        
        If msgBoxResult = DialogResult.Yes Then
            Dim inputWin As String = InputBox("What is your message?", "Tweet Entry", "Enter your messge here", 500, 700)
            Dim tweet = client.Tweets.PublishTweetAsync(inputWin)            
        Else
            Exit Sub
        End If                   
    End Sub
End Class
