Public Class AnimalWelfareWarriors

    Private strOrganizationName As String

    Public Sub New(orgname As String)
        strOrganizationName = orgname
    End Sub

    Public Sub SetOrganizationName(orgname As String)
        strOrganizationName = orgname
    End Sub

    Public Sub GetOrganizationName()
        Return strOrganizationName
    End Sub

    Public Sub CreateAnimalRescueOrganization(orgname As String, location As String)
        'Store organization name
        strOrganizationName = orgname
 
        'Create organization resources
        Dim objResourceHelper As New ResourceHelper

        objResourceHelper.CreateWebsite(strOrganizationName, location)
        objResourceHelper.CreateMailingList(strOrganizationName, location)
        objResourceHelper.CreateSocialMediaPage(strOrganizationName, location)

        'Send out public announcement
        Dim objPublicAnnouncementHelper As New PublicAnnouncementHelper

        objPublicAnnouncementHelper.SendPressRelease(strOrganizationName, location)
        objPublicAnnouncementHelper.SendNewsLetter(strOrganizationName, location)

        'Set up organization in directory
        Dim objDirectoryHelper As New DirectoryHelper

        objDirectoryHelper.AddOrganizationToDirectory(strOrganizationName, location)

        'Send out recruiting emails
        Dim objRecruitingHelper As New RecruitingHelper

        objRecruitingHelper.SendRecruitingEmails(strOrganizationName, location)
    End Sub

    Public Sub SetUpFundraiser(orgname As String, location As String, goalreached As Boolean)
        'Store organization name
        strOrganizationName = orgname
 
        'Check if goal is reached
        If goalreached Then
            'Send out public announcement
            Dim objPublicAnnouncementHelper As New PublicAnnouncementHelper

            objPublicAnnouncementHelper.SendAnnouncementOfGoalReached(strOrganizationName, location)
        Else
            'Create crowdfundingplatform
            Dim objCrowdfundingPlatformHelper As New CrowdfundingPlatformHelper

            objCrowdfundingPlatformHelper.CreateCrowdfundingPlatform(strOrganizationName, location)

            'Send out public announcement
            Dim objPublicAnnouncementHelper As New PublicAnnouncementHelper

            objPublicAnnouncementHelper.SendPublicAnnouncementOfFundraiser(strOrganizationName, location)
        End If
    End Sub

    Public Sub RunCommunityOutreachCampaign(orgname As String, location As String)
        'Store organization name
        strOrganizationName = orgname

        'Create community outreach resources
        Dim objResourceHelper As New ResourceHelper

        objResourceHelper.CreateFlyers(strOrganizationName, location)
        objResourceHelper.CreatePosters(strOrganizationName, location)
        objResourceHelper.CreateBrochures(strOrganizationName, location)

        'Send out public announcement
        Dim objPublicAnnouncementHelper As New PublicAnnouncementHelper

        objPublicAnnouncementHelper.SendOutPressReleases(strOrganizationName, location)
        objPublicAnnouncementHelper.SendOutNewsLetters(strOrganizationName, location)
    End Sub

    Public Sub OrganizeVolunteerActivities(orgname As String, location As String)
        'Store organization name
        strOrganizationName = orgname

        'Create volunteer resources
        Dim objResourceHelper As New ResourceHelper

        objResourceHelper.CreateVolunteerPortal(strOrganizationName, location)
        objResourceHelper.CreateVolunteerRoster(strOrganizationName, location)

        'Send out public announcement
        Dim objPublicAnnouncementHelper As New PublicAnnouncementHelper

        objPublicAnnouncementHelper.SendOutPressReleases(strOrganizationName, location)
        objPublicAnnouncementHelper.SendOutNewsLetters(strOrganizationName, location)
    End Sub

    Public Sub StartAnimalAdoptionProcess(orgname As String, location As String)
        'Store organization name
        strOrganizationName = orgname

        'Create animal adoption resources
        Dim objResourceHelper As New ResourceHelper

        objResourceHelper.CreateAdoptionWebsite(strOrganizationName, location)
        objResourceHelper.CreateAdoptionForms(strOrganizationName, location)
        objResourceHelper.CreateAdoptionDatabase(strOrganizationName, location)

        'Send out public announcement
        Dim objPublicAnnouncementHelper As New PublicAnnouncementHelper

        objPublicAnnouncementHelper.SendOutPressReleases(strOrganizationName, location)
        objPublicAnnouncementHelper.SendOutNewsLetters(strOrganizationName, location)
    End Sub

    Public Sub StartAnimalEducationProgram(orgname As String, location As String)
        'Store organization name
        strOrganizationName = orgname

        'Create animal education resources
        Dim objResourceHelper As New ResourceHelper

        objResourceHelper.CreateEducationWebsite(strOrganizationName, location)
        objResourceHelper.CreateEducationVideos(strOrganizationName, location)
        objResourceHelper.CreateEducationBooklets(strOrganizationName, location)

        'Send out public announcement
        Dim objPublicAnnouncementHelper As New PublicAnnouncementHelper

        objPublicAnnouncementHelper.SendOutPressReleases(strOrganizationName, location)
        objPublicAnnouncementHelper.SendOutNewsLetters(strOrganizationName, location)
    End Sub

    Public Sub StartAnimalMedicalProgram(orgname As String, location As String)
        'Store organization name
        strOrganizationName = orgname

        'Create animal medical resources
        Dim objResourceHelper As New ResourceHelper

        objResourceHelper.CreateMedicalDatabase(strOrganizationName, location)
        objResourceHelper.CreateMedicalForms(strOrganizationName, location)
        objResourceHelper.CreateMedicalCenters(strOrganizationName, location)

        'Send out public announcement
        Dim objPublicAnnouncementHelper As New PublicAnnouncementHelper

        objPublicAnnouncementHelper.SendOutPressReleases(strOrganizationName, location)
        objPublicAnnouncementHelper.SendOutNewsLetters(strOrganizationName, location)
    End Sub

    Public Sub StartAnimalRescueOperation(orgname As String, location As String)
        'Store organization name
        strOrganizationName = orgname

        'Create animal rescue resources
        Dim objResourceHelper As New ResourceHelper

        objResourceHelper.CreateRescueTeam(strOrganizationName, location)
        objResourceHelper.CreateRescueDatabase(strOrganizationName, location)
        objResourceHelper.CreateRescueCenters(strOrganizationName, location)

        'Send out public announcement
        Dim objPublicAnnouncementHelper As New PublicAnnouncementHelper

        objPublicAnnouncementHelper.SendOutPressReleases(strOrganizationName, location)
        objPublicAnnouncementHelper.SendOutNewsLetters(strOrganizationName, location)
    End Sub

    Public Sub StartAnimalAdvocacyCampaign(orgname As String, location As String)
        'Store organization name
        strOrganizationName = orgname

        'Create animal advocacy resources
        Dim objResourceHelper As New ResourceHelper

        objResourceHelper.CreateAdvocacyWebsite(strOrganizationName, location)
        objResourceHelper.CreateAdvocacyInitiatives(strOrganizationName, location)
        objResourceHelper.CreateAdvocacyDatabase(strOrganizationName, location)

        'Send out public announcement
        Dim objPublicAnnouncementHelper As New PublicAnnouncementHelper

        objPublicAnnouncementHelper.SendOutPressReleases(strOrganizationName, location)
        objPublicAnnouncementHelper.SendOutNewsLetters(strOrganizationName, location)
    End Sub

    Public Sub StartAnimalProtectionProgram(orgname As String, location As String)
        'Store organization name
        strOrganizationName = orgname

        'Create animal protection resources
        Dim objResourceHelper As New ResourceHelper

        objResourceHelper.CreateProtectionTeam(strOrganizationName, location)
        objResourceHelper.CreateProtectionDatabase(strOrganizationName, location)
        objResourceHelper.CreateProtectionCenters(strOrganizationName, location)

        'Send out public announcement
        Dim objPublicAnnouncementHelper As New PublicAnnouncementHelper

        objPublicAnnouncementHelper.SendOutPressReleases(strOrganizationName, location)
        objPublicAnnouncementHelper.SendOutNewsLetters(strOrganizationName, location)
    End Sub

    Public Sub StartAnimalSanctuaryProgram(orgname As String, location As String)
        'Store organization name
        strOrganizationName = orgname

        'Create animal sanctuary resources
        Dim objResourceHelper As New ResourceHelper

        objResourceHelper.CreateSanctuaryWebsite(strOrganizationName, location)
        objResourceHelper.CreateSanctuaryDatabases(strOrganizationName, location)
        objResourceHelper.CreateSanctuaryCenters(strOrganizationName, location)

        'Send out public announcement
        Dim objPublicAnnouncementHelper As New PublicAnnouncementHelper

        objPublicAnnouncementHelper.SendOutPressReleases(strOrganizationName, location)
        objPublicAnnouncementHelper.SendOutNewsLetters(strOrganizationName, location)
    End Sub

    Public Sub StartAnimalProtectionLaws(orgname As String, location As String)
        'Store organization name
        strOrganizationName = orgname

        'Create animal protection law resources
        Dim objResourceHelper As New ResourceHelper

        objResourceHelper.CreateLawInitiatives(strOrganizationName, location)
        objResourceHelper.CreateLawDatabases(strOrganizationName, location)
        objResourceHelper.CreateLawCenters(strOrganizationName, location)

        'Send out public announcement
        Dim objPublicAnnouncementHelper As New PublicAnnouncementHelper

        objPublicAnnouncementHelper.SendOutPressReleases(strOrganizationName, location)
        objPublicAnnouncementHelper.SendOutNewsLetters(strOrganizationName, location)
    End Sub

End Class