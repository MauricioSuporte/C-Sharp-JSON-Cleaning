# C# JSON Cleaning Challenge

This repository contains the solution for the C# Json Cleaning challenge from Coderbyte.

## Problem Description
You are given a JSON object with various properties and array items. Some of the properties and items contain invalid values such as empty strings, "N/A", and "-". Your task is to remove these invalid values from the JSON structure.

### Example Input:
```json
{
  "name": {
    "first": "Robert",
    "middle": "",
    "last": "Smith"
  },
  "age": 25,
  "DOB": "-",
  "hobbies": [
    "running",
    "coding",
    "-"
  ],
  "education": {
    "highschool": "N/A",
    "college": "Yale"
  }
}
```

### Example Output:
```json
{
  "name": {
    "first": "Robert",
    "last": "Smith"
  },
  "age": 25,
  "hobbies": [
    "running",
    "coding"
  ],
  "education": {
    "college": "Yale"
  }
}
```

## Solution

The solution recursively checks for invalid values in both objects and arrays:

- Empty strings (`""`)
- "N/A"
- "-"

These values are removed, leaving the valid data in the original JSON structure.

## Features

- Recursive cleaning of nested objects and arrays.
- Removal of invalid values from JSON.

## Getting Started

To run the solution:

1. Clone this repository:
   
   ```bash
   git clone https://github.com/MauricioSuporte/C-Sharp-JSON-Cleaning.git

1. Open the project in your favorite IDE or editor.

1. Run the project. The program will fetch a JSON object from the Coderbyte API and clean it based on the rules defined.

### Technologies Used

* **C#**: The programming language used for the solution.
* **Newtonsoft.Json**: A popular .NET library for working with JSON data.

## Author

* [Maurício Suporte]([https://github.com/yourusername](https://github.com/MauricioSuporte))

Feel free to contribute, fork the project, or open an issue if you have suggestions or questions.

