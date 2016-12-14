<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MetaViewXML
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSetViewWindow = New System.Windows.Forms.Button()
        Me.txtRawXML = New System.Windows.Forms.TextBox()
        Me.txtViewTitle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.numViewWidth = New System.Windows.Forms.NumericUpDown()
        Me.numViewHeight = New System.Windows.Forms.NumericUpDown()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.grpMetaViewWindow = New System.Windows.Forms.GroupBox()
        Me.btnAddViewButton = New System.Windows.Forms.Button()
        Me.grpAddButtonControls = New System.Windows.Forms.GroupBox()
        Me.btnClearBtnInfo = New System.Windows.Forms.Button()
        Me.numBtnHeight = New System.Windows.Forms.NumericUpDown()
        Me.numBtnWidth = New System.Windows.Forms.NumericUpDown()
        Me.numBtnLeft = New System.Windows.Forms.NumericUpDown()
        Me.numBtnTop = New System.Windows.Forms.NumericUpDown()
        Me.txtActionExpr = New System.Windows.Forms.TextBox()
        Me.txtSetState = New System.Windows.Forms.TextBox()
        Me.txtDisplayText = New System.Windows.Forms.TextBox()
        Me.txtBtnName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCopyRawXML = New System.Windows.Forms.Button()
        Me.lstboxFormattedXML = New System.Windows.Forms.ListBox()
        Me.btnDeleteSelectedButton = New System.Windows.Forms.Button()
        Me.btnEditControl = New System.Windows.Forms.Button()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        CType(Me.numViewWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numViewHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMetaViewWindow.SuspendLayout()
        Me.grpAddButtonControls.SuspendLayout()
        CType(Me.numBtnHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numBtnWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numBtnLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numBtnTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(634, 512)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 37)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSetViewWindow
        '
        Me.btnSetViewWindow.Location = New System.Drawing.Point(9, 110)
        Me.btnSetViewWindow.Name = "btnSetViewWindow"
        Me.btnSetViewWindow.Size = New System.Drawing.Size(135, 44)
        Me.btnSetViewWindow.TabIndex = 3
        Me.btnSetViewWindow.Text = "&Set View"
        Me.btnSetViewWindow.UseVisualStyleBackColor = True
        '
        'txtRawXML
        '
        Me.txtRawXML.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRawXML.Location = New System.Drawing.Point(11, 423)
        Me.txtRawXML.Multiline = True
        Me.txtRawXML.Name = "txtRawXML"
        Me.txtRawXML.ReadOnly = True
        Me.txtRawXML.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtRawXML.Size = New System.Drawing.Size(725, 74)
        Me.txtRawXML.TabIndex = 1
        '
        'txtViewTitle
        '
        Me.txtViewTitle.Location = New System.Drawing.Point(50, 22)
        Me.txtViewTitle.Name = "txtViewTitle"
        Me.txtViewTitle.Size = New System.Drawing.Size(90, 20)
        Me.txtViewTitle.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Height:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Title:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Width:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 407)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Raw XML"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Formatted XML"
        '
        'numViewWidth
        '
        Me.numViewWidth.Location = New System.Drawing.Point(50, 50)
        Me.numViewWidth.Maximum = New Decimal(New Integer() {700, 0, 0, 0})
        Me.numViewWidth.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numViewWidth.Name = "numViewWidth"
        Me.numViewWidth.Size = New System.Drawing.Size(91, 20)
        Me.numViewWidth.TabIndex = 1
        Me.numViewWidth.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'numViewHeight
        '
        Me.numViewHeight.Location = New System.Drawing.Point(50, 78)
        Me.numViewHeight.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.numViewHeight.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numViewHeight.Name = "numViewHeight"
        Me.numViewHeight.Size = New System.Drawing.Size(91, 20)
        Me.numViewHeight.TabIndex = 2
        Me.numViewHeight.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(11, 512)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 37)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "&Reset"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'grpMetaViewWindow
        '
        Me.grpMetaViewWindow.Controls.Add(Me.Label2)
        Me.grpMetaViewWindow.Controls.Add(Me.txtViewTitle)
        Me.grpMetaViewWindow.Controls.Add(Me.numViewHeight)
        Me.grpMetaViewWindow.Controls.Add(Me.Label1)
        Me.grpMetaViewWindow.Controls.Add(Me.numViewWidth)
        Me.grpMetaViewWindow.Controls.Add(Me.Label3)
        Me.grpMetaViewWindow.Controls.Add(Me.btnSetViewWindow)
        Me.grpMetaViewWindow.Location = New System.Drawing.Point(11, 12)
        Me.grpMetaViewWindow.Name = "grpMetaViewWindow"
        Me.grpMetaViewWindow.Size = New System.Drawing.Size(156, 173)
        Me.grpMetaViewWindow.TabIndex = 0
        Me.grpMetaViewWindow.TabStop = False
        Me.grpMetaViewWindow.Text = "Meta View Window"
        '
        'btnAddViewButton
        '
        Me.btnAddViewButton.Location = New System.Drawing.Point(389, 106)
        Me.btnAddViewButton.Name = "btnAddViewButton"
        Me.btnAddViewButton.Size = New System.Drawing.Size(150, 48)
        Me.btnAddViewButton.TabIndex = 8
        Me.btnAddViewButton.Text = "&Add Button"
        Me.btnAddViewButton.UseVisualStyleBackColor = True
        '
        'grpAddButtonControls
        '
        Me.grpAddButtonControls.BackColor = System.Drawing.SystemColors.Control
        Me.grpAddButtonControls.Controls.Add(Me.btnSaveChanges)
        Me.grpAddButtonControls.Controls.Add(Me.btnClearBtnInfo)
        Me.grpAddButtonControls.Controls.Add(Me.numBtnHeight)
        Me.grpAddButtonControls.Controls.Add(Me.numBtnWidth)
        Me.grpAddButtonControls.Controls.Add(Me.numBtnLeft)
        Me.grpAddButtonControls.Controls.Add(Me.numBtnTop)
        Me.grpAddButtonControls.Controls.Add(Me.txtActionExpr)
        Me.grpAddButtonControls.Controls.Add(Me.txtSetState)
        Me.grpAddButtonControls.Controls.Add(Me.txtDisplayText)
        Me.grpAddButtonControls.Controls.Add(Me.txtBtnName)
        Me.grpAddButtonControls.Controls.Add(Me.Label11)
        Me.grpAddButtonControls.Controls.Add(Me.btnAddViewButton)
        Me.grpAddButtonControls.Controls.Add(Me.Label10)
        Me.grpAddButtonControls.Controls.Add(Me.Label9)
        Me.grpAddButtonControls.Controls.Add(Me.Label8)
        Me.grpAddButtonControls.Controls.Add(Me.Label7)
        Me.grpAddButtonControls.Controls.Add(Me.Label13)
        Me.grpAddButtonControls.Controls.Add(Me.Label12)
        Me.grpAddButtonControls.Controls.Add(Me.Label4)
        Me.grpAddButtonControls.Enabled = False
        Me.grpAddButtonControls.Location = New System.Drawing.Point(190, 12)
        Me.grpAddButtonControls.Name = "grpAddButtonControls"
        Me.grpAddButtonControls.Size = New System.Drawing.Size(546, 173)
        Me.grpAddButtonControls.TabIndex = 1
        Me.grpAddButtonControls.TabStop = False
        Me.grpAddButtonControls.Text = "Add Button Control"
        '
        'btnClearBtnInfo
        '
        Me.btnClearBtnInfo.Location = New System.Drawing.Point(389, 22)
        Me.btnClearBtnInfo.Name = "btnClearBtnInfo"
        Me.btnClearBtnInfo.Size = New System.Drawing.Size(150, 46)
        Me.btnClearBtnInfo.TabIndex = 9
        Me.btnClearBtnInfo.Text = "&Clear"
        Me.btnClearBtnInfo.UseVisualStyleBackColor = True
        '
        'numBtnHeight
        '
        Me.numBtnHeight.Location = New System.Drawing.Point(273, 77)
        Me.numBtnHeight.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.numBtnHeight.Name = "numBtnHeight"
        Me.numBtnHeight.Size = New System.Drawing.Size(100, 20)
        Me.numBtnHeight.TabIndex = 5
        '
        'numBtnWidth
        '
        Me.numBtnWidth.Location = New System.Drawing.Point(273, 49)
        Me.numBtnWidth.Maximum = New Decimal(New Integer() {700, 0, 0, 0})
        Me.numBtnWidth.Name = "numBtnWidth"
        Me.numBtnWidth.Size = New System.Drawing.Size(100, 20)
        Me.numBtnWidth.TabIndex = 4
        '
        'numBtnLeft
        '
        Me.numBtnLeft.Location = New System.Drawing.Point(73, 76)
        Me.numBtnLeft.Maximum = New Decimal(New Integer() {400, 0, 0, 0})
        Me.numBtnLeft.Name = "numBtnLeft"
        Me.numBtnLeft.Size = New System.Drawing.Size(100, 20)
        Me.numBtnLeft.TabIndex = 3
        '
        'numBtnTop
        '
        Me.numBtnTop.Location = New System.Drawing.Point(73, 48)
        Me.numBtnTop.Maximum = New Decimal(New Integer() {700, 0, 0, 0})
        Me.numBtnTop.Name = "numBtnTop"
        Me.numBtnTop.Size = New System.Drawing.Size(100, 20)
        Me.numBtnTop.TabIndex = 2
        '
        'txtActionExpr
        '
        Me.txtActionExpr.Location = New System.Drawing.Point(73, 135)
        Me.txtActionExpr.Name = "txtActionExpr"
        Me.txtActionExpr.Size = New System.Drawing.Size(304, 20)
        Me.txtActionExpr.TabIndex = 7
        '
        'txtSetState
        '
        Me.txtSetState.Location = New System.Drawing.Point(73, 104)
        Me.txtSetState.Name = "txtSetState"
        Me.txtSetState.Size = New System.Drawing.Size(100, 20)
        Me.txtSetState.TabIndex = 6
        '
        'txtDisplayText
        '
        Me.txtDisplayText.Location = New System.Drawing.Point(273, 24)
        Me.txtDisplayText.Name = "txtDisplayText"
        Me.txtDisplayText.Size = New System.Drawing.Size(100, 20)
        Me.txtDisplayText.TabIndex = 1
        '
        'txtBtnName
        '
        Me.txtBtnName.Location = New System.Drawing.Point(73, 22)
        Me.txtBtnName.Name = "txtBtnName"
        Me.txtBtnName.Size = New System.Drawing.Size(100, 20)
        Me.txtBtnName.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "ActionExpr:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(226, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Height:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(229, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Width:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Left:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Top:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(199, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Display Text:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 107)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "SetState:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Name:"
        '
        'btnCopyRawXML
        '
        Me.btnCopyRawXML.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCopyRawXML.Location = New System.Drawing.Point(299, 512)
        Me.btnCopyRawXML.Name = "btnCopyRawXML"
        Me.btnCopyRawXML.Size = New System.Drawing.Size(152, 37)
        Me.btnCopyRawXML.TabIndex = 3
        Me.btnCopyRawXML.Text = "Copy Raw XML"
        Me.btnCopyRawXML.UseVisualStyleBackColor = True
        '
        'lstboxFormattedXML
        '
        Me.lstboxFormattedXML.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstboxFormattedXML.FormattingEnabled = True
        Me.lstboxFormattedXML.Location = New System.Drawing.Point(11, 237)
        Me.lstboxFormattedXML.Name = "lstboxFormattedXML"
        Me.lstboxFormattedXML.ScrollAlwaysVisible = True
        Me.lstboxFormattedXML.Size = New System.Drawing.Size(725, 160)
        Me.lstboxFormattedXML.TabIndex = 7
        '
        'btnDeleteSelectedButton
        '
        Me.btnDeleteSelectedButton.Enabled = False
        Me.btnDeleteSelectedButton.Location = New System.Drawing.Point(629, 194)
        Me.btnDeleteSelectedButton.Name = "btnDeleteSelectedButton"
        Me.btnDeleteSelectedButton.Size = New System.Drawing.Size(100, 34)
        Me.btnDeleteSelectedButton.TabIndex = 8
        Me.btnDeleteSelectedButton.Text = "Delete"
        Me.btnDeleteSelectedButton.UseVisualStyleBackColor = True
        '
        'btnEditControl
        '
        Me.btnEditControl.Enabled = False
        Me.btnEditControl.Location = New System.Drawing.Point(523, 194)
        Me.btnEditControl.Name = "btnEditControl"
        Me.btnEditControl.Size = New System.Drawing.Size(100, 34)
        Me.btnEditControl.TabIndex = 9
        Me.btnEditControl.Text = "Edit"
        Me.btnEditControl.UseVisualStyleBackColor = True
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Location = New System.Drawing.Point(389, 106)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(150, 48)
        Me.btnSaveChanges.TabIndex = 10
        Me.btnSaveChanges.Text = "Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        Me.btnSaveChanges.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(419, 194)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 34)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(190, 194)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(100, 34)
        Me.btnPreview.TabIndex = 11
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        Me.btnPreview.Visible = False
        '
        'MetaViewXML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 561)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnEditControl)
        Me.Controls.Add(Me.btnDeleteSelectedButton)
        Me.Controls.Add(Me.lstboxFormattedXML)
        Me.Controls.Add(Me.btnCopyRawXML)
        Me.Controls.Add(Me.grpAddButtonControls)
        Me.Controls.Add(Me.grpMetaViewWindow)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRawXML)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnClose)
        Me.MinimumSize = New System.Drawing.Size(763, 600)
        Me.Name = "MetaViewXML"
        Me.Text = "Meta View XML Generator v1.2"
        CType(Me.numViewWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numViewHeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMetaViewWindow.ResumeLayout(False)
        Me.grpMetaViewWindow.PerformLayout()
        Me.grpAddButtonControls.ResumeLayout(False)
        Me.grpAddButtonControls.PerformLayout()
        CType(Me.numBtnHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numBtnWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numBtnLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numBtnTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnSetViewWindow As Button
    Friend WithEvents txtRawXML As TextBox
    Friend WithEvents txtViewTitle As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents numViewWidth As NumericUpDown
    Friend WithEvents numViewHeight As NumericUpDown
    Friend WithEvents btnClear As Button
    Friend WithEvents grpMetaViewWindow As GroupBox
    Friend WithEvents btnAddViewButton As Button
    Friend WithEvents grpAddButtonControls As GroupBox
    Friend WithEvents numBtnHeight As NumericUpDown
    Friend WithEvents numBtnWidth As NumericUpDown
    Friend WithEvents numBtnLeft As NumericUpDown
    Friend WithEvents numBtnTop As NumericUpDown
    Friend WithEvents txtActionExpr As TextBox
    Friend WithEvents txtBtnName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClearBtnInfo As Button
    Friend WithEvents txtSetState As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtDisplayText As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnCopyRawXML As Button
    Friend WithEvents lstboxFormattedXML As ListBox
    Friend WithEvents btnDeleteSelectedButton As Button
    Friend WithEvents btnEditControl As Button
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnPreview As Button
End Class
