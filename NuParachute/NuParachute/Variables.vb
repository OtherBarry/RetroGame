Module Variables
    Public Enemies As New List(Of Object)
    Public Backgrounds As New List(Of Object)
    Public CharacterDropSpeed As Decimal = 2
    Public HelicopterMoveSpeed As Decimal = 4
    Public CharacterMoveSpeed As Decimal = 3
    Public Difficulty As Integer = 3
    Public Seconds As Integer = 30
    Public GameActive As Boolean = False
    Public GameScroll As Boolean = True
    Public Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As IntPtr) As Short
    Public DeciSeconds As Integer = 0
    Public Collision As Boolean = False
    Public Lives As Integer = 3
    Public Paused As Boolean = False
    Public GameWin As Boolean = False
    Public Millis As Integer = 0
    Public Counter As Integer = 0
End Module
