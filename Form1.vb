Imports System.Data.SqlClient
Imports System.IO

Public Class Form1

    Private Sub GenerateGridToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles GenerateGridToolStripButton.Click
        If Me.SqlTextBox.Text.Length > 0 Then
            Dim MyConnectionString As String = "Server=INP2300FCVMOJA1.nps.doi.net\nrssapps;Database=AKRO;Trusted_Connection=True;"
            Dim SqlDataTable As DataTable = GetSqlServerDataTable(MyConnectionString, Me.SqlTextBox.Text)
            Me.DataGridView.DataSource = SqlDataTable

            GenerateCode(SqlDataTable)
        End If
    End Sub

    Private Sub GenerateCode(SqlDataTable As DataTable)
        Dim Code As String = "Ext.onReady(function(){" & vbNewLine & vbNewLine & GetExtJSStore(SqlDataTable, Me.FilenamesPrefixToolStripTextBox.Text & "_json.cfm")
        Code = Code & GetExtJSGrid(SqlDataTable)
        Code = Code & "});" & vbNewLine
        Me.OutputTextBox.Text = Code & vbNewLine

        Me.JSONTextBox.Text = GetJSONDataSourceCode(SqlDataTable)

        Dim JavascriptFilename As String = Me.FilenamesPrefixToolStripTextBox.Text & ".js"
        Me.HTMLTextBox.Text = GetHTML(JavascriptFilename)
    End Sub

    Private Sub WriteFiles(OutputDirectory As String, FilenamesPrefix As String)
        If My.Computer.FileSystem.DirectoryExists(OutputDirectory) Then
            If OutputDirectory.Trim.Substring(OutputDirectory.Trim.Length - 1, 1) <> "\" Then
                OutputDirectory = OutputDirectory & "\"
                Dim JsonFile As String = OutputDirectory & FilenamesPrefix & "_json.cfm"
                Dim JsFile As String = OutputDirectory & FilenamesPrefix & ".js"
                Dim CfmFile As String = OutputDirectory & FilenamesPrefix & ".cfm"

                My.Computer.FileSystem.WriteAllText(JsonFile, Me.JSONTextBox.Text, False)
                My.Computer.FileSystem.WriteAllText(JsFile, Me.OutputTextBox.Text, False)
                My.Computer.FileSystem.WriteAllText(CfmFile, Me.HTMLTextBox.Text, False)
            End If
        Else
            MsgBox("Directory " & OutputDirectory & " does not exist")
        End If
    End Sub

    Private Sub X(SqlDataTable As DataTable)
        For Each col As DataColumn In SqlDataTable.Columns
            Debug.Print("<cfgridcolumn header=""" & col.ColumnName & """ name=""" & col.ColumnName & """ select=""true"" type=""text"" display=""true"" >")
        Next
    End Sub

    Private Function GetHTML(JsFilename As String) As String
        Dim Code As String = ""
        Code = Code & "<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional//EN""  ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">" & vbNewLine
        Code = Code & "<html xmlns=""http://www.w3.org/1999/xhtml"">" & vbNewLine
        Code = Code & "<head>" & vbNewLine
        Code = Code & "<meta http-equiv=""Content-Type"" content=""text/html;charset=utf-8"" />" & vbNewLine
        Code = Code & "<title>NPS Inventory &amp; Monitoring Program Manager</title>" & vbNewLine
        Code = Code & "<script src=""http://cdn.sencha.com/ext/gpl/4.2.1/ext-all.js""></script>" & vbNewLine
        Code = Code & "<script src=""" & JsFilename & """></script>" & vbNewLine
        Code = Code & "<link rel=""stylesheet"" href=""http://cdn.sencha.com/ext/gpl/4.2.1/resources/ext-theme-classic/ext-theme-classic-all.css"">" & vbNewLine
        Code = Code & "</head>" & vbNewLine
        Code = Code & "<body onload="""">" & vbNewLine
        Code = Code & "<div id=""grid""></div>	" & vbNewLine
        Code = Code & "</body>" & vbNewLine
        Return Code
    End Function


    Private Function GetSqlServerDataTable(ByVal ConnectionString As String, ByVal Query As String) As DataTable
        Dim MyDataTable As New DataTable
        Try
            Dim MySqlConnection As New SqlConnection(ConnectionString)
            MySqlConnection.Open()
            Dim MySqlCommand As New SqlCommand(Query, MySqlConnection)
            Dim MyDataReader As SqlDataReader = MySqlCommand.ExecuteReader
            MyDataTable.Load(MyDataReader)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return MyDataTable
    End Function

    Private Function GetExtJSStore(SqlDataTable As DataTable, JsonFilename As String) As String
        Dim Code As String = "// create the data store" & vbNewLine
        Code = Code & vbTab & "var store = new Ext.data.JsonStore({" & vbNewLine
        Code = Code & vbTab & vbTab & "storeId:  'store'," & vbNewLine
        Code = Code & vbTab & vbTab & "autoLoad: true," & vbNewLine
        Code = Code & vbTab & vbTab & "proxy: {" & vbNewLine
        Code = Code & vbTab & vbTab & vbTab & "type: 'ajax'," & vbNewLine
        Code = Code & vbTab & vbTab & vbTab & "url: '" & JsonFilename & "'," & vbNewLine
        Code = Code & vbTab & vbTab & vbTab & "reader: {" & vbNewLine
        Code = Code & vbTab & vbTab & vbTab & "//idProperty: 'COLUMNNAME'," & vbNewLine
        Code = Code & vbTab & vbTab & vbTab & "type: 'json'" & vbNewLine
        Code = Code & vbTab & vbTab & "}" & vbNewLine
        Code = Code & vbTab & "}," & vbNewLine
        Code = Code & vbTab & "fields: [" & vbNewLine
        Dim i As Integer = 1
        For Each Column As DataColumn In SqlDataTable.Columns
            Code = Code & vbTab & vbTab & vbTab & "{name:'" & Column.ColumnName & "', type: '" & Column.DataType.ToString.Replace("System.", "") & "'} " & IIf(i < SqlDataTable.Columns.Count, ",", "") & vbNewLine
            i = i + 1
        Next
        Code = Code & vbTab & vbTab & "]" & vbNewLine
        Code = Code & vbTab & "});" & vbNewLine
        Return Code.Replace("Int32", "Integer")
    End Function

    Private Function GetExtJSGrid(SqlDataTable As DataTable) As String
        Dim Code As String = "// create the grid" & vbNewLine
        Code = Code & vbTab & "Ext.create('Ext.grid.Panel', {" & vbNewLine
        Code = Code & vbTab & vbTab & "selType:  'cellmodel'," & vbNewLine
        Code = Code & vbTab & vbTab & "title:  'DATA'," & vbNewLine
        Code = Code & vbTab & vbTab & "store: store," & vbNewLine
        Code = Code & vbTab & vbTab & "columns: [" & vbNewLine
        Dim i As Integer = 1
        For Each Column As DataColumn In SqlDataTable.Columns
            Code = Code & vbTab & vbTab & vbTab & "{" & vbNewLine
            If Column.DataType.ToString = "System.Date" Then
                Code = Code & vbTab & vbTab & vbTab & vbTab & "xtype: 'gridcolumn'," & vbNewLine
            End If

            Code = Code & vbTab & vbTab & vbTab & vbTab & "dataIndex: '" & Column.ColumnName & "'," & vbNewLine
            Code = Code & vbTab & vbTab & vbTab & vbTab & "text: '" & Column.ColumnName & "'," & vbNewLine
            ' Code = Code & vbTab & vbTab & vbTab & vbTab & "width: 100," & vbNewLine
            Code = Code & vbTab & vbTab & vbTab & vbTab & "autoSizeColumn: true," & vbNewLine
            Code = Code & vbTab & vbTab & vbTab & vbTab & "minWidth: 60," & vbNewLine
            Code = Code & vbTab & vbTab & vbTab & vbTab & "hidden: false," & vbNewLine
            Code = Code & vbTab & vbTab & vbTab & vbTab & "renderer: function(value) {" & vbNewLine
            Code = Code & vbTab & vbTab & vbTab & vbTab & vbTab & "return value;" & vbNewLine
            Code = Code & vbTab & vbTab & vbTab & vbTab & "}" & vbNewLine
            Code = Code & vbTab & vbTab & vbTab & "}" & IIf(i < SqlDataTable.Columns.Count, ",", "") & vbNewLine
            i = i + 1
        Next
        Code = Code & vbTab & vbTab & "]," & vbNewLine
        Code = Code & vbTab & vbTab & "renderTo: 'grid'" & vbNewLine
        Code = Code & vbTab & "});" & vbNewLine
        Code = Code & vbTab & vbNewLine
        Return Code
    End Function

    Private Function GetJSONDataSourceCode(SqlDataTable As DataTable) As String
        Dim Code As String = ""
        Code = Code & "<cfcontent type=""text/plain""  /> " & vbNewLine
        Code = Code & "<cfsetting showDebugOutput=""No"">" & vbNewLine
        Code = Code & "<cftry>" & vbNewLine

        Code = Code & vbTab & "<cfquery name=""q"" datasource=""AKIM"">" & vbNewLine
        Code = Code & vbTab & vbTab & Me.SqlTextBox.Text & vbNewLine
        Code = Code & "</cfquery>" & vbNewLine

        Code = Code & "<cfsavecontent variable=""json"">" & vbNewLine
        Code = Code & vbTab & "[" & vbNewLine
        Code = Code & vbTab & "<cfoutput query=""q"">" & vbNewLine
        Code = Code & vbTab & vbTab & "{" & vbNewLine
        Dim i As Integer = 1 & vbNewLine
        For Each Column As DataColumn In SqlDataTable.Columns
            If Column.DataType = System.Type.GetType("System.DateTime") Then
                Code = Code & vbTab & vbTab & vbTab & "<cfset TheDate = ""#dateformat(q." & Column.ColumnName & ",""yyyy-mm-dd"")# #timeformat(q." & Column.ColumnName & ",""HH:MM:ss"")#"">" & vbNewLine
                Code = Code & vbTab & vbTab & vbTab & """" & Column.ColumnName & """:#SerializeJSON(TheDate)#" & IIf(i < SqlDataTable.Columns.Count, ",", "") & vbNewLine
            ElseIf Column.DataType = System.Type.GetType("System.Date") Then
                Code = Code & vbTab & vbTab & vbTab & "<cfset TheDate = ""#dateformat(q." & Column.ColumnName & ",""yyyy-mm-dd"")#" & vbNewLine
                Code = Code & vbTab & vbTab & vbTab & """" & Column.ColumnName & """:#SerializeJSON(TheDate)#" & IIf(i < SqlDataTable.Columns.Count, ",", "") & vbNewLine
            Else
                Code = Code & vbTab & vbTab & vbTab & """" & Column.ColumnName & """:#SerializeJSON(Trim(q." & Column.ColumnName & "))#" & IIf(i < SqlDataTable.Columns.Count, ",", "") & vbNewLine
            End If
            i = i + 1
        Next
        Code = Code & vbTab & vbTab & "}<cfif #q.currentrow# lt #q.recordcount#>,</cfif>" & vbNewLine
        Code = Code & vbTab & "</cfoutput>" & vbNewLine
        Code = Code & vbTab & "]" & vbNewLine
        Code = Code & "</cfsavecontent>" & vbNewLine
        Code = Code & "<cfoutput>#replace(json, '//','', 'all')#</cfoutput>" & vbNewLine
        Code = Code & "<cfcatch>" & vbNewLine
        Code = Code & vbTab & "<cfset errormessage=""#trim(cfcatch.message)# #trim(cfcatch.detail)#"">" & vbNewLine
        Code = Code & vbTab & "<cfoutput>" & vbNewLine
        Code = Code & vbTab & "[" & vbNewLine
        Code = Code & vbTab & vbTab & "{" & vbNewLine
        Code = Code & vbTab & vbTab & """success"":false, " & vbNewLine
        Code = Code & vbTab & vbTab & """msg"":#errormessage#," & vbNewLine
        Code = Code & vbTab & vbTab & """total"":0" & vbNewLine
        Code = Code & vbTab & vbTab & "}" & vbNewLine
        Code = Code & vbTab & "]" & vbNewLine
        Code = Code & vbTab & "</cfoutput>" & vbNewLine
        Code = Code & "</cfcatch>" & vbNewLine
        Code = Code & "</cftry>" & vbNewLine & vbNewLine

        Return Code
    End Function

    Private Sub SaveGridScriptToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveGridScriptToolStripButton.Click
        Dim SF As New SaveFileDialog
        With SF
            .DefaultExt = ".js"
            .FileName = "x_json.js"
            .Filter = "Javascript files|*.js"
            .InitialDirectory = "C:\ColdFusion10\cfusion\wwwroot"
            .Title = "Save file"
        End With

    End Sub

    Private Sub ExportToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles ExportToolStripButton.Click
        WriteFiles(Me.ExportDirectoryToolStripTextBox.Text, Me.FilenamesPrefixToolStripTextBox.Text)
    End Sub

    Private Sub OpenExportDirectoryToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles OpenExportDirectoryToolStripButton.Click
        If My.Computer.FileSystem.DirectoryExists(Me.ExportDirectoryToolStripTextBox.Text) Then
            Process.Start(Me.ExportDirectoryToolStripTextBox.Text)
        End If
    End Sub

    Private Sub FilenamesPrefixToolStripTextBox_Leave(sender As System.Object, e As System.EventArgs) Handles FilenamesPrefixToolStripTextBox.Leave
        Dim DT As DataTable = Me.DataGridView.DataSource
        Try
            GenerateCode(DT)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
