# SOLID


### SRP (Single Responsibility Principle)

A class or a module should have one, and only one, reason to be changed.

Every module or class should have responsability over a single part of a functionality provided by the software, and the responsability should be entirely encapsulated by the class.

Single: only one, isolated, by itself VS God Object (anti-pattern)

Responsibility: the work or action that each part of your system, the methods, classes, packages, modules are assigned to do

In subsequent writings, he's done a better job at explaining what he meant:

"And this gets to the crux of the Single Responsibility Principle. This principle is about people.

When you write a software module, you want to make sure that when changes are requested, those changes can only originate from a single person, or rather, a single tightly coupled group of people representing a single narrowly defined business function. You want to isolate your modules from the complexities of the organization as a whole, and design your systems such that each module is responsible (responds to) the needs of just that one business function."

Which, really, is hard to disagree with.

"Another wording for the Single Responsibility Principle is:

Gather together the things that change for the same reasons. Separate those things that change for different reasons."

However, as you think about this principle, remember that the reasons for change are people. It is people who request changes. And you don't want to confuse those people, or yourself, by mixing together the code that many different people care about for different reasons.

![](https://github.com/fabioono25/SOLID/blob/master/Solid/Images/HighLevelDesign.png)

Links:

https://8thlight.com/blog/uncle-bob/2014/05/08/SingleReponsibilityPrinciple.html

https://www.udemy.com/design-patterns-csharp-dotnet/learn/v4/overview

https://www.youtube.com/watch?v=Q2QdkiX6p_Y

https://code.tutsplus.com/pt/tutorials/solid-part-1-the-single-responsibility-principle--net-36074

https://www.infoworld.com/article/2946023/application-architecture/implementing-the-single-responsibility-principle-in-c.html

https://www.codeproject.com/Articles/611593/SOLID-Principles-Single-Respons

https://hackernoon.com/you-dont-understand-the-single-responsibility-principle-abfdd005b137

https://www.oodesign.com/single-responsibility-principle.html

https://codeburst.io/understanding-solid-principles-single-responsibility-b7c7ec0bf80

https://www.toptal.com/software/single-responsibility-principle

https://www.intertech.com/Blog/the-single-responsibility-principle-with-c-examples/

http://rcardin.github.io/solid/srp/programming/2017/12/31/srp-done-right.html

http://blog.ploeh.dk/2010/02/02/RefactoringtoAggregateServices/

https://softwareengineering.stackexchange.com/questions/150760/single-responsibility-principle-how-can-i-avoid-code-fragmentation

https://www.win.tue.nl/~wstomv/edu/2ip30/references/criteria_for_modularization.pdf


### OCP (Open-Closed Principle)

Software entities (classes, modules, functions, etc) should be open for extension, but closed for modification.

https://hackernoon.com/why-the-open-closed-principle-is-the-one-you-need-to-know-but-dont-176f7e4416d


### LSP (Liskov Substitution Principle)

Derived classes must be substitutable for their base classes.


