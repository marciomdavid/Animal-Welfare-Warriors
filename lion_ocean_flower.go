package main

import "fmt"

//Animal Welfare Warriors - an organization devoted to animal welfare
type AnimalWelfareWarriors struct {
	name string
	mission string
}

//Animal struct to store data about each individual animal
type Animal struct {
	name string
	species string
	age int
	vaccinated bool
	gender string
}

func main() {
	//create object of AnimalWelfareWarriors
	aww := AnimalWelfareWarriors{
		name: "Animal Welfare Warriors",
		mission: "To raise awareness of the importance of animal welfare and take action to improve animal welfare in our society.",
	}
	
	//print organization specifics
	fmt.Println("Name:", aww.name)
	fmt.Println("Mission:", aww.mission)
	
	//create animals
	animals := []Animal {
		{
			name: "Fluffy",
			species: "cat",
			age: 4,
			vaccinated: true,
			gender: "female",
		}, 
		{
			name: "Buddy",
			species: "dog",
			age: 5,
			vaccinated: false,
			gender: "male",
		},
		{
			name: "Kiki",
			species: "rabbit",
			age: 2,
			vaccinated: true,
			gender: "female",
		},
	}
	
	//print animals' details
	fmt.Println("Animals:")
	for _, animal := range animals {
		fmt.Printf("Name: %v; Species: %v; Age: %v; Vaccinated: %v; Gender: %v\n", animal.name, animal.species, animal.age, animal.vaccinated, animal.gender)
	}
	
	//gather support to help improve animal welfare
	fmt.Println("\nHelp improve animal welfare with the Animal Welfare Warriors!")
}