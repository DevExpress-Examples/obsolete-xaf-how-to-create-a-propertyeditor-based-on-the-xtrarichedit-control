<strong> UPDATE: </strong>
Starting with 18.1, we introduced <a href="https://docs.devexpress.com/eXpressAppFramework/400003/concepts/extra-modules/office-module/office-module-overview">Office Module</a>. This module provides RichTextPropertyEditor with an ability to work with rich text properties.
 
So we suggest using the new editor in new applications. The current example won't be developed anymore.
 


# Obsolete - How to create a PropertyEditor based on the XtraRichEdit control


Take special note that this editor is intended to be used for a simple and most common scenario when only one text property in a Detail View is edited with the help of the XtraRichEdit control (RichEditControl). Other scenarios are not supported in this example and are required to be implemented manually. For example, if there are more than one property, edited with this editor in a Detail View, then there may be problems with merging in ribbons. See the <a href="https://www.devexpress.com/Support/Center/p/B142856">B142856</a> issue for more detailed information.<br><br></p>
<p><strong>Important Notes<br>1.</strong> Please take special note that this example is not a complete solution and is supposed to be further tested and modified by you according to your business requirements.</p>
<p><strong>2. </strong>The standard XAF Save Action may be activated on the first load in this example, because the MS Word and XtraRichEdit RTF formats are different and thus the object receives a different value on the first value post. Once you save the value in the control's format, it will work as expected. See also the <a href="https://www.devexpress.com/Support/Center/p/T136988">Problem with setting the RtfText in XtraRichEdit</a> and <a href="https://www.devexpress.com/Support/Center/p/Q254329">ImmediatePostData with XtraRichEdit</a> tickets for the details on how to improve tracking of changed values in the RichEditControl component.</p>
<p> </p>
<p><strong>See Also:</strong> <br> <a href="http://documentation.devexpress.com/#Xaf/CustomDocument3097"><u>Implement Custom Property Editors</u></a> <br> <a href="http://documentation.devexpress.com/#Xaf/CustomDocument2679"><u>How to: Implement a Property Editor for Windows Forms Applications</u></a> <br> <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument4946"><u>XtraRichEdit Home</u></a><br> <a href="https://www.devexpress.com/Support/Center/p/S31438">PropertyEditors - Support the XtraRichEdit control.</a></p>

<br/>


