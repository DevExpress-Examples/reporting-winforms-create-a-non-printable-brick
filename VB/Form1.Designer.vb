Imports Microsoft.VisualBasic
Imports System
Namespace NonPrintBrick
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.btn_NonPrintableBrick = New System.Windows.Forms.Button()
			Me.printingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
			CType(Me.printingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' btn_NonPrintableBrick
			' 
			Me.btn_NonPrintableBrick.Location = New System.Drawing.Point(64, 84)
			Me.btn_NonPrintableBrick.Name = "btn_NonPrintableBrick"
			Me.btn_NonPrintableBrick.Size = New System.Drawing.Size(158, 76)
			Me.btn_NonPrintableBrick.TabIndex = 1
			Me.btn_NonPrintableBrick.Text = "Show NonPrintableBrick"
			Me.btn_NonPrintableBrick.UseVisualStyleBackColor = True
'			Me.btn_NonPrintableBrick.Click += New System.EventHandler(Me.btn_NonPrintableBrick_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(284, 264)
			Me.Controls.Add(Me.btn_NonPrintableBrick)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.printingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents btn_NonPrintableBrick As System.Windows.Forms.Button
		Private printingSystem1 As DevExpress.XtraPrinting.PrintingSystem
	End Class
End Namespace

