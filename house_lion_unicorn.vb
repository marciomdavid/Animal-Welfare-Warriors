Public Class AnimalWelfareWarriors

    Private Sub Form_Load (ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Change form title
        Me.Text = "Animal Welfare Warriors"

        ' Set maximum size of form
        Me.MaximumSize = New Size (900, 530)

        ' Create label to display the title 
        Dim lblTitle As Label = New Label
        lblTitle.Text = "Animal Welfare Warriors"
        lblTitle.Size = New Size (300, 40)
        lblTitle.Location = New Point (290, 10)
        lblTitle.Font = New Font ("Calibri", 30, FontStyle.Bold)
        Me.Controls.Add (lblTitle)

        ' Create label to display instructions
        Dim lblInstructions As Label = New Label
        lblInstructions.Text = "Welcome! Here you can learn about animal welfare and take action to help animals." 
        lblInstructions.Size = New Size (600, 20)
        lblInstructions.Location = New Point (120, 50)
        lblInstructions.Font = New Font ("Calibri", 10, FontStyle.Regular)
        Me.Controls.Add (lblInstructions)

        ' Create label to display animals
        Dim lblAnimals As Label = New Label
        lblAnimals.Text = "Choose an animal to learn about:"
        lblAnimals.Size = New Size (200, 20)
        lblAnimals.Location = New Point (20, 80)
        lblAnimals.Font = New Font ("Calibri", 10, FontStyle.Regular)
        Me.Controls.Add (lblAnimals)

        ' Create combo box to display animals
        Dim cmbAnimals As ComboBox = New ComboBox
        cmbAnimals.Size = New Size (150, 20)
        cmbAnimals.Location = New Point (20, 100)
        cmbAnimals.Font = New Font ("Calibri", 10, FontStyle.Regular)
        cmbAnimals.Items.Add ("Cats")
        cmbAnimals.Items.Add ("Dogs")
        cmbAnimals.Items.Add ("Reptiles")
        cmbAnimals.Items.Add ("Birds")
        cmbAnimals.Items.Add ("Fish")
        Me.Controls.Add (cmbAnimals)

        ' Create label to display actions
        Dim lblActions As Label = New Label
        lblActions.Text = "Choose an action to help:"
        lblActions.Size = New Size (200, 20)
        lblActions.Location = New Point (180, 80)
        lblActions.Font = New Font ("Calibri", 10, FontStyle.Regular)
        Me.Controls.Add (lblActions)

        ' Create combo box to display actions
        Dim cmbActions As ComboBox = New ComboBox
        cmbActions.Size = New Size (150, 20)
        cmbActions.Location = New Point (180, 100)
        cmbActions.Font = New Font ("Calibri", 10, FontStyle.Regular)
        cmbActions.Items.Add ("Adopt")
        cmbActions.Items.Add ("Volunteer")
        cmbActions.Items.Add ("Donate")
        cmbActions.Items.Add ("Educate")
        Me.Controls.Add (cmbActions)

        ' Create label to display resources
        Dim lblResources As Label = New Label
        lblResources.Text = "Find resources:"
        lblResources.Size = New Size (150, 20)
        lblResources.Location = New Point (340, 80)
        lblResources.Font = New Font ("Calibri", 10, FontStyle.Regular)
        Me.Controls.Add (lblResources)

        ' Create button to display resources
        Dim btnResources As Button = New Button
        btnResources.Text = "See Resources"
        btnResources.Size = New Size (130, 20)
        btnResources.Location = New Point (340, 100)
        btnResources.Font = New Font ("Calibri", 10, FontStyle.Regular)
        btnResources.DialogResult = DialogResult.OK
        Me.Controls.Add (btnResources)

        ' Create button to exit
        Dim btnExit As Button = New Button
        btnExit.Text = "Exit"
        btnExit.Size = New Size (130, 20)
        btnExit.Location = New Point (500, 80)
        btnExit.Font = New Font ("Calibri", 10, FontStyle.Regular)
        btnExit.DialogResult = DialogResult.Cancel
        Me.Controls.Add (btnExit)

        ' Create button to save
        Dim btnSave As Button = New Button
        btnSave.Text = "Save"
        btnSave.Size = New Size (130, 20)
        btnSave.Location = New Point (500, 100)
        btnSave.Font = New Font ("Calibri", 10, FontStyle.Regular)
        btnSave.DialogResult = DialogResult.Retry
        Me.Controls.Add (btnSave)

        ' Create label to display volunteering
        Dim lblVolunteer As Label = New Label
        lblVolunteer.Text = "Volunteer at animal welfare organizations near you:"
        lblVolunteer.Size = New Size (350, 20)
        lblVolunteer.Location = New Point (20, 130)
        lblVolunteer.Font = New Font ("Calibri", 10, FontStyle.Regular)
        Me.Controls.Add (lblVolunteer)

        ' Create text box to display volunteering
        Dim txtVolunteer As TextBox = New TextBox
        txtVolunteer.Size = New Size (350, 20)
        txtVolunteer.Location = New Point (20, 150)
        txtVolunteer.Font = New Font ("Calibri", 10, FontStyle.Regular)
        Me.Controls.Add (txtVolunteer)

        ' Create label to display donations
        Dim lblDonate As Label = New Label
        lblDonate.Text = "Donate to animal welfare organizations near you:"
        lblDonate.Size = New Size (350, 20)
        lblDonate.Location = New Point (20, 180)
        lblDonate.Font = New Font ("Calibri", 10, FontStyle.Regular)
        Me.Controls.Add (lblDonate)

        ' Create text box to display donations
        Dim txtDonate As TextBox = New TextBox
        txtDonate.Size = New Size (350, 20)
        txtDonate.Location = New Point (20, 200)
        txtDonate.Font = New Font ("Calibri", 10, FontStyle.Regular)
        Me.Controls.Add (txtDonate)

        ' Create label to display vets
        Dim lblVet As Label = New Label
        lblVet.Text = "Find veterinarians in your area:"
        lblVet.Size = New Size (350, 20)
        lblVet.Location = New Point (20, 230)
        lblVet.Font = New Font ("Calibri", 10, FontStyle.Regular)
        Me.Controls.Add (lblVet)

        ' Create text box to display vets
        Dim txtVet As TextBox = New TextBox
        txtVet.Size = New Size (350, 20)
        txtVet.Location = New Point (20, 250)
        txtVet.Font = New Font ("Calibri", 10, FontStyle.Regular)
        Me.Controls.Add (txtVet)

        ' Create label to display rescues
        Dim lblRescue As Label = New Label
        lblRescue.Text = "Find animal rescue organizations in your area:"
        lblRescue.Size = New Size (350, 20)
        lblRescue.Location = New Point (20, 280)
        lblRescue.Font = New Font ("Calibri", 10, FontStyle.Regular)
        Me.Controls.Add (lblRescue)

        ' Create text box to display rescues
        Dim txtRescue As TextBox = New TextBox
        txtRescue.Size = New Size (350, 20)
        txtRescue.Location = New Point (20, 300)
        txtRescue.Font = New Font ("Calibri", 10, FontStyle.Regular)
        Me.Controls.Add (txtRescue)

        ' Create label to display shelters
        Dim lblShelter As Label = New Label
        lblShelter.Text = "Find animal shelters near you:"
        lblShelter.Size = New Size (350, 20)
        lblShelter.Location = New Point (20, 330)
        lblShelter.Font = New Font ("Calibri", 10, FontStyle.Regular)
        Me.Controls.Add (lblShelter)

        ' Create text box to display shelters
        Dim txtShelter As TextBox = New TextBox
        txtShelter.Size = New Size (350, 20)
        txtShelter.Location = New Point (20, 350)
        txtShelter.Font = New Font ("Calibri", 10, FontStyle.Regular)
        Me.Controls.Add (txtShelter)

        ' Create label to display events
        Dim lblEvent As Label = New Label
        lblEvent.Text = "List animal welfare events near you:"
        lblEvent.Size = New Size (350, 20)
        lblEvent.Location = New Point (20, 380)
        lblEvent.Font = New Font ("Calibri", 10, FontStyle.Regular)
        Me.Controls.Add (lblEvent)

        ' Create text box to display events
        Dim txtEvent As TextBox = New TextBox
        txtEvent.Size = New Size (350, 20)
        txtEvent.Location = New Point (20, 400)
        txtEvent.Font = New Font ("Calibri", 10, FontStyle.Regular)
        Me.Controls.Add (txtEvent)

        ' Create label to display merchandise
        Dim lblMerchandise As Label = New Label
        lblMerchandise.Text = "Buy animal welfare merchandise and gifts:"
        lblMerchandise.Size = New Size (350, 20)
        lblMerchandise.Location = New Point (20, 430)
        lblMerchandise.Font = New Font ("Calibri", 10, FontStyle.Regular)
        Me.Controls.Add (lblMerchandise)

        ' Create text box to display merchandise
        Dim txtMerchandise As TextBox = New TextBox
        txtMerchandise.Size = New Size (350, 20)
        txtMerchandise.Location = New Point (20, 450)
        txtMerchandise.Font = New Font ("Calibri", 10, FontStyle.Regular)
        Me.Controls.Add (txtMerchandise)

    End Sub

End Class