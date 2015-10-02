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
End Module
