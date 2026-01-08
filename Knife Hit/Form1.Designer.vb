<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        BtnSettings = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(BtnSettings, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnSettings
        ' 
        BtnSettings.BackgroundImage = CType(resources.GetObject("BtnSettings.BackgroundImage"), Image)
        BtnSettings.Location = New Point(-7, -6)
        BtnSettings.Name = "BtnSettings"
        BtnSettings.Size = New Size(67, 57)
        BtnSettings.TabIndex = 0
        BtnSettings.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(232, 348)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(91, 38)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(415, 710)
        Controls.Add(PictureBox2)
        Controls.Add(BtnSettings)
        Name = "Form1"
        Text = "Form1"
        CType(BtnSettings, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnSettings As PictureBox
    Friend WithEvents PictureBox2 As PictureBox

End Class
