#!/usr/bin/perl

use strict;
use warnings;

package Animal_Welfare_Warriors;

# define Animal_Welfare_Warriors
sub new {

	# Create an object
	my $class = shift;
	my $self = {};

	# Initialize the object
	bless $self, $class;

	# Points to the Animal_Welfare_Warriors
	$self->{Animal_Welfare_Warriors} = {};

	# Return the object
	return $self;
}

# Set a new Animal_Welfare_Warrior
sub set_welfare_warrior {

	# Get the Animal_Welfare_Warriors object
	my $self = shift;

	# Get the animal welfare warrior's name
	my $name = shift;

	# Set the animal welfare warrior's information
	$self->{Animal_Welfare_Warriors}{$name} = {};
}

# Get an animal welfare warrior's information
sub get_welfare_warrior {

	# Get the Animal_Welfare_Warriors object
	my $self = shift;

	# Get the animal welfare warrior's name
	my $name = shift;

	# Return the animal welfare warrior's information
	return $self->{Animal_Welfare_Warriors}{$name};
}

# Get a list of animal welfare warriors 
sub get_welfare_warriors_list {

	# Get the Animal_Welfare_Warriors object
	my $self = shift;

	# Define an array to store the names of the animal welfare warriors
	my @names;

	# Loop through each animal welfare warrior
	foreach my $name (keys %{$self->{Animal_Welfare_Warriors}}) {

		# Push the name into the array
		push @names, $name;
	}

	# Return the array of names
	return \@names;
}

# Update an animal welfare warrior's information
sub update_welfare_warrior {

	# Get the Animal_Welfare_Warriors object
	my $self = shift;

	# Get the animal welfare warrior's name
	my $name = shift;

	# Get the updated information 
	my $info = shift;

	# Update the animal welfare warrior's information 
	$self->{Animal_Welfare_Warriors}{$name} = $info;
}

# Delete an animal welfare warrior's information 
sub delete_welfare_warrior {

	# Get the Animal_Welfare_Warriors object
	my $self = shift;

	# Get the animal welfare warrior's name
	my $name = shift;

	# Delete the animal welfare warrior's information
	delete $self->{Animal_Welfare_Warriors}{$name};
}

1;