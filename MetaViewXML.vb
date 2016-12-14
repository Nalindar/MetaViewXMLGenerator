Public Class MetaViewXML

    ' when the program loads create a list to hold our xml
    Dim lstXMLFormattedOutput As New List(Of KeyValuePair(Of Integer, String))
    Dim lstButtonControls As New List(Of ButtonControl)

    ' keep track of the current Key for key/value pairs
    Dim currentKey As Integer = 1

    ' track button index
    Dim buttonIndex As Integer = 0

    Dim viewWidth As Integer = 0
    Dim viewHeight As Integer = 0


    'add or update the view tag and attributes
    Private Sub btnSetViewWindow_Click(sender As Object, e As EventArgs) Handles btnSetViewWindow.Click

        viewWidth = numViewWidth.Value
        viewHeight = numViewHeight.Value

        ' update the view tag
        If lstboxFormattedXML.Items.Count > 0 Then
            lstXMLFormattedOutput.RemoveAt(1)
            lstXMLFormattedOutput.Insert(1, New KeyValuePair(Of Integer, String)(1, "<view width=""" & viewWidth & """  height=""" & viewHeight &
            """  title=""" & txtViewTitle.Text & """>"))
        Else
            ' create the view tag
            btnSetViewWindow.Text = "Update View"
            lstXMLFormattedOutput.Add(New KeyValuePair(Of Integer, String)(0, "<?xml version=""1.0""?>"))
            lstXMLFormattedOutput.Add(New KeyValuePair(Of Integer, String)(1, "<view width=""" & viewWidth & """  height=""" & viewHeight &
            """  title=""" & txtViewTitle.Text & """>"))
            lstXMLFormattedOutput.Add(New KeyValuePair(Of Integer, String)(2, "<control type=""layout"">"))

            ' increment the current key
            currentKey += 1
        End If

        If viewWidth >= 100 AndAlso viewHeight >= 100 Then
            btnPreview.Visible = True
        Else
            btnPreview.Visible = False
        End If

        ' enable add button controls
        grpAddButtonControls.Enabled = True

        ' output the xml
        DisplayXML()

    End Sub

    Private Sub AddNewButton()
        Dim addButtonStringFormatted As String = ""
        Dim addButtonStringRaw As String = ""

        ' create a new button object
        Dim control As New ButtonControl

        ' set its properties
        control.name = txtBtnName.Text
        control.displayText = txtDisplayText.Text
        control.top = numBtnTop.Value
        control.left = numBtnLeft.Value
        control.width = numBtnWidth.Value
        control.height = numBtnHeight.Value
        control.setState = txtSetState.Text
        control.actionExpr = txtActionExpr.Text

        ' add the objects xml strings to the lists
        lstXMLFormattedOutput.Add(New KeyValuePair(Of Integer, String)(currentKey, control.ToString))

        ' add the control object to the object list
        lstButtonControls.Add(control)

        ' increment the current key
        currentKey += 1

        ' output the xml
        DisplayXML()
    End Sub

    ' Display the XML in both views
    Public Sub DisplayXML()

        ' closing tag strings
        Dim tagClosingView As String = "</view>"
        Dim tagClosingControl As String = "</control>"

        ' clear the list
        lstboxFormattedXML.Items.Clear()

        ' display formatted xml
        For Each line In lstXMLFormattedOutput
            lstboxFormattedXML.Items.Add(line.Value)
        Next

        ' display raw xml
        txtRawXML.ResetText()
        Dim text As String = ""
        For i = 0 To lstXMLFormattedOutput.Count - 1
            text += lstXMLFormattedOutput(i).Value
        Next

        ' clean up the strings
        text = text.Replace("> <", "><")
        text = text.Replace("  ", " ")
        text = text.Replace("= """, "=""")
        text = text.Trim()
        txtRawXML.Text = text

        ' add closing tags
        lstboxFormattedXML.Items.Add(tagClosingControl)
        lstboxFormattedXML.Items.Add(tagClosingView)
        txtRawXML.Text += tagClosingControl & tagClosingView
    End Sub

    ' delete the selected button
    Private Sub btnDeleteSelectedButton_Click(sender As Object, e As EventArgs) Handles btnDeleteSelectedButton.Click
        If lstboxFormattedXML.SelectedIndex > 2 AndAlso lstboxFormattedXML.SelectedIndex < lstboxFormattedXML.Items.Count - 2 Then
            ' remove from formatted list
            lstXMLFormattedOutput.RemoveAt(lstboxFormattedXML.SelectedIndex)

            ' remove from button list
            lstButtonControls.RemoveAt(lstboxFormattedXML.SelectedIndex - 3)

            DisplayXML()
            currentKey -= 1
            btnDeleteSelectedButton.Enabled = False
            btnEditControl.Enabled = False
            txtBtnName.Focus()
        End If
    End Sub


    ' listbox selection event
    ' enable/disable the delete/edit buttons
    Private Sub lstboxFormattedXML_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstboxFormattedXML.SelectedIndexChanged
        If lstboxFormattedXML.SelectedIndex > 2 AndAlso lstboxFormattedXML.SelectedIndex < lstboxFormattedXML.Items.Count - 2 Then
            btnDeleteSelectedButton.Enabled = True
            btnEditControl.Enabled = True
        Else
            btnDeleteSelectedButton.Enabled = False
            btnEditControl.Enabled = False
        End If
    End Sub

    ' clear the button info
    Private Sub ClearBtnInfo()
        txtBtnName.Text = ""
        txtActionExpr.Text = ""
        txtSetState.Text = ""
        txtDisplayText.Text = ""
        numBtnTop.Value = 0
        numBtnLeft.Value = 0
        numBtnWidth.Value = 0
        numBtnHeight.Value = 0
    End Sub

    ' clear all method
    Public Sub ClearAll()
        txtViewTitle.Text = String.Empty
        btnSetViewWindow.Text = "Set View"
        grpAddButtonControls.Text = "Add Button Control"
        numViewWidth.Value = 10
        numViewHeight.Value = 10
        txtViewTitle.Enabled = True
        numViewHeight.Enabled = True
        numViewWidth.Enabled = True
        btnSetViewWindow.Enabled = True
        btnSaveChanges.Visible = False
        btnAddViewButton.Visible = True
        grpAddButtonControls.Enabled = False
        btnCancel.Visible = False
        lstXMLFormattedOutput.Clear()
        lstboxFormattedXML.Items.Clear()
        lstButtonControls.Clear()
        txtRawXML.ResetText()
        ClearBtnInfo()
        lstboxFormattedXML.SelectionMode = SelectionMode.One
        grpAddButtonControls.BackColor = SystemColors.Control
    End Sub

    Private Sub btnEditControl_Click(sender As Object, e As EventArgs) Handles btnEditControl.Click
        If lstboxFormattedXML.SelectedIndex > 2 AndAlso lstboxFormattedXML.SelectedIndex < lstboxFormattedXML.Items.Count - 2 Then

            ' get the currently selected buttons index
            buttonIndex = lstboxFormattedXML.SelectedIndex - 3

            ' hide the add view button
            btnAddViewButton.Visible = False

            ' disable the delete button
            btnDeleteSelectedButton.Enabled = False

            ' display the save changes button
            btnSaveChanges.Visible = True
            grpAddButtonControls.Text = "Edit Button: " & lstButtonControls.Item(buttonIndex).name

            ' populate the button controls with the button info
            txtBtnName.Text = lstButtonControls.Item(buttonIndex).name
            txtActionExpr.Text = lstButtonControls.Item(buttonIndex).actionExpr
            txtSetState.Text = lstButtonControls.Item(buttonIndex).setState
            txtDisplayText.Text = lstButtonControls.Item(buttonIndex).displayText
            numBtnTop.Value = lstButtonControls.Item(buttonIndex).top
            numBtnLeft.Value = lstButtonControls.Item(buttonIndex).left
            numBtnWidth.Value = lstButtonControls.Item(buttonIndex).width
            numBtnHeight.Value = lstButtonControls.Item(buttonIndex).height

            btnEditControl.Enabled = False
            btnCancel.Visible = True
            lstboxFormattedXML.SelectionMode = SelectionMode.None
            txtBtnName.Focus()
            grpAddButtonControls.BackColor = SystemColors.InactiveCaption
        End If
    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click

        ' remove from formatted list
        lstXMLFormattedOutput.RemoveAt(buttonIndex + 3)

        ' remove from button list
        lstButtonControls.RemoveAt(buttonIndex)

        ' create a new button object
        Dim btnControl As New ButtonControl

        ' set its properties
        btnControl.name = txtBtnName.Text
        btnControl.displayText = txtDisplayText.Text
        btnControl.top = numBtnTop.Value
        btnControl.left = numBtnLeft.Value
        btnControl.width = numBtnWidth.Value
        btnControl.height = numBtnHeight.Value
        btnControl.setState = txtSetState.Text
        btnControl.actionExpr = txtActionExpr.Text

        ' add the objects xml strings to the lists
        lstXMLFormattedOutput.Insert(buttonIndex + 3, New KeyValuePair(Of Integer, String)(buttonIndex + 3, btnControl.ToString))

        ' add the control object to the object list
        lstButtonControls.Insert(buttonIndex, btnControl)

        ' update form
        btnSaveChanges.Visible = False
        btnAddViewButton.Visible = True
        btnEditControl.Enabled = False
        btnCancel.Visible = False
        grpAddButtonControls.Text = "Add Button Control"
        lstboxFormattedXML.SelectionMode = SelectionMode.One
        grpAddButtonControls.BackColor = SystemColors.Control
        DisplayXML()
        ClearBtnInfo()
    End Sub

    ' add new button to view
    Private Sub btnAddViewButton_Click(sender As Object, e As EventArgs) Handles btnAddViewButton.Click
        AddNewButton()

    End Sub

    ' copy the raw xml to clipboard
    Private Sub btnCopyRawXML_Click(sender As Object, e As EventArgs) Handles btnCopyRawXML.Click
        txtRawXML.SelectAll()
        txtRawXML.Copy()
        txtRawXML.DeselectAll()
    End Sub

    ' clear all
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearAll()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
    Private Sub btnClearBtnInfo_Click(sender As Object, e As EventArgs) Handles btnClearBtnInfo.Click
        ClearBtnInfo()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnCancel.Visible = False
        btnAddViewButton.Visible = True
        btnSaveChanges.Visible = False
        ClearBtnInfo()
        grpAddButtonControls.Text = "Add Button Control"
        lstboxFormattedXML.SelectionMode = SelectionMode.One
        grpAddButtonControls.BackColor = SystemColors.Control
        txtBtnName.Focus()
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        OpenPreview(viewWidth, viewHeight, lstButtonControls)
    End Sub
End Class
