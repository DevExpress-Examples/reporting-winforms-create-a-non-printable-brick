Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports DevExpress.XtraPrinting

' ...
Namespace NonPrintBrick

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub btn_NonPrintableBrick_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim graph As BrickGraphics = printingSystem1.Graph
            ' Start the report generation.
            printingSystem1.Begin()
            ' Set the modifier - specify the page area.
            graph.Modifier = BrickModifier.MarginalHeader
            Dim format As String = "Page {0} of {1}"
            graph.Font = graph.DefaultFont
            graph.BackColor = Color.Transparent
            Dim r As RectangleF = New RectangleF(0, 0, 0, graph.Font.Height)
            ' Create a brick.
            Dim brick As PageInfoBrick = graph.DrawPageInfo(PageInfo.NumberOfTotal, format, Color.Black, r, BorderSide.None)
            brick.Alignment = BrickAlignment.Far
            brick.AutoWidth = True
            ' Create another brick with different alignment.
            brick = graph.DrawPageInfo(PageInfo.DateTime, "{0:MMMM dd}", Color.Black, r, BorderSide.None)
            ' Change the page area - set the modifier.
            printingSystem1.Graph.Modifier = BrickModifier.DetailHeader
            graph.BackColor = Color.Silver
            ' Create a brick, which will be hidden in the printout.
            Dim tBrick As TextBrick = New TextBrick(BorderSide.None, 1, Color.Black, Color.Khaki, Color.Blue)
            tBrick.Url = "http://www.devexpress.com"
            tBrick.Text = "Click here to visit our web site"
            tBrick.Printed = False
            printingSystem1.Graph.DrawBrick(tBrick, New RectangleF(0, 0, 200, 20))
            ' Create a brick - a column header.
            printingSystem1.Graph.DrawString("Report Items", Color.Black, New RectangleF(0, 20, 200, 20), BorderSide.All)
            ' Change the page area - set the modifier.
            printingSystem1.Graph.Modifier = BrickModifier.Detail
            graph.BackColor = Color.White
            ' Create bricks.
            For i As Integer = 0 To 100 - 1
                printingSystem1.Graph.DrawString("Item N" & Convert.ToString(i + 1), Color.Black, New RectangleF(0, 20 * i, 200, 20), BorderSide.All)
            Next

            ' Finish the report generation.
            printingSystem1.End()
            ' Preview the report.
            printingSystem1.PreviewFormEx.Show()
        End Sub
    End Class
End Namespace
