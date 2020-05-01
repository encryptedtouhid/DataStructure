# importing "array" for array operations
import array

# initializing array
arr = array.array('i', [1, 2, 3])  

# printing original array 
for x in range((len(arr)-len(arr)),len(arr)):
	print(arr[x])

# appending an item in array
arr.append(4)

#inserting multiple item in array
arr.insert(5,6)

# printing new extended array 
for x in range((len(arr)-len(arr)),len(arr)):
	print(arr[x])