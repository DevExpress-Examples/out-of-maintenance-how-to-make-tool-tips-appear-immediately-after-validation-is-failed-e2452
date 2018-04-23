Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraEditors.ViewInfo

Namespace ValidationProviderAutoTooltips
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub validationProvider1_ValidationFailed(ByVal sender As Object, ByVal e As ValidationFailedEventArgs) Handles dxValidationProvider1.ValidationFailed
			Dim edit As BaseEdit = TryCast(e.InvalidControl, BaseEdit)
			If edit Is Nothing Then
				Return
			End If

			Dim viewInfo As BaseEditViewInfo = TryCast(edit.GetViewInfo(), BaseEditViewInfo)
			If viewInfo Is Nothing Then
				Return
			End If

			If edit.ToolTipController Is Nothing Then
				edit.ToolTipController = New ToolTipControllerDefault()
			End If

			Dim info As New ToolTipControlInfo(e.InvalidControl, e.ErrorText)
			info.ToolTipPosition = edit.PointToScreen(viewInfo.ErrorIconBounds.Location)

			edit.ToolTipController.InitialDelay = 0
			edit.ToolTipController.ShowHint(info)
		End Sub
	End Class
End Namespace