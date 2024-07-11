# KarateChop Library

The KarateChop library provides an efficient binary search implementation for searching sorted arrays of integers.

## Installation

You can install the KarateChop library via NuGet Package Manager with the following command:

```
Install-Package KarateChopDomain
```

## Usage

To use the `KarateChop` class in your project, follow these steps:

1. Ensure you have installed the KarateChop library via NuGet.
2. Include the `KarateChopDomain` namespace in your file.
3. Use the `Chop` method to perform a binary search on a sorted array of integers.

### Example

```csharp
using System;
using KarateChopDomain;

namespace KarateChopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortedArray = { 1, 3, 5, 7, 9 };
            int target = 5;
            int result = KarateChop.Chop(target, sortedArray);

            if (result != -1)
            {
                Console.WriteLine($"Target found at index {result}.");
            }
            else
            {
                Console.WriteLine("Target not found in the array.");
            }
        }
    }
}
```

### Method Details

#### `Chop(int target, int[] array)`

- **Parameters**:
  - `target`: The integer value to search for in the array.
  - `array`: A sorted array of integers to search within.

- **Returns**:
  - The integer index of the target value in the array, or -1 if the target is not found.

### Example Scenarios

1. **Target Present in the Array**:
   - For `target = 5` and `array = { 1, 3, 5, 7, 9 }`, the method returns `2` (index of the target).

2. **Target Not Present in the Array**:
   - For `target = 6` and `array = { 1, 3, 5, 7, 9 }`, the method returns `-1` (target not found).

## Contributing

Contributions are welcome! If you find any issues or have suggestions for improvements, please open an issue or submit a pull request.