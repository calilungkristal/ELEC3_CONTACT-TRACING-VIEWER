<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.richTextBoxResult = New System.Windows.Forms.RichTextBox()
        Me.btnClearList = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnOpenRecord = New System.Windows.Forms.Button()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.CadetBlue
        Me.lbl1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl1.Location = New System.Drawing.Point(18, 11)
        Me.lbl1.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Padding = New System.Windows.Forms.Padding(132, 5, 132, 5)
        Me.lbl1.Size = New System.Drawing.Size(517, 47)
        Me.lbl1.TabIndex = 42
        Me.lbl1.Text = "T r a c e M E . a p p"
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.White
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel1.Controls.Add(Me.richTextBoxResult)
        Me.panel1.Controls.Add(Me.btnClearList)
        Me.panel1.Controls.Add(Me.btnExit)
        Me.panel1.Controls.Add(Me.btnOpenRecord)
        Me.panel1.Controls.Add(Me.lbl1)
        Me.panel1.Location = New System.Drawing.Point(12, 12)
        Me.panel1.Name = "panel1"
        Me.panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.panel1.Size = New System.Drawing.Size(560, 437)
        Me.panel1.TabIndex = 1
        '
        'richTextBoxResult
        '
        Me.richTextBoxResult.BackColor = System.Drawing.Color.AliceBlue
        Me.richTextBoxResult.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.richTextBoxResult.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.richTextBoxResult.Location = New System.Drawing.Point(18, 69)
        Me.richTextBoxResult.Name = "richTextBoxResult"
        Me.richTextBoxResult.ReadOnly = True
        Me.richTextBoxResult.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.richTextBoxResult.Size = New System.Drawing.Size(517, 314)
        Me.richTextBoxResult.TabIndex = 51
        Me.richTextBoxResult.Text = ""
        '
        'btnClearList
        '
        Me.btnClearList.BackColor = System.Drawing.Color.LightGray
        Me.btnClearList.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnClearList.Location = New System.Drawing.Point(196, 393)
        Me.btnClearList.Name = "btnClearList"
        Me.btnClearList.Size = New System.Drawing.Size(160, 30)
        Me.btnClearList.TabIndex = 50
        Me.btnClearList.Text = "Clear List"
        Me.btnClearList.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightGray
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(365, 393)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(170, 30)
        Me.btnExit.TabIndex = 46
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnOpenRecord
        '
        Me.btnOpenRecord.BackColor = System.Drawing.Color.LightGray
        Me.btnOpenRecord.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnOpenRecord.ForeColor = System.Drawing.Color.Black
        Me.btnOpenRecord.Location = New System.Drawing.Point(18, 393)
        Me.btnOpenRecord.Name = "btnOpenRecord"
        Me.btnOpenRecord.Size = New System.Drawing.Size(170, 30)
        Me.btnOpenRecord.TabIndex = 45
        Me.btnOpenRecord.Text = "Open Record"
        Me.btnOpenRecord.UseVisualStyleBackColor = False
        '
        'openFileDialog1
        '
        Me.openFileDialog1.FileName = "openFileDialog1"
        Me.openFileDialog1.InitialDirectory = "C:\Users\User\Documents\CONTACT_TRACING\CONTACT_TRACING\bin\Debug\netcoreapp3.1\D" &
    "ATA"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONTACT TRACING VIEWER"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents lbl1 As Label
    Private WithEvents panel1 As Panel
    Private WithEvents richTextBoxResult As RichTextBox
    Private WithEvents btnClearList As Button
    Private WithEvents btnExit As Button
    Private WithEvents btnOpenRecord As Button
    Private WithEvents openFileDialog1 As OpenFileDialog
End Class
