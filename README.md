# ZooDemo

A simple and practical task for Zoo simulation

This zoo contains animals, hooray! 
The animals are 3 different species: monkeys, giraffes, and bears. For now.
Each animal has a health value, represented by points in the range from 0 to 100.
There is a method that simulates feeding the top 90% (floor rounded) of the animals sorted by health points in ascending order. 
Here, this 90% has been taken from each group instead of collecting all the animals, and then sorting. 
When this method is called, for each such animal a random value between 10 and 25 is generated and used to increase that animal's health.

There is a method that simulates the animals getting hungry. 
Hunger reduces the health of animals. When this method is called, for each of the three species a random value between 15 and 35 is generated. 
Then the health of each animal in the zoo is decreased by the value generated for its species.

Every kind of the species has a specific death condition. 
A monkey dies, when its health points drop below 40. 
A bear dies, when its health points drop below 65. 
A giraffe cannot move its neck, while it has less than 60 health points. 
When a giraffe’s health has to be reduced (no matter how much) and it cannot move its neck, then it dies.

There is a method that returns the number of animals still alive in the zoo.
There is a method that for a given kind of species returns the minimal health of all the alive ones.
The zoo starts with 10 animals for each species. Each animal starts with 100 health points.
