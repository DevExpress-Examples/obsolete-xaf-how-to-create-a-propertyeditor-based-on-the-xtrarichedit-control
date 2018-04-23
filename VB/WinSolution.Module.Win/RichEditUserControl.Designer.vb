Imports Microsoft.VisualBasic
Imports System
Partial Public Class RichEditUserControl
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

#Region "Component Designer generated code"

    ''' <summary> 
    ''' Required method for Designer support - do not modify 
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(RichEditUserControl))
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.changeFontColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontColorItem()
        Me.changeFontBackColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem()
        Me.toggleFontBoldItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontBoldItem()
        Me.toggleFontItalicItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontItalicItem()
        Me.toggleFontUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem()
        Me.toggleFontDoubleUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem()
        Me.toggleFontStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem()
        Me.toggleFontDoubleStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem()
        Me.toggleFontSuperscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem()
        Me.toggleFontSubscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem()
        Me.fontSizeIncreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem()
        Me.fontSizeDecreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem()
        Me.showFontFormItem1 = New DevExpress.XtraRichEdit.UI.ShowFontFormItem()
        Me.toggleParagraphAlignmentLeftItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem()
        Me.toggleParagraphAlignmentCenterItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem()
        Me.toggleParagraphAlignmentRightItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem()
        Me.toggleParagraphAlignmentJustifyItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem()
        Me.toggleNumberingListItem1 = New DevExpress.XtraRichEdit.UI.ToggleNumberingListItem()
        Me.toggleBulletedListItem1 = New DevExpress.XtraRichEdit.UI.ToggleBulletedListItem()
        Me.toggleMultiLevelListItem1 = New DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem()
        Me.decreaseIndentItem1 = New DevExpress.XtraRichEdit.UI.DecreaseIndentItem()
        Me.increaseIndentItem1 = New DevExpress.XtraRichEdit.UI.IncreaseIndentItem()
        Me.toggleShowWhitespaceItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem()
        Me.showParagraphFormItem1 = New DevExpress.XtraRichEdit.UI.ShowParagraphFormItem()
        Me.cutItem1 = New DevExpress.XtraRichEdit.UI.CutItem()
        Me.copyItem1 = New DevExpress.XtraRichEdit.UI.CopyItem()
        Me.pasteItem1 = New DevExpress.XtraRichEdit.UI.PasteItem()
        Me.quickPrintItem1 = New DevExpress.XtraRichEdit.UI.QuickPrintItem()
        Me.printItem1 = New DevExpress.XtraRichEdit.UI.PrintItem()
        Me.printPreviewItem1 = New DevExpress.XtraRichEdit.UI.PrintPreviewItem()
        Me.undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
        Me.redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
        Me.findItem1 = New DevExpress.XtraRichEdit.UI.FindItem()
        Me.replaceItem1 = New DevExpress.XtraRichEdit.UI.ReplaceItem()
        Me.changeStyleItem1 = New DevExpress.XtraRichEdit.UI.ChangeStyleItem()
        Me.repositoryItemRichEditStyleEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit()
        Me.richEditControl_Renamed = New DevExpress.XtraRichEdit.RichEditControl()
        Me.zoomOutItem1 = New DevExpress.XtraRichEdit.UI.ZoomOutItem()
        Me.zoomInItem1 = New DevExpress.XtraRichEdit.UI.ZoomInItem()
        Me.insertPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertPictureItem()
        Me.insertPageBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertPageBreakItem()
        Me.homeRibbonPage1 = New DevExpress.XtraRichEdit.UI.HomeRibbonPage()
        Me.commonRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup()
        Me.clipboardRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup()
        Me.zoomRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ZoomRibbonPageGroup()
        Me.editingRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup()
        Me.fontRibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.fontRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.FontRibbonPageGroup()
        Me.insertRibbonPage1 = New DevExpress.XtraRichEdit.UI.InsertRibbonPage()
        Me.illustrationsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup()
        Me.pagesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup()
        Me.stylesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup()
        Me.paragraphRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup()
        Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
        Me.repositoryItemRichEditFontSizeEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit()
        Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemRichEditStyleEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' ribbonControl1
        ' 
        Me.ribbonControl1.ApplicationIcon = Nothing
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.changeFontColorItem1, Me.changeFontBackColorItem1, Me.toggleFontBoldItem1, Me.toggleFontItalicItem1, Me.toggleFontUnderlineItem1, Me.toggleFontDoubleUnderlineItem1, Me.toggleFontStrikeoutItem1, Me.toggleFontDoubleStrikeoutItem1, Me.toggleFontSuperscriptItem1, Me.toggleFontSubscriptItem1, Me.fontSizeIncreaseItem1, Me.fontSizeDecreaseItem1, Me.showFontFormItem1, Me.toggleParagraphAlignmentLeftItem1, Me.toggleParagraphAlignmentCenterItem1, Me.toggleParagraphAlignmentRightItem1, Me.toggleParagraphAlignmentJustifyItem1, Me.toggleNumberingListItem1, Me.toggleBulletedListItem1, Me.toggleMultiLevelListItem1, Me.decreaseIndentItem1, Me.increaseIndentItem1, Me.toggleShowWhitespaceItem1, Me.showParagraphFormItem1, Me.cutItem1, Me.copyItem1, Me.pasteItem1, Me.quickPrintItem1, Me.printItem1, Me.printPreviewItem1, Me.undoItem1, Me.redoItem1, Me.findItem1, Me.replaceItem1, Me.changeStyleItem1, Me.zoomOutItem1, Me.zoomInItem1, Me.insertPictureItem1, Me.insertPageBreakItem1})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 45
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.homeRibbonPage1, Me.fontRibbonPage1, Me.insertRibbonPage1})
        Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemFontEdit1, Me.repositoryItemRichEditFontSizeEdit1, Me.repositoryItemRichEditStyleEdit1})
        Me.ribbonControl1.SelectedPage = Me.insertRibbonPage1
        Me.ribbonControl1.Size = New System.Drawing.Size(1226, 141)
        ' 
        ' changeFontColorItem1
        ' 
        Me.changeFontColorItem1.Glyph = (CType(resources.GetObject("changeFontColorItem1.Glyph"), System.Drawing.Image))
        Me.changeFontColorItem1.Id = 2
        Me.changeFontColorItem1.LargeGlyph = (CType(resources.GetObject("changeFontColorItem1.LargeGlyph"), System.Drawing.Image))
        Me.changeFontColorItem1.Name = "changeFontColorItem1"
        ' 
        ' changeFontBackColorItem1
        ' 
        Me.changeFontBackColorItem1.Glyph = (CType(resources.GetObject("changeFontBackColorItem1.Glyph"), System.Drawing.Image))
        Me.changeFontBackColorItem1.Id = 3
        Me.changeFontBackColorItem1.LargeGlyph = (CType(resources.GetObject("changeFontBackColorItem1.LargeGlyph"), System.Drawing.Image))
        Me.changeFontBackColorItem1.Name = "changeFontBackColorItem1"
        ' 
        ' toggleFontBoldItem1
        ' 
        Me.toggleFontBoldItem1.Glyph = (CType(resources.GetObject("toggleFontBoldItem1.Glyph"), System.Drawing.Image))
        Me.toggleFontBoldItem1.Id = 4
        Me.toggleFontBoldItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B))
        Me.toggleFontBoldItem1.LargeGlyph = (CType(resources.GetObject("toggleFontBoldItem1.LargeGlyph"), System.Drawing.Image))
        Me.toggleFontBoldItem1.Name = "toggleFontBoldItem1"
        ' 
        ' toggleFontItalicItem1
        ' 
        Me.toggleFontItalicItem1.Glyph = (CType(resources.GetObject("toggleFontItalicItem1.Glyph"), System.Drawing.Image))
        Me.toggleFontItalicItem1.Id = 5
        Me.toggleFontItalicItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I))
        Me.toggleFontItalicItem1.LargeGlyph = (CType(resources.GetObject("toggleFontItalicItem1.LargeGlyph"), System.Drawing.Image))
        Me.toggleFontItalicItem1.Name = "toggleFontItalicItem1"
        ' 
        ' toggleFontUnderlineItem1
        ' 
        Me.toggleFontUnderlineItem1.Glyph = (CType(resources.GetObject("toggleFontUnderlineItem1.Glyph"), System.Drawing.Image))
        Me.toggleFontUnderlineItem1.Id = 6
        Me.toggleFontUnderlineItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U))
        Me.toggleFontUnderlineItem1.LargeGlyph = (CType(resources.GetObject("toggleFontUnderlineItem1.LargeGlyph"), System.Drawing.Image))
        Me.toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1"
        ' 
        ' toggleFontDoubleUnderlineItem1
        ' 
        Me.toggleFontDoubleUnderlineItem1.Glyph = (CType(resources.GetObject("toggleFontDoubleUnderlineItem1.Glyph"), System.Drawing.Image))
        Me.toggleFontDoubleUnderlineItem1.Id = 7
        Me.toggleFontDoubleUnderlineItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.D))
        Me.toggleFontDoubleUnderlineItem1.LargeGlyph = (CType(resources.GetObject("toggleFontDoubleUnderlineItem1.LargeGlyph"), System.Drawing.Image))
        Me.toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1"
        ' 
        ' toggleFontStrikeoutItem1
        ' 
        Me.toggleFontStrikeoutItem1.Glyph = (CType(resources.GetObject("toggleFontStrikeoutItem1.Glyph"), System.Drawing.Image))
        Me.toggleFontStrikeoutItem1.Id = 8
        Me.toggleFontStrikeoutItem1.LargeGlyph = (CType(resources.GetObject("toggleFontStrikeoutItem1.LargeGlyph"), System.Drawing.Image))
        Me.toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1"
        ' 
        ' toggleFontDoubleStrikeoutItem1
        ' 
        Me.toggleFontDoubleStrikeoutItem1.Glyph = (CType(resources.GetObject("toggleFontDoubleStrikeoutItem1.Glyph"), System.Drawing.Image))
        Me.toggleFontDoubleStrikeoutItem1.Id = 9
        Me.toggleFontDoubleStrikeoutItem1.LargeGlyph = (CType(resources.GetObject("toggleFontDoubleStrikeoutItem1.LargeGlyph"), System.Drawing.Image))
        Me.toggleFontDoubleStrikeoutItem1.Name = "toggleFontDoubleStrikeoutItem1"
        ' 
        ' toggleFontSuperscriptItem1
        ' 
        Me.toggleFontSuperscriptItem1.Glyph = (CType(resources.GetObject("toggleFontSuperscriptItem1.Glyph"), System.Drawing.Image))
        Me.toggleFontSuperscriptItem1.Id = 10
        Me.toggleFontSuperscriptItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.Oemplus))
        Me.toggleFontSuperscriptItem1.LargeGlyph = (CType(resources.GetObject("toggleFontSuperscriptItem1.LargeGlyph"), System.Drawing.Image))
        Me.toggleFontSuperscriptItem1.Name = "toggleFontSuperscriptItem1"
        ' 
        ' toggleFontSubscriptItem1
        ' 
        Me.toggleFontSubscriptItem1.Glyph = (CType(resources.GetObject("toggleFontSubscriptItem1.Glyph"), System.Drawing.Image))
        Me.toggleFontSubscriptItem1.Id = 11
        Me.toggleFontSubscriptItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Oemplus))
        Me.toggleFontSubscriptItem1.LargeGlyph = (CType(resources.GetObject("toggleFontSubscriptItem1.LargeGlyph"), System.Drawing.Image))
        Me.toggleFontSubscriptItem1.Name = "toggleFontSubscriptItem1"
        ' 
        ' fontSizeIncreaseItem1
        ' 
        Me.fontSizeIncreaseItem1.Glyph = (CType(resources.GetObject("fontSizeIncreaseItem1.Glyph"), System.Drawing.Image))
        Me.fontSizeIncreaseItem1.Id = 12
        Me.fontSizeIncreaseItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.OemPeriod))
        Me.fontSizeIncreaseItem1.LargeGlyph = (CType(resources.GetObject("fontSizeIncreaseItem1.LargeGlyph"), System.Drawing.Image))
        Me.fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1"
        ' 
        ' fontSizeDecreaseItem1
        ' 
        Me.fontSizeDecreaseItem1.Glyph = (CType(resources.GetObject("fontSizeDecreaseItem1.Glyph"), System.Drawing.Image))
        Me.fontSizeDecreaseItem1.Id = 13
        Me.fontSizeDecreaseItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.Oemcomma))
        Me.fontSizeDecreaseItem1.LargeGlyph = (CType(resources.GetObject("fontSizeDecreaseItem1.LargeGlyph"), System.Drawing.Image))
        Me.fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1"
        ' 
        ' showFontFormItem1
        ' 
        Me.showFontFormItem1.Glyph = (CType(resources.GetObject("showFontFormItem1.Glyph"), System.Drawing.Image))
        Me.showFontFormItem1.Id = 14
        Me.showFontFormItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D))
        Me.showFontFormItem1.LargeGlyph = (CType(resources.GetObject("showFontFormItem1.LargeGlyph"), System.Drawing.Image))
        Me.showFontFormItem1.Name = "showFontFormItem1"
        ' 
        ' toggleParagraphAlignmentLeftItem1
        ' 
        Me.toggleParagraphAlignmentLeftItem1.Glyph = (CType(resources.GetObject("toggleParagraphAlignmentLeftItem1.Glyph"), System.Drawing.Image))
        Me.toggleParagraphAlignmentLeftItem1.Id = 15
        Me.toggleParagraphAlignmentLeftItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L))
        Me.toggleParagraphAlignmentLeftItem1.LargeGlyph = (CType(resources.GetObject("toggleParagraphAlignmentLeftItem1.LargeGlyph"), System.Drawing.Image))
        Me.toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1"
        ' 
        ' toggleParagraphAlignmentCenterItem1
        ' 
        Me.toggleParagraphAlignmentCenterItem1.Glyph = (CType(resources.GetObject("toggleParagraphAlignmentCenterItem1.Glyph"), System.Drawing.Image))
        Me.toggleParagraphAlignmentCenterItem1.Id = 16
        Me.toggleParagraphAlignmentCenterItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E))
        Me.toggleParagraphAlignmentCenterItem1.LargeGlyph = (CType(resources.GetObject("toggleParagraphAlignmentCenterItem1.LargeGlyph"), System.Drawing.Image))
        Me.toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1"
        ' 
        ' toggleParagraphAlignmentRightItem1
        ' 
        Me.toggleParagraphAlignmentRightItem1.Glyph = (CType(resources.GetObject("toggleParagraphAlignmentRightItem1.Glyph"), System.Drawing.Image))
        Me.toggleParagraphAlignmentRightItem1.Id = 17
        Me.toggleParagraphAlignmentRightItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R))
        Me.toggleParagraphAlignmentRightItem1.LargeGlyph = (CType(resources.GetObject("toggleParagraphAlignmentRightItem1.LargeGlyph"), System.Drawing.Image))
        Me.toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1"
        ' 
        ' toggleParagraphAlignmentJustifyItem1
        ' 
        Me.toggleParagraphAlignmentJustifyItem1.Glyph = (CType(resources.GetObject("toggleParagraphAlignmentJustifyItem1.Glyph"), System.Drawing.Image))
        Me.toggleParagraphAlignmentJustifyItem1.Id = 18
        Me.toggleParagraphAlignmentJustifyItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J))
        Me.toggleParagraphAlignmentJustifyItem1.LargeGlyph = (CType(resources.GetObject("toggleParagraphAlignmentJustifyItem1.LargeGlyph"), System.Drawing.Image))
        Me.toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1"
        ' 
        ' toggleNumberingListItem1
        ' 
        Me.toggleNumberingListItem1.Glyph = (CType(resources.GetObject("toggleNumberingListItem1.Glyph"), System.Drawing.Image))
        Me.toggleNumberingListItem1.Id = 19
        Me.toggleNumberingListItem1.LargeGlyph = (CType(resources.GetObject("toggleNumberingListItem1.LargeGlyph"), System.Drawing.Image))
        Me.toggleNumberingListItem1.Name = "toggleNumberingListItem1"
        ' 
        ' toggleBulletedListItem1
        ' 
        Me.toggleBulletedListItem1.Glyph = (CType(resources.GetObject("toggleBulletedListItem1.Glyph"), System.Drawing.Image))
        Me.toggleBulletedListItem1.Id = 20
        Me.toggleBulletedListItem1.LargeGlyph = (CType(resources.GetObject("toggleBulletedListItem1.LargeGlyph"), System.Drawing.Image))
        Me.toggleBulletedListItem1.Name = "toggleBulletedListItem1"
        ' 
        ' toggleMultiLevelListItem1
        ' 
        Me.toggleMultiLevelListItem1.Glyph = (CType(resources.GetObject("toggleMultiLevelListItem1.Glyph"), System.Drawing.Image))
        Me.toggleMultiLevelListItem1.Id = 21
        Me.toggleMultiLevelListItem1.LargeGlyph = (CType(resources.GetObject("toggleMultiLevelListItem1.LargeGlyph"), System.Drawing.Image))
        Me.toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1"
        ' 
        ' decreaseIndentItem1
        ' 
        Me.decreaseIndentItem1.Glyph = (CType(resources.GetObject("decreaseIndentItem1.Glyph"), System.Drawing.Image))
        Me.decreaseIndentItem1.Id = 22
        Me.decreaseIndentItem1.LargeGlyph = (CType(resources.GetObject("decreaseIndentItem1.LargeGlyph"), System.Drawing.Image))
        Me.decreaseIndentItem1.Name = "decreaseIndentItem1"
        ' 
        ' increaseIndentItem1
        ' 
        Me.increaseIndentItem1.Glyph = (CType(resources.GetObject("increaseIndentItem1.Glyph"), System.Drawing.Image))
        Me.increaseIndentItem1.Id = 23
        Me.increaseIndentItem1.LargeGlyph = (CType(resources.GetObject("increaseIndentItem1.LargeGlyph"), System.Drawing.Image))
        Me.increaseIndentItem1.Name = "increaseIndentItem1"
        ' 
        ' toggleShowWhitespaceItem1
        ' 
        Me.toggleShowWhitespaceItem1.Glyph = (CType(resources.GetObject("toggleShowWhitespaceItem1.Glyph"), System.Drawing.Image))
        Me.toggleShowWhitespaceItem1.Id = 24
        Me.toggleShowWhitespaceItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.D8))
        Me.toggleShowWhitespaceItem1.LargeGlyph = (CType(resources.GetObject("toggleShowWhitespaceItem1.LargeGlyph"), System.Drawing.Image))
        Me.toggleShowWhitespaceItem1.Name = "toggleShowWhitespaceItem1"
        ' 
        ' showParagraphFormItem1
        ' 
        Me.showParagraphFormItem1.Glyph = (CType(resources.GetObject("showParagraphFormItem1.Glyph"), System.Drawing.Image))
        Me.showParagraphFormItem1.Id = 25
        Me.showParagraphFormItem1.LargeGlyph = (CType(resources.GetObject("showParagraphFormItem1.LargeGlyph"), System.Drawing.Image))
        Me.showParagraphFormItem1.Name = "showParagraphFormItem1"
        ' 
        ' cutItem1
        ' 
        Me.cutItem1.Glyph = (CType(resources.GetObject("cutItem1.Glyph"), System.Drawing.Image))
        Me.cutItem1.Id = 26
        Me.cutItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X))
        Me.cutItem1.LargeGlyph = (CType(resources.GetObject("cutItem1.LargeGlyph"), System.Drawing.Image))
        Me.cutItem1.Name = "cutItem1"
        ' 
        ' copyItem1
        ' 
        Me.copyItem1.Glyph = (CType(resources.GetObject("copyItem1.Glyph"), System.Drawing.Image))
        Me.copyItem1.Id = 27
        Me.copyItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C))
        Me.copyItem1.LargeGlyph = (CType(resources.GetObject("copyItem1.LargeGlyph"), System.Drawing.Image))
        Me.copyItem1.Name = "copyItem1"
        ' 
        ' pasteItem1
        ' 
        Me.pasteItem1.Glyph = (CType(resources.GetObject("pasteItem1.Glyph"), System.Drawing.Image))
        Me.pasteItem1.Id = 28
        Me.pasteItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V))
        Me.pasteItem1.LargeGlyph = (CType(resources.GetObject("pasteItem1.LargeGlyph"), System.Drawing.Image))
        Me.pasteItem1.Name = "pasteItem1"
        ' 
        ' quickPrintItem1
        ' 
        Me.quickPrintItem1.Glyph = (CType(resources.GetObject("quickPrintItem1.Glyph"), System.Drawing.Image))
        Me.quickPrintItem1.Id = 33
        Me.quickPrintItem1.LargeGlyph = (CType(resources.GetObject("quickPrintItem1.LargeGlyph"), System.Drawing.Image))
        Me.quickPrintItem1.Name = "quickPrintItem1"
        ' 
        ' printItem1
        ' 
        Me.printItem1.Glyph = (CType(resources.GetObject("printItem1.Glyph"), System.Drawing.Image))
        Me.printItem1.Id = 34
        Me.printItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
        Me.printItem1.LargeGlyph = (CType(resources.GetObject("printItem1.LargeGlyph"), System.Drawing.Image))
        Me.printItem1.Name = "printItem1"
        ' 
        ' printPreviewItem1
        ' 
        Me.printPreviewItem1.Glyph = (CType(resources.GetObject("printPreviewItem1.Glyph"), System.Drawing.Image))
        Me.printPreviewItem1.Id = 35
        Me.printPreviewItem1.LargeGlyph = (CType(resources.GetObject("printPreviewItem1.LargeGlyph"), System.Drawing.Image))
        Me.printPreviewItem1.Name = "printPreviewItem1"
        ' 
        ' undoItem1
        ' 
        Me.undoItem1.Glyph = (CType(resources.GetObject("undoItem1.Glyph"), System.Drawing.Image))
        Me.undoItem1.Id = 36
        Me.undoItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z))
        Me.undoItem1.LargeGlyph = (CType(resources.GetObject("undoItem1.LargeGlyph"), System.Drawing.Image))
        Me.undoItem1.Name = "undoItem1"
        ' 
        ' redoItem1
        ' 
        Me.redoItem1.Glyph = (CType(resources.GetObject("redoItem1.Glyph"), System.Drawing.Image))
        Me.redoItem1.Id = 37
        Me.redoItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y))
        Me.redoItem1.LargeGlyph = (CType(resources.GetObject("redoItem1.LargeGlyph"), System.Drawing.Image))
        Me.redoItem1.Name = "redoItem1"
        ' 
        ' findItem1
        ' 
        Me.findItem1.Glyph = (CType(resources.GetObject("findItem1.Glyph"), System.Drawing.Image))
        Me.findItem1.Id = 38
        Me.findItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
        Me.findItem1.LargeGlyph = (CType(resources.GetObject("findItem1.LargeGlyph"), System.Drawing.Image))
        Me.findItem1.Name = "findItem1"
        ' 
        ' replaceItem1
        ' 
        Me.replaceItem1.Glyph = (CType(resources.GetObject("replaceItem1.Glyph"), System.Drawing.Image))
        Me.replaceItem1.Id = 39
        Me.replaceItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H))
        Me.replaceItem1.LargeGlyph = (CType(resources.GetObject("replaceItem1.LargeGlyph"), System.Drawing.Image))
        Me.replaceItem1.Name = "replaceItem1"
        ' 
        ' changeStyleItem1
        ' 
        Me.changeStyleItem1.Edit = Me.repositoryItemRichEditStyleEdit1
        Me.changeStyleItem1.Id = 40
        Me.changeStyleItem1.Name = "changeStyleItem1"
        Me.changeStyleItem1.Width = 150
        ' 
        ' repositoryItemRichEditStyleEdit1
        ' 
        Me.repositoryItemRichEditStyleEdit1.AutoHeight = False
        Me.repositoryItemRichEditStyleEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repositoryItemRichEditStyleEdit1.Control = Me.richEditControl_Renamed
        Me.repositoryItemRichEditStyleEdit1.Name = "repositoryItemRichEditStyleEdit1"
        ' 
        ' richEditControl
        ' 
        Me.richEditControl_Renamed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richEditControl_Renamed.Location = New System.Drawing.Point(0, 141)
        Me.richEditControl_Renamed.MenuManager = Me.ribbonControl1
        Me.richEditControl_Renamed.Name = "richEditControl"
        Me.richEditControl_Renamed.Size = New System.Drawing.Size(1226, 533)
        Me.richEditControl_Renamed.TabIndex = 1
        ' 
        ' zoomOutItem1
        ' 
        Me.zoomOutItem1.Glyph = (CType(resources.GetObject("zoomOutItem1.Glyph"), System.Drawing.Image))
        Me.zoomOutItem1.Id = 41
        Me.zoomOutItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Subtract))
        Me.zoomOutItem1.LargeGlyph = (CType(resources.GetObject("zoomOutItem1.LargeGlyph"), System.Drawing.Image))
        Me.zoomOutItem1.Name = "zoomOutItem1"
        ' 
        ' zoomInItem1
        ' 
        Me.zoomInItem1.Glyph = (CType(resources.GetObject("zoomInItem1.Glyph"), System.Drawing.Image))
        Me.zoomInItem1.Id = 42
        Me.zoomInItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Add))
        Me.zoomInItem1.LargeGlyph = (CType(resources.GetObject("zoomInItem1.LargeGlyph"), System.Drawing.Image))
        Me.zoomInItem1.Name = "zoomInItem1"
        ' 
        ' insertPictureItem1
        ' 
        Me.insertPictureItem1.Glyph = (CType(resources.GetObject("insertPictureItem1.Glyph"), System.Drawing.Image))
        Me.insertPictureItem1.Id = 43
        Me.insertPictureItem1.LargeGlyph = (CType(resources.GetObject("insertPictureItem1.LargeGlyph"), System.Drawing.Image))
        Me.insertPictureItem1.Name = "insertPictureItem1"
        ' 
        ' insertPageBreakItem1
        ' 
        Me.insertPageBreakItem1.Glyph = (CType(resources.GetObject("insertPageBreakItem1.Glyph"), System.Drawing.Image))
        Me.insertPageBreakItem1.Id = 44
        Me.insertPageBreakItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Enter))
        Me.insertPageBreakItem1.LargeGlyph = (CType(resources.GetObject("insertPageBreakItem1.LargeGlyph"), System.Drawing.Image))
        Me.insertPageBreakItem1.Name = "insertPageBreakItem1"
        ' 
        ' homeRibbonPage1
        ' 
        Me.homeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.commonRibbonPageGroup1, Me.clipboardRibbonPageGroup1, Me.zoomRibbonPageGroup1, Me.editingRibbonPageGroup1})
        Me.homeRibbonPage1.Name = "homeRibbonPage1"
        Me.homeRibbonPage1.Text = "Standard"
        ' 
        ' commonRibbonPageGroup1
        ' 
        Me.commonRibbonPageGroup1.ItemLinks.Add(Me.quickPrintItem1)
        Me.commonRibbonPageGroup1.ItemLinks.Add(Me.printItem1)
        Me.commonRibbonPageGroup1.ItemLinks.Add(Me.printPreviewItem1)
        Me.commonRibbonPageGroup1.ItemLinks.Add(Me.undoItem1)
        Me.commonRibbonPageGroup1.ItemLinks.Add(Me.redoItem1)
        Me.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1"
        Me.commonRibbonPageGroup1.RichEditControl = Me.richEditControl_Renamed
        ' 
        ' clipboardRibbonPageGroup1
        ' 
        Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.cutItem1)
        Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.copyItem1)
        Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.pasteItem1)
        Me.clipboardRibbonPageGroup1.Name = "clipboardRibbonPageGroup1"
        Me.clipboardRibbonPageGroup1.RichEditControl = Me.richEditControl_Renamed
        ' 
        ' zoomRibbonPageGroup1
        ' 
        Me.zoomRibbonPageGroup1.ItemLinks.Add(Me.zoomOutItem1)
        Me.zoomRibbonPageGroup1.ItemLinks.Add(Me.zoomInItem1)
        Me.zoomRibbonPageGroup1.Name = "zoomRibbonPageGroup1"
        Me.zoomRibbonPageGroup1.RichEditControl = Me.richEditControl_Renamed
        ' 
        ' editingRibbonPageGroup1
        ' 
        Me.editingRibbonPageGroup1.ItemLinks.Add(Me.findItem1)
        Me.editingRibbonPageGroup1.ItemLinks.Add(Me.replaceItem1)
        Me.editingRibbonPageGroup1.Name = "editingRibbonPageGroup1"
        Me.editingRibbonPageGroup1.RichEditControl = Me.richEditControl_Renamed
        ' 
        ' fontRibbonPage1
        ' 
        Me.fontRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.fontRibbonPageGroup1})
        Me.fontRibbonPage1.Name = "fontRibbonPage1"
        Me.fontRibbonPage1.Text = "Font"
        ' 
        ' fontRibbonPageGroup1
        ' 
        Me.fontRibbonPageGroup1.ItemLinks.Add(Me.changeFontColorItem1)
        Me.fontRibbonPageGroup1.ItemLinks.Add(Me.changeFontBackColorItem1)
        Me.fontRibbonPageGroup1.ItemLinks.Add(Me.toggleFontBoldItem1)
        Me.fontRibbonPageGroup1.ItemLinks.Add(Me.toggleFontItalicItem1)
        Me.fontRibbonPageGroup1.ItemLinks.Add(Me.toggleFontUnderlineItem1)
        Me.fontRibbonPageGroup1.ItemLinks.Add(Me.toggleFontDoubleUnderlineItem1)
        Me.fontRibbonPageGroup1.ItemLinks.Add(Me.toggleFontStrikeoutItem1)
        Me.fontRibbonPageGroup1.ItemLinks.Add(Me.toggleFontDoubleStrikeoutItem1)
        Me.fontRibbonPageGroup1.ItemLinks.Add(Me.toggleFontSuperscriptItem1)
        Me.fontRibbonPageGroup1.ItemLinks.Add(Me.toggleFontSubscriptItem1)
        Me.fontRibbonPageGroup1.ItemLinks.Add(Me.fontSizeIncreaseItem1)
        Me.fontRibbonPageGroup1.ItemLinks.Add(Me.fontSizeDecreaseItem1)
        Me.fontRibbonPageGroup1.ItemLinks.Add(Me.showFontFormItem1)
        Me.fontRibbonPageGroup1.Name = "fontRibbonPageGroup1"
        Me.fontRibbonPageGroup1.RichEditControl = Me.richEditControl_Renamed
        ' 
        ' insertRibbonPage1
        ' 
        Me.insertRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.illustrationsRibbonPageGroup1, Me.pagesRibbonPageGroup1, Me.stylesRibbonPageGroup1, Me.paragraphRibbonPageGroup1})
        Me.insertRibbonPage1.Name = "insertRibbonPage1"
        Me.insertRibbonPage1.Text = "Common"
        ' 
        ' illustrationsRibbonPageGroup1
        ' 
        Me.illustrationsRibbonPageGroup1.ItemLinks.Add(Me.insertPictureItem1)
        Me.illustrationsRibbonPageGroup1.Name = "illustrationsRibbonPageGroup1"
        Me.illustrationsRibbonPageGroup1.RichEditControl = Me.richEditControl_Renamed
        ' 
        ' pagesRibbonPageGroup1
        ' 
        Me.pagesRibbonPageGroup1.ItemLinks.Add(Me.insertPageBreakItem1)
        Me.pagesRibbonPageGroup1.Name = "pagesRibbonPageGroup1"
        Me.pagesRibbonPageGroup1.RichEditControl = Me.richEditControl_Renamed
        ' 
        ' stylesRibbonPageGroup1
        ' 
        Me.stylesRibbonPageGroup1.ItemLinks.Add(Me.changeStyleItem1)
        Me.stylesRibbonPageGroup1.Name = "stylesRibbonPageGroup1"
        Me.stylesRibbonPageGroup1.RichEditControl = Me.richEditControl_Renamed
        ' 
        ' paragraphRibbonPageGroup1
        ' 
        Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.toggleParagraphAlignmentLeftItem1)
        Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.toggleParagraphAlignmentCenterItem1)
        Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.toggleParagraphAlignmentRightItem1)
        Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.toggleParagraphAlignmentJustifyItem1)
        Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.toggleNumberingListItem1)
        Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.toggleBulletedListItem1)
        Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.toggleMultiLevelListItem1)
        Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.decreaseIndentItem1)
        Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.increaseIndentItem1)
        Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.toggleShowWhitespaceItem1)
        Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.showParagraphFormItem1)
        Me.paragraphRibbonPageGroup1.Name = "paragraphRibbonPageGroup1"
        Me.paragraphRibbonPageGroup1.RichEditControl = Me.richEditControl_Renamed
        ' 
        ' repositoryItemFontEdit1
        ' 
        Me.repositoryItemFontEdit1.AutoHeight = False
        Me.repositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1"
        ' 
        ' repositoryItemRichEditFontSizeEdit1
        ' 
        Me.repositoryItemRichEditFontSizeEdit1.AutoHeight = False
        Me.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repositoryItemRichEditFontSizeEdit1.Control = Me.richEditControl_Renamed
        Me.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1"
        ' 
        ' richEditBarController1
        ' 
        Me.richEditBarController1.BarItems.Add(Me.changeFontColorItem1)
        Me.richEditBarController1.BarItems.Add(Me.changeFontBackColorItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleFontBoldItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleFontItalicItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleFontUnderlineItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleFontDoubleUnderlineItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleFontStrikeoutItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleFontDoubleStrikeoutItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleFontSuperscriptItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleFontSubscriptItem1)
        Me.richEditBarController1.BarItems.Add(Me.fontSizeIncreaseItem1)
        Me.richEditBarController1.BarItems.Add(Me.fontSizeDecreaseItem1)
        Me.richEditBarController1.BarItems.Add(Me.showFontFormItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentLeftItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentCenterItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentRightItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentJustifyItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleNumberingListItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleBulletedListItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleMultiLevelListItem1)
        Me.richEditBarController1.BarItems.Add(Me.decreaseIndentItem1)
        Me.richEditBarController1.BarItems.Add(Me.increaseIndentItem1)
        Me.richEditBarController1.BarItems.Add(Me.toggleShowWhitespaceItem1)
        Me.richEditBarController1.BarItems.Add(Me.showParagraphFormItem1)
        Me.richEditBarController1.BarItems.Add(Me.cutItem1)
        Me.richEditBarController1.BarItems.Add(Me.copyItem1)
        Me.richEditBarController1.BarItems.Add(Me.pasteItem1)
        Me.richEditBarController1.BarItems.Add(Me.quickPrintItem1)
        Me.richEditBarController1.BarItems.Add(Me.printItem1)
        Me.richEditBarController1.BarItems.Add(Me.printPreviewItem1)
        Me.richEditBarController1.BarItems.Add(Me.undoItem1)
        Me.richEditBarController1.BarItems.Add(Me.redoItem1)
        Me.richEditBarController1.BarItems.Add(Me.findItem1)
        Me.richEditBarController1.BarItems.Add(Me.replaceItem1)
        Me.richEditBarController1.BarItems.Add(Me.changeStyleItem1)
        Me.richEditBarController1.BarItems.Add(Me.zoomOutItem1)
        Me.richEditBarController1.BarItems.Add(Me.zoomInItem1)
        Me.richEditBarController1.BarItems.Add(Me.insertPictureItem1)
        Me.richEditBarController1.BarItems.Add(Me.insertPageBreakItem1)
        Me.richEditBarController1.RichEditControl = Me.richEditControl_Renamed
        ' 
        ' usrRichEditControl
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.richEditControl_Renamed)
        Me.Controls.Add(Me.ribbonControl1)
        Me.Name = "usrRichEditControl"
        Me.Size = New System.Drawing.Size(1226, 674)
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemRichEditStyleEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region

    Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private repositoryItemFontEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit
    Private repositoryItemRichEditFontSizeEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit
    Private richEditControl_Renamed As DevExpress.XtraRichEdit.RichEditControl
    Private changeFontColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontColorItem
    Private changeFontBackColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem
    Private toggleFontBoldItem1 As DevExpress.XtraRichEdit.UI.ToggleFontBoldItem
    Private toggleFontItalicItem1 As DevExpress.XtraRichEdit.UI.ToggleFontItalicItem
    Private toggleFontUnderlineItem1 As DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem
    Private toggleFontDoubleUnderlineItem1 As DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem
    Private toggleFontStrikeoutItem1 As DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem
    Private toggleFontDoubleStrikeoutItem1 As DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem
    Private toggleFontSuperscriptItem1 As DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem
    Private toggleFontSubscriptItem1 As DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem
    Private fontSizeIncreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem
    Private fontSizeDecreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem
    Private showFontFormItem1 As DevExpress.XtraRichEdit.UI.ShowFontFormItem
    Private toggleParagraphAlignmentLeftItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem
    Private toggleParagraphAlignmentCenterItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem
    Private toggleParagraphAlignmentRightItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem
    Private toggleParagraphAlignmentJustifyItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem
    Private toggleNumberingListItem1 As DevExpress.XtraRichEdit.UI.ToggleNumberingListItem
    Private toggleBulletedListItem1 As DevExpress.XtraRichEdit.UI.ToggleBulletedListItem
    Private toggleMultiLevelListItem1 As DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem
    Private decreaseIndentItem1 As DevExpress.XtraRichEdit.UI.DecreaseIndentItem
    Private increaseIndentItem1 As DevExpress.XtraRichEdit.UI.IncreaseIndentItem
    Private toggleShowWhitespaceItem1 As DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem
    Private showParagraphFormItem1 As DevExpress.XtraRichEdit.UI.ShowParagraphFormItem
    Private cutItem1 As DevExpress.XtraRichEdit.UI.CutItem
    Private copyItem1 As DevExpress.XtraRichEdit.UI.CopyItem
    Private pasteItem1 As DevExpress.XtraRichEdit.UI.PasteItem
    Private quickPrintItem1 As DevExpress.XtraRichEdit.UI.QuickPrintItem
    Private printItem1 As DevExpress.XtraRichEdit.UI.PrintItem
    Private printPreviewItem1 As DevExpress.XtraRichEdit.UI.PrintPreviewItem
    Private undoItem1 As DevExpress.XtraRichEdit.UI.UndoItem
    Private redoItem1 As DevExpress.XtraRichEdit.UI.RedoItem
    Private findItem1 As DevExpress.XtraRichEdit.UI.FindItem
    Private replaceItem1 As DevExpress.XtraRichEdit.UI.ReplaceItem
    Private changeStyleItem1 As DevExpress.XtraRichEdit.UI.ChangeStyleItem
    Private repositoryItemRichEditStyleEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit
    Private zoomOutItem1 As DevExpress.XtraRichEdit.UI.ZoomOutItem
    Private zoomInItem1 As DevExpress.XtraRichEdit.UI.ZoomInItem
    Private insertPictureItem1 As DevExpress.XtraRichEdit.UI.InsertPictureItem
    Private insertPageBreakItem1 As DevExpress.XtraRichEdit.UI.InsertPageBreakItem
    Private homeRibbonPage1 As DevExpress.XtraRichEdit.UI.HomeRibbonPage
    Private fontRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.FontRibbonPageGroup
    Private paragraphRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup
    Private clipboardRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup
    Private commonRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup
    Private editingRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup
    Private stylesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup
    Private zoomRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ZoomRibbonPageGroup
    Private insertRibbonPage1 As DevExpress.XtraRichEdit.UI.InsertRibbonPage
    Private illustrationsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup
    Private pagesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup
    Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
    Private fontRibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
End Class
