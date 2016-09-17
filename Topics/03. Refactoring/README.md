<!-- section start -->
<!-- attr: { class:'slide-title', showInPresentation:true, hasScriptWrapper:true } -->
# Refactoring: Improving the Quality of Existing Code
## When and How to Refactor? Refactoring Patterns
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic01.png" style="top:65%; left:80%; width:16.08%; z-index:-1; border-radius:10px;" /> -->
<article class="signature">
	<p class="signature-course">High-Quality Code - Part 2</p>
	<p class="signature-initiative">Telerik Software Academy</p>
	<a href="http://academy.telerik.com" class="signature-link">http://academy.telerik.com</a>
</article>




<!-- section start -->
<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Table of Contents
- [Refactoring](#refactor)
- [Refactoring principles and tips](#principles)
- [Code smells](#smells)
- [Refactorings](#refactoring-types)
  - Data level, statement level, method level, class level, system level refactorings, etc.
- [Refactoring patterns](#patterns)
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic02.png" style="top:14.84%; left:72.98%; width:29.24%; z-index:-1; border-radius:10px;" /> -->

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # What is Refactoring? -->


<!-- attr: { id:'refactor', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="refactor"></a>What is Refactoring?
<div style="width:70%">`Refactoring means "to improve the design and quality of existing source code without changing its external behavior".
Martin Fowler`</div>

- It is a step by step process that  turns the bad code into  good code
  - Based on "refactoring patterns" &rarr; well-known recipes for improving the code
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic03.png" style="top:13.22%; left:70.44%; width:25%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Code Refactoring
- What is **refactoring** of the source code?
  - Improving the design and quality of existing source code without changing its behavior
  - Step by step process that turns the bad code into good code (if possible)
- **Why** we need refactoring?
  - Code constantly changes and its quality constantly degrades (unless refactored)
  - Requirements often change and code needs to be changed to follow them


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# When to Refactor?
- **Bad smells in the code** indicate need of refactoring
- Refactor:
  - To make adding a new function easier
  - As part of the process of fixing bugs
  - When reviewing someone else’s code
  - Have technical debt (or any problematic code)
  - When doing test-driven development
- **Unit tests** guarantee that refactoring does not change the behavior
  - If there are no unit tests, write them
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic04.png" style="top:14.10%; left:93.12%; width:15.23%; z-index:-1; border-radius:10px;" /> -->

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Refactoring Principles and Tips -->

<!-- attr: { id:'principles',showInPresentation:true, hasScriptWrapper:true, style:'font-size:0.95em' } -->
# <a id="principles"></a>Good Code Main Principles
- Avoid duplication (**DRY**)
- Simplicity – Keep it simple stupid (**KISS**)
- Make it expressive (self-documenting, comments)
- Reduce overall code (**YAGNI**)
  - More code = more bugs
  - Avoid premature optimization
- Appropriate level of abstraction
  - Hide implementation details
- Boy scout rule
  - Leave your code better than you found it
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic05.png" style="top:42%; left:65%; width:34.38%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Good Code Main Principles -->
- Don’t make me think
  - Code should surprise the reader as little as possible (principle of least astonishment)
  - Consistency!
- Write code for the maintainer
  - Unit test

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Good Code Main Principles -->
- **SOLID**
  - Single responsibility principle
  - Open/closed principle
  - Liskov substitution principle
  - Interface segregation principle
  - Dependency inversion principle


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Refactoring Process
- Save the code you start with
  - Check-in or backup the current code
- Make sure you have tests to assure the behavior after the code is refactored
  - Unit tests / characterization tests
- Do refactorings one at a time
  - Keep refactorings small
  - Don’t underestimate small changes
- Run the tests and they should pass / else revert
- Check-in


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Refactoring Tips
- Keep refactorings small
- One at a time
- Make a checklist
- Make a "later"/TODO list
- Check-in/commit frequently
- Add tests cases
- Review the results
  - Pair programming
- Use tools (Visual Studio + Add-ins)




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Code Smells -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic06.png" style="top50%; left:30%; width:40%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { id:'smells', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="smells"></a>Code Smells
- Certain structures in the code that **suggest the possibility** of refactoring
- Types of code smells
    - The bloaters
    - The obfuscators
    - Object-oriented abusers
    - Change preventers
    - Dispensables
    - The couplers
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic07.png" style="top:20%; left:60%; width:35%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Code Smells: The Bloaters
- **Long method**
  - Small methods are always better (easy naming, testing, understanding, less duplicate code)
- **Large class**
  - Too many instance variables or methods
  - Violating Single Responsibility principle
- **Primitive obsession** (overused primitives)
  - Over-use of primitives, instead of better abstraction
  - Part of them can be extracted in separate class and encapsulate their validation there


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Code Smells: The Bloaters -->
- **Long parameter list** (in/out/ref parameters)
  - May indicate procedural rather than OO style
  - May be the method is doing too much things
- **Data clumps**
  - A set of data items that are always used together, but are not organized together
    - E.g. credit card fields in order class
- **Combinatorial explosion**
  - Ex. ListCars, ListByRegion, ListByManufacturer, ListByManufacturerAndRegion, etc.
  - Solution may be Interpreter (LINQ)


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Code Smells: The Bloaters -->
- **Oddball solution**
  - A different way of solving a common problem
  - Not using consistency
  - Solution: Substitute algorithm or use adapter
- **Class doesn't do much**
  - Solution: Merge with another class or remove
- **Required setup/teardown code**
  - Requires several lines of code before its use
  - Solution: Use parameter object, factory method, IDisposable


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Code Smells: The Obfuscators
- **Regions**
  - The intend of the code is unclear and needs commenting (smell)
  - The code is too long to understand (smell)
  - Solution: organize code, introduce a new class
- **Comments**
  - Should be used to tell WHY, not WHAT or HOW
  - Good comments: provide additional information, link to issues, explain reasons, give context
  - Link: [Funny comments](http://stackoverflow.com/questions/184618/what-is-the-best-comment-in-source-code-you-have-ever-encountered?answertab=votes#tab-top)


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Code Smells: The Obfuscators -->
- **Poor/improper names**
  - Should be proper, descriptive and consistent
- **Vertical separation**
  - You should define variables just before first use
    - Avoid scrolling
- **Inconsistency**
  - Follow the POLA
  - Inconsistency is confusing and distracting
- **Obscured intent**
  - Code should be as expressive as possible


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Code Smells: OO Abusers
- **Switch statement**
  - Can be replaced with polymorphism
- **Temporary field**
  - When passing data between methods
- **Class depends on subclass**
  - The classes cannot be separated (circular dependency)
  - May broke Liskov substitution principle
- **Inappropriate static**
  - Strong coupling between static and callers
  - Static things cannot be replaced or reused


<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size:0.95em' } -->
# Code Smells: Change Preventers
- **Divergent change**
  - A class is commonly changed in different ways for different reasons
  - Violates SRP (single responsibility principle)
  - Solution: extract class
- **Shotgun surgery**
  - One change requires changes in many classes
    - Hard to find them, easy to miss some
  - Solution: move method, move fields
  - Ideally there should be one-to-one relationship between common changes and classes


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Code Smells: Change Preventers -->
- **Parallel inheritance hierarchies**
  - New vehicle = new operator
  - Frequently share same prefix
  - Hard to be completely avoided. We can merge the classes or use the Intelligent children pattern
- **Inconsistent abstraction level**
  - E.g. code in a method should be one level of abstraction below the method's name
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic11.png" style="top:22%; left:70%; width:30%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Code Smells: Change Preventers -->
- **Conditional complexity**
  - Cyclomatic complexity
    - number of unique pathsthat the code can be evaluated
  - Symptoms: deep nesting (arrow code) & bug ifs
  - Solutions: extract method, strategy pattern, state pattern, decorator
- **Poorly written tests**
  - Badly written tests can prevent change
  - Tight coupling


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Code Smells: Dispensables
- **Lazy class**
  - Classes that don't do enough to justify their existence should be removed
  - Every class costs something to be understand and maintained
- **Data class**
  - Some classes with only fields and properties
  - Missing validation? Class logic split into other classes?
  - Solution: move related logic into the class


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Code Smells: Dispensables -->
- **Duplicated code**
  - Violates the DRY principle
  - Result of copy-pasted code
  - Solutions: extract method, extract class, pull-up method, template method pattern
- **Dead code** (code that is never used)
  - Usually detected by static analysis tools
- **Speculative generality**
  - "Some day we might need…"
  - YAGNI principle


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Code Smells: The Couplers
- **Feature envy**
  - Method that seems more interested in a class other than the one it actually is in
  - Keep together things that change together
- **Inappropriate intimacy**
  - Classes that know too much about one another
  - Smells: inheritance, bidirectional relationships
  - Solutions: move method/field, extract class, change bidirectional to unidirectional association, replace inheritance with delegation


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Code Smells: The Couplers -->
- **The Law of Demeter** (**LoD**)
  - Principle of least knowledge
  - A given object should assume as little as possible about the structure or properties of anything else
  - Bad e.g.: `customer.Wallet.RemoveMoney()`
- **Indecent exposure**
  - Some classes or members are public but shouldn't be
  - Violates encapsulation
  - Can lead to inappropriate intimacy


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Code Smells: The Couplers -->
- **Message chains**
  - `Somemthing.another.someother.other.another`
  - Tight coupling between client and the structure of the navigation
- **Middle man**
  - Sometimes delegation goes too far
  - Sometimes we can remove it or inline it
- **Tramp data**
  - Pass data only because something else need it
  - Solutions: Remove middle man, extract class


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Code Smells: The Couplers -->
- **Hidden temporal coupling**
  - Occurs when members of a class requires clients to invoke one member before the other
    - Operations consecutively should not be guessed
  - E.g. The use of Pizza class should not know the steps of making pizza
    - Builder or Template Method pattern
- **Hidden dependencies**
  - Classes should declare their dependencies in their constructor
  - "new" is glue / Dependency Inversion principle




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Refactorings -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic15.png" style="top:45%; left:28%; width:45%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { id:'refactoring-types', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="refactoring-types"></a>Data Level Refactorings
- Replace a magic number with a named constant
- Rename a variable with more informative name
- Replace an expression with a method
  - To simplify it or avoid code duplication
- Move an expression inline
- Introduce an intermediate variable
  - Introduce explanatory variable
- Convert a multi-use variable to a multiple single-use variables
  - Create separate variable for each usage
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic16.png" style="top:37.02%; left:85.14%; width:19.39%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Data Level Refactorings -->
- Create a local variable for local purposes rather than a parameter
- Convert a data primitive to a class
  - Additional behavior / validation logic (money)
- Convert a set of type codes (constants) to enum
- Convert a set of type codes to a class with subclasses with different behavior
- Change an array to an object
  - When you use an array with different types in it
- Encapsulate a collection (list of cards => deck)
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic17.png" style="top:46.72%; left:92.40%; width:17.19%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Statement Level Refactorings
- Decompose a boolean expression
- Move a complex boolean expression into a well-named boolean function
- Consolidate duplicated code in conditionals
- Return as soon as you know the answer instead of assigning a return value
- Use break or return instead ofa loop control variable
- Replace conditionals with polymorphism
- Use null objects instead of testing for nulls


<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size:0.95em' } -->
# Method Level Refactorings
- Extract method / Inline method
- Rename method
- Convert a long routine to a class
- Add / remove parameter
- Combine similar methods byparameterizing them
- Substitute a complex algorithm with simpler
- Separate methods whose behavior depends on parameters passed in (create new ones)
- Pass a whole object rather than specific fields
- Return interface types / base class
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic19.png" style="top:12.34%; left:77%; width:21%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Class Level Refactorings
- Change structure toclass and vice versa
- Pull members up / pushmembers down the hierarchy
- Extract specialized code into a subclass
- Combine similar code into a superclass
- Collapse hierarchy
- Replace inheritance with delegation
  - Replace "is-a" with "has-a" relationship
- Replace delegation with inheritance


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Class Interface Refactorings
- Extract interface(s) / Keep interface segregation
- Move a method to another class
- Convert a class to two
- Delete a class
- Hide a delegating class (A calls B and C when A should call B and B call C)
- Remove the man in the middle
- Introduce (use) an extension class
  - When we don’t have access to the original class
  - Alternatively use decorator pattern


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Class Interface Refactorings -->
- Encapsulate an exposed member variable
  - In C# always use properties
  - Define proper access to getters and setters
    - Remove setters to read-only data
- Hide data and routines that are not intended to be used outside of the class / hierarchy
  - private -> protected -> internal -> public
- Use strategy to avoid big class hierarchies
- Apply other design patterns to solve common class and class hierarchy problems (façade, adapter, etc.)


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# System Level Refactorings
- Move class (set of classes) to another namespace / assembly
- Provide a factory method instead of a simple constructor / Use fluent API
- Replace error codes with exceptions
- Extract strings to resource files
- Use dependency injection
- Apply architecture patterns





<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Refactoring Patterns
## Well-Known Recipes for Improving the Code Quality -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic24.png" style="top:63%; left:32%; width:35%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { id:'patterns', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="patterns"></a>Rafactoring Patterns
- When should we perform refactoring of the code?
  - **Bad smells in the code** indicate need of refactoring
- Unit tests guarantee that refactoring does not change the behavior
- Rafactoring patterns
  - Large repeating code fragments &rarr; extract repeating code in separate method
  - Large methods &rarr; split them logically
  - Large loop body or deep nesting &rarr; extract method


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Refactoring Patterns -->
- Refactoring patterns
  - Class or method has weak cohesion &rarr; split into several classes / methods
  - Single change carry out changes in several classes &rarr; classes have tight coupling &rarr; consider redesign
  - Related data are always used together but are not part of a single class &rarr; group them in a class
  - A method has too many parameters &rarr; create a class to groups parameters together
  - A method calls more methods from another class than from its own class &rarr; move it


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Rafactoring Patterns -->
- Refactoring patterns
  - Two classes are tightly coupled &rarr; merge them or redesign them to separate their responsibilities
  - Public non-constant fields &rarr; make them private and define accessing properties
  - Magic numbers in the code &rarr; consider extracting constants
  - Bad named class / method / variable &rarr; rename it
  - Complex boolean condition &rarr; split it to several expressions or method calls


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Rafactoring Patterns -->
- Refactoring patterns
  - Complex expression &rarr; split it into few simple parts
  - A set of constants is used as enumeration &rarr; convert it to enumeration
  - Method logic is too complex and is hard to understand &rarr; extract several more simple methods or even create a new class
  - Unused classes, methods, parameters, variables &rarr; remove them
  - Large data is passed by value without a good reason &rarr; pass it by reference


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Rafactoring Patterns -->
- Refactoring patterns
  - Few classes share repeating functionality &rarr; extract base class and reuse the common code
  - Different classes need to be instantiated depending on configuration setting &rarr; use factory
  - Code is not well formatted &rarr; reformat it
  - Too many classes in a single namespace &rarr; split classes logically into more namespaces
  - Unused **using** definitions &rarr; remove them
  - Non-descriptive error messages &rarr; improve them
  - Absence of defensive programming &rarr; add it



<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # HQC-Part 2: Refactoring
## Questions? -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Free Trainings @ Telerik Academy
- C# Programming @ Telerik Academy
    - [HQC-Part 2 course](http://academy.telerik.com/student-courses/programming/high-quality-code-part-2/about)
  - Telerik Software Academy
    - [telerikacademy.com](https://telerikacademy.com)
  - Telerik Academy @ Facebook
    - [facebook.com/TelerikAcademy](facebook.com/TelerikAcademy)
  - Telerik Software Academy Forums
    - [forums.academy.telerik.com](forums.academy.telerik.com)
