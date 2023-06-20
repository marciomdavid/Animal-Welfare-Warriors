#include<stdio.h>

#define MAX 50

// global variables
int AWW_animals[MAX]; 
int AWW_animal_count = 0;

// structure
struct Animal_welfare_warriors
{
    char name[MAX];
    char breed[MAX];
    char species[MAX];
    char age[MAX];
    char color[MAX];
};

// Function Declarations
void add_animal_at_AWW();
void remove_animal_from_AWW();
void update_animal_at_AWW();
void search_animal_at_AWW();
void print_animal_at_AWW();

// Main function
int main()
{
    int choice;

    while(1)
    {
        // user interface
        printf("\n\n\nWelcome to Animal Welfare Warriors\n");
        printf("1. Add Animal\n");
        printf("2. Remove Animal\n");
        printf("3. Update Animal\n");
        printf("4. Search Animal\n");
        printf("5. Print Animal\n");
        printf("6. Exit\n");
        printf("Enter your choice : ");
        scanf("%d", &choice);

        switch (choice)
        {
            case 1:
                // Add animal
                add_animal_at_AWW();
                break;
            case 2:
                // Remove animal
                remove_animal_from_AWW();
                break;
            case 3:
                // Update animal
                update_animal_at_AWW();
                break;
            case 4:
                // Search animal
                search_animal_at_AWW();
                break;
            case 5:
                // Print animal
                print_animal_at_AWW();
                break;
            case 6:
                // Exit
                return 0;
            default:
                printf("Invalid Choice\n");      
        }
    }

    return 0;
}

// Function to add animal at AWW
void add_animal_at_AWW()
{
    struct Animal_welfare_warriors aww;

    // input animal data
    printf("Enter name of animal : ");
    scanf("%s", aww.name);
    printf("Enter breed of animal : ");
    scanf("%s", aww.breed);
    printf("Enter species of animal : ");
    scanf("%s", aww.species);
    printf("Enter age of animal : ");
    scanf("%s", aww.age);
    printf("Enter color of animal : ");
    scanf("%s", aww.color);

    // store data in global array
    AWW_animals[AWW_animal_count] = aww;

    // increment count
    AWW_animal_count++;
}

// Function to remove animal from AWW
void remove_animal_from_AWW()
{
    struct Animal_welfare_warriors aww;
    int i, found=0;

    // input animal name to remove it from AWW
    printf("Enter name of the animal to remove : ");
    scanf("%s", aww.name);

    // search for the animal in AWW
    for (i = 0; i < AWW_animal_count; i++)
    {
        if (strcmp(AWW_animals[i].name, aww.name) == 0)
        {
            // found the animal
            found = 1;
            break;
        }
    }

    if (found==1)
    {
        // remove animal
        for (i = i + 1; i < AWW_animal_count; i++)
        {
            AWW_animals[i - 1] = AWW_animals[i];
        }

        // decrement count
        AWW_animal_count--;
        printf("Animal removed successfully\n");
    }
    else
    {
        // display error message
        printf("Animal not found\n");
    }
}

// Function to update animal at AWW
void update_animal_at_AWW()
{
    struct Animal_welfare_warriors aww;
    int i, found = 0;

    // input animal name to update it 
    printf("Enter name of the animal to update : ");
    scanf("%s", aww.name);

    // search for the animal in AWW
    for (i = 0; i < AWW_animal_count; i++)
    {
        if (strcmp(AWW_animals[i].name, aww.name) == 0)
        {
            // found the animal
            found = 1;
            break;
        }
    }

    if (found == 1)
    {
        // update animal data
        printf("Enter breed of animal : ");
        scanf("%s", aww.breed);
        printf("Enter species of animal : ");
        scanf("%s", aww.species);
        printf("Enter age of animal : ");
        scanf("%s", aww.age);
        printf("Enter color of animal : ");
        scanf("%s", aww.color);

        // update data in global array
        AWW_animals[i] = aww;
    }
    else
    {
        // display error message
        printf("Animal not found\n");
    }
}

// Function to search animal at AWW
void search_animal_at_AWW()
{
    struct Animal_welfare_warriors aww;
    int i, found = 0;

    // input animal name to search it 
    printf("Enter name of the animal to search : ");
    scanf("%s", aww.name);

    // search for the animal in AWW
    for (i = 0; i < AWW_animal_count; i++)
    {
        if (strcmp(AWW_animals[i].name, aww.name) == 0)
        {
            // found the animal
            found = 1;
            break;
        }
    }

    if (found == 1)
    {
        // print data
        printf("Name : %s\n", AWW_animals[i].name);
        printf("Breed : %s\n", AWW_animals[i].breed);
        printf("Species : %s\n", AWW_animals[i].species);
        printf("Age : %s\n", AWW_animals[i].age);
        printf("Color : %s\n", AWW_animals[i].color);
    }
    else
    {
        // display error message
        printf("Animal not found\n");
    }

}

// Function to print animals at AWW
void print_animal_at_AWW()
{
    int i;

    // print data
    printf("\n\nAnimals at Animal Welfare Warriors : \n");

    for (i = 0; i < AWW_animal_count; i++)
    {
        printf("Name : %s\n", AWW_animals[i].name);
        printf("Breed : %s\n", AWW_animals[i].breed);
        printf("Species : %s\n", AWW_animals[i].species);
        printf("Age : %s\n", AWW_animals[i].age);
        printf("Color : %s\n\n", AWW_animals[i].color);
    }
}