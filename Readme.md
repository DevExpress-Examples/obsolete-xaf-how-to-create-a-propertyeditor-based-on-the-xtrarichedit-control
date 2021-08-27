<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128588745/10.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1509)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MergeRibbonsDetailViewController.cs](./CS/WinSolution.Module.Win/MergeRibbonsDetailViewController.cs) (VB: [MergeRibbonsDetailViewController.vb](./VB/WinSolution.Module.Win/MergeRibbonsDetailViewController.vb))
* [Model.DesignedDiffs.xafml](./CS/WinSolution.Module.Win/Model.DesignedDiffs.xafml) (VB: [Model.DesignedDiffs.xafml](./VB/WinSolution.Module.Win/Model.DesignedDiffs.xafml))
* [RichEditPropertyEditor.cs](./CS/WinSolution.Module.Win/RichEditPropertyEditor.cs) (VB: [RichEditPropertyEditor.vb](./VB/WinSolution.Module.Win/RichEditPropertyEditor.vb))
* [RichEditUserControl.cs](./CS/WinSolution.Module.Win/RichEditUserControl.cs) (VB: [RichEditUserControl.vb](./VB/WinSolution.Module.Win/RichEditUserControl.vb))
* [Updater.cs](./CS/WinSolution.Module.Win/Updater.cs) (VB: [Updater.vb](./VB/WinSolution.Module.Win/Updater.vb))
<!-- default file list end -->
# How to create a PropertyEditor based on the XtraRichEdit control


<p>We are going to provide Rich Text Editor integration in an upcoming release, so this example will be obsoleted. Please refer to the <a href="https://www.devexpress.com/Support/Center/p/T608185">T608185: WinForms Rich Text Editor Module - v18.1 Preview</a> article to see implementation details and provide us with your opinion regarding it.<br><br><br>Take special note that this editor is intended to be used for a simple and most common scenario when only one text property in a Detail View is edited with the help of the XtraRichEdit control (RichEditControl). Other scenarios are not supported in this example and are required to be implemented manually. For example, if there are more than one property, edited with this editor in a Detail View, then there may be problems with merging in ribbons. See the <a href="https://www.devexpress.com/Support/Center/p/B142856">B142856</a> issue for more detailed information.<br><br></p>
<p><strong>Important Notes<br>1.</strong> Please take special note that this example is not a complete solution and is supposed to be further tested and modified by you according to your business requirements.</p>
<p><strong>2. </strong>The standard XAF Save Action may be activated on the first load in this example, because the MS Word and XtraRichEdit RTF formats are different and thus the object receives a different value on the first value post. Once you save the value in the control's format, it will work as expected. See also the <a href="https://www.devexpress.com/Support/Center/p/T136988">Problem with setting the RtfText in XtraRichEdit</a> and <a href="https://www.devexpress.com/Support/Center/p/Q254329">ImmediatePostData with XtraRichEdit</a> tickets for the details on how to improve tracking of changed values in the RichEditControl component.</p>
<p> </p>
<p><strong>See Also:</strong> <br> <a href="http://documentation.devexpress.com/#Xaf/CustomDocument3097"><u>Implement Custom Property Editors</u></a> <br> <a href="http://documentation.devexpress.com/#Xaf/CustomDocument2679"><u>How to: Implement a Property Editor for Windows Forms Applications</u></a> <br> <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument4946"><u>XtraRichEdit Home</u></a><br> <a href="https://www.devexpress.com/Support/Center/p/S31438">PropertyEditors - Support the XtraRichEdit control.</a></p>

<br/>


