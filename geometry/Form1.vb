Public Class Geometryform
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles textboxall.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim heigt, side As String
        Dim overall As String
        Dim Par, leng, widt As Double


        leng = Len.Text
        widt = wid.Text
        heigt = heit.Text
        side = sid.Text

        Par = (leng + widt) * 2

        overall = "Thank You" + " last name" + " first name" + " Middle name" + " for Using This App.The PARAMETER of a Rectangle is" + Str(Par)




        textboxall.Text = overall










    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim leng, widt, heigt As String
        Dim Vol, overall As String

        leng = Len.Text
        widt = wid.Text
        heigt = heit.Text


        Vol = (leng * widt * heigt)


        overall = "Thank You" + " last name" + " first name" + " Middle name" + " for Using This App.The VOlUME of a Rectangle is" + Str(Vol)

        textboxall.Text = overall
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim leng, widt, heigt, side As String
        Dim area, overall As String

        leng = Len.Text
        widt = wid.Text
        heigt = heit.Text
        side = sid.Text

        area = (widt * leng)

        overall = "Thank You" + " last name" + " first name" + " Middle name" + " for Using This App.The AREA of a Rectangle is" + Str(area)

        textboxall.Text = overall





    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Len.Clear()
        wid.Clear()
        heit.Clear()
        sid.Clear()
        textboxall.Clear()

    End Sub

    Private Sub Parameter_Click(sender As Object, e As EventArgs) Handles Parameter.Click
        Dim heigt, side As String
        Dim overall As String
        Dim Par, leng, widt As String


        leng = Len.Text
        widt = wid.Text
        heigt = heit.Text
        side = sid.Text

        Par = 4 * (side)




        overall = "Thank You" + " last name" + " first name" + " Middle name" + " for Using This App.The PARAMETER of a Square is" + Str(Par)




        textboxall.Text = overall
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim leng, widt, heigt, side As String
        Dim Vol, overall As String

        leng = Len.Text
        widt = wid.Text
        heigt = heit.Text
        side = sid.Text

        Vol = side ^ 3


        overall = "Thank You" + " last name" + " first name" + " Middle name" + " for Using This App.The VOlUME of a Square is" + Str(Vol)

        textboxall.Text = overall
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim leng, widt, heigt, side As String
        Dim area, overall As String

        leng = Len.Text
        widt = wid.Text
        heigt = heit.Text
        side = sid.Text

        area = side ^ 2

        overall = "Thank You" + " last name" + " first name" + " Middle name" + " for Using This App.The AREA of a Square is" + Str(area)

        textboxall.Text = overall
    End Sub
End Class
