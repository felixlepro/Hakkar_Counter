Public Class Form1
    Dim bloodDeck As Integer
    Dim otherCards As Integer
    Dim totalcards As Integer
    Dim draws As Integer
    Dim maxDamage As Integer
    Dim allChances As New List(Of Double)
    Dim allDamage As New List(Of Integer)
    Dim possibleDamage As New Dictionary(Of Integer, Double)

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles nupBlood.ValueChanged
        bloodDeck = nupBlood.Value
        If totalcards < bloodDeck Then
            nupTotal.Value = bloodDeck
        End If
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bloodDeck = 0
        otherCards = 0
        totalcards = 0

    End Sub


    Private Sub NumericUpDown1_ValueChanged_1(sender As Object, e As EventArgs) Handles nupDraw.ValueChanged
        draws = nupDraw.Value
    End Sub

    Private Sub nupTotal_ValueChanged(sender As Object, e As EventArgs) Handles nupTotal.ValueChanged
        totalcards = nupTotal.Value
        If totalcards < bloodDeck Then
            nupBlood.Value = totalcards

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        allChances.Clear()
        allDamage.Clear()


        bloodDeck = nupBlood.Value
        totalcards = nupTotal.Value
        otherCards = totalcards - bloodDeck
        maxDamage = 0

        Draw(bloodDeck, bloodDeck, otherCards, 0, draws, 1)
        ShowResults()
        Lethal()


    End Sub
    Private Function Draw(ByVal blood As Integer, ByVal bloodMax As Integer, ByVal other As Integer, ByVal damage As Integer, drawsLeft As Integer, chance As Double) As Integer

        If other > 0 And drawsLeft > 0 Then
            DrawOther(blood, bloodMax, other, damage, drawsLeft, chance)
        Else
            damage += OnlyBlood(blood, drawsLeft)
            allChances.Add(chance)
            allDamage.Add(damage)
            Return 0
        End If
        If blood > 0 And drawsLeft > 0 Then
            DrawBlood(blood, bloodMax, other, damage, drawsLeft, chance)
        End If
        Return 0
    End Function

    Private Function DrawBlood(ByVal blood As Integer, ByVal bloodMax As Integer, ByVal other As Integer, ByVal damage As Integer, drawsLeft As Integer, chance As Double) As Integer
        chance *= blood
        chance /= (other + blood)
        blood -= 1
        damage += 3
        Draw(blood, bloodMax, other, damage, drawsLeft, chance)

        Return 0
    End Function

    Private Function DrawOther(ByVal blood As Integer, ByVal bloodMax As Integer, ByVal other As Integer, ByVal damage As Integer, drawsLeft As Integer, chance As Double) As Integer
        chance *= other
        chance /= (other + blood)
        other -= 1
        drawsLeft -= 1
        bloodMax += (bloodMax - blood)
        blood = bloodMax
        Draw(blood, bloodMax, other, damage, drawsLeft, chance)
        Return 0
    End Function
    Private Function OnlyBlood(blood As Integer, drawsLeft As Integer) As Integer
        Dim damageBlood As Integer = 0
        Dim fatigue = 1
        For i As Integer = 1 To drawsLeft
            damageBlood += 3 * blood
            damageBlood += fatigue
            fatigue += 1

            blood *= 2
        Next

        Return damageBlood
    End Function
    Private Function ShowResults() As Integer
        Dim index As Integer
        possibleDamage.Clear()

        For i As Integer = 0 To allDamage.Last
            index = allDamage.FindIndex(Function(p) p = i)
            While index <> -1
                Try
                    possibleDamage.Item(i) += allChances.Item(index)
                Catch ex As Exception
                    possibleDamage.Add(i, allChances.Item(index))
                End Try
                allDamage.RemoveAt(index)
                allChances.RemoveAt(index)
                index = allDamage.FindIndex(Function(p) p = i)
            End While
        Next
        ListBox1.Items.Clear()

        For Each pair In possibleDamage
            ListBox1.Items.Add(pair.Key.ToString + vbTab + (pair.Value * 100).ToString("0.00") + "%")
        Next

        Return 0
    End Function

    Private Function Lethal()
        Dim p As Double = 0
        For Each pair In possibleDamage
            If pair.Key >= NumericUpDown1.Value Then
                p += pair.Value * 100

            End If
        Next
        Pourcentage.Text = p.ToString("0.00") + "%"
    End Function
    Private Sub NumericUpDown1_ValueChanged_2(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Lethal()

    End Sub

End Class
