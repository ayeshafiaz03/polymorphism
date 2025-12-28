# Polymorphism – C#

This repository demonstrates the concept of **Polymorphism** in C#, which is one of the core principles of Object-Oriented Programming (OOP).

---

## What is Polymorphism?

Polymorphism means **"many forms"**. In object-oriented programming, it refers to the ability of a single method, function, or object to behave differently based on the context in which it is used.

Polymorphism allows the same method name to perform different tasks, depending on:
- The object that is calling the method
- The type of data or parameters passed
- The class hierarchy involved

This concept improves code **flexibility**, **reusability**, and **maintainability**.

---

## Key Concepts of Polymorphism

- A single method can behave differently for different objects.
- Achieved mainly through:
  - **Method Overriding (Runtime Polymorphism)**
  - **Method Overloading (Compile-Time Polymorphism)**
- Base class reference can point to derived class objects.

---

## Types of Polymorphism in C#

### 1. Compile-Time Polymorphism
- Also known as **method overloading**
- Achieved by having multiple methods with the same name but different parameters
- Method selection happens at compile time

### 2. Run-Time Polymorphism
- Achieved through **method overriding**
- Uses inheritance and virtual methods
- Method selection happens at runtime based on object type

---

## Why Polymorphism is Important?

- Makes code more scalable
- Supports loose coupling
- Enhances readability
- Simplifies maintenance
- Plays a key role in real-world object modeling

  
## CODE 01: Payment System 
Real-World E-Commerce
An online store accepts different payment methods (Cash, Credit Card, PayPal).
Each payment method processes payment differently.
## Polymorphism Concept
Method overriding using base class reference

<img width="1305" height="893" alt="Screenshot 2025-12-28 130142" src="https://github.com/user-attachments/assets/b11f286f-9e46-4b0c-84eb-93ebe66c52e3" />

## CODE 02: Vehicle Speed Control 
Transport System
Different vehicles calculate speed differently.
## Polymorphism Concept
Override method with real-life logic

<img width="1335" height="895" alt="Screenshot 2025-12-28 130406" src="https://github.com/user-attachments/assets/e970b4a3-107c-4a8a-8f56-1f53c153a2e6" />

## CODE 03: Employee Salary System
Different employees calculate salary differently.
## Polymorphism Concept
Business logic example

<img width="1337" height="880" alt="Screenshot 2025-12-28 130536" src="https://github.com/user-attachments/assets/bff56c2c-d623-42ec-ab9a-ce90d9032619" />
