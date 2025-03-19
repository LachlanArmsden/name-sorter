# Dye & Durham Coding Assessment - Name Sorter

## Summary of Project
This is a C# project that reads a text file and sorts the names in a alphabetical manner acording to their last name, then finally outputting a new text file called "sorted-names-list.txt" with the sorted names.
I have coded to the best of my ability to provide high-quality code that is efficient, readable, as well as adhering to each of the SOLID principles.
This project successfully adheres to each of the assessment criteria that was defined, however the optional criteria of providing a build pipeline was not attempted. 
This was due to my current lack of knowledge of creating a build pipeline like Travis or AppVeyor in this area. I have focused on the main criteria primarily, to demonstrate my coding abilties.

Mutiple Unit Tests were created for each of the functions, where they can be found in the Tests folder in the project.

The project contains 4 classes that handle the functionality of the project:
- Main.cs
- NameSorter.cs
- TextFunction.cs
- DirectoryManager.cs

The project also contains 3 interfaces:
- INameSorter.cs
- ITextFunction.cs
- IDirectoryManager.cs

## How to Use
To execute the program, navigate to the name-sorter.exe file in command prompt and execute it with the following command: "name-sorter.exe ./unsorted-names-list.txt".
If no text file is provided in the input, then the program will state: "Program requires input."
If the text file is not present in the project, then the program will state: "Could not find <filename>"

This project was developed in Visual Studio, utilising the debug properties command line arguments to automatically input the "./unsorted-names-list.txt" command when executed.
It has also been configured that the Unit Tests will only run on the debug version of the program. 

All the text files that the project uses is located within the same folder as the "name-sorter.csproj" file. This is where "unsorted-names-list.txt" is stored as well as where "sorted-names-list.txt" is created in.
