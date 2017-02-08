Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data

Public Class frmViewReport

    ''' <summary>
    ''' The default constructor for this form.
    ''' It takes a report class and the data set which used to populate the report data.
    ''' </summary>
    ''' <param name="reportClass">The Report class to be shown on the form</param>
    ''' <param name="dataSource">The data set to get the data from</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal reportClass As ReportClass, ByVal dataSource As DataSet)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        reportClass.SetDataSource(dataSource)
        Me.rptViewer.ReportSource = reportClass
    End Sub
End Class