Public Class AnimalWelfareWarriors

' This class defines the members of the Animal Welfare Warriors

Private m_strName As String
Private m_strMission As String
Private m_strLocation As String
Private m_intAge As Integer

Public Sub New(ByVal strName As String, ByVal strMission As String, ByVal strLocation As String, ByVal intAge As Integer)
    m_strName = strName
    m_strMission = strMission
    m_strLocation = strLocation
    m_intAge = intAge
End Sub

Public Property Name() As String
    Get
        Return m_strName
    End Get
    Set(ByVal value As String)
        m_strName = value
    End Set
End Property

Public Property Mission() As String
    Get
        Return m_strMission
    End Get
    Set(ByVal value As String)
        m_strMission = value
    End Set
End Property

Public Property Location() As String
    Get
        Return m_strLocation
    End Get
    Set(ByVal value As String)
        m_strLocation = value
    End Set
End Property

Public Property Age() As Integer
    Get
        Return m_intAge
    End Get
    Set(ByVal value As Integer)
        m_intAge = value
    End Set
End Property

Public Sub SpeakUpForAnimals()
    Dim strSpeech As String
    strSpeech = "We, the Animal Welfare Warriors, will fight for" &amp; vbCrLf
    strSpeech &amp;= "all animals, big and small, in order to ensure their rights" &amp; vbCrLf
    strSpeech &amp;= "and safety are respected." &amp; vbCrLf &amp; vbCrLf
    strSpeech &amp;= "Our mission is to speak up for the animals who cannot speak for themselves."
    MsgBox strSpeech
End Sub

Public Function JoinTheWarriors(ByVal strName As String, ByVal intAge As Integer) As Boolean
    If Not String.IsNullOrEmpty(strName) AndAlso intAge &gt;= 18 Then
        m_strName = strName
        m_intAge = intAge
        Return True
    Else
        Return False
    End If
End Function

Public Sub LeadTheCharge()
    Dim strSpeech As String
    strSpeech = "Join me, " &amp; m_strName &amp; ", in the fight for animal rights and justice!"
    MsgBox strSpeech
End Sub

Public Sub UpdateLocation(ByVal strLocation As String)
    m_strLocation = strLocation
End Sub

Public Sub FightForAnimalRights()
    Dim strSpeech As String
    strSpeech = "We, the Animal Welfare Warriors, must stand up for all animals and fight for their rights!"
    MsgBox strSpeech
End Sub

Public Function AdoptAnAnimal(ByVal strAnimal As String) As Boolean
    If Not String.IsNullOrEmpty(strAnimal) Then
        MsgBox "You have adopted a " &amp; strAnimal &amp; "! Congratulations!"
        Return True
    Else
        Return False
    End If
End Function

Public Sub RescueAnimals()
    Dim strSpeech As String
    strSpeech = "We must rescue animals from danger and harm and give them the love and care they need!"
    MsgBox strSpeech
End Sub

Public Sub EducateOthers()
    Dim strSpeech As String
    strSpeech = "It is our duty to educate others about animal rights and the importance of treating all creatures with respect and kindness."
    MsgBox strSpeech
End Sub

Public Sub SpeakOutAgainstCruelty()
    Dim strSpeech As String
    strSpeech = "We must stand against all forms of animal cruelty and ensure that animals everywhere are treated with compassion and kindness."
    MsgBox strSpeech
End Sub

Public Sub SpreadAwareness()
    Dim strSpeech As String
    strSpeech = "We must spread awareness about animal rights and make sure that everyone understands how important it is to respect and protect our furry friends."
    MsgBox strSpeech
End Sub

End Class