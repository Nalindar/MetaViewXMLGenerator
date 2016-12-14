Module Preview

    Public Sub OpenPreview(viewWidth As Integer, viewHeight As Integer, ByRef listOfButtons As List(Of ButtonControl))
        Dim preview As New PreviewForm

        preview.Width = viewWidth
        preview.Height = viewHeight

        For Each btnControl In listOfButtons
            Dim newbtn As New Button
            newbtn.Top = btnControl.top
            newbtn.Left = btnControl.left
            newbtn.Width = btnControl.width
            newbtn.Height = btnControl.height
            newbtn.Text = btnControl.displayText
            preview.Controls.Add(newbtn)
        Next

        preview.ShowDialog()
    End Sub

End Module
