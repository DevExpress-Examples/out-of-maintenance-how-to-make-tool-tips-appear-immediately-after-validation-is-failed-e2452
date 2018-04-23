Imports Microsoft.VisualBasic
Imports System
Namespace ValidationProviderAutoTooltips
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
			Dim conditionValidationRule1 As New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
			Dim conditionValidationRule2 As New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			Me.textEdit2 = New DevExpress.XtraEditors.TextEdit()
			Me.dxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' textEdit1
			' 
			Me.dxValidationProvider1.SetIconAlignment(Me.textEdit1, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
			Me.textEdit1.Location = New System.Drawing.Point(12, 13)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Size = New System.Drawing.Size(177, 20)
			Me.textEdit1.TabIndex = 0
			conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
			conditionValidationRule1.ErrorText = "Error text"
			conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
			Me.dxValidationProvider1.SetValidationRule(Me.textEdit1, conditionValidationRule1)
			' 
			' textEdit2
			' 
			Me.textEdit2.Location = New System.Drawing.Point(12, 57)
			Me.textEdit2.Name = "textEdit2"
			Me.textEdit2.Size = New System.Drawing.Size(177, 20)
			Me.textEdit2.TabIndex = 1
			conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
			conditionValidationRule2.ErrorText = "This value is not valid"
			Me.dxValidationProvider1.SetValidationRule(Me.textEdit2, conditionValidationRule2)
			' 
			' dxValidationProvider1
			' 
			Me.dxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto
'			Me.dxValidationProvider1.ValidationFailed += New DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(Me.validationProvider1_ValidationFailed);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
			Me.ClientSize = New System.Drawing.Size(284, 262)
			Me.Controls.Add(Me.textEdit2)
			Me.Controls.Add(Me.textEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private textEdit1 As DevExpress.XtraEditors.TextEdit
		Private textEdit2 As DevExpress.XtraEditors.TextEdit
		Private WithEvents dxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
	End Class
End Namespace

