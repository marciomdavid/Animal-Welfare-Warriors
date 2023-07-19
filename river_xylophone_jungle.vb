Public Class AnimalWelfareWarriors

Dim Animals As Animals

Sub main()

Dim AnimalArray As New ArrayList() 

Dim AnimalTypes As New Dictionary(Of String, Integer)

AnimalTypes.Add("Reptiles", 0)
AnimalTypes.Add("Mammals", 1)
AnimalTypes.Add("Birds", 2)
AnimalTypes.Add("Fish", 3)

For Each AnimalType In AnimalTypes
	AnimalArray.Add(New Animals(AnimalType.Key, AnimalType.Value))
Next

Dim AnimalRescueTeam As New AnimalRescueTeam()

For Each Animal In AnimalArray
	AnimalRescueTeam.RescueAnimal(Animal)
Next

End Sub

End Class

Public Class Animals

Dim AnimalType As String
Dim AnimalID As Integer

Public Sub New(ByVal animalType As String, ByVal animalId As Integer)
	Me.AnimalType = animalType
	Me.AnimalID = animalId
End Sub

Public Function GetAnimalType() As String
	Return AnimalType
End Function

Public Function GetAnimalID() As Integer
	Return AnimalID
End Function

End Class

Public Class AnimalRescueTeam

Public Sub RescueAnimal(ByVal animal As Animals)
	Select Case animal.GetAnimalType()
		Case "Reptiles"
			RescueReptiles(animal.GetAnimalID())
		Case "Mammals"
			RescueMammals(animal.GetAnimalID())
		Case "Birds"
			RescueBirds(animal.GetAnimalID())
		Case "Fish"
			RescueFish(animal.GetAnimalID())
	End Select
End Sub

Private Sub RescueReptiles(ByVal reptileID As Integer)
	Console.WriteLine("Rescuing Reptiles: {0}", reptileID)
End Sub

Private Sub RescueMammals(ByVal mammalID As Integer)
	Console.WriteLine("Rescuing Mammals: {0}", mammalID)
End Sub

Private Sub RescueBirds(ByVal birdID As Integer)
	Console.WriteLine("Rescuing Birds: {0}", birdID)
End Sub

Private Sub RescueFish(ByVal fishID As Integer)
	Console.WriteLine("Rescuing Fish: {0}", fishID)
End Sub

End Class