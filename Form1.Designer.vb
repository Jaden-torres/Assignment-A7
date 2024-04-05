<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        Button1 = New Button()
        GroupBox2 = New GroupBox()
        GroupBox3 = New GroupBox()
        ComboBox1 = New ComboBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(2, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(369, 265)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(407, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(502, 48)
        Label1.TabIndex = 1
        Label1.Text = "Smart Home Electric Savings"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(113, 282)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(757, 53)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(271, 353)
        Button1.Name = "Button1"
        Button1.Size = New Size(337, 62)
        Button1.TabIndex = 3
        Button1.Text = "Display Statistics"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(155, 421)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(561, 42)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(97, 484)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(691, 41)
        GroupBox3.TabIndex = 5
        GroupBox3.TabStop = False
        GroupBox3.Text = "GroupBox3"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        ComboBox1.Location = New Point(482, 185)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(290, 33)
        ComboBox1.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(942, 613)
        Controls.Add(ComboBox1)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(Button1)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox

End Class
