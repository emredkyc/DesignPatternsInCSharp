<h1 align="center">Design Patterns In Csharp</h1>
<p align="center">
The most common Design Patterns you need to know with examples in C#.
</p>

<p align="center">
    <img src="assets/Design-Patterns-in-Use.png">
<p>

## What are Design Patterns?

The concept of design patterns in software engineering was popularized in the early 1990s by the famous book **["Design Patterns: Elements of Reusable Object-Oriented Software"](https://amzn.to/3SKaa9x)** by Erich Gamma, Richard Helm, Ralph Johnson, and John Vlissides, collectively known as the "Gang of Four" (GoF). However, the roots of design patterns go back further, drawing inspiration from the field of architecture.

Architect Christopher Alexander introduced the idea of patterns in architecture in his 1977 book **"A Pattern Language,"** where he described solutions to common design problems in urban planning and building architecture. Alexander's work emphasized that each pattern solves a specific problem and is part of a more extensive design system. This approach resonated with software developers facing similar challenges in software construction.

Seeing the potential of Alexander's concepts in software development, the GoF adapted and expanded these ideas to object-oriented programming. Their book **introduced 23 design patterns categorized into Creational, Structural, and Behavioral patterns**, providing a standardized approach to solving common software design issues.

In software development, design patterns serve a similar purpose—**they provide templated solutions to recurring problems**, ensuring that you don't have to reinvent the wheel each time you encounter a familiar issue.

> **Software design pattern** - Is a common solution to common problem that have been observed in practice. 

## Give a Star! :star:

If you like or are using this project to learn or start your solution, please give it a star. Thanks!

## Design Pattern Types

Design patterns can be separated into three main categories:

* **Creational Patterns** - Object creation

    - **Singleton Pattern**: Ensures a class has only one instance and provides a global point of access to it. This is particularly useful for managing resources like database connections.

    - **Factory Method Pattern**: Defines an interface for creating an object but lets subclasses alter the type of objects that will be created. It's ideal when you have a superclass with multiple subclasses, and must create an instance of one of these subclasses based on some initialization parameters.

    - **Abstract Factory Pattern**: Offers an interface for creating families of related or dependent objects without specifying their concrete classes. This pattern shines when you must ensure that the created objects can work together without knowing their exact types.

    - **Builder Pattern**: Separates the construction of a complex object from its representation, allowing the same construction process to create various representations. This pattern is excellent for when you need to create an object with many optional or required components.

    - **Prototype Pattern**: Creates new objects by copying an existing object, known as the prototype. This is particularly useful in scenarios where the cost of creating an object is heavier than copying an existing one.
