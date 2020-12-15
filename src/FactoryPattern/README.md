# Factory Pattern

This pattern can be implemented in three different ways depending on your use case. 
Largely, the difference between each implementation is how much _what you're actually building_ differs from each other.

- Provides a way to code to an abstraction rather than a concrete implementation.

## Simple Factory
- Creates objects directly through the class via a method.
- Simpliest but the least flexible.
- Not really a _true_ factory - scales poorly.

## Factory
- Uses inheritance and relies on subclassing to handle the desired object instantiation.
- Implemented by overriding the base class method.

## Abstract Factory

- Implemented through composition (an object).
- Great for when you're creating many different things that each have a common base class, but all belong together logically.
- The most robust solution as far as lines of code and abstraction level but still has drawbacks if what you're creating changes its interface 
since every concrete class would also need updated (which can be a lot of work).