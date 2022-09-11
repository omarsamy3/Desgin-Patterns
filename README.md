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
