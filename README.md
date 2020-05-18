# Strategy-Design-Pattern-with-Clash-of-Clans
---

##### Start:

> Let's say you work for the company, Supercell, that made a highly successful game Clash of Clans and you have to design troops for the game. Initially, you have the following requirements:
- You have two troops, Giant and Barbarian
- Both have same TrainingTime, TrainingCost, and Focus, Hitpoints(life), DamagePerSec(AttackingRate).

> If you have a little object oriented design knowledge, you will start with creating an interface and class. lets begin coding.

###### Requirements:

- Now you have housing space which is same for all the troops.
- Each troop has its own type of Attack (Sword Attack, Punch Attack, Archer Attack, Flame Attack, Bomb Attack), on Focus on attack
- Each troop has its own intensity of attack() and Hitpoint i.e life.
- A particular troop can move on ground or can fly.
- Upgrade, as level changes there value should increase.

---

##### Guidelines to Design:
###### 1. Figure out the areas in your code which are going to change and separate them.
> Take what varies and “encapsulate” it so it won’t affect the rest of your code.
> The result? Fewer unintended consequences from code changes and more
flexibility in your systems!

Here, TypeOfAttack is changing, MovementTroop(), IncreaseWRTLevels()


###### 2. Always Program to an Interface. But Why?
Let's take an example
> ###### Programming to an implementation would be:
> Dog d = new Dog();
> d.bark();
> 
> Cat c = new Cat();
> c.meow();
> 
Declaring the variable “d” as type Dog (a concrete implementation of Animal)forces us to code to a concrete implementation.

> ###### Programming to an interface/supertype
> Animal animal = new Dog();
> animal.makeSound()
> 
> animal = new Cat();
> animal.makeSound();
> 
Instead of hard coding:
> Animal a;
> a = getAnimal();
> a.makeSound()

---
###### Let's Design The Game now:

> **TypeOfAttack()**
> - SwordAttack()
> - ArcherAttack()
> - Punch Attack()
--------------------
> **MovementTroops()**
> - Ground()
> - Air()
-------------
> **LevelIncrease()**
> - TrainingTime()
> - TrainingCost()
> - AttackingRate()
---------
> **Troops()**
> - TypeOfAttackBehaviour typeOfAttack;
> - MovementTroopsBehaviour movementBehaviour;
> - LevelIncreased level;
> - PerformAttack()
> - PerformMovement()
> - IncrementInLevel()
---

---
If you are looking for any formal definition, so let me fullfill ur wish:

> The Strategy Pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from
clients that use it.

Tip:
> Always prefer has a relationship over is a relationship. If you don't know about these relationships, then I will be discussing it in some other video, so stay tuned for that :) 

Happy Learning!!!





