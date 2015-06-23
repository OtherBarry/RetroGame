Module GlobalVariables
    'All Variablees used more than once should be placed here.

    'Start Game Balance
    Public CharacterDropSpeed As Decimal = 0.64
    Public HelicopterMoveSpeed As Decimal = 1.92
    Public CharacterMoveSpeed As Decimal = 2
    'End Game Balance

    'Start Object Generation
    Public Copters(50) As PictureBox
    Public CopterCount As Integer = 0
    Public Clouds(50) As PictureBox
    Public CloudCount As Integer = 0
    'End Object Generation
End Module
