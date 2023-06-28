<?php

//This class is used to store animal welfare warriors data
class AnimalWelfareWarriors{
    //These variables will hold animal welfare warriors data
    public $name;
    public $animalRescues;
    public $contributeAmount;
    // Constructor
    public function __construct($name,$animalRescues,$contributeAmount){
        $this->name = $name;
        $this->animalRescues = $animalRescues;
        $this->contributeAmount = $contributeAmount;
    }
    // This function will display the animal welfare warriors details
    public function display(){
        echo "Name: $this->name <br>";
        echo "Number of Animal rescues performed: $this->animalRescues <br>";
        echo "Amount contributed for Animal Welfare: $this->contributeAmount <br>";
    }
 
}

// This class is used to store AnimalWelfareWarriors profile
class Profile {
    // These variables will hold the profile data
    public $profileDisplayName;
    public $profileAge;
    public $profileGender;
    public $profileLocation;
    // Constructor
    public function __construct($profileDisplayName,$profileAge,$profileGender,$profileLocation){
        $this->profileDisplayName = $profileDisplayName;
        $this->profileAge = $profileAge;
        $this->profileGender = $profileGender;
        $this->profileLocation = $profileLocation;
    }
    // This function will display the profile details
    public function display(){
        echo "Display Name: $this->profileDisplayName <br>";
        echo "Age: $this->profileAge <br>";
        echo "Gender: $this->profileGender <br>";
        echo "Location: $this->profileLocation <br>";
    }
 
}

// This function will retrieve animal welfare warriors and profile data from the database
function retrieveData(){
    // Connect to the database
    $host = "localhost";
    $user = "root";
    $password = "";
    $database = "animals_data";
 
    $conn = mysqli_connect($host, $user, $password, $database);
    if ($conn->connect_error) {
        die("Connection failed: " . $conn->connect_error);
    }
    // Retrieve data from the database
    $sql = "SELECT * FROM AnimalWelfareWarriors, Profile WHERE AnimalWelfareWarriors.name = Profile.profileDisplayName";
    $animalWarriorsData = $conn->query($sql);
 
    // Create array of objects
    $animalWelfareWarriors = array();
    while ($row = $animalWarriorsData->fetch_assoc()) {
        array_push($animalWelfareWarriors,
            new AnimalWelfareWarriors($row["name"], $row["animalRescues"], $row["contributeAmount"]));
        array_push($animalWelfareWarriors,
            new Profile($row["profileDisplayName"], $row["profileAge"], $row["profileGender"], $row["profileLocation"]));
    }
    // Close connection
    $conn->close();
    // Return array of objects
    return $animalWelfareWarriors;
}

// This function will display animal welfare warriors data
function displayData($animalWelfareWarriors) {
    // Iterate through array of objects
    foreach($animalWelfareWarriors as $animalWarrior){
        // Check if the current element is an AnimalWelfareWarriors object
        if(get_class($animalWarrior) == 'AnimalWelfareWarriors'){
            $animalWarrior->display();
            echo "<br>";
        }
        // Check if the current element is an Profile object
        if(get_class($animalWarrior) == 'Profile'){
            $animalWarrior->display();
            echo "<br><br>";
        }
    }
}

// Retrieve animal welfare warriors data
$animalWelfareWarriors = retrieveData();
// Display animal welfare warriors data
displayData($animalWelfareWarriors);
?>