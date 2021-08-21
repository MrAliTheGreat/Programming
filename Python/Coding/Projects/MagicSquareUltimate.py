import numpy as np
from random import randint , random

population_size = 5000
population_rate = 0.6
mutation_rate = 0.3
max_rounds_no_change = 100
generation = 1
best_generation = 1
best_fitness = 0
elitism_rate = 0.1
population = []

input_square = list(input('What Are Your Numbers? '))
input_numbers = []

for item in input_square:
    try:
        input_numbers.append(int(item))
    except:
        continue

size_square = int((len(input_numbers))**0.5)
blank_square = np.zeros((size_square , size_square))

# Choosing parents

# We have to use oop for optimization here
# Roulette Wheel method
#def ChooseParents(population_input , all_fitnesses_input):
#    i = 0
#    random_choice = randint(0 , sum(all_fitnesses_input))
#    while i <= len(population_input) - 1:
#        random_choice -= all_fitnesses_input[i]
#        if random_choice < 0:
#            return population_input[i]
#        i+=1
#    return population_input[len(population_input) - 1]

def ChooseParents(population_input , all_fitnesses_input):
    tournament_size = 3
    best_fit = 0
    for num in range(tournament_size):
        random_index = randint(0 , len(population_input) - 1)
        if all_fitnesses_input[random_index] > best_fit:
            parent = population_input[random_index]
            best_fit = all_fitnesses_input[random_index]
    return parent
        


def Converter(size_matrix , pos):
    row = int(pos / size_matrix)
    col = pos % size_matrix
    
    return row , col

# Creating random population
for i in range(population_size):
    input_numbers_copy = input_numbers.copy()
    square = blank_square.copy()

    while len(input_numbers_copy) != 0:
        rand_pos = randint(0 , len(input_numbers_copy) - 1)
        rand_num = input_numbers_copy.pop(rand_pos)
        
        while True:
            rand_pos_square_row = randint(0 , len(square) - 1)
            rand_pos_square_column = randint(0 , len(square) - 1)
            if square[rand_pos_square_row][rand_pos_square_column] == 0:
                break
            
        square[rand_pos_square_row][rand_pos_square_column] = rand_num
    
    population.append(square)
    
while True:
        
    # Calculating fitness
        
    all_fitnesses = []   
    for pop in population:
        all_sum_numbers = []
        num_same = []
        col_sum = pop.sum(axis = 0)
        row_sum = pop.sum(axis = 1)
        all_sum_numbers.extend(col_sum)
        all_sum_numbers.extend(row_sum)
        all_sum_numbers = set(all_sum_numbers)
        
        for num in all_sum_numbers:
            num_same.append((row_sum == num).sum() + (col_sum == num).sum())
            
        all_fitnesses.append(max(num_same))
    
    if max(all_fitnesses) < best_fitness:
        if abs(best_generation - generation) > max_rounds_no_change:
            best_answer = population[all_fitnesses.index(max(all_fitnesses))]
            break
        
#    if generation == 200:
#        best_answer = population[all_fitnesses.index(max(all_fitnesses))]
#        break
    if max(all_fitnesses) == size_square * 2:
        best_answer = population[all_fitnesses.index(max(all_fitnesses))]
        break
            
    best_fitness = max(all_fitnesses)
    best_generation = generation
    
    # Crossover
    new_population = []        
    
    random_crossover_start = randint(0 , len(input_numbers) - 2)
    random_crossover_end = randint(random_crossover_start + 1 , len(input_numbers) - 1)
    
    # Here we must have 2 parents to crossover so we must implement choosing parents first
    parent1 = ChooseParents(population , all_fitnesses)
    parent2 = ChooseParents(population , all_fitnesses)
    
    # Elitism
    num_elites = int (len(population) * elitism_rate)
    sorted_fitnesses = all_fitnesses.copy()
    sorted_fitnesses = np.argsort(sorted_fitnesses)
    sorted_fitnesses = sorted_fitnesses[::-1]
    for i in range(num_elites):
        new_population.append(population[sorted_fitnesses[i]])
    
    while len(new_population) < len(population):
        if random() < population_rate:
            for i in range(random_crossover_start , random_crossover_end + 1):
                # Parent1 Changing
                parent1 = np.where(parent1 == parent2.item(i) , parent1.item(i) , parent1)
                parent1[Converter(size_square , i)[0]][Converter(size_square , i)[1]] = parent2[Converter(size_square , i)[0]][Converter(size_square , i)[1]]
                # Parent2 Changing
                parent2 = np.where(parent2 == parent1.item(i) , parent2.item(i) , parent2)
                parent2[Converter(size_square , i)[0]][Converter(size_square , i)[1]] = parent1[Converter(size_square , i)[0]][Converter(size_square , i)[1]]
            
        new_population.append(parent1)
        new_population.append(parent2)
        child1 = parent1.copy()
        child2 = parent2.copy()
        
        # Mutation
        if random() < mutation_rate:
            mutation_rand1 = randint(0 , size_square - 1)
            mutation_rand2 = randint(0 , size_square - 1)
            temp = child1[Converter(size_square , mutation_rand1)[0]][Converter(size_square , mutation_rand1)[1]]
            child1[Converter(size_square , mutation_rand1)[0]][Converter(size_square , mutation_rand1)[1]] = child2[Converter(size_square , mutation_rand2)[0]][Converter(size_square , mutation_rand2)[1]]
            child2[Converter(size_square , mutation_rand2)[0]][Converter(size_square , mutation_rand2)[1]] = temp
    
    generation += 1
        
    
    
# 2 Notes:
# First of all, we can use elitism which is by using elitism_rate*population_size we know the number of elites
# We sort our generation in descending order and choose some (The number from above) of the squares with highest fitness
# elitisim_rate is around 0.1
    
# Second of all, we can use tournament selection which is choosing N of our population randomly 
# and choose the best one to be a parent it can be used instead of roulette wheel which we used here
# N (Tournament size) is 3 or 4



    
               
                
            
            
            
            
            
            
            
            
            
            
            