<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtArtifactName = New System.Windows.Forms.TextBox()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.numYearFound = New System.Windows.Forms.NumericUpDown()
        Me.cbCondition = New System.Windows.Forms.ComboBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtHiddenID = New System.Windows.Forms.TextBox()
        CType(Me.numYearFound, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtArtifactName
        '
        Me.txtArtifactName.Location = New System.Drawing.Point(193, 53)
        Me.txtArtifactName.Name = "txtArtifactName"
        Me.txtArtifactName.Size = New System.Drawing.Size(153, 20)
        Me.txtArtifactName.TabIndex = 0
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(193, 79)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(153, 20)
        Me.txtCountry.TabIndex = 1
        '
        'numYearFound
        '
        Me.numYearFound.Location = New System.Drawing.Point(193, 105)
        Me.numYearFound.Name = "numYearFound"
        Me.numYearFound.Size = New System.Drawing.Size(153, 20)
        Me.numYearFound.TabIndex = 2
        '
        'cbCondition
        '
        Me.cbCondition.FormattingEnabled = True
        Me.cbCondition.Items.AddRange(New Object() {"Excellent", "Good", "Fair", "Poor"})
        Me.cbCondition.Location = New System.Drawing.Point(193, 131)
        Me.cbCondition.Name = "cbCondition"
        Me.cbCondition.Size = New System.Drawing.Size(153, 21)
        Me.cbCondition.TabIndex = 3
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(172, 390)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(92, 31)
        Me.btnCreate.TabIndex = 4
        Me.btnCreate.Text = "Save Artifact"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(405, 390)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(92, 31)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete Artifact"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(289, 390)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(92, 31)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "Update Artifact"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(527, 390)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(92, 31)
        Me.btnRead.TabIndex = 4
        Me.btnRead.Text = "Load records"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Artifact Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Origin Country:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Year Discovered:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(111, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Condition:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(114, 158)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(562, 226)
        Me.DataGridView1.TabIndex = 6
        '
        'txtHiddenID
        '
        Me.txtHiddenID.Location = New System.Drawing.Point(352, 54)
        Me.txtHiddenID.Name = "txtHiddenID"
        Me.txtHiddenID.Size = New System.Drawing.Size(153, 20)
        Me.txtHiddenID.TabIndex = 7
        Me.txtHiddenID.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtHiddenID)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.cbCondition)
        Me.Controls.Add(Me.numYearFound)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.txtArtifactName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.numYearFound, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtArtifactName As TextBox
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents numYearFound As NumericUpDown
    Friend WithEvents cbCondition As ComboBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtHiddenID As TextBox
End Class
