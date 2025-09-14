<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_MainPage
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
        Me.GBOX_ContactsDetail = New System.Windows.Forms.GroupBox
        Me.LBL_Group = New System.Windows.Forms.Label
        Me.LBL_BirthDate = New System.Windows.Forms.Label
        Me.LBL_HomeAddress = New System.Windows.Forms.Label
        Me.LBL_EmergencyNumber = New System.Windows.Forms.Label
        Me.LBL_EmailAddress = New System.Windows.Forms.Label
        Me.LBL_OfficeAddress = New System.Windows.Forms.Label
        Me.LBL_OfficeNumber = New System.Windows.Forms.Label
        Me.LBL_ResidenceNumber2 = New System.Windows.Forms.Label
        Me.LBL_ResidenceNumber1 = New System.Windows.Forms.Label
        Me.LBL_CellNumber2 = New System.Windows.Forms.Label
        Me.LBL_CellNumber1 = New System.Windows.Forms.Label
        Me.LBL_LName = New System.Windows.Forms.Label
        Me.LBL_FName = New System.Windows.Forms.Label
        Me.TXT_Group = New System.Windows.Forms.TextBox
        Me.TXT_BirthDate = New System.Windows.Forms.TextBox
        Me.TXT_HomeAddress = New System.Windows.Forms.TextBox
        Me.TXT_EmailAddress = New System.Windows.Forms.TextBox
        Me.TXT_EmergencyNumber = New System.Windows.Forms.TextBox
        Me.TXT_OfficeAddress = New System.Windows.Forms.TextBox
        Me.TXT_OfficeNumber = New System.Windows.Forms.TextBox
        Me.TXT_ResidenceNumber2 = New System.Windows.Forms.TextBox
        Me.TXT_ResidenceNumber1 = New System.Windows.Forms.TextBox
        Me.TXT_CellNumber2 = New System.Windows.Forms.TextBox
        Me.TXT_CellNumber1 = New System.Windows.Forms.TextBox
        Me.TXT_LName = New System.Windows.Forms.TextBox
        Me.TXT_FName = New System.Windows.Forms.TextBox
        Me.GBOX_Contacts = New System.Windows.Forms.GroupBox
        Me.LBL_Contacts = New System.Windows.Forms.Label
        Me.LBOX_Contacts = New System.Windows.Forms.ListBox
        Me.LBL_SearchContacts = New System.Windows.Forms.Label
        Me.CBO_Contacts = New System.Windows.Forms.ComboBox
        Me.BTN_Exit = New System.Windows.Forms.Button
        Me.LBL_PhoneBook = New System.Windows.Forms.Label
        Me.GBOX_Controls = New System.Windows.Forms.GroupBox
        Me.BTN_Rename = New System.Windows.Forms.Button
        Me.BTN_Update = New System.Windows.Forms.Button
        Me.BTN_Add = New System.Windows.Forms.Button
        Me.BTN_Save = New System.Windows.Forms.Button
        Me.BTN_Delete = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DigitalClock = New CloudToolkitN6.CloudDigitalClock
        Me.GBOX_ContactsDetail.SuspendLayout()
        Me.GBOX_Contacts.SuspendLayout()
        Me.GBOX_Controls.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBOX_ContactsDetail
        '
        Me.GBOX_ContactsDetail.BackColor = System.Drawing.Color.DarkGray
        Me.GBOX_ContactsDetail.Controls.Add(Me.LBL_Group)
        Me.GBOX_ContactsDetail.Controls.Add(Me.LBL_BirthDate)
        Me.GBOX_ContactsDetail.Controls.Add(Me.LBL_HomeAddress)
        Me.GBOX_ContactsDetail.Controls.Add(Me.LBL_EmergencyNumber)
        Me.GBOX_ContactsDetail.Controls.Add(Me.LBL_EmailAddress)
        Me.GBOX_ContactsDetail.Controls.Add(Me.LBL_OfficeAddress)
        Me.GBOX_ContactsDetail.Controls.Add(Me.LBL_OfficeNumber)
        Me.GBOX_ContactsDetail.Controls.Add(Me.LBL_ResidenceNumber2)
        Me.GBOX_ContactsDetail.Controls.Add(Me.LBL_ResidenceNumber1)
        Me.GBOX_ContactsDetail.Controls.Add(Me.LBL_CellNumber2)
        Me.GBOX_ContactsDetail.Controls.Add(Me.LBL_CellNumber1)
        Me.GBOX_ContactsDetail.Controls.Add(Me.LBL_LName)
        Me.GBOX_ContactsDetail.Controls.Add(Me.LBL_FName)
        Me.GBOX_ContactsDetail.Controls.Add(Me.TXT_Group)
        Me.GBOX_ContactsDetail.Controls.Add(Me.TXT_BirthDate)
        Me.GBOX_ContactsDetail.Controls.Add(Me.TXT_HomeAddress)
        Me.GBOX_ContactsDetail.Controls.Add(Me.TXT_EmailAddress)
        Me.GBOX_ContactsDetail.Controls.Add(Me.TXT_EmergencyNumber)
        Me.GBOX_ContactsDetail.Controls.Add(Me.TXT_OfficeAddress)
        Me.GBOX_ContactsDetail.Controls.Add(Me.TXT_OfficeNumber)
        Me.GBOX_ContactsDetail.Controls.Add(Me.TXT_ResidenceNumber2)
        Me.GBOX_ContactsDetail.Controls.Add(Me.TXT_ResidenceNumber1)
        Me.GBOX_ContactsDetail.Controls.Add(Me.TXT_CellNumber2)
        Me.GBOX_ContactsDetail.Controls.Add(Me.TXT_CellNumber1)
        Me.GBOX_ContactsDetail.Controls.Add(Me.TXT_LName)
        Me.GBOX_ContactsDetail.Controls.Add(Me.TXT_FName)
        Me.GBOX_ContactsDetail.Location = New System.Drawing.Point(198, 116)
        Me.GBOX_ContactsDetail.Name = "GBOX_ContactsDetail"
        Me.GBOX_ContactsDetail.Size = New System.Drawing.Size(599, 463)
        Me.GBOX_ContactsDetail.TabIndex = 5
        Me.GBOX_ContactsDetail.TabStop = False
        '
        'LBL_Group
        '
        Me.LBL_Group.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Group.Location = New System.Drawing.Point(6, 411)
        Me.LBL_Group.Name = "LBL_Group"
        Me.LBL_Group.Size = New System.Drawing.Size(197, 23)
        Me.LBL_Group.TabIndex = 24
        Me.LBL_Group.Text = "Group"
        Me.LBL_Group.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBL_BirthDate
        '
        Me.LBL_BirthDate.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_BirthDate.Location = New System.Drawing.Point(6, 379)
        Me.LBL_BirthDate.Name = "LBL_BirthDate"
        Me.LBL_BirthDate.Size = New System.Drawing.Size(197, 23)
        Me.LBL_BirthDate.TabIndex = 23
        Me.LBL_BirthDate.Text = "Birth Date"
        Me.LBL_BirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBL_HomeAddress
        '
        Me.LBL_HomeAddress.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_HomeAddress.Location = New System.Drawing.Point(6, 348)
        Me.LBL_HomeAddress.Name = "LBL_HomeAddress"
        Me.LBL_HomeAddress.Size = New System.Drawing.Size(197, 23)
        Me.LBL_HomeAddress.TabIndex = 22
        Me.LBL_HomeAddress.Text = "Home Address"
        Me.LBL_HomeAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBL_EmergencyNumber
        '
        Me.LBL_EmergencyNumber.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EmergencyNumber.Location = New System.Drawing.Point(6, 284)
        Me.LBL_EmergencyNumber.Name = "LBL_EmergencyNumber"
        Me.LBL_EmergencyNumber.Size = New System.Drawing.Size(197, 23)
        Me.LBL_EmergencyNumber.TabIndex = 21
        Me.LBL_EmergencyNumber.Text = "Emergency Number"
        Me.LBL_EmergencyNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBL_EmailAddress
        '
        Me.LBL_EmailAddress.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EmailAddress.Location = New System.Drawing.Point(6, 316)
        Me.LBL_EmailAddress.Name = "LBL_EmailAddress"
        Me.LBL_EmailAddress.Size = New System.Drawing.Size(197, 23)
        Me.LBL_EmailAddress.TabIndex = 21
        Me.LBL_EmailAddress.Text = "Email Address"
        Me.LBL_EmailAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBL_OfficeAddress
        '
        Me.LBL_OfficeAddress.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_OfficeAddress.Location = New System.Drawing.Point(6, 252)
        Me.LBL_OfficeAddress.Name = "LBL_OfficeAddress"
        Me.LBL_OfficeAddress.Size = New System.Drawing.Size(197, 23)
        Me.LBL_OfficeAddress.TabIndex = 20
        Me.LBL_OfficeAddress.Text = "Office Address"
        Me.LBL_OfficeAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBL_OfficeNumber
        '
        Me.LBL_OfficeNumber.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_OfficeNumber.Location = New System.Drawing.Point(6, 220)
        Me.LBL_OfficeNumber.Name = "LBL_OfficeNumber"
        Me.LBL_OfficeNumber.Size = New System.Drawing.Size(197, 23)
        Me.LBL_OfficeNumber.TabIndex = 19
        Me.LBL_OfficeNumber.Text = "Office Number"
        Me.LBL_OfficeNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBL_ResidenceNumber2
        '
        Me.LBL_ResidenceNumber2.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ResidenceNumber2.Location = New System.Drawing.Point(6, 188)
        Me.LBL_ResidenceNumber2.Name = "LBL_ResidenceNumber2"
        Me.LBL_ResidenceNumber2.Size = New System.Drawing.Size(197, 23)
        Me.LBL_ResidenceNumber2.TabIndex = 18
        Me.LBL_ResidenceNumber2.Text = "Residential Number 2"
        Me.LBL_ResidenceNumber2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBL_ResidenceNumber1
        '
        Me.LBL_ResidenceNumber1.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ResidenceNumber1.Location = New System.Drawing.Point(6, 156)
        Me.LBL_ResidenceNumber1.Name = "LBL_ResidenceNumber1"
        Me.LBL_ResidenceNumber1.Size = New System.Drawing.Size(197, 23)
        Me.LBL_ResidenceNumber1.TabIndex = 17
        Me.LBL_ResidenceNumber1.Text = "Residential Number 1"
        Me.LBL_ResidenceNumber1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBL_CellNumber2
        '
        Me.LBL_CellNumber2.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CellNumber2.Location = New System.Drawing.Point(6, 124)
        Me.LBL_CellNumber2.Name = "LBL_CellNumber2"
        Me.LBL_CellNumber2.Size = New System.Drawing.Size(197, 23)
        Me.LBL_CellNumber2.TabIndex = 16
        Me.LBL_CellNumber2.Text = "Cell Number 2"
        Me.LBL_CellNumber2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBL_CellNumber1
        '
        Me.LBL_CellNumber1.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CellNumber1.Location = New System.Drawing.Point(6, 92)
        Me.LBL_CellNumber1.Name = "LBL_CellNumber1"
        Me.LBL_CellNumber1.Size = New System.Drawing.Size(197, 23)
        Me.LBL_CellNumber1.TabIndex = 15
        Me.LBL_CellNumber1.Text = "Cell Number 1"
        Me.LBL_CellNumber1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBL_LName
        '
        Me.LBL_LName.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_LName.Location = New System.Drawing.Point(6, 60)
        Me.LBL_LName.Name = "LBL_LName"
        Me.LBL_LName.Size = New System.Drawing.Size(197, 23)
        Me.LBL_LName.TabIndex = 14
        Me.LBL_LName.Text = "Last Name"
        Me.LBL_LName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBL_FName
        '
        Me.LBL_FName.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_FName.Location = New System.Drawing.Point(6, 28)
        Me.LBL_FName.Name = "LBL_FName"
        Me.LBL_FName.Size = New System.Drawing.Size(197, 23)
        Me.LBL_FName.TabIndex = 13
        Me.LBL_FName.Text = "First Name"
        Me.LBL_FName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TXT_Group
        '
        Me.TXT_Group.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Group.Location = New System.Drawing.Point(209, 407)
        Me.TXT_Group.Name = "TXT_Group"
        Me.TXT_Group.Size = New System.Drawing.Size(364, 27)
        Me.TXT_Group.TabIndex = 15
        Me.TXT_Group.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_BirthDate
        '
        Me.TXT_BirthDate.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_BirthDate.Location = New System.Drawing.Point(209, 375)
        Me.TXT_BirthDate.Name = "TXT_BirthDate"
        Me.TXT_BirthDate.Size = New System.Drawing.Size(364, 27)
        Me.TXT_BirthDate.TabIndex = 14
        Me.TXT_BirthDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_HomeAddress
        '
        Me.TXT_HomeAddress.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_HomeAddress.Location = New System.Drawing.Point(209, 343)
        Me.TXT_HomeAddress.Name = "TXT_HomeAddress"
        Me.TXT_HomeAddress.Size = New System.Drawing.Size(364, 27)
        Me.TXT_HomeAddress.TabIndex = 13
        Me.TXT_HomeAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_EmailAddress
        '
        Me.TXT_EmailAddress.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_EmailAddress.Location = New System.Drawing.Point(209, 311)
        Me.TXT_EmailAddress.Name = "TXT_EmailAddress"
        Me.TXT_EmailAddress.Size = New System.Drawing.Size(364, 27)
        Me.TXT_EmailAddress.TabIndex = 12
        Me.TXT_EmailAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_EmergencyNumber
        '
        Me.TXT_EmergencyNumber.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_EmergencyNumber.Location = New System.Drawing.Point(209, 279)
        Me.TXT_EmergencyNumber.Name = "TXT_EmergencyNumber"
        Me.TXT_EmergencyNumber.Size = New System.Drawing.Size(364, 27)
        Me.TXT_EmergencyNumber.TabIndex = 11
        Me.TXT_EmergencyNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_OfficeAddress
        '
        Me.TXT_OfficeAddress.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_OfficeAddress.Location = New System.Drawing.Point(209, 247)
        Me.TXT_OfficeAddress.Name = "TXT_OfficeAddress"
        Me.TXT_OfficeAddress.Size = New System.Drawing.Size(364, 27)
        Me.TXT_OfficeAddress.TabIndex = 10
        Me.TXT_OfficeAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_OfficeNumber
        '
        Me.TXT_OfficeNumber.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_OfficeNumber.Location = New System.Drawing.Point(209, 215)
        Me.TXT_OfficeNumber.Name = "TXT_OfficeNumber"
        Me.TXT_OfficeNumber.Size = New System.Drawing.Size(364, 27)
        Me.TXT_OfficeNumber.TabIndex = 9
        Me.TXT_OfficeNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_ResidenceNumber2
        '
        Me.TXT_ResidenceNumber2.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ResidenceNumber2.Location = New System.Drawing.Point(209, 183)
        Me.TXT_ResidenceNumber2.Name = "TXT_ResidenceNumber2"
        Me.TXT_ResidenceNumber2.Size = New System.Drawing.Size(364, 27)
        Me.TXT_ResidenceNumber2.TabIndex = 8
        Me.TXT_ResidenceNumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_ResidenceNumber1
        '
        Me.TXT_ResidenceNumber1.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ResidenceNumber1.Location = New System.Drawing.Point(209, 151)
        Me.TXT_ResidenceNumber1.Name = "TXT_ResidenceNumber1"
        Me.TXT_ResidenceNumber1.Size = New System.Drawing.Size(364, 27)
        Me.TXT_ResidenceNumber1.TabIndex = 7
        Me.TXT_ResidenceNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_CellNumber2
        '
        Me.TXT_CellNumber2.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CellNumber2.Location = New System.Drawing.Point(209, 119)
        Me.TXT_CellNumber2.Name = "TXT_CellNumber2"
        Me.TXT_CellNumber2.Size = New System.Drawing.Size(364, 27)
        Me.TXT_CellNumber2.TabIndex = 6
        Me.TXT_CellNumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_CellNumber1
        '
        Me.TXT_CellNumber1.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CellNumber1.Location = New System.Drawing.Point(209, 87)
        Me.TXT_CellNumber1.Name = "TXT_CellNumber1"
        Me.TXT_CellNumber1.Size = New System.Drawing.Size(364, 27)
        Me.TXT_CellNumber1.TabIndex = 5
        Me.TXT_CellNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_LName
        '
        Me.TXT_LName.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_LName.Location = New System.Drawing.Point(209, 55)
        Me.TXT_LName.Name = "TXT_LName"
        Me.TXT_LName.Size = New System.Drawing.Size(364, 27)
        Me.TXT_LName.TabIndex = 4
        Me.TXT_LName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_FName
        '
        Me.TXT_FName.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_FName.Location = New System.Drawing.Point(209, 23)
        Me.TXT_FName.Name = "TXT_FName"
        Me.TXT_FName.Size = New System.Drawing.Size(364, 27)
        Me.TXT_FName.TabIndex = 3
        Me.TXT_FName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GBOX_Contacts
        '
        Me.GBOX_Contacts.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GBOX_Contacts.Controls.Add(Me.LBL_Contacts)
        Me.GBOX_Contacts.Controls.Add(Me.LBOX_Contacts)
        Me.GBOX_Contacts.Controls.Add(Me.LBL_SearchContacts)
        Me.GBOX_Contacts.Controls.Add(Me.CBO_Contacts)
        Me.GBOX_Contacts.Location = New System.Drawing.Point(12, 116)
        Me.GBOX_Contacts.Name = "GBOX_Contacts"
        Me.GBOX_Contacts.Size = New System.Drawing.Size(166, 465)
        Me.GBOX_Contacts.TabIndex = 4
        Me.GBOX_Contacts.TabStop = False
        '
        'LBL_Contacts
        '
        Me.LBL_Contacts.Font = New System.Drawing.Font("Segoe Condensed", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Contacts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LBL_Contacts.Location = New System.Drawing.Point(8, 28)
        Me.LBL_Contacts.Name = "LBL_Contacts"
        Me.LBL_Contacts.Size = New System.Drawing.Size(146, 27)
        Me.LBL_Contacts.TabIndex = 5
        Me.LBL_Contacts.Text = "CONTACTS"
        Me.LBL_Contacts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBOX_Contacts
        '
        Me.LBOX_Contacts.BackColor = System.Drawing.Color.RosyBrown
        Me.LBOX_Contacts.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBOX_Contacts.FormattingEnabled = True
        Me.LBOX_Contacts.ItemHeight = 20
        Me.LBOX_Contacts.Location = New System.Drawing.Point(10, 75)
        Me.LBOX_Contacts.Name = "LBOX_Contacts"
        Me.LBOX_Contacts.Size = New System.Drawing.Size(142, 264)
        Me.LBOX_Contacts.Sorted = True
        Me.LBOX_Contacts.TabIndex = 2
        '
        'LBL_SearchContacts
        '
        Me.LBL_SearchContacts.BackColor = System.Drawing.Color.Black
        Me.LBL_SearchContacts.Font = New System.Drawing.Font("Segoe Condensed", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_SearchContacts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LBL_SearchContacts.Image = Global.PHONE_BOOK.My.Resources.Resources.icontexto_webdev_search_048x048
        Me.LBL_SearchContacts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LBL_SearchContacts.Location = New System.Drawing.Point(10, 358)
        Me.LBL_SearchContacts.Name = "LBL_SearchContacts"
        Me.LBL_SearchContacts.Size = New System.Drawing.Size(141, 62)
        Me.LBL_SearchContacts.TabIndex = 3
        Me.LBL_SearchContacts.Text = "SEARCH CONTACTS"
        Me.LBL_SearchContacts.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CBO_Contacts
        '
        Me.CBO_Contacts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBO_Contacts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBO_Contacts.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBO_Contacts.ForeColor = System.Drawing.SystemColors.InfoText
        Me.CBO_Contacts.FormattingEnabled = True
        Me.CBO_Contacts.Location = New System.Drawing.Point(10, 429)
        Me.CBO_Contacts.Name = "CBO_Contacts"
        Me.CBO_Contacts.Size = New System.Drawing.Size(141, 28)
        Me.CBO_Contacts.TabIndex = 21
        '
        'BTN_Exit
        '
        Me.BTN_Exit.BackColor = System.Drawing.Color.DimGray
        Me.BTN_Exit.BackgroundImage = Global.PHONE_BOOK.My.Resources.Resources.icontexto_webdev_remove_048x048
        Me.BTN_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTN_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_Exit.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BTN_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Exit.Location = New System.Drawing.Point(16, 383)
        Me.BTN_Exit.Name = "BTN_Exit"
        Me.BTN_Exit.Size = New System.Drawing.Size(154, 52)
        Me.BTN_Exit.TabIndex = 22
        Me.BTN_Exit.Text = "EXIT"
        Me.BTN_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Exit.UseVisualStyleBackColor = False
        '
        'LBL_PhoneBook
        '
        Me.LBL_PhoneBook.BackColor = System.Drawing.Color.Maroon
        Me.LBL_PhoneBook.Font = New System.Drawing.Font("Segoe Condensed", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_PhoneBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LBL_PhoneBook.Location = New System.Drawing.Point(14, 9)
        Me.LBL_PhoneBook.Name = "LBL_PhoneBook"
        Me.LBL_PhoneBook.Size = New System.Drawing.Size(783, 85)
        Me.LBL_PhoneBook.TabIndex = 3
        Me.LBL_PhoneBook.Text = "PHONE BOOK"
        Me.LBL_PhoneBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GBOX_Controls
        '
        Me.GBOX_Controls.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GBOX_Controls.Controls.Add(Me.BTN_Rename)
        Me.GBOX_Controls.Controls.Add(Me.BTN_Update)
        Me.GBOX_Controls.Controls.Add(Me.BTN_Exit)
        Me.GBOX_Controls.Controls.Add(Me.BTN_Add)
        Me.GBOX_Controls.Controls.Add(Me.BTN_Save)
        Me.GBOX_Controls.Controls.Add(Me.BTN_Delete)
        Me.GBOX_Controls.Location = New System.Drawing.Point(817, 116)
        Me.GBOX_Controls.Name = "GBOX_Controls"
        Me.GBOX_Controls.Size = New System.Drawing.Size(187, 463)
        Me.GBOX_Controls.TabIndex = 8
        Me.GBOX_Controls.TabStop = False
        '
        'BTN_Rename
        '
        Me.BTN_Rename.BackColor = System.Drawing.Color.DimGray
        Me.BTN_Rename.BackgroundImage = Global.PHONE_BOOK.My.Resources.Resources.icontexto_webdev_reload_048x048
        Me.BTN_Rename.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTN_Rename.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_Rename.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Rename.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BTN_Rename.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Rename.Location = New System.Drawing.Point(16, 313)
        Me.BTN_Rename.Name = "BTN_Rename"
        Me.BTN_Rename.Size = New System.Drawing.Size(154, 52)
        Me.BTN_Rename.TabIndex = 20
        Me.BTN_Rename.Text = "RENAME"
        Me.BTN_Rename.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Rename.UseVisualStyleBackColor = False
        '
        'BTN_Update
        '
        Me.BTN_Update.BackColor = System.Drawing.Color.DimGray
        Me.BTN_Update.BackgroundImage = Global.PHONE_BOOK.My.Resources.Resources.icontexto_webdev_bullet_048x048
        Me.BTN_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTN_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_Update.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BTN_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Update.Location = New System.Drawing.Point(16, 173)
        Me.BTN_Update.Name = "BTN_Update"
        Me.BTN_Update.Size = New System.Drawing.Size(154, 52)
        Me.BTN_Update.TabIndex = 18
        Me.BTN_Update.Text = "UPDATE"
        Me.BTN_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Update.UseVisualStyleBackColor = False
        '
        'BTN_Add
        '
        Me.BTN_Add.BackColor = System.Drawing.Color.DimGray
        Me.BTN_Add.BackgroundImage = Global.PHONE_BOOK.My.Resources.Resources.icontexto_webdev_add_048x048
        Me.BTN_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTN_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_Add.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BTN_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Add.Location = New System.Drawing.Point(16, 33)
        Me.BTN_Add.Name = "BTN_Add"
        Me.BTN_Add.Size = New System.Drawing.Size(154, 52)
        Me.BTN_Add.TabIndex = 16
        Me.BTN_Add.Text = "ADD NEW"
        Me.BTN_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Add.UseVisualStyleBackColor = False
        '
        'BTN_Save
        '
        Me.BTN_Save.BackColor = System.Drawing.Color.DimGray
        Me.BTN_Save.BackgroundImage = Global.PHONE_BOOK.My.Resources.Resources.icontexto_webdev_print_048x048
        Me.BTN_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTN_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_Save.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BTN_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Save.Location = New System.Drawing.Point(16, 103)
        Me.BTN_Save.Name = "BTN_Save"
        Me.BTN_Save.Size = New System.Drawing.Size(154, 52)
        Me.BTN_Save.TabIndex = 17
        Me.BTN_Save.Text = "SAVE"
        Me.BTN_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Save.UseVisualStyleBackColor = False
        '
        'BTN_Delete
        '
        Me.BTN_Delete.BackColor = System.Drawing.Color.DimGray
        Me.BTN_Delete.BackgroundImage = Global.PHONE_BOOK.My.Resources.Resources.icontexto_webdev_cancel_048x048
        Me.BTN_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTN_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_Delete.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BTN_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Delete.Location = New System.Drawing.Point(16, 243)
        Me.BTN_Delete.Name = "BTN_Delete"
        Me.BTN_Delete.Size = New System.Drawing.Size(154, 52)
        Me.BTN_Delete.TabIndex = 19
        Me.BTN_Delete.Text = "DELETE"
        Me.BTN_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Delete.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Consolas", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 604)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(625, 125)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "IF YOU WANT TO DELETE A CONTACT, THEN FIRST SELECT THAT CONTACT AND THEN PRESS DE" & _
            "LETE BUTTON" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "IF YOU WANT TO RENAME A CONTACT, THEN FIRST SELECT THAT CONTACT A" & _
            "ND THEN PRESS RENAME BUTTON"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(709, 606)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(291, 125)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "CREATED BY:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    SAAD QURESHI" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    veracious2007@gmail.com" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    00923428042326"
        '
        'DigitalClock
        '
        Me.DigitalClock.BackColor = System.Drawing.Color.Transparent
        Me.DigitalClock.ColorLower_1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.DigitalClock.ColorLower_2 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.DigitalClock.ColorUpper_1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.DigitalClock.ColorUpper_2 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.DigitalClock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DigitalClock.DateColor = System.Drawing.Color.Gold
        Me.DigitalClock.DateFont = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DigitalClock.DrawDate = True
        Me.DigitalClock.Font = New System.Drawing.Font("MS Mincho", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DigitalClock.Location = New System.Drawing.Point(817, 9)
        Me.DigitalClock.Name = "DigitalClock"
        Me.DigitalClock.NumberColor = System.Drawing.Color.Gold
        Me.DigitalClock.NumberFont = New System.Drawing.Font("Segoe Condensed", 30.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DigitalClock.Size = New System.Drawing.Size(187, 85)
        Me.DigitalClock.TabIndex = 11
        '
        'FRM_MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1016, 740)
        Me.Controls.Add(Me.DigitalClock)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GBOX_Controls)
        Me.Controls.Add(Me.GBOX_ContactsDetail)
        Me.Controls.Add(Me.GBOX_Contacts)
        Me.Controls.Add(Me.LBL_PhoneBook)
        Me.MaximizeBox = False
        Me.Name = "FRM_MainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PHONE BOOK"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GBOX_ContactsDetail.ResumeLayout(False)
        Me.GBOX_ContactsDetail.PerformLayout()
        Me.GBOX_Contacts.ResumeLayout(False)
        Me.GBOX_Controls.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents GBOX_ContactsDetail As System.Windows.Forms.GroupBox
    Private WithEvents GBOX_Contacts As System.Windows.Forms.GroupBox
    Private WithEvents LBL_SearchContacts As System.Windows.Forms.Label
    Private WithEvents CBO_Contacts As System.Windows.Forms.ComboBox
    Private WithEvents LBL_PhoneBook As System.Windows.Forms.Label
    Friend WithEvents LBOX_Contacts As System.Windows.Forms.ListBox
    Private WithEvents LBL_Contacts As System.Windows.Forms.Label
    Friend WithEvents TXT_Group As System.Windows.Forms.TextBox
    Friend WithEvents TXT_BirthDate As System.Windows.Forms.TextBox
    Friend WithEvents TXT_HomeAddress As System.Windows.Forms.TextBox
    Friend WithEvents TXT_EmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents TXT_EmergencyNumber As System.Windows.Forms.TextBox
    Friend WithEvents TXT_OfficeAddress As System.Windows.Forms.TextBox
    Friend WithEvents TXT_OfficeNumber As System.Windows.Forms.TextBox
    Friend WithEvents TXT_ResidenceNumber2 As System.Windows.Forms.TextBox
    Friend WithEvents TXT_ResidenceNumber1 As System.Windows.Forms.TextBox
    Friend WithEvents TXT_CellNumber2 As System.Windows.Forms.TextBox
    Friend WithEvents TXT_CellNumber1 As System.Windows.Forms.TextBox
    Friend WithEvents TXT_LName As System.Windows.Forms.TextBox
    Friend WithEvents TXT_FName As System.Windows.Forms.TextBox
    Friend WithEvents LBL_Group As System.Windows.Forms.Label
    Friend WithEvents LBL_BirthDate As System.Windows.Forms.Label
    Friend WithEvents LBL_HomeAddress As System.Windows.Forms.Label
    Friend WithEvents LBL_EmergencyNumber As System.Windows.Forms.Label
    Friend WithEvents LBL_EmailAddress As System.Windows.Forms.Label
    Friend WithEvents LBL_OfficeAddress As System.Windows.Forms.Label
    Friend WithEvents LBL_OfficeNumber As System.Windows.Forms.Label
    Friend WithEvents LBL_ResidenceNumber2 As System.Windows.Forms.Label
    Friend WithEvents LBL_ResidenceNumber1 As System.Windows.Forms.Label
    Friend WithEvents LBL_CellNumber2 As System.Windows.Forms.Label
    Friend WithEvents LBL_CellNumber1 As System.Windows.Forms.Label
    Friend WithEvents LBL_LName As System.Windows.Forms.Label
    Friend WithEvents LBL_FName As System.Windows.Forms.Label
    Friend WithEvents BTN_Save As System.Windows.Forms.Button
    Friend WithEvents BTN_Delete As System.Windows.Forms.Button
    Friend WithEvents GBOX_Controls As System.Windows.Forms.GroupBox
    Friend WithEvents BTN_Exit As System.Windows.Forms.Button
    Friend WithEvents BTN_Add As System.Windows.Forms.Button
    Friend WithEvents BTN_Update As System.Windows.Forms.Button
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BTN_Rename As System.Windows.Forms.Button
    Friend WithEvents DigitalClock As CloudToolkitN6.CloudDigitalClock

End Class
