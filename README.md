# Lab6&7-I Built A Zoo

Lab06 and Lab07-I Built A Zoo

*Author: Sue Tarazi*

----

## Description
This is a C# console application that utilizes classes and interfaces to describe a zoo. This application uses the four pillars of Object Oriented Programming, which are Inheritance, Abstraction, Polymorphism and Encapsulation.
This application also makes use of interfaces, which contain method signatures of what is required for that action to be completed. In our case, our interfaces are IFly and ISwim.

### Technical Information
* Inheritance = used to make classes take behaviors and properties from other classes. The 'parent' class is the base class and the 'child' class is the derived class. In our app, there is lots of inheritance. For example, the Wings and NoWings classes both are derived from the LandAnimals base class. 
* Abstraction = defines a template and is often used to derive a class down. It can not be instantiated. In our app, WaterAnimals and LandAnimals were abstract classes, so derived classes down the line could use their properties. 
* Polymorphism = the ability to change the behaviors and values of selected methods. In our app, we used 'override'to override the Wingspan property in the BaldEagle class. We also used 'override' to override the method MoveAround() in the NoLegs class.
* Encapsulation = the grouping together of specific information for reusability or access requirements. We used public and protected modifiers in our Pegasus class.
* Interfaces tell us what a class can do. Interfaces are implemented on one or more classes. They allow us to "code by contract", which means they allow us to give the functionality the contain to a specific class we specify. In our app, the BaldEagle, Pegasus and Elephant classes all use the IFly interface and the Pegasus, Hippo, Penguin, Narwhal and Stingray classes use the ISwim interface. 
---

### Getting Started
Clone this repository to your local machine.

```
$ git clone [https://github.com/suetarazi/Lab6-IbuiltAZoo](https://github.com/suetarazi/Lab6-IbuiltAZoo)
```

### To run the program from Visual Studio:
Select ```File``` -> ```Open``` -> ```Project/Solution```

Next navigate to the location you cloned the Repository.

Double click on the ```Lab6-IbuiltAZoo``` directory.

Then select and open ```Lab6-IbuiltAZoo.sln```

---

### Visuals
***[Add screenshots of your application in action]***
#### Chart of Classes
[Chart of Classes](https://files.slack.com/files-tmb/T039KG69K-F010DHUA7U2-16006027e6/img_8704_1024.jpg)
#### Application Start
![Image 1](https://via.placeholder.com/750x500)
#### Using the Application
![Image 1](https://via.placeholder.com/750x500)
#### Application End
![Image 1](https://via.placeholder.com/750x500)

---

### Change Log

