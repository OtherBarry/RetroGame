Module Variables
    Public Enemies As New List(Of Object)
    Public Backgrounds As New List(Of Object)
    Public Powerups As New List(Of Object)
    Public Player As New Parachuter
    Public ScrollSpeed As Decimal = 2
    Public Difficulty As Integer = 5
    Public Seconds As Integer = 30
    Public GameState As String = "Menu"
    Public GameScroll As Boolean = True
    Public Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As IntPtr) As Short
    Public DeciSeconds As Integer = 0
    Public Lives As Integer = 3
    Public DrawHitboxes As Boolean = False
    Public GameMode As String = "Endless"
    Public Level As Integer = 1
    Public ESCounter As Integer = 0
    Public LiveArray() As PictureBox = {Game.Live0, Game.Live1, Game.Live2, Game.Live3, Game.Live4, Game.Live5, Game.Live6, Game.Live7, Game.Live8, Game.Live9}
    Public speedActive As Boolean = True
    Public freezeActive As Boolean = True
    Public invincibleActive As Boolean = True
    Public audioActive As Boolean = True
    Public shirtNumber As Integer = 0
    Public parachuteNumber As Integer = 3
    Public Skins(,) As Image = {{My.Resources.cc, My.Resources.cp, My.Resources.cr, My.Resources.cw, My.Resources.cy},
                                {My.Resources.pc, My.Resources.pp, My.Resources.pr, My.Resources.pw, My.Resources.py},
                                {My.Resources.rc, My.Resources.rp, My.Resources.rr, My.Resources.rw, My.Resources.ry},
                                {My.Resources.wc, My.Resources.wp, My.Resources.wr, My.Resources.ww, My.Resources.wy},
                                {My.Resources.yc, My.Resources.yp, My.Resources.yr, My.Resources.yw, My.Resources.yy}}

End Module
