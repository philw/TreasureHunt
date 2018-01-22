Module Module1

    Const BOARD_ROWS As Integer = 7
    Const BOARD_COLUMNS As Integer = 10

    Structure TLocation
        Dim Row As Integer
        Dim Column As Integer
    End Structure

    Sub Main()

        Dim Board(BOARD_ROWS - 1, BOARD_COLUMNS - 1) As Char
        Dim TreasureLocation As TLocation
        Dim GuessLocation As TLocation
        Dim Found As Boolean = False


        TreasureLocation = SetupGame(Board)

        Do While Not Found
            DisplayBoard(Board)
            GuessLocation = GetLocation()
            If GuessLocation.Column = TreasureLocation.Column And GuessLocation.Row = TreasureLocation.Row Then
                Board(GuessLocation.Row, GuessLocation.Column) = "X"
                Found = True
            Else
                Board(GuessLocation.Row, GuessLocation.Column) = "o"
            End If
        Loop

        DisplayBoard(Board)
        Console.WriteLine("You have found the treasure!")

        Console.ReadLine()


    End Sub

    Function SetupGame(ByRef Board(,) As Char) As TLocation

        Dim Location As TLocation

        For Row = 0 To BOARD_ROWS - 1
            For Column = 0 To BOARD_COLUMNS - 1
                Board(Row, Column) = "."
            Next
        Next

        Location.Row = 4
        Location.Column = 4

        Return Location

    End Function

    Sub DisplayBoard(ByRef Board(,) As Char)

        Console.Clear()
        Console.WriteLine("Treasure Hunt")
        Console.WriteLine()

        For Row = 0 To BOARD_ROWS - 1
            For Column = 0 To BOARD_COLUMNS - 1
                Console.Write(Board(Row, Column))
            Next
            Console.WriteLine()
        Next
        Console.WriteLine()

    End Sub

    Function GetLocation() As TLocation

        Dim Location As TLocation

        Console.Write("Enter row: ")
        Location.Row = Console.ReadLine

        Console.Write("Enter column: ")
        Location.Column = Console.ReadLine

        Return Location

    End Function


End Module
