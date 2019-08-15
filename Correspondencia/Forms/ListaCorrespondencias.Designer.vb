<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaCorrespondencias
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListaCorrespondencias))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnCorreo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtFilter = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnActualizar = New System.Windows.Forms.ToolStripButton()
        Me.Visualizar = New System.Windows.Forms.ToolStripButton()
        Me.Lista = New System.Windows.Forms.DataGridView()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.pdfViewer = New AxAcroPDFLib.AxAcroPDF()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pdfViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnCorreo, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.txtFilter, Me.ToolStripSeparator2, Me.btnActualizar, Me.Visualizar, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1041, 51)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.AutoSize = False
        Me.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNuevo.Image = Global.Correspondencia.My.Resources.Resources.file_new
        Me.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(36, 48)
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnCorreo
        '
        Me.btnCorreo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCorreo.Image = Global.Correspondencia.My.Resources.Resources.mail
        Me.btnCorreo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCorreo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCorreo.Name = "btnCorreo"
        Me.btnCorreo.Size = New System.Drawing.Size(36, 48)
        Me.btnCorreo.Text = "Correo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 51)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(34, 48)
        Me.ToolStripLabel1.Text = "Filtro"
        '
        'txtFilter
        '
        Me.txtFilter.AutoSize = False
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(180, 35)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 51)
        '
        'btnActualizar
        '
        Me.btnActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnActualizar.Image = Global.Correspondencia.My.Resources.Resources.refresh
        Me.btnActualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(36, 48)
        Me.btnActualizar.Text = "Actualizar"
        '
        'Visualizar
        '
        Me.Visualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Visualizar.Image = Global.Correspondencia.My.Resources.Resources.file_document
        Me.Visualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Visualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Visualizar.Name = "Visualizar"
        Me.Visualizar.Size = New System.Drawing.Size(36, 48)
        Me.Visualizar.Text = "Visualizar Documento"
        '
        'Lista
        '
        Me.Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Lista.Location = New System.Drawing.Point(12, 69)
        Me.Lista.MultiSelect = False
        Me.Lista.Name = "Lista"
        Me.Lista.Size = New System.Drawing.Size(405, 499)
        Me.Lista.TabIndex = 1
        '
        'pdfViewer
        '
        Me.pdfViewer.Enabled = True
        Me.pdfViewer.Location = New System.Drawing.Point(440, 69)
        Me.pdfViewer.Name = "pdfViewer"
        Me.pdfViewer.OcxState = CType(resources.GetObject("pdfViewer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.pdfViewer.Size = New System.Drawing.Size(590, 499)
        Me.pdfViewer.TabIndex = 2
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Correspondencia.My.Resources.Resources.down
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 48)
        Me.ToolStripButton1.Text = "Descargar"
        '
        'ListaCorrespondencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1041, 580)
        Me.Controls.Add(Me.pdfViewer)
        Me.Controls.Add(Me.Lista)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "ListaCorrespondencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Correspondencias"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pdfViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCorreo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtFilter As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnActualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Lista As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Visualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents pdfViewer As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton

End Class
