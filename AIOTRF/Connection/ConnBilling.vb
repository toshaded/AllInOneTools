﻿Imports System.Data.SqlClient
Module ConnBilling
    'Module Created By O2PSoftlabs
    Public Function connbills() As SqlConnection
        Dim dcmdBill As New SqlCommand
        Dim conbill As SqlConnection

        conbill = New SqlConnection("server=127.0.0.1;uid=MMODB;pwd=Test;database=BILLING;")
        Return conbill
        conbill = Nothing
    End Function
    Public dabill As SqlDataAdapter
    Public dtbill As New DataTable
    Public conbillc = ConnBilling.connbills
    Public cmdbill As SqlCommand
    Public ribill As SqlCommand
    Public robill As SqlDataAdapter
    Public sdbbill As Data.SqlClient.SqlDataAdapter
    Public perintahbill As SqlClient.SqlCommand
End Module
