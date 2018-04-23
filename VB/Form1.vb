Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Repository

Namespace ButtonEditPopupMenu
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private popupMenu1 As DevExpress.XtraBars.PopupMenu
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private WithEvents repositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
		Private components As IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
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
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
			Me.popupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
			Me.dataSet1 = New System.Data.DataSet()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.dataTable1
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemButtonEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(408, 210)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1})
			Me.dataTable1.TableName = "Table1"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "Column1"
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' gridColumn1
			' 
			Me.gridColumn1.Caption = "gridColumn1"
			Me.gridColumn1.ColumnEdit = Me.repositoryItemButtonEdit1
			Me.gridColumn1.FieldName = "Column1"
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.Visible = True
			Me.gridColumn1.VisibleIndex = 0
			' 
			' repositoryItemButtonEdit1
			' 
			Me.repositoryItemButtonEdit1.AutoHeight = False
			Me.repositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Click to open a context menu", Nothing, Nothing, True)})
			Me.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1"
'			Me.repositoryItemButtonEdit1.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.repositoryItemButtonEdit1_ButtonClick);
			' 
			' barManager1
			' 
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barButtonItem1, Me.barButtonItem2})
			Me.barManager1.MaxItemId = 2
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(408, 0)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 210)
			Me.barDockControlBottom.Size = New System.Drawing.Size(408, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 210)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(408, 0)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 210)
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "barButtonItem1"
			Me.barButtonItem1.Id = 0
			Me.barButtonItem1.Name = "barButtonItem1"
			' 
			' barButtonItem2
			' 
			Me.barButtonItem2.Caption = "barButtonItem2"
			Me.barButtonItem2.Id = 1
			Me.barButtonItem2.Name = "barButtonItem2"
			' 
			' popupMenu1
			' 
			Me.popupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem2)})
			Me.popupMenu1.Manager = Me.barManager1
			Me.popupMenu1.Name = "popupMenu1"
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(408, 210)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "How to display a context menu when a ButtonEdit's button is clicked"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			dataTable1.Rows.Add(New Object() {})
			dataTable1.Rows.Add(New Object() {})
		End Sub

		Private Sub repositoryItemButtonEdit1_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repositoryItemButtonEdit1.ButtonClick
			If e.Button.Kind = ButtonPredefines.Ellipsis Then
				MessageBox.Show("This is a dialog box.")
			End If
			If e.Button.Kind = ButtonPredefines.Combo Then
				Dim editor As ButtonEdit = TryCast(sender, ButtonEdit)
				Dim evi As ButtonEditViewInfo = TryCast(editor.GetViewInfo(), ButtonEditViewInfo)
				Dim bvi As EditorButtonObjectInfoArgs = evi.ButtonInfoByButton(e.Button)
				Dim pt As New Point(bvi.Bounds.Left, bvi.Bounds.Bottom)
				pt = editor.PointToScreen(pt)
				popupMenu1.ShowPopup(pt)
			End If
		End Sub
	End Class
End Namespace
