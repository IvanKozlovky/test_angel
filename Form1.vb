Public Class Form1

    Private WithEvents btnSolve As Button
    Private Sub btnSolve_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSolve.Click, Button1.Click
        ' Опреділяємо коефіцієнти з текстових полів
        Dim a, b, c As Double
        a = CDbl(txtA.Text)
        b = CDbl(txtB.Text)
        c = CDbl(txtC.Text)

        ' Обчислюємо дискримінант
        Dim D As Double
        D = b * b - 4 * a * c

        ' Обчислюємо корені рівняння
        Dim x1, x2 As Double
        If D < 0 Then
            ' Якщо дискримінант менший за нуль, рівняння не має дійсних коренів
            lblResult.Text = "Рівняння не має дійсних коренів."
        ElseIf D = 0 Then
            ' Якщо дискримінант дорівнює нулю, рівняння має один корінь
            x1 = -b / (2 * a)
            lblResult.Text = "Рівняння має один корінь: x = " & x1
        Else
            ' Якщо дискримінант більший за нуль, рівняння має два корені
            x1 = (-b + Math.Sqrt(D)) / (2 * a)
            x2 = (-b - Math.Sqrt(D)) / (2 * a)
            lblResult.Text = "Рівняння має два корені: x1 = " & x1 & ", x2 = " & x2
        End If
    End Sub
End Class
