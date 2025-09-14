
Imports System.Data
Imports System.Data.SqlClient

Public Class FRM_MainPage

    Dim myConnection As SqlConnection
    Dim myCommand As SqlCommand
    Dim dr As SqlDataReader
    Dim foundFlag As Integer = 0

    Sub createConnection()
        myConnection = New SqlConnection("Server=HOME-CEAB4BC482;DATABASE=PhoneBook;integrated security = true;")
    End Sub

    Sub fillComboBoxAndListBox()
        Try
            createConnection()
            myConnection.Open()
            myCommand = New SqlCommand("Select * from Contacts", myConnection)
            dr = myCommand.ExecuteReader()
            While dr.Read()
                CBO_Contacts.Items.Add(dr(0).ToString())
                LBOX_Contacts.Items.Add(dr(0).ToString())
            End While
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            dr.Close()
            myConnection.Close()
        End Try
    End Sub

    Private Sub FRM_MainPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillComboBoxAndListBox()
    End Sub

    Sub showContactsInfo()
        While dr.Read()
            TXT_FName.Text = dr(0).ToString()
            TXT_LName.Text = dr(1).ToString()
            TXT_CellNumber1.Text = dr(2).ToString()
            TXT_CellNumber2.Text = dr(3).ToString()
            TXT_ResidenceNumber1.Text = dr(4).ToString()
            TXT_ResidenceNumber2.Text = dr(5).ToString()
            TXT_OfficeNumber.Text = dr(6).ToString()
            TXT_OfficeAddress.Text = dr(7).ToString()
            TXT_EmergencyNumber.Text = dr(8).ToString()
            TXT_EmailAddress.Text = dr(9).ToString()
            TXT_HomeAddress.Text = dr(10).ToString()
            TXT_BirthDate.Text = dr(11).ToString()
            TXT_Group.Text = dr(12).ToString()
        End While
    End Sub

    Sub showContactsInComboBox()
        Try
            createConnection()
            myConnection.Open()
            myCommand = New SqlCommand("Select * from Contacts Where firstName ='" & CBO_Contacts.Text & "'", myConnection)
            dr = myCommand.ExecuteReader()
            showContactsInfo()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            dr.Close()
            myConnection.Close()
        End Try
    End Sub

    Sub showContactsInListBox()
        Try
            createConnection()
            myConnection.Open()
            myCommand = New SqlCommand("Select * from Contacts Where firstName ='" & LBOX_Contacts.Text & "'", myConnection)
            dr = myCommand.ExecuteReader()
            showContactsInfo()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            dr.Close()
            myConnection.Close()
        End Try
    End Sub

    Dim selectedStr As String = Nothing

    Private Sub CBO_Contacts_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBO_Contacts.SelectedValueChanged
        showContactsInComboBox()
    End Sub

    Private Sub LBOX_Contacts_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBOX_Contacts.SelectedIndexChanged
        showContactsInListBox()
        selectedStr = LBOX_Contacts.SelectedItem
    End Sub

    Private Sub BTN_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Exit.Click
        End
    End Sub

    Sub clearAll()
        TXT_FName.Clear()
        TXT_LName.Clear()
        TXT_CellNumber1.Clear()
        TXT_CellNumber2.Clear()
        TXT_ResidenceNumber1.Clear()
        TXT_ResidenceNumber2.Clear()
        TXT_OfficeNumber.Clear()
        TXT_OfficeAddress.Clear()
        TXT_EmergencyNumber.Clear()
        TXT_EmailAddress.Clear()
        TXT_HomeAddress.Clear()
        TXT_BirthDate.Clear()
        TXT_Group.Clear()
    End Sub

    Private Sub BTN_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Delete.Click
        Try
            createConnection()
            myConnection.Open()
            myCommand = New SqlCommand("Delete from Contacts Where firstName ='" & LBOX_Contacts.Text & "'", myConnection)
            dr = myCommand.ExecuteReader()
            MsgBox("Successfully Deleted", MsgBoxStyle.Information)
            CBO_Contacts.Text = ""
            CBO_Contacts.Items.Clear()
            LBOX_Contacts.Items.Clear()
            clearAll()
            showContactsInfo()
            fillComboBoxAndListBox()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            dr.Close()
            myConnection.Close()
        End Try
    End Sub

    Private Sub BTN_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Add.Click
        clearAll()
    End Sub

    Sub checkIfExistsOrNot()
        createConnection()
        myConnection.Open()
        myCommand = New SqlCommand("Select * from Contacts ", myConnection)
        dr = myCommand.ExecuteReader()
        While dr.Read()
            If TXT_FName.Text = dr(0).ToString() Then
                foundFlag = 1
            End If
        End While
    End Sub

    Private Sub BTN_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Save.Click
        checkIfExistsOrNot()
        If TXT_FName.Text <> "" Then
            If foundFlag = 0 Then
                Try
                    createConnection()
                    myConnection.Open()
                    myCommand = New SqlCommand("INSERT INTO [Contacts](firstName,lastName,cellNumber1,cellNumber2,residentialNumber1,residentialNumber2,officeNumber,officeAddress,emergencyNumber,emailAddress,homeAddress,birthDate,groupName) VALUES ('" & TXT_FName.Text & "','" & TXT_LName.Text & "','" & TXT_CellNumber1.Text & "','" & TXT_CellNumber2.Text & "','" & TXT_ResidenceNumber1.Text & "','" & TXT_ResidenceNumber2.Text & "','" & TXT_OfficeNumber.Text & "','" & TXT_OfficeAddress.Text & "','" & TXT_EmergencyNumber.Text & "','" & TXT_EmailAddress.Text & "','" & TXT_HomeAddress.Text & "','" & TXT_BirthDate.Text & "','" & TXT_Group.Text & "')", myConnection)
                    dr = myCommand.ExecuteReader()
                    MsgBox("SUCCESSFULLY ADDED", MsgBoxStyle.Information)
                    CBO_Contacts.Text = ""
                    CBO_Contacts.Items.Clear()
                    LBOX_Contacts.Items.Clear()
                    showContactsInfo()
                    fillComboBoxAndListBox()
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                Finally
                    dr.Close()
                    myConnection.Close()
                End Try
            Else
                MsgBox("CONTACT ALREADY EXISTS, CANNOT BE ADDED", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("ENTER FIRST NAME FIRST", MsgBoxStyle.Information)
        End If
        foundFlag = 0
    End Sub

    Private Sub BTN_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Update.Click
        checkIfExistsOrNot()
        If foundFlag = 1 Then
            Try
                createConnection()
                myConnection.Open()
                myCommand = New SqlCommand("UPDATE Contacts SET lastName ='" & TXT_LName.Text & "', cellNumber1 ='" & TXT_CellNumber1.Text & "', cellNumber2 ='" & TXT_CellNumber2.Text & "', residentialNumber1 ='" & TXT_ResidenceNumber1.Text & "', residentialNumber2 ='" & TXT_ResidenceNumber2.Text & "', officeNumber ='" & TXT_OfficeNumber.Text & "', officeAddress ='" & TXT_OfficeAddress.Text & "', emergencyNumber ='" & TXT_EmergencyNumber.Text & "', emailAddress ='" & TXT_EmailAddress.Text & "', homeAddress ='" & TXT_HomeAddress.Text & "', birthDate ='" & TXT_BirthDate.Text & "', groupName ='" & TXT_Group.Text & "'  where firstName = '" & TXT_FName.Text & "'", myConnection)
                dr = myCommand.ExecuteReader()
                MsgBox("SUCCESSFULLY UPDATED", MsgBoxStyle.Information)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            Finally
                dr.Close()
                myConnection.Close()
            End Try
        Else
            MsgBox("YOU CANNOT UPDATE A CONTACT WHICH IS NOT IN THE DATABASE, FIRST SAVE THAT CONTACT THEN YOU CAN UPDATE", MsgBoxStyle.Information)
        End If
        foundFlag = 0
    End Sub

    Private Sub BTN_Rename_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Rename.Click
        Try
            createConnection()
            myConnection.Open()
            myCommand = New SqlCommand("UPDATE Contacts SET firstName ='" & TXT_FName.Text & "' where firstName = '" & selectedStr & "'", myConnection)
            dr = myCommand.ExecuteReader()
            MsgBox("SUCCESSFULLY RENAMED", MsgBoxStyle.Information)
            CBO_Contacts.Text = ""
            CBO_Contacts.Items.Clear()
            LBOX_Contacts.Items.Clear()
            fillComboBoxAndListBox()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            dr.Close()
            myConnection.Close()
        End Try
    End Sub

End Class
