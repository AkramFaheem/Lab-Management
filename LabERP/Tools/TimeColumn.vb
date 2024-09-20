Imports System
Imports System.Windows.Forms

Public Class TimeColumn

    Inherits DataGridViewColumn

    Public Sub New()
        MyBase.New(New TimeCell())
    End Sub 'New


    Public Overrides Property CellTemplate() As DataGridViewCell
        Get
            Return MyBase.CellTemplate
        End Get
        Set(ByVal value As DataGridViewCell)
            ' Ensure that the cell used for the template is a CalendarCell
            If Not (value Is Nothing) And Not value.GetType().IsAssignableFrom(GetType(TimeCell)) Then
                Throw New InvalidCastException("Must be a TimeCell")
            End If
            'MyBase.CellTemplate = value
        End Set
    End Property
End Class

#Region "Time Cell Class"
Public Class TimeCell

    Inherits DataGridViewTextBoxCell


    Public Sub New()
        ' Use the Time format.
        Style.Format = "hh:mm tt"

    End Sub


    Public Overrides Sub InitializeEditingControl(ByVal rowIndex As Integer, ByVal initialFormattedValue As Object, ByVal dataGridViewCellStyle As DataGridViewCellStyle)

        MyBase.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle)
        Dim ctl As TimeEditingControl = CType(DataGridView.EditingControl, TimeEditingControl)
        ctl.Value = CType(Me.Value, DateTime)

    End Sub


    Public Overrides ReadOnly Property EditType() As Type
        Get
            ' Return the type of the editing contol that TimeCell uses.
            Return GetType(TimeEditingControl)
        End Get

    End Property


    Public Overrides ReadOnly Property ValueType() As Type
        Get
            ' Return the type of the value that TimeCell contains.
            Return GetType(DateTime)

        End Get

    End Property


    Public Overrides ReadOnly Property DefaultNewRowValue() As Object
        Get
            ' Use the current date and time as the default value.
            Return DateTime.Now

        End Get

    End Property


End Class

#End Region

Class TimeEditingControl
    Inherits DateTimePicker
    Implements IDataGridViewEditingControl

    Private dataGridViewControl As DataGridView
    Private valueIsChanged As Boolean = False
    Private rowIndexNum As Integer


    Public Sub New()
        Me.Format = DateTimePickerFormat.Time
    End Sub 'New

    ' Implements the IDataGridViewEditingControl.EditingControlFormattedValue property.
    Public Property EditingControlFormattedValue() As Object Implements IDataGridViewEditingControl.EditingControlFormattedValue
        Get
            Return Me.Value.ToShortTimeString()
        End Get
        Set(ByVal value As Object)
            If TypeOf value Is [String] Then
                Me.Value = DateTime.Parse(CStr(value))
            End If
        End Set
    End Property


    ' Implements the IDataGridViewEditingControl.GetEditingControlFormattedValue method.
    Public Function GetEditingControlFormattedValue(ByVal context As DataGridViewDataErrorContexts) As Object Implements IDataGridViewEditingControl.GetEditingControlFormattedValue
        Return Me.Value.ToShortTimeString()
    End Function 'GetFormattedValue


    ' Implements the IDataGridViewEditingControl.ApplyCellStyleToEditingControl method.
    Public Sub ApplyCellStyleToEditingControl(ByVal dataGridViewCellStyle As DataGridViewCellStyle) Implements IDataGridViewEditingControl.ApplyCellStyleToEditingControl
        Me.Font = dataGridViewCellStyle.Font
        Me.CalendarForeColor = dataGridViewCellStyle.ForeColor
        Me.CalendarMonthBackground = dataGridViewCellStyle.BackColor
    End Sub 'UseCellStyle

    ' Implements the IDataGridViewEditingControl.EditingControlRowIndex property.
    Public Property EditingControlRowIndex() As Integer Implements IDataGridViewEditingControl.EditingControlRowIndex
        Get
            Return rowIndexNum
        End Get
        Set(ByVal value As Integer)
            rowIndexNum = value
        End Set
    End Property


    ' Implements the IDataGridViewEditingControl.EditingControlWantsInputKey method.
    Public Function EditingControlWantsInputKey(ByVal key As Keys, ByVal dataGridViewWantsInputKey As Boolean) As Boolean Implements IDataGridViewEditingControl.EditingControlWantsInputKey

        ' Let the DateTimePicker handle the keys listed.
        Select Case key And Keys.KeyCode
            Case Keys.Left, Keys.Up, Keys.Down, Keys.Right, Keys.Home, Keys.End, Keys.PageDown, Keys.PageUp
                Return True
            Case Else
                Return False
        End Select
    End Function 'IsInputKey


    ' Implements the IDataGridViewEditingControl.PrepareEditingControlForEdit method.
    Public Sub PrepareEditingControlForEdit(ByVal selectAll As Boolean) Implements IDataGridViewEditingControl.PrepareEditingControlForEdit
        ' No preparation needs to be done.
    End Sub 'PrepareForEdit

    ' Implements the IDataGridViewEditingControl.RepositionEditingControlOnValueChange
    ' property.
    Public ReadOnly Property RepositionEditingControlOnValueChange() As Boolean Implements IDataGridViewEditingControl.RepositionEditingControlOnValueChange
        Get
            Return False
        End Get
    End Property

    ' Implements the IDataGridViewEditingControl.EditingControlDataGridView property.
    Public Property EditingControlDataGridView() As DataGridView Implements IDataGridViewEditingControl.EditingControlDataGridView
        Get
            Return dataGridViewControl
        End Get
        Set(ByVal value As DataGridView)
            dataGridViewControl = value
        End Set
    End Property

    ' Implements the IDataGridViewEditingControl.EditingControlValueChanged property.
    Public Property EditingControlValueChanged() As Boolean Implements IDataGridViewEditingControl.EditingControlValueChanged
        Get
            Return valueIsChanged
        End Get
        Set(ByVal value As Boolean)
            valueIsChanged = value
        End Set
    End Property

    ' Implements the IDataGridViewEditingControl.EditingPanelCursor method.
    Public ReadOnly Property EditingPanelCursor() As Cursor Implements IDataGridViewEditingControl.EditingPanelCursor
        Get
            Return MyBase.Cursor
        End Get
    End Property


    Protected Overrides Sub OnValueChanged(ByVal eventargs As EventArgs)
        ' Notify the DataGridView that the contents of the cell
        ' have changed.
        valueIsChanged = True
        EditingControlDataGridView.NotifyCurrentCellDirty(True)
        MyBase.OnValueChanged(eventargs)

    End Sub 'OnValueChanged

End Class
