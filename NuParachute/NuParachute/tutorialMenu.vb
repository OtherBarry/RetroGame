Public Class tutorialMenu
    Private enemyPicList = {My.Resources.HelicopterSmall, My.Resources.PlaneSmall}
    Private pwrUpPicList = {My.Resources.Speed}
    Private enemyInfoList = {"The basic unit of the game. Slow moving but also the most common enemy type.", "Fast moving units that are few in number but really hard to dodge. Watch out!"}
    Private pwrUpInfoList = {"Increases the rate at which you drop for 5 seconds"}
    Private enemyTitle = {"Helicopter", "Plane"}
    Private pwrUpTitle = {"Speed"}
    Dim enemyListNumber As Integer = 0
    Dim pwrUpListNumber As Integer = 0
    Private Sub leftEnemyBtn_Click(sender As Object, e As EventArgs) Handles leftEnemyBtn.Click
        enemyListNumber = enemyListNumber - 1
        If enemyListNumber = -1 Then
            enemyListNumber = 0
        End If
        enemyLbl.Text = enemyTitle(enemyListNumber)
        enemyPic.BackgroundImage = enemyPicList(enemyListNumber)
        enemyPic.BackgroundImageLayout = ImageLayout.Stretch
        enemyInfo.Text = enemyInfoList(enemyListNumber)
    End Sub
    Private Sub rightEnemyBtn_Click(sender As Object, e As EventArgs) Handles rightEnemyBtn.Click
        enemyListNumber = enemyListNumber + 1
        If enemyListNumber = 2 Then
            enemyListNumber = 1
        End If
        enemyLbl.Text = enemyTitle(enemyListNumber)
        enemyPic.BackgroundImage = enemyPicList(enemyListNumber)
        enemyPic.BackgroundImageLayout = ImageLayout.Stretch
        enemyInfo.Text = enemyInfoList(enemyListNumber)
    End Sub
    Private Sub enemyLbl_VisibleChanged(sender As Object, e As EventArgs) Handles enemyLbl.VisibleChanged
        enemyLbl.Text = enemyTitle(enemyListNumber)
    End Sub
    Private Sub exitTutorialBtn_Click(sender As Object, e As EventArgs) Handles exitTutorialBtn.Click
        enemyListNumber = 0
        pwrUpListNumber = 0
        Me.Close()
        Main.Show()
    End Sub
    Private Sub enemyPic_VisibleChanged(sender As Object, e As EventArgs) Handles enemyPic.VisibleChanged
        enemyPic.BackgroundImage = enemyPicList(enemyListNumber)
        enemyPic.BackgroundImageLayout = ImageLayout.Stretch
    End Sub
    Private Sub enemyInfo_VisibleChanged(sender As Object, e As EventArgs) Handles enemyInfo.VisibleChanged
        enemyInfo.Text = enemyInfoList(enemyListNumber)
    End Sub
End Class