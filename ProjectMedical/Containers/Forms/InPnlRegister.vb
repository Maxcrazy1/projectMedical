Imports System.Text.RegularExpressions

Class InPnlRegister
    Private ctrlPnlMain As New InHome
    Private Patient As New Patient
    Private name, lastName, documentID, genre, email, age,
    number, maritStatus, firstDate, profesion, address As String

    'Control de validaciónes, se pasan los nombres de los controles 
    'a la array nameControles para que los condicione
    '@param form el formulario donde se ejecutaran dichas funciones
    Public Function validateFormRegister(form As Control) As Boolean
        Dim bln As Boolean
        Dim nameControls() As String = {
            "TxtCed",
            "TxtNom",
            "TxtApe"
            }

        Return bln = ValidateCtrlInForm(form, nameControls)
    End Function

    'Evento que formatea el panel de registro para un nuevo registro
    'Switch = en caso de estar activa muestra el botón press de nuevo paciente
    Public Sub NewRegister(Optional isNewRegister As Boolean = True)
        ctrlPnlMain.SetBtnActiveDataPatientOrRegister(isNewRegister)
        FrmPrincipal.PnlRegistro1.dateFirstConsultation.Value = DateTime.Now.ToString("dd/MM/yyyy")
        resetFieldsRegister()
        rePaintColor({FrmPrincipal.PnlRegistro1.TxtCed, FrmPrincipal.PnlRegistro1.TxtNom, FrmPrincipal.PnlRegistro1.TxtApe})
        ShowControlsInFrmPatient()
        SetNamePatientInMainForm()
    End Sub

    'Setea que controles va a resetear
    Public Sub resetFieldsRegister()

        Dim Arr As String() =
            {"System.Windows.Forms.TextBox",
            "Bunifu.Framework.UI.BunifuMaterialTextbox",
            "System.Windows.Forms.MaskedTextBox",
            "System.Windows.Forms.RichTextBox"
            }

        resetFields(FrmPrincipal.PnlRegistro1, Arr)
    End Sub

    'Activa o desactiva ciertos datos que se muestran en caso de haber cargado la información de un paciente
    Public Sub ShowControlsInFrmPatient(Optional setVisibleCtrl As Boolean = False)
        Dim frmRegister = FrmPrincipal.PnlRegistro1
        scrollForm(frmRegister, 0)
        frmRegister.btnEliminar.Enabled = setVisibleCtrl
        FrmPrincipal.lblName.Visible = setVisibleCtrl
        FrmPrincipal.BtnHistory.Visible = setVisibleCtrl
    End Sub

    'Fija el nombre en el form
    Public Sub SetNamePatientInMainForm(Optional namePacient As String = "")
        FrmPrincipal.lblName.Text = "Paciente | " & SetCamelCase(namePacient)
    End Sub


    ' Condiciona si el formato de la dirección es correcto.
    Public Function IsValidEmail(ByVal email As String) As Boolean
        If email <> "" Then
            Dim condition = New Regex("^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$")
            Dim captureError = condition.Match(email)
            Return (captureError.Captures.Count <> 0)
        End If
        Return True
    End Function

    'Fija la información del paciente donde corresponde
    Public Sub FillDataFieldsPatients(ByVal documentId As String)
        Dim Patient As New Patient
        Dim dataPatient = Patient.getPatient(documentId)


        For Each valueFieldFormAndDb As KeyValuePair(Of Object, String()) In FillArrayFieldsPatient()
            valueFieldFormAndDb.Key.DataBindings.Add(valueFieldFormAndDb.Value(1), dataPatient(0), "patients." & valueFieldFormAndDb.Value(0))
        Next
        setDiffInYears()
        Patient.getContact(Patient.getId(documentId))

        AdjustPnlsToDataPatient(dataPatient)

    End Sub

    Private Sub setDiffInYears()
        Dim frmRegister = FrmPrincipal.PnlRegistro1
        If frmRegister.TxtAge.Text = "" Then
            Dim dateStart As Date = frmRegister.lblDateBirth.Text()
            frmRegister.TxtAge.Text = CStr(DateDiff(DateInterval.Year, dateStart, Date.Today))
        End If
    End Sub
    Private Function FillArrayFieldsPatient()
        Dim frmRegister = FrmPrincipal.PnlRegistro1

        Dim fieldsFormAndDB = New Dictionary(Of Object, String())
        fieldsFormAndDB.Add(frmRegister.TxtCed, {"document_id", "Text"})
        fieldsFormAndDB.Add(frmRegister.TxtNom, {"name", "Text"})
        fieldsFormAndDB.Add(frmRegister.TxtApe, {"last_name", "Text"})
        fieldsFormAndDB.Add(frmRegister.TxtCorreo, {"email", "Text"})
        fieldsFormAndDB.Add(frmRegister.txtProfesion, {"profesion", "Text"})
        fieldsFormAndDB.Add(frmRegister.txtAddress, {"address", "Text"})
        fieldsFormAndDB.Add(frmRegister.CboxGen, {"genre", "selectedIndex"})
        fieldsFormAndDB.Add(frmRegister.TxtAge, {"age", "Text"})
        fieldsFormAndDB.Add(frmRegister.lblDateBirth, {"date_birth", "Text"})
        fieldsFormAndDB.Add(frmRegister.CboxEdo, {"marital_status", "selectedIndex"})
        fieldsFormAndDB.Add(frmRegister.dateFirstConsultation, {"start_date", "Value"})

        Return fieldsFormAndDB
    End Function

    'Ajusta el pnl con la data del paciente enviada a tráves del param
    Private Sub AdjustPnlsToDataPatient(dataPatient As Object)
        Dim frmRegister = FrmPrincipal.PnlRegistro1
        SetFrmToDataPatient(dataPatient(1)("document_id".ToString), dataPatient(1)("name".ToString) +
                 " " + dataPatient(1)("last_name".ToString))
        resetfieldsHistory()
        scrollForm(frmRegister, 0)
        cleanDataBindings(frmRegister)
    End Sub

    'Fija la docId del paciente el nombre y activa ciertos controles a la hora de haber registrado el paciente
    Private Sub SetFrmToDataPatient(docId As Integer, namePatient As String)
        FrmPrincipal.cedula = docId
        ShowControlsInFrmPatient(True)
        SetNamePatientInMainForm(namePatient)
        ctrlPnlMain.SetBtnActiveDataPatientOrRegister(True)
    End Sub

    'Envia la peticion para guardar el paciente y su nro
    Private Sub SendPetitionSavePatient()
        Dim dataToSave As String = "null, '" & documentID & "', '" & name & "','" & lastName & "', '" &
          genre & "', '" & email & "', '" & maritStatus & "', '" & age & "', null, '" & firstDate & "','" &
          profesion & "','" & address & "'"

        Patient.storePatient(dataToSave, documentID)
        Patient.storeContact(documentID, number)
        SetFrmToDataPatient(documentID, name + " " + lastName)
    End Sub


    'Llena el string que sera enviado para guardarse en la DB y ademas limpia el form y condiciona si ya existe
    Public Sub FillArrayToSavePatient()
        FillPrivateFieldsPatient()
        rePaintColor({FrmPrincipal.PnlRegistro1.TxtCed, FrmPrincipal.PnlRegistro1.TxtNom, FrmPrincipal.PnlRegistro1.TxtApe})
        If Patient.getId(documentID) = -1 Then
            SendPetitionSavePatient()
        Else
            MsgBox("EL PACIENTE HA SIDO REGISTRADO ANTERIORMENTE", MsgBoxStyle.Exclamation, "REGISTRO DUPLICADO")
            FillDataFieldsPatients(documentID)
        End If
    End Sub

    'Actualizar datos de paciente
    Public Sub FillDataPatientToUpdate(ByVal oldDocID As String)
        FillPrivateFieldsPatient()
        Dim arr As String = "document_id='" & documentID & "', name='" & name & "', last_name='" &
            lastName & "', genre='" & genre & "', email='" & email & "', marital_status='" &
            maritStatus & "', age ='" & age & "', start_date='" & firstDate & "', profesion='" &
            profesion & "', address='" & address & "'"

        Patient.updatePatient(oldDocID, arr)
        Patient.updateContact(oldDocID, number)

        SetFrmToDataPatient(documentID, name + " " + lastName)
    End Sub


    'Carga las variables privadas de la clase
    Private Sub FillPrivateFieldsPatient()
        documentID = FrmPrincipal.PnlRegistro1.TxtCed.Text()
        name = FrmPrincipal.PnlRegistro1.TxtNom.Text()
        lastName = FrmPrincipal.PnlRegistro1.TxtApe.Text()
        genre = FrmPrincipal.PnlRegistro1.CboxGen.selectedIndex()
        email = FrmPrincipal.PnlRegistro1.TxtCorreo.Text()
        age = FrmPrincipal.PnlRegistro1.TxtAge.Text()
        number = FrmPrincipal.PnlRegistro1.TxtNro.Text()
        maritStatus = FrmPrincipal.PnlRegistro1.CboxEdo.selectedIndex()
        firstDate = FrmPrincipal.PnlRegistro1.dateFirstConsultation.Value.ToString("yyyy/MM/dd")
        profesion = FrmPrincipal.PnlRegistro1.txtProfesion.Text()
        address = FrmPrincipal.PnlRegistro1.txtAddress.Text
    End Sub

    Public Sub deletePatient(ByVal documentsId() As String, Optional isNewRegister As Boolean = False)
        Dim ctrlListPat As New InPnlLstPatients
        Dim ctrlPat As New Patient

        ctrlPat.deletePatient(documentsId)

        If isNewRegister Then
            NewRegister()
        Else
            NewRegister(isNewRegister)
        End If

        ctrlListPat.FillPatientList()
    End Sub

End Class
