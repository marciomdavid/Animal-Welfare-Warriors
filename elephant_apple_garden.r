# Set working directory
setwd("C:/Users/User/Animal Welfare Warriors")

# Load necessary libraries
library(tidyverse)
library(data.table)

# 1. Load and read in the CSV file
data <- read.csv("animal_welfare_warriors.csv")

# 2. Clean up the data by removing spaces from variable names
names(data) <- gsub(" ", "_", names(data))

# 3. Convert the dataframe into a data table
dt <- data.table(data)

# 4. Create summary statistics of the data
summary(dt)

# 5. Create a new column to calculate the total number of animals adopted
dt$total_animals_adopted <- rowSums(dt[, c("dogs_adopted", "cats_adopted", "other_adopted")], na.rm = TRUE)

# 6. Create a pivot table showing the % of dogs, cats, and other animals adopted
pivot_table <- dcast(dt, volunteer_name ~ type_of_animal, value.var = "total_animals_adopted", fun.aggregate = mean, na.rm = TRUE)

# 7. Create a plot to visualize the results of the pivot table
ggplot(data = pivot_table, aes(x = volunteer_name, y = dogs_adopted, fill = type_of_animal)) + 
  geom_bar(stat = "identity", position = "dodge") +
  xlab("Volunteer Name") +
  ylab("Number of Animals Adopted") +
  ggtitle("Number of Dogs, Cats, and Other Animals Adopted by Volunteer")

# 8. Create a summary table showing the number of animals adopted by each volunteer
summary_table <- dcast(dt, volunteer_name ~ type_of_animal, value.var = "total_animals_adopted",fun.aggregate=sum, na.rm = TRUE)

# 9. Create a boxplot to visualize the results of the summary table
ggplot(data = summary_table, aes(x = type_of_animal, y = total_animals_adopted)) + 
  geom_boxplot() + 
  xlab("Type of Animal") +
  ylab("Number of Animals Adopted") +
  ggtitle("Number of Animals Adopted by Volunteer Grouped by Type of Animal")

# 10. Create a correlation matrix to identify relationships between the different variables
correlation_matrix <- cor(dt[, c("volunteer_name", "dogs_adopted", "cats_adopted", "other_adopted")], use = "complete.obs")

# 11. Calculate the number of months since each volunteer joined the organization
dt$months_since_joined <- as.numeric(as.character(sys.Date() - as.Date(dt$volunteer_joined, "%m/%d/%y")))

# 12. Create a bar chart to visualize the number of months since each volunteer joined
ggplot(data = dt, aes(x = volunteer_name, y = months_since_joined)) + 
  geom_bar(stat = "identity", position = "dodge") + 
  xlab("Volunteer Name") + 
  ylab("Number of Months Since Joined") +
  ggtitle("Months Since Each Volunteer Joined Animal Welfare Warriors")

# 13. Calculate the mean number of animals adopted by each volunteer
mean_adoption <- aggregate(cbind(dogs_adopted, cats_adopted, other_adopted) ~ volunteer_name, data = dt, mean, na.rm = TRUE)

# 14. Create a line chart to visualize the mean number of animals adopted by each volunteer
ggplot(data = mean_adoption, aes(x = volunteer_name, y = dogs_adopted, group = 1)) + 
  geom_line(aes(color = "Dogs")) +
  geom_line(aes(x = volunteer_name, y = cats_adopted, group = 1, color = "Cats")) +
  geom_line(aes(x = volunteer_name, y = other_adopted, group = 1, color = "Other")) +
  xlab("Volunteer Name") + 
  ylab("Average Number of Animals Adopted") +
  ggtitle("Average Number of Animals Adopted by Volunteer") +
  scale_color_manual(values = c("Dogs" = "red", "Cats" = "blue", "Other" = "green"))

# 15. Create a summary table of the number of animals adopted by each volunteer
summary_table_2 <- dcast(dt, volunteer_name ~ type_of_animal, value.var = "total_animals_adopted", fun.aggregate=sum, na.rm = TRUE)

