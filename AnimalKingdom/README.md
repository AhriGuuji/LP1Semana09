# Diagram UML for AnimalKingdom

```mermaid
---
title: Program AnimalKingdom
---

classDiagram
    class Dog {
        + Sound() string
    }

    class Cat {
        + Sound() string
    }

    class Bee {
        + Sound() string
    }

    class Bat {
        + Sound() string
    }

    class Animal {
        + Sound() string
    }

    Animal <-- Cat
    Animal <-- Dog
    Animal <-- Bee
    Animal <-- Bat
    
```
