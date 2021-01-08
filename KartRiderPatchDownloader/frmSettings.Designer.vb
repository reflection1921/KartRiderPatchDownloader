<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbRegion = New System.Windows.Forms.GroupBox()
        Me.btnRegionApply = New System.Windows.Forms.Button()
        Me.cbRegion = New System.Windows.Forms.ComboBox()
        Me.gbVersion = New System.Windows.Forms.GroupBox()
        Me.btnCheckManually = New System.Windows.Forms.Button()
        Me.btnCheckLatest = New System.Windows.Forms.Button()
        Me.txtVersion = New System.Windows.Forms.TextBox()
        Me.gbOption = New System.Windows.Forms.GroupBox()
        Me.chkCopy = New System.Windows.Forms.CheckBox()
        Me.chkExtractGZ = New System.Windows.Forms.CheckBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.gbRegion.SuspendLayout()
        Me.gbVersion.SuspendLayout()
        Me.gbOption.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbRegion
        '
        Me.gbRegion.Controls.Add(Me.btnRegionApply)
        Me.gbRegion.Controls.Add(Me.cbRegion)
        Me.gbRegion.Location = New System.Drawing.Point(12, 12)
        Me.gbRegion.Name = "gbRegion"
        Me.gbRegion.Size = New System.Drawing.Size(214, 78)
        Me.gbRegion.TabIndex = 0
        Me.gbRegion.TabStop = False
        Me.gbRegion.Text = "Select Region"
        '
        'btnRegionApply
        '
        Me.btnRegionApply.Location = New System.Drawing.Point(6, 46)
        Me.btnRegionApply.Name = "btnRegionApply"
        Me.btnRegionApply.Size = New System.Drawing.Size(202, 23)
        Me.btnRegionApply.TabIndex = 1
        Me.btnRegionApply.Text = "Apply"
        Me.btnRegionApply.UseVisualStyleBackColor = True
        '
        'cbRegion
        '
        Me.cbRegion.FormattingEnabled = True
        Me.cbRegion.Items.AddRange(New Object() {"Korea(KR)", "Taiwan(TW)"})
        Me.cbRegion.Location = New System.Drawing.Point(6, 20)
        Me.cbRegion.Name = "cbRegion"
        Me.cbRegion.Size = New System.Drawing.Size(202, 20)
        Me.cbRegion.TabIndex = 0
        Me.cbRegion.Text = "Select Region"
        '
        'gbVersion
        '
        Me.gbVersion.Controls.Add(Me.btnCheckManually)
        Me.gbVersion.Controls.Add(Me.btnCheckLatest)
        Me.gbVersion.Controls.Add(Me.txtVersion)
        Me.gbVersion.Enabled = False
        Me.gbVersion.Location = New System.Drawing.Point(12, 96)
        Me.gbVersion.Name = "gbVersion"
        Me.gbVersion.Size = New System.Drawing.Size(214, 108)
        Me.gbVersion.TabIndex = 1
        Me.gbVersion.TabStop = False
        Me.gbVersion.Text = "Select Version"
        '
        'btnCheckManually
        '
        Me.btnCheckManually.Location = New System.Drawing.Point(6, 76)
        Me.btnCheckManually.Name = "btnCheckManually"
        Me.btnCheckManually.Size = New System.Drawing.Size(202, 23)
        Me.btnCheckManually.TabIndex = 2
        Me.btnCheckManually.Text = "Check version manually"
        Me.btnCheckManually.UseVisualStyleBackColor = True
        '
        'btnCheckLatest
        '
        Me.btnCheckLatest.Location = New System.Drawing.Point(6, 47)
        Me.btnCheckLatest.Name = "btnCheckLatest"
        Me.btnCheckLatest.Size = New System.Drawing.Size(202, 23)
        Me.btnCheckLatest.TabIndex = 1
        Me.btnCheckLatest.Text = "Check latest version"
        Me.btnCheckLatest.UseVisualStyleBackColor = True
        '
        'txtVersion
        '
        Me.txtVersion.Location = New System.Drawing.Point(6, 20)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(202, 21)
        Me.txtVersion.TabIndex = 0
        '
        'gbOption
        '
        Me.gbOption.Controls.Add(Me.chkCopy)
        Me.gbOption.Controls.Add(Me.chkExtractGZ)
        Me.gbOption.Enabled = False
        Me.gbOption.Location = New System.Drawing.Point(12, 210)
        Me.gbOption.Name = "gbOption"
        Me.gbOption.Size = New System.Drawing.Size(214, 68)
        Me.gbOption.TabIndex = 2
        Me.gbOption.TabStop = False
        Me.gbOption.Text = "Option"
        '
        'chkCopy
        '
        Me.chkCopy.AutoSize = True
        Me.chkCopy.Enabled = False
        Me.chkCopy.Location = New System.Drawing.Point(6, 42)
        Me.chkCopy.Name = "chkCopy"
        Me.chkCopy.Size = New System.Drawing.Size(188, 16)
        Me.chkCopy.TabIndex = 1
        Me.chkCopy.Text = "Copy to KartRider install path"
        Me.chkCopy.UseVisualStyleBackColor = True
        '
        'chkExtractGZ
        '
        Me.chkExtractGZ.AutoSize = True
        Me.chkExtractGZ.Location = New System.Drawing.Point(6, 20)
        Me.chkExtractGZ.Name = "chkExtractGZ"
        Me.chkExtractGZ.Size = New System.Drawing.Size(91, 16)
        Me.chkExtractGZ.TabIndex = 0
        Me.chkExtractGZ.Text = "Extract *.gz"
        Me.chkExtractGZ.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Enabled = False
        Me.btnApply.Location = New System.Drawing.Point(12, 284)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(214, 23)
        Me.btnApply.TabIndex = 3
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 317)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.gbOption)
        Me.Controls.Add(Me.gbVersion)
        Me.Controls.Add(Me.gbRegion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.Text = "Settings"
        Me.gbRegion.ResumeLayout(False)
        Me.gbVersion.ResumeLayout(False)
        Me.gbVersion.PerformLayout()
        Me.gbOption.ResumeLayout(False)
        Me.gbOption.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbRegion As System.Windows.Forms.GroupBox
    Friend WithEvents btnRegionApply As System.Windows.Forms.Button
    Friend WithEvents cbRegion As System.Windows.Forms.ComboBox
    Friend WithEvents gbVersion As System.Windows.Forms.GroupBox
    Friend WithEvents btnCheckLatest As System.Windows.Forms.Button
    Friend WithEvents txtVersion As System.Windows.Forms.TextBox
    Friend WithEvents btnCheckManually As System.Windows.Forms.Button
    Friend WithEvents gbOption As System.Windows.Forms.GroupBox
    Friend WithEvents chkCopy As System.Windows.Forms.CheckBox
    Friend WithEvents chkExtractGZ As System.Windows.Forms.CheckBox
    Friend WithEvents btnApply As System.Windows.Forms.Button
End Class
