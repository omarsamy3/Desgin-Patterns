# Desgin-Patterns
This is a training repo to implement different kinds of design patterns for practicing.
## Creational Patterns
### 1. Singleton Pattern..
- To have only one instance of a class to provide more storage in memory.
>> By making a private constructor to prevent creating instances using constructor, and replace that with a function to deal with the same private instance in your class.<br>
>> You can lock the creation of the instance in case of multithreading.

### 2.Prototype Pattern
- Specify the kinds of objects to create using a prototypical instance, and create new objects by copying this prototype.
>> Copy heavy initialization objects instead of creating it.<br>
>> This helps to save time consuming to get data every time I want it -from database for example -.

### 3. Builder Pattern
- Separate the construction of a complex object from its representation so that the same construction processes can create different representations.<br>
`Build complex objects step by step` ... Like string builder class.<br>
>> Keep the class user away from the complex implementation of the object.<br>

### 4. Factory Pattern
- Define an interface for creating an object, but let subclasses decide which class to instantiate.<br>
`Create object without exposing the creation logic to the client and refer to newly created object using a common interface`.<br>
>> Make an interface to be implemented by the different kinds of classes and to be used to make the loginc needed by another class with will make the required logic.
### Abstract Factory Pattern
>> Make the Factory class deal with different classes to include their functions and call the facory object only one time to use for different cases.
