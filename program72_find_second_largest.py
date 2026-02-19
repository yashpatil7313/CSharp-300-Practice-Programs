# Program 72: Find second largest number in a list

numbers = [10, 45, 23, 89, 67]

numbers = list(set(numbers))  # Remove duplicates
numbers.sort()

print("Second largest number:", numbers[-2])