# 16. Calculate the mean total number of adopted animals for each volunteer
mean_total_adoption <- aggregate(cbind(total_animals_adopted) ~ volunteer_name, data = dt, mean, na.rm = TRUE)

# 17. Create a histogram to visualize the mean total number of animals adopted by each volunteer
ggplot(data = mean_total_adoption, aes(x = total_animals_adopted)) +
  geom_histogram(binwidth = 5, aes(fill = "lightblue")) +
  xlab("Mean Total Number of Animals Adopted") +
  ylab("Number of Volunteers") +
  ggtitle("Mean Total Number of Animals Adopted by Each Volunteer") 

# 18. Calculate the mean adoption rate for each type of animal
mean_adoption_rate <- aggregate(cbind(dogs_adopted, cats_adopted, other_adopted) ~ type_of_animal, data = dt, mean, na.rm = TRUE)

# 19. Create a stacked bar chart to visualize the mean adoption rate for each type of animal
ggplot(data = mean_adoption_rate, aes(x = type_of_animal)) +
  geom_col(aes(y = dogs_adopted, fill = "Dogs"), position = "stack") +
  geom_col(aes(y = cats_adopted, fill = "Cats"), position = "stack") +
  geom_col(aes(y = other_adopted, fill = "Other"), position = "stack") +
  xlab("Type of Animal") +
  ylab("Mean Number of Animals Adopted") +
  ggtitle("Mean Adoption Rate for Different Types of Animals") +
  scale_fill_manual(values = c("Dogs" = "red", "Cats" = "blue", "Other" = "green"))

# 20. Calculate the total number of animals adopted by the organization
total_adopted <- sum(dt$total_animals_adopted, na.rm = TRUE)

# 21. Calculate the total number of volunteers
total_volunteers <- nrow(unique(dt$volunteer_name))

# 22. Create a data frame to store the information about the number of animals adopted and the total number of volunteers
data_frame <- data.frame(total_adopted = total_adopted,
                         total_volunteers = total_volunteers)

# 23. Create a pie chart to visualize the total number of animals adopted by the organization
ggplot(data = data_frame, aes(x = "", y = total_adopted)) +
  geom_bar(width = 1, stat="identity", aes(fill = "lightblue")) +
  coord_polar("y", start = 0) +
  xlab("") +
  ylab("Number of Animals Adopted") +
  ggtitle("Total Number of Animals Adopted by Animal Welfare Warriors")

# 24. Calculate the number of animals adopted per month by the organization
dt$month_adopted <- as.numeric(format(as.Date(dt$date_adopted, "%m/%d/%y"), "%m"))
monthly_adopted <- aggregate(cbind(total_animals_adopted) ~ month_adopted, data = dt, sum, na.rm = TRUE)

# 25. Create a line chart to visualize the number of animals adopted by the organization
ggplot(data = monthly_adopted, aes(x = month_adopted, y = total_animals_adopted)) +
  geom_line(color = "red") +
  xlab("Month") +
  ylab("Number of Animals Adopted") +
  ggtitle("Number of Animals Adopted by Animal Welfare Warriors by Month")

# 26. Create a summary table of the total number of animals adopted and the total number of volunteers
summary_table_3 <- data.frame(total_adopted = total_adopted, total_volunteers = total_volunteers)

# 27. Create a tableau dashboard to visualize the summary table
library(tableauSDK)
tableau_dashboard("Animal Welfare Warriors Dashboard")

# 28. Calculate the total number of hours volunteered by each volunteer
dt$total_hours_volunteered <- rowSums(dt[, c("dogs_hours", "cats_hours", "other_hours")], na.rm = TRUE)

# 29. Create a summary table showing the number of hours volunteered by each volunteer
summary_table_4 <- dcast(dt, volunteer_name ~ type_of_animal, value.var = "total_hours_volunteered", fun.aggregate=sum, na.rm = TRUE)

# 30. Create a boxplot to visualize the total number of hours volunteered by each volunteer
ggplot(data = summary_table_4, aes(x = type_of_animal, y = total_hours_volunteered)) + 
  geom_boxplot() + 
  xlab("Type of Animal") +
  ylab("Number of Hours Volunteered") +
  ggtitle("Total Number of Hours Volunteered by Volunteer Grouped by Type of Animal")

