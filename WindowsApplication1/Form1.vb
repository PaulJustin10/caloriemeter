Public Class Form1
    Dim x, y, z As Double


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        lbl_quantity.Text = lbl_quantity.Text + "1"

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        lbl_quantity.Text = lbl_quantity.Text + "2"
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        lbl_quantity.Text = lbl_quantity.Text + "3"
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        lbl_quantity.Text = lbl_quantity.Text + "4"
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        lbl_quantity.Text = lbl_quantity.Text + "5"
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        lbl_quantity.Text = lbl_quantity.Text + "6"
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        lbl_quantity.Text = lbl_quantity.Text + "7"
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        lbl_quantity.Text = lbl_quantity.Text + "8"
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        lbl_quantity.Text = lbl_quantity.Text + "9"
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        lbl_quantity.Text = lbl_quantity.Text + "0"
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        If lbl_quantity.Text.Length <> 0 Then
            lbl_quantity.Text = lbl_quantity.Text.Substring(0, lbl_quantity.Text.Length - 1)
        End If
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        x = x + (Val(lbl_quantity.Text) * Val(lbl_price.Text))
        y = y + (Val(lbl_quantity.Text) * Val(lbl_calorie.Text))
        z = z + (Val(lbl_quantity.Text) * Val(lbl_protein.Text))
        lst_summary.Items.Add(lbl_quantity.Text + " @ " + lst_menu.SelectedItem + vbTab + vbTab + "Php." + (Val(lbl_quantity.Text) * Val(lbl_price.Text)).ToString + vbTab + vbTab + (Val(lbl_calorie.Text) * Val(lbl_quantity.Text)).ToString + " Calories" + vbTab + (Val(lbl_protein.Text) * Val(lbl_quantity.Text)).ToString + "g")
        lstitems.Items.Add(lbl_quantity.Text + " @ " + lst_menu.SelectedItem + vbTab + "Php." + (Val(lbl_quantity.Text) * Val(lbl_price.Text)).ToString + vbTab + (Val(lbl_calorie.Text) * Val(lbl_quantity.Text)).ToString + " Calories" + vbTab + (Val(lbl_protein.Text) * Val(lbl_quantity.Text)).ToString + "g")
        txt_totalamount.Text = x
        txt_totalcalories.Text = y
        txt_totalprotein.Text = z


    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        lst_menu.Items.Clear()
        lbl_price.Text = ""
        lbl_calorie.Text = ""
        lbl_protein.Text = ""
        lbl_quantity.Text = ""
        lst_menu.Items.Add("Ratatouille Vegetable")
        lst_menu.Items.Add("Baked Vegetable")
        lst_menu.Items.Add("Chicken Steak      ")
    End Sub

    Private Sub lst_menu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_menu.SelectedIndexChanged
        lbl_quantity.Text = ""
        If lst_menu.SelectedItem = "Ratatouille Vegetable" Then
            lbl_price.Text = "150.00"
            lbl_calorie.Text = "60.8 Calories"
            lbl_protein.Text = "1.2g"
        ElseIf lst_menu.Text = "Baked Vegetable" Then
            lbl_price.Text = "120.00"
            lbl_calorie.Text = "30 Calories"
            lbl_protein.Text = "15g"
        ElseIf lst_menu.Text = "Chicken Steak      " Then
            lbl_price.Text = "210.00"
            lbl_calorie.Text = "60 Calories"
            lbl_protein.Text = "45g"
        ElseIf lst_menu.Text = "Green Tea          " Then
            lbl_price.Text = "30.00"
            lbl_calorie.Text = "10 Calories"
            lbl_protein.Text = "5g"
        ElseIf lst_menu.Text = "Lime Water          " Then
            lbl_price.Text = "20.00"
            lbl_calorie.Text = "10 Calories"
            lbl_protein.Text = "7g"
        ElseIf lst_menu.Text = "Honey Lemon          " Then
            lbl_price.Text = "25.00"
            lbl_calorie.Text = "15 Calories"
            lbl_protein.Text = "12g"
        ElseIf lst_menu.Text = "Protein Brownie  " Then
            lbl_price.Text = "180.00"
            lbl_calorie.Text = "55 Calories"
            lbl_protein.Text = "48g"
        ElseIf lst_menu.Text = "Cheese Cake       " Then
            lbl_price.Text = "120.00"
            lbl_calorie.Text = "30 Calories"
            lbl_protein.Text = "15g"
        ElseIf lst_menu.Text = "Fruit Truffle       " Then
            lbl_price.Text = "115.00"
            lbl_calorie.Text = "45 Calories"
            lbl_protein.Text = "36g"
        End If
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        lst_menu.Items.Clear()
        lbl_price.Text = ""
        lbl_calorie.Text = ""
        lbl_protein.Text = ""
        lbl_quantity.Text = ""
        lst_menu.Items.Add("Green Tea          ")
        lst_menu.Items.Add("Lime Water          ")
        lst_menu.Items.Add("Honey Lemon          ")
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        lst_menu.Items.Clear()
        lbl_price.Text = ""
        lbl_calorie.Text = ""
        lbl_protein.Text = ""
        lbl_quantity.Text = ""
        lst_menu.Items.Add("Protein Brownie  ")
        lst_menu.Items.Add("Cheese Cake       ")
        lst_menu.Items.Add("Fruit Truffle       ")
    End Sub

    Private Sub lst_summary_DoubleClick(sender As Object, e As EventArgs) Handles lst_summary.DoubleClick
        lst_summary.Items.Remove(lst_summary.SelectedItem)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnl_receipt.Visible = True
        pnl_receipt.BringToFront()

        lblamount.Text = Val(txt_totalamount.Text) - 10
        lblvat.Text = 10
        lbltendered.Text = txt_amounttendered.Text
        lblchange.Text = Val(txt_amounttendered.Text) - Val(txt_totalamount.Text)




    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub pnl_receipt_Paint(sender As Object, e As PaintEventArgs) Handles pnl_receipt.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        pnl_receipt.Visible = False
        pnl_receipt.SendToBack()

        lst_menu.Items.Clear()
        lbl_calorie.Text = ""
        lbl_protein.Text = ""
        lbl_price.Text = ""
        lbl_quantity.Text = ""
        lst_summary.Items.Clear()
        txt_amounttendered.Clear()
        txt_totalamount.Clear()
        txt_totalcalories.Clear()
        txt_totalprotein.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        txt_totalamount.Clear()
        txt_totalcalories.Clear()
        txt_totalprotein.Clear()
        txt_amounttendered.Clear()
        lbl_quantity.Text = ""
        lbl_price.Text = ""
        lbl_calorie.Text = ""
        lbl_protein.Text = ""
        lst_menu.Items.Clear()

    End Sub


    Private Sub txt_amounttendered_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_amounttendered.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 45) Then
            If Asc(e.KeyChar) = 13 Then
                MsgBox("Change is: " + (Val(txt_amounttendered.Text) - Val(txt_totalamount.Text)).ToString, vbOKOnly + vbInformation, "Change")
            End If
        End If
    End Sub


    Private Sub lblvat_Click(sender As Object, e As EventArgs) Handles lblvat.Click

    End Sub
    Private Sub lblamount_Click(sender As Object, e As EventArgs) Handles lblamount.Click

    End Sub

    Private Sub txt_amounttendered_TextChanged(sender As Object, e As EventArgs) Handles txt_amounttendered.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub txt_totalprotein_TextChanged(sender As Object, e As EventArgs) Handles txt_totalprotein.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txt_totalcalories_TextChanged(sender As Object, e As EventArgs) Handles txt_totalcalories.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub lbl_quantity_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lst_summary_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_summary.SelectedIndexChanged

    End Sub

    Private Sub txt_totalamount_TextChanged(sender As Object, e As EventArgs) Handles txt_totalamount.TextChanged

    End Sub
End Class
