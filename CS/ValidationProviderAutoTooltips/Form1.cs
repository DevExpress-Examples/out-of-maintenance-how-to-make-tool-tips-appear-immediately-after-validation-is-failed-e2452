using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.ViewInfo;

namespace ValidationProviderAutoTooltips
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void validationProvider1_ValidationFailed(object sender, ValidationFailedEventArgs e)
		{
			BaseEdit edit = e.InvalidControl as BaseEdit;
			if ( edit == null )
				return;

			BaseEditViewInfo viewInfo = edit.GetViewInfo() as BaseEditViewInfo;
			if ( viewInfo == null )
				return;

			if ( edit.ToolTipController == null )
				edit.ToolTipController = new ToolTipControllerDefault();

			ToolTipControlInfo info = new ToolTipControlInfo(e.InvalidControl, e.ErrorText);
			info.ToolTipPosition = edit.PointToScreen(viewInfo.ErrorIconBounds.Location);

			edit.ToolTipController.InitialDelay = 0;
			edit.ToolTipController.ShowHint(info);
		}
	}
}