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
>> Make the Factory class deal with different classes to include their functions and call the facory object only one time to use for different cases.<br>

## Structural  Patterns:- 
### 1. Proxy Pattern
- Provide a surrogate or placeholder for another object to control access to it.
`Like a gateway for an object`<br>
>> The client calls the proxy instead of web service, so if the service changed, we deal with the proxy not the client `Remote Proxy`<br>
>> Get data from database using the proxy, and the client deal with the proxy not the database `Virtual Proxy`<br>
>> Protect the object from the client to control it yourself away from the client `Protection Proxy`.<br>

### 2. Decorator Pattern
>> Allows behavior to be added to an individual object, dynamically, without affecting the behavior of other objects from the same class. <br>
>> The `decorator pattern` is often useful for adherting to the `Single Resposiblity Principle`,<br>
as it allows functionality to be divided between classes with unique areas of concern.

### 3. Adapter Pattern 
>> Convert the interface of a class into another interface that clients expect.<br>
>> The `Adapter pattern` lets classes work together that could not otherwise because of `incompatible interfaces`.

### 4. Facade Pattern
>> Provide a unified interface to a set of interfaces in a subsystem. <br>
>>`Facade` defines a higher-level interface that makes the subsystem easier to use.<br>

### 5. Flyweight Pattern
>> Use sharing to support large numbers of fine-grained objects efficiently.<br>
`Flyweight`  lets you fit more objects into the available amount of RAM by sharing common parts of state between multiple objects instead of keeping all of the data in each object.<br>

## Behavioral  Patterns:- 
### 1. Chain of Responsibility Pattern (COR)
- Can we make more than handler for a given request?
- How can we handle a request using sequence of steps?
>> Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request.<br>
>> `Chain` the receiving objects and pass the request along the chain until an object handles it.<br>
