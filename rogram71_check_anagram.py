# Program 71: Check if two strings are anagrams

str1 = input("Enter first string: ").lower()
str2 = input("Enter second string: ").lower()

if sorted(str1) == sorted(str2):
    print("Strings are Anagrams")
else:
    print("Strings are Not Anagrams")

