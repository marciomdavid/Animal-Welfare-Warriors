//Animal Welfare Warriors

//Global Variables
var animalWelfareOrganizations = [];
var volunteers = [];
var events = [];

//Animal Welfare Organizations
function createOrganization(name, mission, location) {
	var organization = {
		name: name,
		mission: mission,
		location: location,
		volunteers: []
	}
	animalWelfareOrganizations.push(organization);
}

//Volunteers
function addVolunteerToOrganization(volunteer, organization) {
	var organization = animalWelfareOrganizations.find(function(org){
		return org.name === organization;
	});
	organization.volunteers.push(volunteer);
	volunteers.push(volunteer);
}

//Events
function createEvent(name, date, location) {
	var event = {
		name: name,
		date: date,
		location: location,
		volunteersAttending: []
	}
	events.push(event);
}

function addVolunteerToEvent(volunteer, event) {
	var event = events.find(function(ev){
		return ev.name === event;
	});
	event.volunteersAttending.push(volunteer);
}

//Animal Welfare Warriors
function AnimalWelfareWarriors(name, commitmentLevel, volunteerExperience, organization) {
	this.name = name;
	this.commitmentLevel = commitmentLevel;
	this.volunteerExperience = volunteerExperience;
	this.organization = organization;
	this.volunteerEvents = [];
	
	//add volunteer to organization
	this.addVolunteerToOrganization = function() {
		addVolunteerToOrganization(this, this.organization);
	}
	
	//add volunteer to event
	this.addVolunteerToEvent = function(event) {
		addVolunteerToEvent(this, event);
		this.volunteerEvents.push(event);
	}
}