# 31. Create a scatter plot to identify the relationship between the total number of animals adopted and the total number of hours volunteered
ggplot(data = dt, aes(x = total_animals_adopted, y = total_hours_volunteered)) +
  geom_point(color = "red") +
  geom_smooth(method = "lm", color = "blue") +
  xlab("Total Number of Animals Adopted") +
  ylab("Total Number of Hours Volunteered") +
  ggtitle("Relationship Between Total Number of Animals Adopted and Total Number of Hours Volunteered")

# 32. Create a summary table showing the total number of animals adopted and the total number of hours volunteered by each volunteer
summary_table_5 <- dcast(dt, volunteer_name ~ ., value.var = c("total_animals_adopted", "total_hours_volunteered"), 
                         fun.aggregate=sum, na.rm = TRUE)

# 33. Calculate the average adoption rate per volunteer
dt$average_adoption_rate <- dt$total_animals_adopted / dt$total_hours_volunteered

# 34. Create a summary table showing the average adoption rate for each volunteer
average_adoption_rate <- aggregate(cbind(average_adoption_rate) ~ volunteer_name, data = dt, mean, na.rm = TRUE)

# 35. Create a histogram to visualize the average adoption rate for each volunteer
ggplot(data = average_adoption_rate, aes(x = average_adoption_rate)) +
  geom_histogram(binwidth = 0.01, aes(fill = "lightblue")) +
  xlab("Average Adoption Rate") +
  ylab("Number of Volunteers") +
  ggtitle("Average Adoption Rate for Each Volunteer")

# 36. Create a summary table of the total number of animals adopted, the total number of volunteers, and the total number of hours volunteered
total_numbers <- data.frame(total_adopted = total_adopted, total_volunteers = total_volunteers, total_hours_volunteered = sum(dt$total_hours_volunteered, na.rm = TRUE))

# 37. Create a pie chart to visualize the total number of animals adopted, the total number of volunteers, and the total number of hours volunteered
ggplot(data = total_numbers, aes(x = "", y = total_adopted)) +
  geom_bar(width = 1, stat="identity", aes(fill = "lightblue1")) +
  geom_bar(width = 1, stat="identity", aes(fill = "lightblue2"), y = total_volunteers) +
  geom_bar(width = 1, stat="identity", aes(fill = "lightblue3"), y = total_hours_volunteered) +
  coord_polar("y", start = 0) +
  xlab("") +
  ylab("") +
  ggtitle("Total Numbers for Animal Welfare Warriors") +
  scale_fill_manual(values = c("lightblue1" = "red", "lightblue2" = "blue", "lightblue3" = "green"))

# 38. Calculate the total number of hours volunteered per month
monthly_hours_volunteered <- aggregate(cbind(total_hours_volunteered) ~ month_adopted, data = dt, sum, na.rm = TRUE)

# 39. Create a line chart to visualize the total number of hours volunteered per month
ggplot(data = monthly_hours_volunteered, aes(x = month_adopted, y = total_hours_volunteered)) + 
  geom_line(color = "red") +
  xlab("Month") +
  ylab("Number of Hours Volunteered") +
  ggtitle("Total Number of Hours Volunteered by Animal Welfare Warriors by Month")

# 40. Calculate the total number of animals adopted per month
monthly_animals_adopted <- aggregate(cbind(total_animals_adopted) ~ month_adopted, data = dt, sum, na.rm = TRUE)

# 41. Create a line chart to visualize the total number of animals adopted per month
ggplot(data = monthly_animals_adopted, aes(x = month_adopted, y = total_animals_adopted)) + 
  geom_line(color = "red") +
  xlab("Month") +
  ylab("Number of Animals Adopted") +
  ggtitle("Total Number of Animals Adopted by Animal Welfare Warriors by Month")

# 42. Create a data frame to store the information about the total number of animals adopted and the total number of hours volunteered by the organization
data_frame_2 <- data.frame(total_adopted = total_adopted,
                          total_hours_volunteered = sum(dt$total_hours_volunteered, na.rm = TRUE))

# 43. Create a