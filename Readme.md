<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/ValidationProviderAutoTooltips/Form1.cs) (VB: [Form1.vb](./VB/ValidationProviderAutoTooltips/Form1.vb))
<!-- default file list end -->
# How to make tool tips appear immediately after validation is failed


<p>Usually, to read an error message after validation is failed it's necessary to hover the mouser cursor over the error icon that appearers near the control. This example shows how to make tool tips with an error text that appears together with an error icon. To implement this it's sufficient to handle DXValidationProvider's ValidationFailed event.</p>

<br/>


