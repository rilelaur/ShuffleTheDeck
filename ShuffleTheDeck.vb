'Laura Riley

Option Explicit On
Option Strict On

Module ShuffleTheDeck

    Sub Main()
        Dim deck(3, 12) As Integer
        Dim wasCardDrawn(3, 12) As Boolean
        Dim cardDrawn As String
        Dim suitType As Integer
        Dim cardValue As Integer
        Dim keepDrawing As Boolean = True
        Dim UserInput As String

        Randomize()

        Console.WriteLine("Type ""shuffle"" to shuffle the deck")
        Console.WriteLine("Type ""quit"" to quit the program")
        Console.WriteLine("Press enter to draw a card." & vbCrLf)

        While keepDrawing = True And UserInput <> "quit" And UserInput <> "shuffle"
            If UserInput = "quit" Then
                Console.Clear()
                Console.WriteLine("Have a nice day.")
                keepDrawing = False
            End If

            UserInput = Console.ReadLine()

            For cardSuit = 0 To 3
                suitType = CInt(Rnd() * 3)
                For value = 0 To 12
                    cardValue = CInt(Rnd() * 12)
                    cardDrawn = (suitType & cardValue)
                    deck(cardSuit, value) = CInt(cardDrawn)
                Next
            Next


            If wasCardDrawn(suitType, cardValue) = True Then
                wasCardDrawn(suitType, cardValue) = False
            Else
                For cardSuit = 0 To 3
                    suitType = CInt(Rnd() * 3)
                    For value = 0 To 12
                        cardValue = CInt(Rnd() * 12)
                    Next
                Next
            End If

            Console.WriteLine($"The card that you drew is {cardValue} of {suitType}" & vbCrLf)

            If UserInput = "quit" Then
                Console.Clear()
                Console.WriteLine("Have a nice day.")
                keepDrawing = False
            End If
        End While

        Console.Read()
    End Sub

    'Determines the suit drawn either clubs, spades, hearts, or diamonds
    Function Suit(suitType As Integer) As String
        Select Case suitType
            Case 0
                Return "Clubs"
            Case 1
                Return "Spades"
            Case 2
                Return "Hearts"
            Case 3
                Return "Diamonds"
            Case Else
                Return CStr(suitType)
        End Select
    End Function
    'Determines the card Value between Ace and King that is drawn
    Function Card(cardValue As Integer) As String
        Select Case cardValue
            Case 0
                Return "Ace"
            Case 1
                Return "2"
            Case 2
                Return "3"
            Case 3
                Return "4"
            Case 4
                Return "5"
            Case 5
                Return "6"
            Case 6
                Return "7"
            Case 7
                Return "8"
            Case 8
                Return "9"
            Case 9
                Return "10"
            Case 10
                Return "Jack"
            Case 11
                Return "Queen"
            Case 12
                Return "King"
            Case Else
                Return CStr(cardValue)
        End Select
    End Function


End Module
