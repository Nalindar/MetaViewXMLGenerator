Public Class ButtonControl

    Public Property name As String
    Public Property displayText As String
    Public Property top As Integer
    Public Property left As Integer
    Public Property width As Integer
    Public Property height As Integer
    Public Property setState As String
    Public Property actionExpr As String



    ' overrides ToString()
    Public Overrides Function ToString() As String

        Dim addButtonStringFormatted As String = "<control type= ""button""  name=""" & name & """  left=""" & left & """  top=""" & top & """  width=""" & width & """  height=""" & height & """  text=""" & displayText & """"

        If setState <> "" Then
            addButtonStringFormatted += "  setstate=""" & setState & """"
        End If

        If actionExpr <> "" Then
            addButtonStringFormatted += "  actionexpr=""" & actionExpr & """"
        End If

        addButtonStringFormatted += " /> "


        Return addButtonStringFormatted
    End Function


End Class
