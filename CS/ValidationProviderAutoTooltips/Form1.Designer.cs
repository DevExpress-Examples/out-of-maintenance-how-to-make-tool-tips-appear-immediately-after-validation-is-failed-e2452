namespace ValidationProviderAutoTooltips
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if ( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
			DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
			this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
			this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
			this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider();
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// textEdit1
			// 
			this.dxValidationProvider1.SetIconAlignment(this.textEdit1, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
			this.textEdit1.Location = new System.Drawing.Point(12, 13);
			this.textEdit1.Name = "textEdit1";
			this.textEdit1.Size = new System.Drawing.Size(177, 20);
			this.textEdit1.TabIndex = 0;
			conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
			conditionValidationRule1.ErrorText = "Error text";
			conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
			this.dxValidationProvider1.SetValidationRule(this.textEdit1, conditionValidationRule1);
			// 
			// textEdit2
			// 
			this.textEdit2.Location = new System.Drawing.Point(12, 57);
			this.textEdit2.Name = "textEdit2";
			this.textEdit2.Size = new System.Drawing.Size(177, 20);
			this.textEdit2.TabIndex = 1;
			conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
			conditionValidationRule2.ErrorText = "This value is not valid";
			this.dxValidationProvider1.SetValidationRule(this.textEdit2, conditionValidationRule2);
			// 
			// dxValidationProvider1
			// 
			this.dxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
			this.dxValidationProvider1.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.validationProvider1_ValidationFailed);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.textEdit2);
			this.Controls.Add(this.textEdit1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.TextEdit textEdit1;
		private DevExpress.XtraEditors.TextEdit textEdit2;
		private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
	}
}

