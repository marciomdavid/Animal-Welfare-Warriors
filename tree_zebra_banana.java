import java.util.ArrayList;
import java.util.List;

public class AnimalWelfareWarriors {

    // declare a List of Animal objects
    private List<Animal> animals;

    public AnimalWelfareWarriors() {
        // initialize the list of animals
        animals = new ArrayList<>();
    }

    // add an animal to the list of animals
    public void addAnimal(Animal animal) {
        animals.add(animal);
    }

    // count up the number of animals
    public int countAnimals() {
        int count = 0;
        for (Animal animal : animals)
            count++;
        return count;
    }

    // find an animal by its name
    public Animal findAnimalByName(String name) {
        for (Animal animal : animals) {
            if (animal.getName().equals(name))
                return animal;
        }
        return null;
    }

    // remove an animal from the list of animals
    public void removeAnimal(Animal animal) {
        animals.remove(animal);
    }

    // rescue an animal and add it to the list of animals
    public void rescueAnimal(Animal animal) {
        animals.add(animal);
    }

    // adopt an animal and remove it from the list of animals
    public void adoptAnimal(Animal animal) {
        animals.remove(animal);
    }

}