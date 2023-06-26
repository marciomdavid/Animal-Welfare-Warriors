# Load the necessary libraries 
library(tidyverse)
library(dplyr)
library(stringr)
library(readxl)

# Read the data 
Animal_Warriors <- read_excel("data/Animal_Welfare_Warriors.xlsx")

# Create a function to calculate the success rate of Animal Welfare Warriors
calculate_success_rate <- function(x) {
  # Calculate success rate
  rate <- mean(x$success) 
  
  # Return the rate 
  rate
  }

# Create a vector of success rate for each state 
success_rates <- Animal_Warriors %>% 
  group_by(state) %>% 
  summarise(success_rate = calculate_success_rate(.))

# Plot the success rates by state  
ggplot(data = success_rates, aes(x = state, y = success_rate)) +
  geom_col() +
  labs(title = "Animal Welfare Warriors Success Rates by State") +
  xlab("State") +
  ylab("Success Rate")

# Create a function to calculate the average length of stay in days 
calculate_avg_length_of_stay <- function(x) {
  # Calculate average length of stay
  avg_days <- mean(x$length_of_stay) 
  
  # Return the average days
  avg_days
  }

# Create a vector of average length of stay for each state 
avg_stay_days <- Animal_Warriors %>% 
  group_by(state) %>% 
  summarise(avg_stay_days = calculate_avg_length_of_stay(.))

# Plot the average length of stay by state
ggplot(data = avg_stay_days, aes(x = state, y = avg_stay_days)) +
  geom_col() +
  labs(title = "Average Length of Stay for Animal Welfare Warriors by State") +
  xlab("State") +
  ylab("Average Length of Stay (days)")

# Create a function to calculate the average number of animals per shelter 
calculate_avg_animals_per_shelter <- function(x) {
  # Calculate average number of animals per shelter
  avg_num_animals <- mean(x$num_animals) 
  
  # Return the average num of animals
  avg_num_animals
  }

# Create a vector of average number of animals per shelter for each state 
avg_animals_per_shelter <- Animal_Warriors %>% 
  group_by(state) %>% 
  summarise(avg_animals_per_shelter = calculate_avg_animals_per_shelter(.))

# Plot the average number of animals per shelter by state
ggplot(data = avg_animals_per_shelter, aes(x = state, y = avg_animals_per_shelter)) +
  geom_col() +
  labs(title = "Average Number of Animals in Shelters by State") +
  xlab("State") +
  ylab("Average Number of Animals per Shelter")

# Create a function to calculate the average number of volunteers per shelter 
calculate_avg_volunteers_per_shelter <- function(x) {
  # Calculate average number of volunteers per shelter
  avg_num_volunteers <- mean(x$num_volunteers) 
  
  # Return the average num of volunteers
  avg_num_volunteers
  }

# Create a vector of average number of volunteers per shelter for each state 
avg_volunteers_per_shelter <- Animal_Warriors %>% 
  group_by(state) %>% 
  summarise(avg_volunteers_per_shelter = calculate_avg_volunteers_per_shelter(.))

# Plot the average number of volunteers per shelter by state
ggplot(data = avg_volunteers_per_shelter, aes(x = state, y = avg_volunteers_per_shelter)) +
  geom_col() +
  labs(title = "Average Number of Volunteers in Shelters by State") +
  xlab("State") +
  ylab("Average Number of Volunteers per Shelter")

# Calculate the total funds raised by each shelter
shelter_funds <- Animal_Warriors %>% 
  group_by(shelter) %>% 
  summarise(total_funds = sum(funds_raised))

# Plot the total funds raised for each shelter
ggplot(data = shelter_funds, aes(x = shelter, y = total_funds)) +
  geom_col() +
  labs(title = "Total Funds Raised for Shelters by Animal Welfare Warriors") +
  xlab("Shelter") +
  ylab("Total Funds Raised")
  
# Calculate the highest performing shelters 
highest_performers <- Animal_Warriors %>% 
  group_by(shelter) %>% 
  summarise(success_rate = calculate_success_rate(.),
            avg_length_of_stay = calculate_avg_length_of_stay(.),
            avg_animals_per_shelter = calculate_avg_animals_per_shelter(.),
            avg_volunteers_per_shelter = calculate_avg_volunteers_per_shelter(.),
            total_funds = sum(funds_raised)) %>% 
  arrange(desc(success_rate))

# Print the top 5 highest performing shelters 
head(highest_performers, 5)